using VastGIS.Api;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Services.Views.Abstract
{
    public interface ICreateLayerView : IView<CreateLayerModel>
    {
        string LayerName { get; }
        GeometryType GeometryType { get; }
        ZValueType ZValueType { get; }
        bool MemoryLayer { get; }
    }
}
