using System;
using System.Collections.Generic;
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
                    string connectionString = "Data Source=" +
                                              ((IRealEstateContext)_context).RealEstateDatabase.DatabaseName;
                    var ds = GeoSource.Open(((IRealEstateContext)_context).RealEstateDatabase.DatabaseName);
                    
                    _context.Map.Lock();
                    _context.Legend.Lock();
                    foreach (var oneclass in classes)
                    {
                        LoadDataToMap(ds,connectionString, oneclass,null);
                    }
                    _context.Map.Unlock();
                    _context.Legend.Unlock();
                    _context.Legend.Redraw();
                }
            }
        }

        private void LoadDataToMap(IDatasource ds,string connectionString, VgObjectclasses oneclass,ILegendGroup parentGroup)
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
                        LoadDataToMap(ds, connectionString, subClass, legendGroup);
                       
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(oneclass.Filter))
                    {
                        stepMsg = oneclass.Zwmc;
                        IVectorLayer vectorLayer = ((IVectorDatasource)ds).RunQuery(oneclass.Filter);
                        vectorLayer.DynamicLoading = true;
                        int handle = _context.Map.Layers.Add(vectorLayer, (bool)oneclass.Visible);
                        _context.Legend.Layers.ItemByHandle(handle).Name = oneclass.Zwmc;
                        //_context.Legend.Layers.MoveLayer(handle, parentGroup.Handle);
                    }
                    else
                    {
                        stepMsg = oneclass.Zwmc;
                        IVectorLayer vectorLayer = ((IVectorDatasource)ds).GetLayerByName(oneclass.Mc, false);
                        vectorLayer.DynamicLoading = true;
                        int handle = _context.Map.Layers.Add(vectorLayer, (bool)oneclass.Visible);
                        _context.Legend.Layers.ItemByHandle(handle).Name = oneclass.Zwmc;
                        //_context.Legend.Layers.MoveLayer(handle, parentGroup.Handle);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageService.Current.Warn("图层加载发生错误,"+stepMsg+":"+ex.Message);
                return;
            }
            
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
