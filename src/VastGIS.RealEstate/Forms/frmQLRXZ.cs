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
    public partial class frmQLRXZ : Form
    {
        private List<Qlr> _qlrs;
        public frmQLRXZ(List<Qlr> qlrs)
        {
            InitializeComponent();
            _qlrs = qlrs;
            lstQLR.Items.Clear();
            lstXQLR.Items.Clear();
            foreach (Qlr qlr in _qlrs)
            {
                lstQLR.Items.Add(qlr.Qlrmc, true);
                lstXQLR.Items.Add(qlr.Qlrmc, false);
            }
            cmbBhyy.SelectedIndex = 0;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstQLR.Items.Count; i++)
            {
                lstQLR.SetItemChecked(i,true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }

        public string GetMemo(CheckedListBox listBox)
        {
            string names = "";
            for (int i = 0; i < listBox.CheckedItems.Count; i++)
            {
                names += listBox.CheckedItems[i].ToString() + ",";
            }
            names = names.Substring(0, names.Length - 1);
            return names;
        }

        public string GetMemo2()
        {
            return $"该宗地权利人{GetMemo(lstQLR)}";
        }
        
        public string GetMemo3()
        {
            if (chkQlrbh.Checked == false) return "该宗地权利人未发生变化";

            if (cmbBhyy.SelectedIndex == 0) return $"权利人变化：权利人已故，现使用人{GetMemo(lstXQLR)}";
            else if (cmbBhyy.SelectedIndex == cmbBhyy.Items.Count - 1) return $"权利人变化：权利人赠与{GetMemo(lstXQLR)}";
            else return"权利人变化：经调查，因"+cmbBhyy.Text + $"，现房屋使用人{GetMemo(lstXQLR)}";
           
        }

        private void chkQlrbh_CheckedChanged(object sender, EventArgs e)
        {
            cmbBhyy.Enabled = chkQlrbh.Checked;
            lstXQLR.Enabled = chkQlrbh.Checked;
        }
    }
}
