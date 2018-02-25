using VastGIS.Api.Enums;
using VastGIS.Plugins.Enums;

namespace VastGIS.Plugins.Services
{
    public interface IFileDialogService
    {
        bool SaveFile(string filter, ref string filename);
        bool Open(string filter, out string filename, int filterIndex = -1);
        bool OpenFile(DataSourceType layerType, out string filename);
        bool OpenFiles(DataSourceType layerType, out string[] filenames);
        bool ChooseFolder(string initialPath, out string chosenPath);
        string Title { get; set; }
        string GetLayerFilter(LayerType layerType);
    }
}
