using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;

namespace VastGIS.UI.Legacy
{
    /// <summary>
    /// Utility structure to hold drawing options with type
    /// </summary>
    public class GeometryRowStyle
    {
        internal GeometryStyle Style;
        internal GeometryType Type;

        public GeometryRowStyle(GeometryStyle style, GeometryType type)
        {
            Style = style;
            Type = type;
        }
    }
}
