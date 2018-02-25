using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Model;

namespace VastGIS.Plugins.Interfaces
{
    public interface IRepository
    {
        IEnumerable<string> Folders { get; }
        IEnumerable<DatabaseConnection> Connections { get; }
        IEnumerable<WmsServer> WmsServers { get; }
        TmsProviderList TmsProviders { get;}
        RepositoryGroupList TmsGroups { get; }
        IEnumerable<TmsProvider> DefaultTmsProviders { get; }
        List<string> ExpandedFolders { get; }

        void Initialize(IAppContext context);

        void AddFolderLink();
        void AddFolderLink(string path);
        void RemoveFolderLink(string path, bool silent);

        void AddConnectionWithPrompt(GeoDatabaseType? databaseType = null);
        void AddConnection(DatabaseConnection connection);
        void RemoveConnection(DatabaseConnection connection, bool silent);

        void AddWmsServer(WmsServer server);
        void RemoveWmsServer(WmsServer server);
        void UpdateWmsServer(WmsServer server);
        void ClearWmsServers();
        
        event EventHandler BeforeSaved;
        event EventHandler<FolderEventArgs> FolderAdded;
        event EventHandler<FolderEventArgs> FolderRemoved;
        event EventHandler<ConnectionEventArgs> ConnectionAdded;
        event EventHandler<ConnectionEventArgs> ConnectionRemoved;

        void PrepareToSave();
    }
}
