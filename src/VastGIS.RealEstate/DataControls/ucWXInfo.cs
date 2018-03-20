using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucWXInfo : UserControl
    {
        public ucWXInfo()
        {
            InitializeComponent();
        }

        public void LinkObject(ISurveyEntity entity)
        {
            txtWXDCY.DataBindings.Clear();
            //datWXDCSJ.DataBindings.Clear();
            txtWXCLY.DataBindings.Clear();
            //datWXCLSJ.DataBindings.Clear();
            txtWXZTY.DataBindings.Clear();
            //datWXZTSJ.DataBindings.Clear();
            txtWXDCY.DataBindings.Add("Text", entity, "WxDcy", true, DataSourceUpdateMode.OnPropertyChanged);
            //datWXDCSJ.DataBindings.Add("Value", entity, "WxDcsj");
            txtWXCLY.DataBindings.Add("Text", entity, "WxCly", true, DataSourceUpdateMode.OnPropertyChanged);
            //datWXCLSJ.DataBindings.Add("Value", entity, "WxClsj");
            txtWXZTY.DataBindings.Add("Text", entity, "WxZty", true, DataSourceUpdateMode.OnPropertyChanged);
            //datWXZTSJ.DataBindings.Add("Value", entity, "WxZtsj");
        }

        public void LinkObject(AppConfig config, ISurveyEntity entity)
        {
            txtWXDCY.DataBindings.Clear();
            txtWXCLY.DataBindings.Clear();
            txtWXZTY.DataBindings.Clear();
            txtWXDCY.DataBindings.Add("Text", entity, "WxDcy", true, DataSourceUpdateMode.OnPropertyChanged);
            txtWXCLY.DataBindings.Add("Text", entity, "WxCly", true, DataSourceUpdateMode.OnPropertyChanged);
            txtWXZTY.DataBindings.Add("Text", entity, "WxZty", true, DataSourceUpdateMode.OnPropertyChanged);

            if (string.IsNullOrEmpty(entity.WxDcy))
                entity.WxDcy = config.WxDcy;
            if (string.IsNullOrEmpty(entity.WxCly))
                entity.WxCly = config.WxCly;
            if (string.IsNullOrEmpty(entity.WxZty))
                entity.WxZty = config.WxZty;
        }
    }
}
