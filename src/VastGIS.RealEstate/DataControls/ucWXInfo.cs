using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucWXInfo : UserControl
    {
        public ucWXInfo()
        {
            InitializeComponent();
        }

        public void LinkObject(IBackEntity entity)
        {
            txtWXDCY.DataBindings.Clear();
            //datWXDCSJ.DataBindings.Clear();
            //txtWXCLY.DataBindings.Clear();
            //datWXCLSJ.DataBindings.Clear();
            //txtWXZTY.DataBindings.Clear();
            //datWXZTSJ.DataBindings.Clear();
            txtWXDCY.DataBindings.Add("Text", entity, "WxDcy");
            //datWXDCSJ.DataBindings.Add("Value", entity, "WxDcsj");
            txtWXCLY.DataBindings.Add("Text", entity, "WxCly");
            //datWXCLSJ.DataBindings.Add("Value", entity, "WxClsj");
            txtWXZTY.DataBindings.Add("Text", entity, "WxZty");
            //datWXZTSJ.DataBindings.Add("Value", entity, "WxZtsj");
        }
    }
}
