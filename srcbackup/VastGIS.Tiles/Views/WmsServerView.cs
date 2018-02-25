using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Services;
using VastGIS.Tiles.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Tiles.Views
{
    public partial class WmsServerView : WmsServerViewBase, IWmsServerView
    {
        public WmsServerView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            txtName.Text = Model.Name;
            txtUrl.Text = Model.Url;
        }

        public string ServerName
        {
            get { return txtName.Text; }
        }

        public string Url
        {
            get
            {
                string s = txtUrl.Text.Trim().ToLower();

                if (!s.StartsWith("http"))
                {
                    s = "http://" + s;
                }

                return s;
            }
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }
    }

    public class WmsServerViewBase : MapWindowView<WmsServer> { }
}
