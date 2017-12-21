using VastGIS.Plugins.Mvp;

namespace VastGIS.Views.Abstract
{
    public interface ISetProjectionView : IView
    {
        SetProjectionView.ProjectionType Projection { get; }
        string CustomProjection { get; }
        int DefaultProjectionIndex { get; }
    }
}
