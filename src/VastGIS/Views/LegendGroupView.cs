using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;
using VastGIS.UI.Forms;
using VastGIS.Views.Abstract;

namespace VastGIS.Views
{
    public partial class LegendGroupView : LegendGroupViewBase, ILegendGroupView
    {
        public LegendGroupView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            lblNumLayers.Text = "Number of layers: " + Model.Layers.Count;
            txtGroupName.Text = Model.Text;
            txtGroupName.SelectAll();
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public string GroupName
        {
            get { return txtGroupName.Text; }
        }

        private void txtGroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FireOkClicked();
            }
        }
    }

    public class LegendGroupViewBase : MapWindowView<ILegendGroup> { }
}
