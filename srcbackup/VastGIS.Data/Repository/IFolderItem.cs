namespace VastGIS.Data.Repository
{
    public interface IFolderItem : IExpandableItem
    {
        string GetPath();

        bool Root { get; }

        void ForceExpand();
    }
}
