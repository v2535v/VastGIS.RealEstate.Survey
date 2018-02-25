using System;
using System.ComponentModel;
using VastGIS.Api.Interfaces;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Controls
{
    /// <summary>
    /// A wrapper class which exposes properties to display input layer or datasource in the UI via binding (in comboboxes and grids).
    /// </summary>
    public class InputLayerGridAdapter
    {
        private readonly IDatasourceInput _source;

        public InputLayerGridAdapter(IDatasourceInput source)
        {
            if (source == null) throw new ArgumentNullException("source");
            _source = source;
        }

        public InputLayerGridAdapter(ILayer layer)
        {
            _source = new LayerInput(layer);
        }

        public InputLayerGridAdapter(string filename)
        {
            _source = new DatasourceInput(filename);
        }

        [Browsable(false)]
        public IDatasourceInput Source
        {
            get { return _source; } 
        }

        public string Description
        {
            get
            {
                string s = _source.Name;
                var ds = _source.Datasource;
                s += ds != null ? " " + ds.SizeInfo : string.Empty;
                return s;
            }
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
