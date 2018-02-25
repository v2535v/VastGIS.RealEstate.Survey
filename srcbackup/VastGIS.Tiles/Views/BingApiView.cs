using System;
using System.Windows.Forms;
using VastGIS.Plugins.Services;
using VastGIS.Shared;
using VastGIS.Tiles.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Tiles.Views
{
    public partial class BingApiView : MapWindowView, IBingApiView
    {
        public BingApiView(IConfigService service)
        {
            if (service == null) throw new ArgumentNullException("service");

            InitializeComponent();

            textBox1.Text = service.Config.BingApiKey;
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        private void OnlinkLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "http://www.microsoft.com/maps/create-a-bing-maps-key.aspx";
            PathHelper.OpenUrl(url);
        }

        public string Key
        {
            get { return textBox1.Text; }
        }
    }
}
