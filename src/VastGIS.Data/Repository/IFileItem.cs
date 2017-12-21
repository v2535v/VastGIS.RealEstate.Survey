using VastGIS.Api.Concrete;

namespace VastGIS.Data.Repository
{
    public interface IFileItem : ILayerItem
    {
        string Filename { get; }
        IFolderItem Folder { get; }
    }
}
