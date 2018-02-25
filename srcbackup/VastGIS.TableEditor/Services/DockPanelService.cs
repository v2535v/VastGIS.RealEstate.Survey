using System;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.TableEditor.Properties;
using VastGIS.Plugins.TableEditor.Views;
using VastGIS.UI.Docking;

namespace VastGIS.Plugins.TableEditor.Services
{
    internal class DockPanelService
    {
        public DockPanelService(IAppContext context, TableEditorPresenter presenter, TableEditorPlugin plugin)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (presenter == null) throw new ArgumentNullException("presenter");
            if (plugin == null) throw new ArgumentNullException("plugin");

            var panels = context.DockPanels;

            panels.Lock();
            var panel = panels.Add(presenter.GetInternalObject(), DockPanelKeys.TableEditor, plugin.Identity);
            panel.Caption = "Table editor";
            panel.SetIcon(Resources.ico_table24);

            panel.DockTo(DockPanelState.Bottom, 300);
            panel.Visible = false;

            panels.Unlock();
        }
    }
}
