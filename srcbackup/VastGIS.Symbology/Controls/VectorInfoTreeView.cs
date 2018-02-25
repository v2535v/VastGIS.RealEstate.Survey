using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Symbology.Helpers;
using VastGIS.UI.Controls;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;

namespace VastGIS.Plugins.Symbology.Controls
{
    public class VectorInfoTreeView : TwoColumnTreeView
    {
        public void Initialize(ILayer layer)
        {
            CreateColumns();

            if (layer == null) return;

            Nodes.Clear();

            var root = VectorInfoHelper.GetFeatureSetInfo(layer.FeatureSet);

            var ogr = VectorInfoHelper.GetVectorLayerInfo(layer.VectorSource);
            root.AddSubItem(ogr);

            var node = AddSubItems(Nodes, root);

            node.ExpandAll();
        }
    }
}
