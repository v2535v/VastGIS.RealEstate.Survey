using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Api.Static;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Config;
using VastGIS.Plugins.RealEstate.Services;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Helpers;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate
{
    public class ProjectListener
    {
        private readonly IAppContext _context;
        private readonly IRealEstateEditingService _layerService;
        private RealEstateEditor _plugin;
        private ILayerService _olayerService;
        private SynchronizationContext _syncContext;
        private ISpatialReference _spatialReference;
        private List<VgObjectclass> _classes;

        public ProjectListener(IAppContext context, RealEstateEditor plugin, IRealEstateEditingService layerService,ILayerService oLayerService)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (layerService == null) throw new ArgumentNullException("layerService");

            _context = context;
            _layerService = layerService;
            _plugin = plugin;
            _olayerService = oLayerService;
            plugin.ProjectChanged += Plugin_ProjectChanged;
            plugin.ProjectClosing += plugin_ProjectClosing;
            plugin.BeforeRemoveLayer += plugin_BeforeRemoveLayer;
        }

        /// <summary>
        /// 只支持两层结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plugin_ProjectChanged(object sender, EventArgs e)
        {
            if (_context.Map.Layers.Count <= 0)
            {
                if (string.IsNullOrEmpty(_context.Project.Filename) == false)
                {
                    //VGLayerConfig config = new VGLayerConfig(_context, _plugin);
                    //config.AddLayersFromDb();

                    ((IRealEstateContext)_context).RealEstateDatabase.DatabaseName =
                        ReProjectHelper.GetProjectDatabase(_context.Project.Filename);
                    _classes = ((IRealEstateContext)_context).RealEstateDatabase.SystemService
                        .GetObjectclasses(false);
                    List<VgObjectclass> classes = ((IRealEstateContext)_context).RealEstateDatabase.SystemService
                        .GetObjectclasses(true);
                    int srid = ((IRealEstateContext)_context).RealEstateDatabase.SystemService.GetSystemSRID();
                    _spatialReference = new SpatialReference();
                    _spatialReference.ImportFromEpsg(srid);
                    //_context.Map.Projection = _spatialReference;
                    string connectionString =((IRealEstateContext)_context).RealEstateDatabase.DatabaseName ;

                    _syncContext = SynchronizationContext.Current;
                    _olayerService.BeginBatch();
                    Task.Factory.StartNew(() =>
                        {
                            _context.Legend.Groups.Clear();
                            foreach (var oneclass in classes)
                            {
                                if (oneclass.Dxlx == 0)
                                {
                                    //检查该对象下面有没有图层，如果没有就不再加载
                                    if (oneclass.SubClasses == null) continue;
                                    //检查该对象下面是否只有表，而无空间数据
                                    if (oneclass.SubClasses.FirstOrDefault(c => c.Dxlx == 1) == null) continue;
                                    ILegendGroup legendGroup = _context.Legend.Groups.Add(oneclass.Zwmc);
                                    foreach (var subClass in oneclass.SubClasses)
                                    {
                                        LoadDataToMap(connectionString, subClass, legendGroup);
                                    }
                                }
                            }
                            
                        }).ContinueWith(t =>
                        {
                            _olayerService.EndBatch();
                            ReorderLayers(classes);
                            ((IRealEstateContext)_context).RealEstateDatabase.EntityChanged += RealEstateDatabase_EntityChanged;
                            _context.Map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
                        }, TaskScheduler.FromCurrentSynchronizationContext());
                }
                
            }
        }

        private void RealEstateDatabase_EntityChanged(object sender, VastGIS.RealEstate.Data.Events.EntityChanedEventArgs e)
        {
            if (e.Entities==null || e.Entities.Count<1) return;
            if (e.Entities[0].HasGeometry == false) return;
            ILayer pLayer = _context.Map.Layers.FirstOrDefault(c => c.Name.ToUpper() ==e.Entities[0].LayerName);
            if (pLayer == null)
            {
                VgObjectclass oneclass=_classes.FirstOrDefault(c => c.Mc.ToUpper() == e.Entities[0].TableName);
                if (oneclass != null)
                {
                    pLayer = _context.Map.Layers.FirstOrDefault(c => c.Name == oneclass.Zwmc);
                }
            }
            if (pLayer != null)
            {
                if (pLayer.IsVector)
                {
                    pLayer.VectorSource.ReloadFromSource();
                    _context.Map.Redraw(RedrawType.All);
                }
            }
        }

        private void ReorderLayers(List<VgObjectclass> classes)
        {
            foreach (var oneclass in classes)
            {
                if (oneclass.Dxlx > 0) continue;
                if (oneclass.SubClasses == null) continue;
                int groupHandle = FindGroupHandle(oneclass.Zwmc);
                foreach (var subClass in oneclass.SubClasses)
                {
                    if (subClass.Dxlx != 1) continue;
                    int subHandle = FindLayerHandle(subClass.Zwmc);
                    if (groupHandle > -1 && subHandle > -1)
                    {
                        _context.Legend.Layers.MoveLayer(subHandle, groupHandle);
                    }
                }
            }
        }

        private int FindGroupHandle(string layerName)
        {
            var layers = _context.Legend.Groups;
            for (int i = 0; i < layers.Count; i++)
            {
                var layer = layers[i];
                Debug.WriteLine(layer.Text + ": " + layer.Handle.ToString());
                if (layer.Text == layerName)
                    return layer.Handle;
            }
            return -1;
        }
        private int FindLayerHandle(string layerName)
        {
            var layers = _context.Legend.Layers;
            for (int i = 0; i < layers.Count; i++)
            {
                var layer = layers[i];
                Debug.WriteLine(layer.Name + ": "+ layer.Handle.ToString());
                if (layer.Name == layerName)
                    return layer.Handle;
            }
            return -1;
        }

        private void LoadDataToMap(string connectionString, VgObjectclass oneclass,ILegendGroup parentGroup)
        {
            string stepMsg = "";
            try
            {
                if (oneclass.Dxlx == 0)
                {
                    if (oneclass.SubClasses == null) return;
                    ILegendGroup legendGroup = _context.Legend.Groups.Add(oneclass.Zwmc);
                    stepMsg = oneclass.Zwmc;
                    foreach (var subClass in oneclass.SubClasses)
                    {
                        LoadDataToMap(connectionString, subClass, legendGroup);
                    }
                }
                else if (oneclass.Dxlx == 2) return;
                else if(oneclass.Dxlx==1)
                {
                    
                    stepMsg = oneclass.Zwmc;
                    var vectorLayer = new VectorLayer();
                    vectorLayer.DynamicLoading = true;
                    if (!string.IsNullOrEmpty(oneclass.Filter))
                    {
                        if (vectorLayer.Open(connectionString, oneclass.Filter,false))
                        {
                            //bool isDynamic = vectorLayer.DynamicLoading;
                            //vectorLayer.DynamicLoading = true;
                            var data = vectorLayer.Data;
                            AddLayerToMap(vectorLayer, oneclass.Zwmc);
                        }
                    }
                    else
                    {
                        if (vectorLayer.Open(connectionString, oneclass.Mc,false))
                        {
                            //bool isDynamic = vectorLayer.DynamicLoading;
                            //vectorLayer.DynamicLoading = true;
                           var data = vectorLayer.Data;
                            vectorLayer.Data.Snappable = oneclass.Snapable;
                            AddLayerToMap(vectorLayer,oneclass.Zwmc);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageService.Current.Warn("图层加载发生错误,"+stepMsg+":"+ex.Message);
                return;
            }
            
        }

        private void AddLayerToMap(VectorLayer layer,string layerName)
        {
            _syncContext.Post(o => _olayerService.AddDatasource(layer,layerName), layer);
        }

        private void plugin_BeforeRemoveLayer(object sender, LayerCancelEventArgs e)
        {
            if (_context.Map.GeometryEditor.LayerHandle == e.LayerHandle)
            {
                if (!_context.Map.GeometryEditor.SaveChanges())
                {
                    e.Cancel = true;
                    return;
                }
            }

            var layer = _context.Map.Layers.ItemByHandle(e.LayerHandle);
            if (layer != null && layer.FeatureSet != null && layer.FeatureSet.InteractiveEditing)
            {
                if (!_layerService.SaveEditing(true))
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void plugin_ProjectClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_context.Map.GeometryEditor.SaveChanges())
            {
                e.Cancel = true;
                return;
            }
            
            var layers = _context.Map.Layers;

            foreach (var layer in layers)
            {
                var fs = layer.FeatureSet;
                if (fs != null && fs.InteractiveEditing)
                {
                    if (!_layerService.SaveEditing(true))
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }
    }
}
