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
            StringBuilder builder = new StringBuilder();
            if (cmbXJFS.SelectedItem != null)
            {
                builder.Append("该宗地进行了" + cmbXJFS.Text + ",");
                builder.Append("房屋" + cmbXJFS.Text + "时间为" + intXJNF.IntegerValue.ToString() + "年,");
            }
            if (chkZJ1.Checked)
            {
                if (cmbXJFS.SelectedItem != null)
                    builder.Append("已经办理了" + cmbXJFS.Text + "手续，");
                builder.Append("土地证号:" + txtTDZH.Text.Trim() == "" ? "无" : txtTDZH.Text);
                builder.Append("批准文号:" + txtPZWH.Text.Trim() == "" ? "无" : txtPZWH.Text);
            }
            else
            {
                if (cmbXJFS.SelectedItem != null)
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
            {
                builder.Append("四至界址有争议。");
            }
            return builder.ToString();
        }

        public GKJ GetGkj()
        {
            GKJ gkj = new GKJ();

            if (cmbXJFS.SelectedIndex >= 0)
            {
                gkj.XJFS = $"该宗地已进行{cmbXJFS.Text}，房屋{cmbXJFS.Text}时间{intXJNF.IntegerValue}年";
                if (chkZJ1.Checked) gkj.XJSS = $"已办理了{cmbXJFS.Text}手续";
                else gkj.XJSS = $"未办理{cmbXJFS.Text}手续";
            }
            gkj.XJNF = intXJNF.IntegerValue.ToString();

            if (!string.IsNullOrEmpty(txtTDZH.Text.Trim())) gkj.TDZH = $"土地证号:{txtTDZH.Text.Trim()}";
            if (!string.IsNullOrEmpty(txtPZWH.Text.Trim())) gkj.PZWH = $"批准文号:{txtPZWH.Text.Trim()}";

            if (dblXZZDMJ.DoubleValue > 0)
            {
                gkj.XZZDMJ = $"现状宗地面积为{dblXZZDMJ.DoubleValue}平方米";
                if (dblXZZDMJ.DoubleValue > dblYYMJ.DoubleValue) gkj.XZZDMJ += $"，比原登记面积增加{dblXZZDMJ.DoubleValue - dblYYMJ.DoubleValue}平方米";
                if (dblXZZDMJ.DoubleValue < dblYYMJ.DoubleValue) gkj.XZZDMJ += $"，比原登记面积减少{dblYYMJ.DoubleValue - dblXZZDMJ.DoubleValue}平方米";
            }

            if (dblLSYDMJ.DoubleValue > 0) gkj.LSYDMJ = $"其中临时用地面积{dblLSYDMJ.DoubleValue}平方米";

            if (dblYYMJ.DoubleValue > 0) gkj.YYZDMJ = $"发证宗地面积{dblYYMJ.DoubleValue}平方米";

            if (dblFCJZMJ.DoubleValue > 0) gkj.FCJZMJ = $"房产建筑面积{dblFCJZMJ.DoubleValue}平方米";

            if (cmbSZ.SelectedIndex >= 0)
            {
                gkj.SZJZ = $"四至{cmbSZ.Text}";
            }

            if (chkZL.Checked) gkj.ZL = $"坐落发生变化";
            else gkj.ZL = "坐落未发生变化";

            if (chkJZ.Checked) gkj.JZ = "界址发生变化";
            else gkj.JZ = "界址未发生变化";

            return gkj;
        }
    }

    public class GKJ
    {
        public string XJFS { get; set; }

        public string XJNF { get; set; }

        public string XJSS { get; set; }

        public string TDZH { get; set; }

        public string PZWH { get; set; }

        public string XZZDMJ { get; set; }

        public string LSYDMJ { get; set; }

        public string YYZDMJ { get; set; }

        public string FCJZMJ { get; set; }

        public string SZJZ { get; set; }
        public string ZL { get; set; }
        public string JZ { get; set; }
    }
}
