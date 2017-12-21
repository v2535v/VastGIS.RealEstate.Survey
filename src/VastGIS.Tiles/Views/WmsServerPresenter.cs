using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Tiles.Views.Abstract;

namespace VastGIS.Tiles.Views
{
    internal class WmsServerPresenter: BasePresenter<IWmsServerView, WmsServer>
    {
        public WmsServerPresenter(IWmsServerView view)
            : base(view)
        {
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(View.ServerName))
            {
                MessageService.Current.Info("Server name is empty.");
                return false;
            }

            string url = View.Url;

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageService.Current.Info("URL is empty.");
                return false;
            }

            if (url.ToLower().StartsWith("https"))
            {
                MessageService.Current.Info("HTTPS protocol is not supported.");
                return false;
            }

            try
            {
                var uri = new Uri(url);
            }
            catch
            {
                MessageService.Current.Info("Invalid URL.");
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
            if (!Validate())
            {
                return false;
            }

            Model.Name = View.ServerName;
            Model.Url = View.Url;

            return true;
        }
    }
}
