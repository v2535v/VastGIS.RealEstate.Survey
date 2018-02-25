﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Views.Abstract;

namespace VastGIS.Views
{
    internal class SetScalePresenter: BasePresenter<ISetScaleView>
    {
        private readonly IAppContext _context;

        public SetScalePresenter(ISetScaleView view, IAppContext context)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        private bool Validate(out double scale)
        {
            if (!double.TryParse(View.NewScale, out scale))
            {
                MessageService.Current.Info("Invalid scale.");
                return false;
            }

            if (scale <= 0)
            {
                MessageService.Current.Info("Scale must be positive.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// A handler for the IView.OkButton.Click event. 
        /// If the method returns true, View will be closed and presenter.ReturnValue set to true.
        /// If the method return false, no actions are taken, so View.Close, presenter.ReturnValue
        /// should be called / set manually.
        /// </summary>
        public override bool ViewOkClicked()
        {
            double scale;
            if (!Validate(out scale))
            {
                return false;
            }

            var oldBehavior = _context.Map.ZoomBehavior;
            
            _context.Map.ZoomBehavior = View.SnapToZoomLevel ? ZoomBehavior.UseTileLevels : ZoomBehavior.Default;

            _context.Map.CurrentScale = scale;

            _context.Map.ZoomBehavior = oldBehavior;

            return true;
        }
    }
}
