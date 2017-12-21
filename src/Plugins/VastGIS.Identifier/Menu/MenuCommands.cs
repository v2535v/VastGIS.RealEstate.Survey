using System.Collections.Generic;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Identifier.Properties;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Identifier.Menu
{
    public class MenuCommands : CommandProviderBase
    {
        public MenuCommands(PluginIdentity identity) : base(identity)
        {
        }

        public override IEnumerable<ICommand> GetCommands()
        {
            return new List<MenuCommand>()
            {
                new MenuCommand("Identify Shapes and Raster Values", MenuKeys.IdentifyTool, Resources.icon_identify)
            };
        }
    }
}
