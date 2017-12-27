using System;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Identifier.Menu
{
    public class MenuGenerator
    {
        private readonly IAppContext _context;
        private readonly MenuCommands _commands;

        public MenuGenerator(IAppContext context, IdentifierPlugin plugin)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (plugin == null) throw new ArgumentNullException("plugin");

            _commands = new MenuCommands(plugin.Identity);
            _context = context;

            if (context.ViewType == MainViewType.Normal)
            {

                //InitMenu(context, plugin.Identity);
                InitToolbar(context);
            }
            else
            {
                // InitRibbonMenu(context, plugin.Identity);
            }
            
        }

        private void InitToolbar(IAppContext context)
        {
            var items = context.Toolbars.MapToolbar.Items;

            items.AddButton(_commands[MenuKeys.IdentifyTool]);
        }
    }
}
