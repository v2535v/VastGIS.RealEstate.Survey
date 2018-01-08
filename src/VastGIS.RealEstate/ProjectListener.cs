using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// 只是动态的加载了图层，暂时没有用组的方式，请修改，而且在已有项目打开的情况下项目新建还是有问题。
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
                    List<VgObjectclasses> classes = ((IRealEstateContext)_context).RealEstateDatabase.SystemService
                        .GetObjectclasseses(true);
                    int srid = ((IRealEstateContext)_context).RealEstateDatabase.SystemService.GetSystemSRID();
                    _spatialReference = new SpatialReference();
                    _spatialReference.ImportFromEpsg(srid);
                    //_context.Map.Projection = _spatialReference;
                    string connectionString =((IRealEstateContext)_context).RealEstateDatabase.DatabaseName ;

                    _syncContext = SynchronizationContext.Current;
                    _olayerService.BeginBatch();
                    Task.Factory.StartNew(() =>
                        {
                            foreach (var oneclass in classes)
                            {
                                if (oneclass.Dxlx == 0)
                                {
                                    ILegendGroup legendGroup = _context.Legend.Groups.Add(oneclass.Zwmc);
                                    if (oneclass.SubClasses == null) continue;
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
                            
                        }, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }

        private void ReorderLayers(List<VgObjectclasses> classes)
        {
            foreach (var oneclass in classes)
            {
                if (oneclass.Dxlx > 0) continue;
                int groupHandle = FindGroupHandle(oneclass.Zwmc);
                foreach (var subClass in oneclass.SubClasses)
                {
                   
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

        private void LoadDataToMap(string connectionString, VgObjectclasses oneclass,ILegendGroup parentGroup)
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
                else
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
                            AddLayerToMap(vectorLayer,oneclass.Zwmc);
                            //_olayerService.AddDatasource(vectorLayer, oneclass.Zwmc);
                            //int handle = _olayerService.LastLayerHandle;
                            //ILegendLayer legendLayer = _context.Legend.Layers.ItemByHandle(handle);
                            // legendLayer.Name = oneclass.Zwmc;
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
