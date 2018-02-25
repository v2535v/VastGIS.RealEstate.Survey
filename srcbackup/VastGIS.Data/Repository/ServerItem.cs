using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Enums;
using Syncfusion.Windows.Forms.Tools;

namespace VastGIS.Data.Repository
{
    internal class ServerItem : MetadataItem<ServerItemMetadata>, IServerItem
    {
        internal ServerItem(TreeNodeAdv node) : base(node)
        {
        }

        public GeoDatabaseType DatabaseType
        {
            get { return Metadata.DatabaseType; }
        }
    }
}
