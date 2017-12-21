using System;

namespace VastGIS.Data.Repository
{
    public class RepositoryEventArgs: EventArgs
    {
        public RepositoryEventArgs(IRepositoryItem item)
        {
            if (item == null) throw new ArgumentNullException("item");
            Item = item;
        }

        public IRepositoryItem Item { get; private set; }
    }
}
