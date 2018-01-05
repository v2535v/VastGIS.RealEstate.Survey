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

        public ucJZD(Jzd jzd)
        {
            InitializeComponent();
            _jzd = jzd;
            InitDataBinding();
        }

        private void InitDataBinding()
        {
            txtJZDH.DataBindings.Add("Text", _jzd, "Jzdh");
        }
        public Jzd Jzd
        {
            get { return _jzd; }
            set
            {
                _jzd=value;
                
            }
        }

        private void tabPageAdv1_Click(object sender, EventArgs e)
        {

        }
    }
}
