﻿using System;
using System.ComponentModel;
using System.Linq;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;

namespace VastGIS.Data.Model
{
    public class VectorLayerGridAdapter
    {
        private readonly VectorLayer _layer;

        public VectorLayerGridAdapter(VectorLayer layer)
        {
            if (layer == null) throw new ArgumentNullException("layer");
            _layer = layer;
        }

        public bool Selected { get; set; }

        public string Name
        {
            get { return _layer.Name; }
        }

        [DisplayName("Features count")]
        public int NumFeatures
        {
            get { return _layer.get_FeatureCount(); }
        }

        [DisplayName("EPSG")]
        public string Epsg
        {
            get
            {
                int epsg;
                if (_layer.Projection.TryAutoDetectEpsg(out epsg))
                {
                    return epsg.ToString();
                }
                return "<not defined>";
            }
        }
        
        [Browsable(false)]
        public GeometryType GeometryType
        {
            get { return _layer.GeometryType; }
        }

        [Browsable(false)]
        public VectorLayer Layer
        {
            get { return _layer; }
        }
    }
}
