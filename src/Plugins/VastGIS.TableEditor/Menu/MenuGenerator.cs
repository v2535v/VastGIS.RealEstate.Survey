using System;
using System.Linq;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.TableEditor.Menu
{
    public class MenuGenerator
    {
        private readonly IAppContext _context;
        private readonly MenuCommands _commands;

        public MenuGenerator(IAppContext context, TableEditorPlugin plugin)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
            _commands = new MenuCommands(plugin);
            if (context.ViewType == MainViewType.Normal)
            {
                InitToolbars();

                InitMenu();
            }
            else
            {
                // InitRibbonMenu(context, plugin.Identity);
            }
        }

        private void InitToolbars()
        {
            var items = _context.Toolbars.FileToolbar.Items;
            items.AddButton(_commands[MenuKeys.ShowTable]);
        }

        private void InitMenu()
        {
            var menu = _context.Menu.LayerMenu;

            IMenuItem before = menu.SubItems.FirstOrDefault(subItem => subItem.HasKey && subItem.Key == Plugins.Menu.MenuKeys.LayerProperties);

            menu.SubItems.InsertBefore = before;

            menu.SubItems.AddButton(_commands[MenuKeys.ShowTable]).BeginGroup = true;

            menu.Update();
        }
    }
}
