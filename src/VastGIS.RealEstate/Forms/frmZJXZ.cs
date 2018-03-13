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
            DialogResult=DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }

        public string GetMemo()
        {
            StringBuilder builder=new StringBuilder();
            builder.Append("(");
            if (chkZJ1.Checked) builder.Append(chkZJ1.Text + ",");
            if (chkZJ2.Checked) builder.Append(chkZJ2.Text + ",");
            if (chkZJ3.Checked) builder.Append(chkZJ3.Text + ",");
            if (chkZJ4.Checked) builder.Append(chkZJ4.Text + ",");
            if (chkZJ5.Checked) builder.Append(chkZJ5.Text + ",");
            string memo = builder.ToString();
            if (memo.Length == 1)
            {
                memo = "(无)";
            }
            else
            {
                memo = memo.Substring(0, memo.Length - 1) + ")";
            }
            if (chkDJSX.Checked)
            {
                memo += ",已办理登记手续";
            }
            else
            {
                memo += ",未办理登记手续";
            }
            return memo;
        }
    }
}
