using System.IO;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Model.Parameters.Layers
{
    internal class VectorLayerParameter: LayerParameterBase
    {
        public override DataSourceType DataSourceType
        {
            get { return DataSourceType.Vector; }
        }

        public override object Value
        {
            get
            {
                if (Control != null)
                {
                    return Control.GetValue() as IVectorInput;
                }

                return base.Value;
            }
        }

        public override ILayerSource Datasource
        {
            get
            {
                var info = Value as IVectorInput;
                return info != null ? info.Datasource : null;
            }
        }
    }
}
