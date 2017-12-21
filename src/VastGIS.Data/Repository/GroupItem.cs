using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Plugins.Model;
using Syncfusion.Windows.Forms.Tools;

namespace VastGIS.Data.Repository
{
    internal class GroupItem : MetadataItem<GroupItemMetadata>, IGroupItem
    {
        internal GroupItem(TreeNodeAdv node)
            : base(node)
        {
        }

        public bool ExpandedOnce { get; private set; }

        public bool Expanded
        {
            get { return _node.Expanded; }
        }

        public bool IsParentOf(LayerIdentity identity)
        {
            return false;
        }

        public RepositoryGroup Group
        {
            get { return Metadata.Group; }
        }
    }
}
