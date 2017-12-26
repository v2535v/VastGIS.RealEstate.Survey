// -------------------------------------------------------------------------------------------
// <copyright file="MenuListener.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Linq;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Printing.Enums;
using VastGIS.Plugins.Printing.Helpers;
using VastGIS.Plugins.Printing.Services;
using VastGIS.Plugins.Printing.Views;
using VastGIS.UI.Menu;

namespace VastGIS.Plugins.Printing.Menu
{
    internal class MenuListener : MenuServiceBase
    {
        private readonly PrintingPlugin _plugin;

        public MenuListener(IAppContext context, PrintingPlugin plugin)
            : base(context, plugin.Identity)
        {
            if (plugin == null) throw new ArgumentNullException("plugin");
            _plugin = plugin;

            plugin.ItemClicked += OnItemClicked;
            plugin.ViewUpdating += ViewUpdating;
        }
        
        private void ViewUpdating(object sender, EventArgs e)
        {
            var item = _context.Toolbars.FindItem(MenuKeys.SelectPrintArea, _plugin.Identity);
            if (item != null)
            {
                item.Checked = _context.Map.GetIsCustomSelectionMode(_plugin.Identity.Guid);
            }
        }

        private void OnItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.ItemKey)
            {
                case MenuKeys.Print:
                    var model = new TemplateModel(PrintArea.CurrentScreen, _plugin.PrinterSettings);

                    if (_context.Container.Run<TemplatePresenter, TemplateModel>(model))
                    {
                        _context.Container.Run<LayoutPresenter, TemplateModel>(model);
                    }
                    break;
                case MenuKeys.SelectPrintArea:
                    _context.Map.MapCursor = MapCursor.Selection;
                    _context.Map.StartCustomSelectionMode(_plugin.Identity.Guid);
                    break;
            }
        }
    }
}