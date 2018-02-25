// -------------------------------------------------------------------------------------------
// <copyright file="WmsStylePresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.Symbology.Views.Abstract;
using VastGIS.Projections.Helpers;

namespace VastGIS.Plugins.Symbology.Views
{
    internal class WmsStylePresenter : ComplexPresenter<IWmsStyleView, WmsStyleCommand, ILegendLayer>
    {
        private readonly IAppContext _context;

        public WmsStylePresenter(IWmsStyleView view, IAppContext context)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        public override void RunCommand(WmsStyleCommand command)
        {
            switch (command)
            {
                case WmsStyleCommand.Projection:
                    _context.ShowProjectionProperties(Model.Projection, View as IWin32Window);
                    break;
                case WmsStyleCommand.Apply:
                    ApplyChanges();
                    _context.Map.Redraw();
                    break;
                case WmsStyleCommand.ClearCache:
                    if (MessageService.Current.Ask("Do you want to clear disk cache for this WMS layer?"))
                    {
                        _context.Map.Tiles.ClearCache2(CacheType.Disk, Model.WmsSource.Id);
                    }
                    break;
                case WmsStyleCommand.ClearColorAdjustments:
                    View.ClearColorAdjustments();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("command");
            }
        }

        /// <summary>
        /// A handler for the IView.OkButton.Click event. 
        /// If the method returns true, View will be closed and presenter.ReturnValue set to true.
        /// If the method return false, no actions are taken, so View.Close, presenter.ReturnValue
        /// should be called / set manually.
        /// </summary>
        public override bool ViewOkClicked()
        {
            return ApplyChanges();
        }

        private bool ApplyChanges()
        {
            if (!View.ValidateInput())
            {
                return false;
            }

            View.ApplyChanges();
            return true;
        }
    }
}