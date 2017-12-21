using VastGIS.Data.Enums;

namespace VastGIS.Data.Repository
{
    public interface IRepositoryItem
    {
        RepositoryItemType Type { get; }
        RepositoryItemCollection SubItems { get; }
        object GetInternalObject();
        void Expand();
        void Refresh();
        bool Loaded { get; }
        IRepositoryItem Parent { get; }
        string DisplayName { get; }
    }
}
