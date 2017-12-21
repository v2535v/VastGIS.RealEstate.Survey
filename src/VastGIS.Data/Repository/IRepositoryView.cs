using System;
using System.Collections.Generic;
using VastGIS.Api.Concrete;
using VastGIS.Data.Enums;

namespace VastGIS.Data.Repository
{
    public interface IRepositoryView
    {
        RepositoryItemCollection Items { get; }
        IRepositoryItem GetSpecialItem(RepositoryItemType type);
        IGroupItem GetGroup(RepositoryItemType rootType, Guid groupId);
        IRepositoryItem SelectedItem { get; }
        event EventHandler<RepositoryEventArgs> ItemSelected;
        void UpdateState(HashSet<LayerIdentity> layers);
        void UpdateState(IRepositoryItem item);
        void UpdateTmsState(int providerId);
    }
}
