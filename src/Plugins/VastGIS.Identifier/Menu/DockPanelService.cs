using System;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Identifier.Properties;
using VastGIS.Plugins.Identifier.Views;
using VastGIS.Plugins.Interfaces;
using VastGIS.UI.Docking;

namespace VastGIS.Plugins.Identifier.Menu
{
    public class DockPanelService
    {
        public DockPanelService(IAppContext context, IdentifierPresenter presenter, IdentifierPlugin plugin)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (presenter == null) throw new ArgumentNullException("presenter");
            if (plugin == null) throw new ArgumentNullException("plugin");

            var panels = context.DockPanels;

            panels.Lock();
            var panel = panels.Add(presenter.GetInternalObject(), DockPanelKeys.Identifier, plugin.Identity);
            panel.Caption = "Identifier";
            panel.SetIcon(Resources.ico_identify);

            var preview = panels.Preview;
            if (preview != null && preview.Visible)
            {
                panel.DockTo(preview, DockPanelState.Tabbed, 150);
            }

            panels.Unlock();
        }
    }
}
