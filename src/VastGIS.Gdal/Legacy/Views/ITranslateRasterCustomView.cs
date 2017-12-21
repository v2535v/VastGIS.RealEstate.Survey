using VastGIS.Plugins.Mvp;
using VastGIS.Tools.Views;

namespace VastGIS.Gdal.Legacy.Views
{
    public interface ITranslateRasterCustomView : IView<ToolViewModel>
    {
        string InputFilename { get; }
        string OutputFilename { get; }
        string Options { get; }
        string OutputFormat { get; }
        bool AddToMap { get; }
    }
}
