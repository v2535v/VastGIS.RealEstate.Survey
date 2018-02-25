﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Static;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Enums;

namespace VastGIS.Tools.Model.Layers
{
    /// <summary>
    /// Darasource which serves as an input for a certain GIS tool.
    /// </summary>
    public class DatasourceInput: IVectorInput, IRasterInput
    {
        private string _filename = string.Empty;
        private readonly bool _closeAfterRun = true;
        private readonly int _layerHandle = -1;

        public DatasourceInput(ILayer layer)
        {
            if (layer == null) throw new ArgumentNullException("layer");

            _closeAfterRun = false;
            _layerHandle = layer.Handle;

            Datasource = layer.LayerSource;
        }

        public DatasourceInput(ILayerSource source)
        {
            if (source == null) throw new ArgumentNullException("source");
            Datasource = source;
        }

        public DatasourceInput(string filename)
        {
            // TODO: datasource must be closed in case of OGR layers
            var identity = new LayerIdentity(filename);
            var ds = GeoSource.OpenFromIdentity(identity);
            Datasource = ds.GetLayers().FirstOrDefault();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the datasource must be closed after the task is completed.
        /// </summary>
        public bool CloseAfterRun
        {
            get { return _closeAfterRun; }
        }

        /// <summary>
        /// Gets or sets the datasource serving as input for GIS task.
        /// </summary>
        IRasterSource IRasterInput.Datasource
        {
            get { return Datasource as IRasterSource; }
            set { throw new NotSupportedException(""); }
        }

        /// <summary>
        /// Gets or sets the datasource serving as input for GIS task.
        /// </summary>
        IFeatureSet IVectorInput.Datasource
        {
            get { return Datasource as IFeatureSet;  }
            set { throw new NotSupportedException(""); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether only selected features of the input layer should be processed.
        /// </summary>
        public virtual bool SelectedOnly { get; set; }

        /// <summary>
        /// Gets or sets the datasource serving as input for GIS task.
        /// </summary>
        public ILayerSource Datasource { get; set; }

        public string Name
        {
            get { return Path.GetFileNameWithoutExtension(Datasource != null ? Datasource.Filename: _filename);  }
        }

        /// <summary>
        /// Gets filename of the datasource.
        /// </summary>
        public string Filename 
        {
            get { return Datasource != null ? Datasource.Filename: _filename; } 
        }

        /// <summary>
        /// A pointer to datasource holding either identity or layer handler, sufficient to reopen 
        /// the datasource in the future.
        /// </summary>
        public DatasourcePointer Pointer 
        {
            get { return new DatasourcePointer(Filename); } 
        }

        /// <summary>
        /// Gets the type of the input.
        /// </summary>
        public InputType InputType 
        {
            get { return InputType.Datasource; } 
        }

        /// <summary>
        /// Closes the input layer if CloseAfterRun flag was set.
        /// </summary>
        public void Close()
        {
            _filename = Datasource.Filename;

            if (CloseAfterRun)
            {
                Datasource.Dispose();
            }

            Datasource = null;
        }

        /// <summary>
        /// Gets the layer handle of the input datasource. If datasource isn't added to the map -1 will be returned.
        /// </summary>
        public int LayerHandle 
        {
            get { return _layerHandle; } 
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Close();
        }
    }
}
