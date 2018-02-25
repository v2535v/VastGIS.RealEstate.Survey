using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Model;

namespace VastGIS.Services.Serialization
{
    [DataContract]
    public class XmlRepository
    {
        public XmlRepository(IRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");

            Folders = repository.Folders.ToList();
            Connections = repository.Connections.ToList();
            WmsServers = repository.WmsServers.ToList();
            TmsProviders = repository.TmsProviders.ToList();
            TmsGroups = repository.TmsGroups.ToList();
            ExpandedFolders = repository.ExpandedFolders.ToList();
        }

        [DataMember]
        public List<RepositoryGroup> TmsGroups { get; set; }

        [DataMember]
        public List<string> Folders { get; set; }

        [DataMember]
        public List<string> ExpandedFolders { get; set; }

        [DataMember]
        public List<DatabaseConnection> Connections { get; set; }

        [DataMember]
        public List<WmsServer> WmsServers { get; set; }

        [DataMember]
        public List<TmsProvider> TmsProviders { get; set; }
    }
}
