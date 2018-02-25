using System.Drawing;
using VastGIS.Api.Enums;

namespace VastGIS.Api.Interfaces
{
    public interface IGeometryVertexStyle
    {
        Color Color { get; set; }
        bool FillVisible { get; set; }
        int Size { get; set; }
        VertexType VertexType { get; set; }
        bool Visible { get; set; }
    }
}
