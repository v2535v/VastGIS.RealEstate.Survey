using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmZJXZ : Form
    {
        public frmZJXZ()
        {
            InitializeComponent();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            chkZJ1.Checked = true;
            chkZJ2.Checked = true;
            chkZJ3.Checked = true;
            chkZJ4.Checked = true;
            chkZJ5.Checked = true;
            chkDJSX.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string GetMemo()
        {
            StringBuilder zjBuilder = new StringBuilder();
            List<string> zjList = new List<string>();
            if (chkZJ1.Checked) zjList.Add(chkZJ1.Text);
            if (chkZJ2.Checked) zjList.Add(chkZJ2.Text);
            if (chkZJ3.Checked) zjList.Add(chkZJ3.Text);
            if (chkZJ4.Checked) zjList.Add(chkZJ4.Text);
            if (chkZJ5.Checked) zjList.Add(chkZJ5.Text);
            if (zjList.Count > 0)
            {
                zjBuilder.AppendFormat("使用人提供了（{0}）", string.Join("、", zjList));
            }
            StringBuilder djBuilder = new StringBuilder();
            if (chkDJSX.Checked)
            {
                djBuilder.Append("已进行土地登记");
            }
            else
            {
                djBuilder.Append("未办理登记手续");
            }

            if (zjBuilder.Length <= 0) return djBuilder.ToString();
            return zjBuilder.AppendFormat("，{0}", djBuilder).ToString();

            //builder.Append("(");
            //if (chkZJ1.Checked) builder.Append(chkZJ1.Text + ",");
            //if (chkZJ2.Checked) builder.Append(chkZJ2.Text + ",");
            //if (chkZJ3.Checked) builder.Append(chkZJ3.Text + ",");
            //if (chkZJ4.Checked) builder.Append(chkZJ4.Text + ",");
            //if (chkZJ5.Checked) builder.Append(chkZJ5.Text + ",");
            //string memo = builder.ToString();
            //if (memo.Length == 1)
            //{
            //    memo = "(无)";
            //}
            //else
            //{
            //    memo = memo.Substring(0, memo.Length - 1) + ")";
            //}
            //if (chkDJSX.Checked)
            //{
            //    memo += ",已办理登记手续";
            //}
            //else
            //{
            //    memo += ",未办理登记手续";
            //}
            //return memo;
        }
    }
}
