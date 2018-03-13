using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmGKJ : Form
    {
        public frmGKJ()
        {
            InitializeComponent();
            cmbXJFS.SelectedIndex = 0;
        }

        public string GetMemo()
        {
            StringBuilder builder=new StringBuilder();
            builder.Append("该宗地进行了" + cmbXJFS.Text + ",");
            builder.Append("房屋"+ cmbXJFS.Text + "时间为"+intXJNF.IntegerValue.ToString()+"年,");
            if (chkZJ1.Checked)
            {
                builder.Append("已经办理了" + cmbXJFS.Text + "手续，");
                builder.Append("土地证号:" + txtTDZH.Text.Trim() == "" ? "无" : txtTDZH.Text);
                builder.Append("批准文号:" + txtPZWH.Text.Trim() == "" ? "无" : txtPZWH.Text);
            }
            else
            {
                builder.Append("未办理" + cmbXJFS.Text + "手续。");
            }

            builder.Append("现状宗地面积：" + dblXZZDMJ.DoubleValue.ToString() + "平方米，");
            builder.Append("原有宗地面积：" + dblYYMJ.DoubleValue.ToString() + "平方米，");
            builder.Append("房产建筑面积：" + dblFCJZMJ.DoubleValue.ToString() + "平方米。");
            if (cmbSZ.SelectedIndex == 0)
            {
                builder.Append("四至界址清楚。");
            }
            else
            { builder.Append("四至界址有争议。"); }
            return builder.ToString();
        }
       
    }
}
