using System;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.UI.Menu;

namespace VastGIS.Plugins.Identifier.Menu
{
    public class MenuListener: MenuServiceBase
    {
        private readonly IdentifierPlugin _plugin;
        
        public MenuListener(IAppContext context, IdentifierPlugin plugin):
            base(context, plugin.Identity)
        {
            if (plugin == null) throw new ArgumentNullException("plugin");
            _plugin = plugin;
            
            plugin.ItemClicked += plugin_ItemClicked;
            plugin.ViewUpdating += ViewUpdating;
        }

        private void ViewUpdating(object sender, EventArgs e)
        {
            var item = _context.Toolbars.FindItem(MenuKeys.IdentifyTool, _plugin.Identity);
            if (item != null)
            {
                item.Checked = _context.Map.MapCursor == MapCursor.Identify;
            }
        }

        void plugin_ItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.ItemKey)
            {
                case MenuKeys.IdentifyTool:
                    _context.Map.MapCursor = MapCursor.Identify;
                    break;
            }
        }
    }
}
