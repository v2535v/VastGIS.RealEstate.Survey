using System.IO;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Model.Parameters.Layers
{
    /// <summary>
    /// Layer of arbitrary type.
    /// </summary>
    internal class GenericLayerParameter: LayerParameterBase
    {
        public override DataSourceType DataSourceType
        {
            get { return DataSourceType.All; }
        }

        public override object Value
        {
            get
            {
                if (Control != null)
                {
                    return Control.GetValue() as IDatasourceInput;
                }

                return base.Value;
            }
        }

        public override ILayerSource Datasource
        {
            get
            {
                var info = Value as IDatasourceInput;
                return info != null ? info.Datasource : null;
            }
        }
    }
}
