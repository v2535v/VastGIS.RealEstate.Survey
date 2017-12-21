using System.Collections.Generic;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.TableEditor.Properties;

namespace VastGIS.Plugins.TableEditor.Menu
{
    public class MenuCommands : CommandProviderBase
    {
        public MenuCommands(TableEditorPlugin plugin)
            : base(plugin.Identity)
        {
        }

        public override IEnumerable<ICommand> GetCommands()
        {
            return new List<MenuCommand>()
            {
                new MenuCommand("Attribute Table", MenuKeys.ShowTable, Resources.table_editor),
            };
        }
    }
}
