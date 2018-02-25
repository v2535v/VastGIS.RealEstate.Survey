using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Projections.Forms;
using VastGIS.Shared;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;
using VastGIS.Tools.Properties;

namespace VastGIS.Tools.Tools.Projections
{
    [CustomLayout]
    [GisTool(GroupKeys.Projections)]
    public class IdentifyProjectionTool: ToolBase
    {
        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Identify projection";  }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Identifies projection as one of the well known from the projection string provided by user."; }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run()
        {
            using (var form = new IdentifyProjectionForm(_context))
            {
                return _context.View.ShowChildView(form);
            }
        }
    }
}
