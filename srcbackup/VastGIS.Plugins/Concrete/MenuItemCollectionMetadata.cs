using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Concrete
{
    internal class MenuItemCollectionMetadata
    {
        public IMenuItem InsertBefore { get; set; }
        public bool AlignRight { get; set; }
    }
}
