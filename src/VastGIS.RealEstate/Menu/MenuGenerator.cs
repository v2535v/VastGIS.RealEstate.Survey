﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuGenerator.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The menu generator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using VastGIS.Api.Enums;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.ShapeEditor;
using VastGIS.UI.Menu.Ribbon;

namespace VastGIS.Plugins.RealEstate.Menu
{
    #region

    #endregion

    /// <summary>
    /// The menu generator.
    /// </summary>
    public class MenuGenerator
    {
        #region Fields

        /// <summary>
        /// The menu commands.
        /// </summary>
        private readonly MenuCommands _commands;

        #endregion

        private readonly IAppContext _context;
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuGenerator"/> class.
        /// </summary>
        /// <param name="context">
        /// The application context.
        /// </param>
        /// <param name="plugin">
        /// The plugin.
        /// </param>
        public MenuGenerator(IAppContext context, RealEstateEditor plugin)
        {
            _commands = new MenuCommands(context,plugin);
            _context = context;
            // InitMenu(context, plugin.Identity);
            if (context.ViewType == MainViewType.Normal)
            {

                InitMenu(context, plugin.Identity);
            }
            else
            {
               InitRibbonMenu(context, plugin.Identity);
            }
        }
        #endregion

        private void InitRibbonMenu(IAppContext context, PluginIdentity identity)
        {
            RibbonMenu menu = context.RibbonMenu as RibbonMenu;
            menu.AddHeaderTab("tabZD", "数据采集");
            menu.AddToolStripEx("toolStripExZDCommon", "数据编辑", "tabZD");

            menu.AddButton(_commands[MenuKeys.NewREProject]);
            menu.AddButton(_commands[MenuKeys.ImportDXF]);

            menu.AddButton(_commands[MenuKeys.ZoomToDbMax]);
            menu.AddButton(_commands[MenuKeys.NewFeature]);
            menu.AddButton(_commands[MenuKeys.CopyFeature]);
            menu.AddButton(_commands[MenuKeys.DeleteFeature]);
            menu.AddButton(_commands[MenuKeys.EditFeature]);
            menu.AddButton(_commands[MenuKeys.EditGeometry]);
            menu.AddButton(_commands[MenuKeys.UnionFeature]);
            menu.AddButton(_commands[MenuKeys.SplitPolygon]);
            menu.AddButton(_commands[MenuKeys.WYGZFeature]);
            menu.AddButton(_commands[MenuKeys.TwoDistanceConstructor]);
            menu.AddButton(_commands[MenuKeys.CreateJZDByZD]);
            menu.AddButton(_commands[MenuKeys.AssignZRZH]);
            menu.AddButton(_commands[MenuKeys.AssignPhoto]);

            menu.AddToolStripEx("toolStripExZDTable", "属性表编辑", "tabZD");
            menu.AddButton(_commands[MenuKeys.OpenTable]);

            menu.AddToolStripEx("toolStripExZDTool", "工具", "tabZD");
            menu.AddButton(_commands[MenuKeys.Measure]);
        }

        public MenuCommands MenuCommands { get { return _commands; } }
        #region Methods

        /// <summary>
        /// Initialize the new menu.
        /// </summary>
        /// <param name="context">
        /// The application context.
        /// </param>
        /// <param name="identity">
        /// The plug-in identity.
        /// </param>
        private void InitMenu(IAppContext context, PluginIdentity identity)
        {
            var menu = context.Menu.Items.AddDropDown("不动产", "_", identity);
            foreach (ICommand menuCommand in _commands.GetCommands())
            {
                menu.SubItems.AddButton(menuCommand.Text, menuCommand.Key,menuCommand.Icon, identity);
            }
            //menu.SubItems.AddButton("打开不动产数据库", MenuKeys.OpenRealEstateDatabase, identity);
            //menu.SubItems.AddButton("启动编辑", MenuKeys.StartEditingRealEstateDatabase, identity);
        }

        /// <summary>
        /// Initialize the toolbar.
        /// </summary>
        /// <param name="context">
        /// The application context.
        /// </param>
        /// <param name="identity">
        /// The plug-in identity.
        /// </param>
        private void InitToolbar(IAppContext context, PluginIdentity identity)
        {
            // Create a new toolbar
            var bar = context.Toolbars.Add("Template Plugin toolbar", identity);
            bar.DockState = ToolbarDockState.Top;

            // Add toolbar buttons, use MenuKeys to identify the buttons and add the command in MenuCommands:
            bar.Items.AddButton(_commands[MenuKeys.ShowDockableWindow]);
        }

        #endregion
    }
}