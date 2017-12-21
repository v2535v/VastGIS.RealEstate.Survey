using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Shared;

namespace VastGIS.Plugins.ShapeEditor.Helpers
{
    public static class FeatureSetHelper
    {
        public static string SerializeForClipboard(this IFeatureSet fs)
        {
            if (fs == null)
            {
                return "";
            }

            var sb = new StringBuilder("wkt_geom\t");

            foreach(var fld in fs.Table.Fields)
            {
                sb.Append(fld.Name);
                sb.Append('\t');
            }
            sb.RemoveFromEnd("\t");
            sb.Append(Environment.NewLine);

            foreach(var ft in fs.Features)
            {
                sb.Append(ft.Geometry.ExportToWkt() + "\t");
                
                for (int j = 0; j < ft.NumFields; j++)
                {
                    var val = ft.GetValue(j);
                    sb.Append(val ?? "NULL");
                    sb.Append("\t");
                }

                sb.RemoveFromEnd("\t");
                sb.Append(Environment.NewLine);
            }
            sb.RemoveFromEnd(Environment.NewLine);

            return sb.ToString();
        }

        /// <summary>
        /// Returns true if at least one feature within featureset has multipart geometry.
        /// </summary>
        public static bool HasMultiPart(this IFeatureSet fs, bool selectedOnly = true)
        {
            return fs.Features.Any(ft => (!selectedOnly || ft.Selected) && ft.Geometry.Parts.Count > 1);
        }
    }
}
