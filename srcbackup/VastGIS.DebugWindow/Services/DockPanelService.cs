﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.DebugWindow.Properties;
using VastGIS.Plugins.DebugWindow.Views;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.DebugWindow.Services
{
    public class DockPanelService
    {
        public const string DockPanelKey = "DebugDockPanel";

        public DockPanelService(IAppContext context, DebugWindowPlugin plugin, DebugPresenter presenter)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (plugin == null) throw new ArgumentNullException("plugin");
            if (presenter == null) throw new ArgumentNullException("presenter");

            var panels = context.DockPanels;

            panels.Lock();

            try
            {
                var panel = panels.Add(presenter.GetInternalObject(), DockPanelKey, plugin.Identity);
                panel.Caption = "Debug";
                panel.SetIcon(Resources.ico_bug24);
                panel.DockTo(DockPanelState.Bottom, 300);
                panel.Visible = false;
            }
            finally
            {
                panels.Unlock();
            }
        }
    }
}
