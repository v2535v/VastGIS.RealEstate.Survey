using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Tools.Views.Custom.Abstract
{
    public interface IRandomPointsView: IView<ToolViewModel>
    {
        int NumPoints { get; }
        ILayerSource Input { get; }
        string OutputName { get; }
    }
}
