using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucJZD : UserControl
    {
        private Jzd _jzd;

        public ucJZD()
        {
            InitializeComponent();
        }

        public void LinkObject(Jzd jzd)
        {
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue", jzd, "ID");
            txtZDZHDM.DataBindings.Clear();
            txtZDZHDM.DataBindings.Add("Text", jzd, "Zdzhdm");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text", jzd, "Ysdm");
            txtJZDH.DataBindings.Clear();
            txtJZDH.DataBindings.Add("Text", jzd, "Jzdh");
            txtJZDGZBH.DataBindings.Clear();
            txtJZDGZBH.DataBindings.Add("Text", jzd, "Jzdgzbh");
            //intSXH.DataBindings.Clear();
            //intSXH.DataBindings.Add("IntegerValue", jzd, "Sxh");
            //cmbJBLX.DataBindings.Clear();
            //cmbJBLX.DataBindings.Add("SelectedValue", jzd, "Jblx");
            //cmbJZDLX.DataBindings.Clear();
            //cmbJZDLX.DataBindings.Add("SelectedValue", jzd, "Jzdlx");
            //dblXZBZ.DataBindings.Clear();
            //dblXZBZ.DataBindings.Add("DoubleValue", jzd, "Xzbz");
            //dblYZBZ.DataBindings.Clear();
            //dblYZBZ.DataBindings.Add("DoubleValue", jzd, "Yzbz");
            _jzd = jzd;
        }
    }
}
