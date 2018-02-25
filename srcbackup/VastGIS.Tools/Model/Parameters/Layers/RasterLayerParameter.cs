using System.IO;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Model.Parameters.Layers
{
    internal class RasterLayerParameter : LayerParameterBase
    {
        public override DataSourceType DataSourceType
        {
            get { return DataSourceType.Raster; }
        }

        public override object Value
        {
            get
            {
                if (Control != null)
                {
                    return Control.GetValue() as IRasterInput;
                }

                return base.Value;
            }
        }

        public override ILayerSource Datasource
        {
            get
            {
                var info = Value as IRasterInput;
                return info != null ? info.Datasource : null;
            }
        }
    }
}
