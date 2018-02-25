﻿// -------------------------------------------------------------------------------------------
// <copyright file="LayerService.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Linq;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Events;
using VastGIS.Api.Static;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Projections.Enums;
using VastGIS.Projections.Services.Abstract;
using VastGIS.Shared;
using LayerCancelEventArgs = VastGIS.Plugins.Events.LayerCancelEventArgs;

namespace VastGIS.Services.Concrete
{
    public class LayerService : ILayerService
    {
        private readonly IBroadcasterService _broadcaster;
        private readonly IAppContext _context;
        private readonly IFileDialogService _fileDialogService;
        private readonly IProjectionMismatchService _mismatchTester;
        private int _lastLayerHandle;
        private bool _withinBatch;
        private bool _aborted;
        
        public LayerService(
            IAppContext context,
            IFileDialogService fileDialogService,
            IBroadcasterService broadcaster,
            IProjectionMismatchService mismatchTester)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (fileDialogService == null) throw new ArgumentNullException("fileDialogService");
            if (broadcaster == null) throw new ArgumentNullException("broadcaster");

            _context = context;
            _fileDialogService = fileDialogService;
            _broadcaster = broadcaster;
            _mismatchTester = mismatchTester;
            _aborted = false;
        }

        /// <summary>
        /// Don't show the popup on projection mismatch, just do the reprojection
        /// </summary>
        /// <param name="autoReproject">if set to <c>true</c> [automatic reproject].</param>
        public void SetReprojectOnMismatch(bool autoReproject)
        {
            _mismatchTester.SetReprojectOnMismatch(autoReproject);
        }

        public bool RemoveSelectedLayer()
        {
            int layerHandle = _context.Legend.SelectedLayerHandle;
            if (layerHandle == -1)
            {
                MessageService.Current.Info("No selected layer to remove.");
                return false;
            }

            return RemoveLayerCore(layerHandle, false);
        }

        public bool RemoveLayer(int layerHandle)
        {
            BeginBatch();

            bool result = RemoveLayerCore(layerHandle, true);

            EndBatch();

            return result;
        }

        public bool RemoveLayer(LayerIdentity identity)
        {
            var layers = _context.Map.Layers.Where(l => l.Identity == identity);
            BeginBatch();

            bool result = false;
            foreach (var l in layers)
            {
                if (!RemoveLayerCore(l.Handle, true))
                {
                    result = false;
                    break;
                }
                result = true;
            }

            EndBatch();
            return result;
        }

        public bool AddLayer(DataSourceType layerType)
        {
            string[] filenames;
            if (!_fileDialogService.OpenFiles(layerType, out filenames))
            {
                return false;
            }

            BeginBatch();

            bool result = false;

            try
            {
                foreach (var name in filenames)
                {
                    if (AddLayersFromFilename(name))
                    {
                        result = true; // currently at least one should be success to return success
                    }
                }
            }
            finally
            {
                EndBatch();
            }

            return result;
        }

        public bool AddLayersFromFilename(string filename)
        {
            bool batch = _withinBatch;
            if (!batch)
            {
                BeginBatch();
            }

            bool result = AddLayersFromFilenameCore(filename);

            if (!batch)
            {
                EndBatch();
            }

            return result;
        }

        public bool AddLayersFromFilename(string filename, string layerName)
        {
            bool result = AddLayersFromFilename(filename);

            if (result)
            {
                int layerHandle = LastLayerHandle;
                var layer = _context.Layers.ItemByHandle(layerHandle);
                if (layer != null)
                {
                    layer.Name = layerName;
                }
            }

            return result;
        }

        public bool AddLayerIdentity(LayerIdentity identity)
        {
            if (identity == null)
            {
                return false;
            }

            switch (identity.IdentityType)
            {
                case LayerIdentityType.File:
                    return AddLayersFromFilenameCore(identity.Filename);
                case LayerIdentityType.OgrDatasource:
                    return AddDatabaseLayer(identity.Connection, identity.Query, identity.GeometryType);
                case LayerIdentityType.Wms:
                    return AddWmsLayer(identity);
                default:
                    Logger.Current.Warn("Unexpected layer identity");
                    return false;
            }
        }

        public bool AddDatabaseLayer(
            string connection,
            string layerName,
            GeometryType multiGeometryType = GeometryType.None,
            ZValueType zValue = ZValueType.None)
        {
            var layer = new VectorLayer();
            if (layer.Open(connection, layerName))
            {
                if (multiGeometryType != GeometryType.None)
                {
                    layer.SetActiveGeometryType(multiGeometryType, zValue);
                }
                
                return AddDatasource(layer);
            }

            return false;
        }

        public bool AddDatabaseLayer2(
            string connection,
            string layerName,
            GeometryType multiGeometryType = GeometryType.None,
            ZValueType zValue = ZValueType.None,string filter="")
        {
            var layer = new VectorLayer();
            if (string.IsNullOrEmpty(filter))
            {
                if (layer.Open(connection, layerName))
                {
                    if (multiGeometryType != GeometryType.None)
                    {
                        layer.SetActiveGeometryType(multiGeometryType, zValue);
                    }

                    return AddDatasource(layer);
                }
            }
            else
            {
                layer.OpenFromQuery(connection, filter);
              
                if (multiGeometryType != GeometryType.None)
                    {
                        layer.SetActiveGeometryType(multiGeometryType, zValue);
                    }

                    return AddDatasource(layer);
               

                //if (layer.OpenFromQuery(connection, filter))
                //{
                //   // layer.Name = layerName;
                //    if (multiGeometryType != GeometryType.None)
                //    {
                //        layer.SetActiveGeometryType(multiGeometryType, zValue);
                //    }

                //    return AddDatasource(layer);
                //}
            }
            return false;
        }

