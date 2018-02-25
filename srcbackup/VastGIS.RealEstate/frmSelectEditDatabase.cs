using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Services;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate
{
    public partial class frmSelectEditDatabase : MapWindowForm
    {
        public frmSelectEditDatabase(List<string> databases)
        {
            InitializeComponent();
            lstDatabases.DataSource = databases;
           
            btnOk.Click += btnOk_Click;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstDatabases.SelectedIndex>=0)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageService.Current.Info("选择要编辑的数据库");
            }
        }

        public string SelectedDatabase
        {
            get { return lstDatabases.SelectedItem.ToString(); }
        }
    }
}
