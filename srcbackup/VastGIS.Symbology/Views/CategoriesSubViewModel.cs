using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Symbology.Model;
using VastGIS.Plugins.Symbology.Services;

namespace VastGIS.Plugins.Symbology.Views
{
    public class CategoriesSubViewModel
    {
        public CategoriesSubViewModel(ILegendLayer layer, SymbologyMetadata metadata)
        {
            if (layer == null) throw new ArgumentNullException("layer");
            if (metadata == null) throw new ArgumentNullException("metadata");

            Layer = layer;
            Metadata = metadata;
        }

        public ILegendLayer Layer { get; set; }

        public SymbologyMetadata Metadata { get; set; }

        public IFeatureSet FeatureSet 
        {
            get { return Layer.FeatureSet; }
        }
    }
}
