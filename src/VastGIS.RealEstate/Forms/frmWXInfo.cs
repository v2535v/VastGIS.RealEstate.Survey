using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmWXInfo : Form
    {
        public frmWXInfo()
        {
            InitializeComponent();
        }

        public string WxDcy
        {
            get { return txtWXDCY.Text.Trim(); }
            set { txtWXDCY.Text = value; }
        }

        public string WxCly
        {
            get { return txtWXCLY.Text.Trim(); }
            set { txtWXCLY.Text = value; }
        }

        public string WxZty
        {
            get { return txtWXZTY.Text.Trim(); }
            set { txtWXZTY.Text = value; }
        }
    }
}
