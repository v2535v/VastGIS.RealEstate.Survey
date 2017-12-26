// -------------------------------------------------------------------------------------------
// <copyright file="PrintingPlugin.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mef;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Printing.Controls;
using VastGIS.Plugins.Printing.Menu;
using VastGIS.Plugins.Printing.Services;

namespace VastGIS.Plugins.Printing
{
    [MapWindowPlugin(loadOnStartUp: true)]
    public class PrintingPlugin : BasePlugin
    {
        private MenuGenerator _menuGenerator;
        private MenuListener _menuListener;
        private MapListener _mapListener;
        private IAppContext _context;
        private PrinterSettings _printerSettings;
        private MenuUpdater _menuUpdater;

        public PrinterSettings PrinterSettings
        {
            get { return _printerSettings ?? (_printerSettings = new PrinterSettings()); }
        }

        public override void Initialize(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            _context = context;
            _menuGenerator = context.Container.GetInstance<MenuGenerator>();
            _menuListener = context.Container.GetInstance<MenuListener>();
            _mapListener = context.Container.GetInstance<MapListener>();
            _menuUpdater = context.Container.GetInstance<MenuUpdater>();
        }

        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }

        public override IEnumerable<IConfigPage> ConfigPages
        {
            get { yield return _context.Container.GetInstance<PrintingConfigPage>(); }
        }
    }
}