        public bool AddDatasource(IDatasource ds, string layerName = "")
        {
            int addedCount = 0;

            var layers = _context.Map.Layers;
            foreach (var layer in ds.GetLayers())
            {
                // projection mistmatch testing
                var newLayer = TestProjectionMismatch(layer, out _aborted);

                if (_aborted)
                {
                    return false;
                }

                if (newLayer == null)
                {
                    continue;
                }

                // ask plugins if they don't object
                var args = new DatasourceCancelEventArgs(newLayer);
                _broadcaster.BroadcastEvent(p => p.BeforeLayerAdded_, _context.Map, args);

                if (args.Cancel)
                {
                    return false;
                }

                int layerHandle = layers.Add(newLayer);
                if (layerHandle != -1)
                {
                    var ll = layers.ItemByHandle(layerHandle);
                    ll.Name = string.IsNullOrWhiteSpace(layerName) ? layer.Name : layerName;

                    addedCount++;
                    _lastLayerHandle = layerHandle;
                }
            }

            return addedCount > 0; // currently at least one should be success to return success
        }

        public void ZoomToSelected()
        {
            int handle = _context.Legend.SelectedLayerHandle;
            _context.Map.ZoomToSelected(handle);
        }

        public void ClearSelection()
        {
            foreach (var layer in _context.Map.Layers.Where(l => l.IsVector))
            {
                layer.FeatureSet.ClearSelection();
            }

            _context.Map.Redraw();
        }

        public bool Aborted
        {
            get
            {
                bool value = _aborted;
                _aborted = false;
                return value;
            }
        }

        public int LastLayerHandle
        {
            get
            {
                // TODO: it can be invalid when multithreading / tasks are used
                return _lastLayerHandle;
            }
        }

        public void BeginBatch()
        {
            _withinBatch = true;
            _context.Map.Lock();
        }

        public void EndBatch()
        {
            _withinBatch = false;
            _context.Map.Unlock();
            _context.Legend.Redraw();
        }

        public void SaveStyle()
        {
            int layerHandle = _context.Legend.SelectedLayerHandle;
            if (layerHandle == -1)
            {
                MessageService.Current.Info("No layer is selected");
            }

            bool result = _context.Map.Layers.Current.SaveOptions("", true, "");
            MessageService.Current.Info(result ? "Layer options are saved." : "Failed to save layer options.");
        }

        public void LoadStyle()
        {
            int layerHandle = _context.Legend.SelectedLayerHandle;
            if (layerHandle == -1)
            {
                MessageService.Current.Info("No layer is selected");
            }

            string description = "";
            bool result = _context.Map.Layers.Current.LoadOptions("", ref description);
            if (result)
            {
                _context.Legend.Redraw(LegendRedraw.LegendAndMap);
                MessageService.Current.Info("Options are loaded successfully.");
            }
            else
            {
                string msg = "No options are loaded: " + _context.Map.LastError;
                var layer = _context.Map.GetLayer(layerHandle).VectorSource;
                if (layer != null)
                {
                    msg += Environment.NewLine + "Last GDAL error message: " + layer.GdalLastErrorMsg;
                }

                MessageService.Current.Info(msg);
            }
        }

        private bool AddLayersFromFilenameCore(string filename)
        {
            try
            {
                var ds = GeoSource.Open(filename);

                if (ds == null)
                {
                    MessageService.Current.Warn(string.Format("Failed to open datasource: {0} \n {1}", filename,
                        GeoSource.LastError));
                    return false;
                }

                return AddDatasource(ds);
            }
            catch (Exception ex)
            {
                MessageService.Current.Warn(string.Format("There was a problem opening layer: {0}. \n Details: {1}",
                    filename, ex.Message));
                return false;
            }
        }

        private bool AddWmsLayer(LayerIdentity identity)
        {
            if (identity.IdentityType == LayerIdentityType.Wms)
            {
                var wms = new WmsSource("") { BaseUrl = identity.Connection, Layers = identity.Query };

                // TODO: we don't notify plugin about it, perhaps we should
                int layerHandle = _context.Map.Layers.Add(wms);
                if (layerHandle != -1)
                {
                    _lastLayerHandle = layerHandle;
                    return true;
                }
            }

            return false;
        }

        private bool RemoveLayerCore(int layerHandle, bool silent)
        {
            var layer = _context.Map.GetLayer(layerHandle);

            if (layer == null)
            {
                Logger.Current.Warn("LayerService.RemoveLayer: attempting to remove layer with invalid handle.");
                return false;
            }

            if (!silent)
            {
                if (!MessageService.Current.Ask(string.Format("Do you want to remove the layer: {0}?", layer.Name)))
                {
                    return false;
                }
            }

            var args = new LayerCancelEventArgs(layerHandle);
            _broadcaster.BroadcastEvent(p => p.BeforeRemoveLayer_, _context.Legend, args);
            if (args.Cancel)
            {
                return false;
            }

            _context.Map.Layers.Remove(layerHandle);
            return true;
        }

        /// <summary>
        /// Tests if datasources projection matches map projection. Performs reprojection is needed or
        /// substitues original datasources with reprojected version created earlier.
        /// </summary>
        private ILayerSource TestProjectionMismatch(ILayerSource layer, out bool abort)
        {
            abort = false;

            ILayerSource newLayer;
            var result = _mismatchTester.TestLayer(layer, out newLayer);

            switch (result)
            {
                case TestingResult.Ok:
                    newLayer = layer;
                    break;
                case TestingResult.Substituted:
                    // do nothing; user new layer
                    break;
                case TestingResult.SkipFile:
                case TestingResult.Error:
                    return null;
                case TestingResult.CancelOperation:
                    abort = true;
                    return null;
            }

            return newLayer;
        }
    }
}