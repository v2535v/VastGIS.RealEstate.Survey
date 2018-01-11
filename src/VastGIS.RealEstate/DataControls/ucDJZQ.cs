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
    public partial class ucDJZQ : UserControl
    {
        public ucDJZQ()
        {
            InitializeComponent();
        }

        public void LinkObject(Djzq djzq)
        {
            intID.DataBindings.Clear();
            txtYSDM.DataBindings.Clear();
            txtDJZQDM.DataBindings.Clear();
            txtDJZQMC.DataBindings.Clear();
            intID.DataBindings.Add("Value", djzq, "ID",false,DataSourceUpdateMode.Never);
            txtYSDM.DataBindings.Add("Text", djzq, "Ysdm");
            txtDJZQDM.DataBindings.Add("Text", djzq, "Djzqdm");
            txtDJZQMC.DataBindings.Add("Text", djzq, "Djzqmc");
            
        }
    }
}
