﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuListener.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015-2017
// </copyright>
// <summary>
//   The menu listener.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.TemplatePlugin.Properties;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Events;

namespace VastGIS.Plugins.TemplatePlugin.Menu
{

    /// <summary>
    ///     The menu listener.
    /// </summary>
    public class MenuListener
    {
        #region Constants

        /// <summary>
        ///     The key to identify the dock panel
        /// </summary>
        /// <remarks>Change it to fit your plug-in</remarks>
        private const string DOCKPANELKEY = "TemplatePluginDockPanel";

        #endregion

        #region Fields

        /// <summary>
        ///     The application context.
        /// </summary>
        private readonly IAppContext _context;

        /// <summary>
        ///     A user control as a sample for a dockable window.
        /// </summary>
        private readonly SampleDockWindow _sampleDockWindow;

        /// <summary>
        /// The _plugin.
        /// </summary>
        private readonly InitPlugin _plugin;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuListener"/> class.
        /// </summary>
        /// <param name="context">
        /// The application context.
        /// </param>
        /// <param name="plugin">
        /// The plugin.
        /// </param>
        /// <param name="sampleDockWindow">
        /// The sample dock wi
        /// </param>
        public MenuListener(IAppContext context, InitPlugin plugin, SampleDockWindow sampleDockWindow)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            if (plugin == null)
            {
                throw new ArgumentNullException("plugin");
            }

            if (sampleDockWindow == null)
            {
                throw new ArgumentNullException("sampleDockWindow");
            }

            // Save to local properties:
            _context = context;
            _sampleDockWindow = sampleDockWindow;
            _plugin = plugin;

            // Create event handlers:
            plugin.ItemClicked += Plugin_ItemClicked;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add a dockable window to the panels
        /// </summary>
        private void AddDockWindowToPanels()
        {
            var panels = _context.DockPanels;

            // Check if the panel not already exists:
            var myPanel = panels.Find(DOCKPANELKEY);
            if (myPanel != null)
            {
                myPanel.Visible = true;
                return;
            }

            // Panel is not yet loaded:
            panels.Lock();
            var panel = panels.Add(_sampleDockWindow, DOCKPANELKEY, _plugin.Identity);
            panel.Caption = "Template dock window";
            panel.SetIcon(Resources.ico_template);

            // TODO: Read configuration setting to show the window like the last time:
            var preview = panels.Preview;
            if (preview != null && preview.Visible)
            {
                panel.DockTo(preview, DockPanelState.Tabbed, 150);
            }

            panels.Unlock();

            _sampleDockWindow.Write("AddDockWindowToPanels", "Add to panel");
        }

        /// <summary>
        /// The toolbar button clicked event handler
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The menu item event arguments
        /// </param>
        private void Plugin_ItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.ItemKey)
            {
                case MenuKeys.ShowDockableWindow:
                    // Clicked on the toolbar button
                    MessageService.Current.Info("Hello from Template plugin");
                    AddDockWindowToPanels();
                    break;
            }
        }

        #endregion
    }
}