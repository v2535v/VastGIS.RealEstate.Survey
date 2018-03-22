using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmSetEditLayers : Form
    {
        private List<VgObjectclass> _editLayers;
        public frmSetEditLayers(List<VgObjectclass> allLayers, List<VgObjectclass> editLayers)
        {
            InitializeComponent();
            if (allLayers == null || editLayers == null)
                return;

            this.lstAllLayers.DataSource = allLayers;
            this.lstAllLayers.DisplayMember = "Zwmc";
            this.lstAllLayers.ValueMember = "Mc";
            _editLayers = editLayers;
            this.lstEditLayers.DataSource = _editLayers;
            this.lstEditLayers.DisplayMember = "Zwmc";
            this.lstEditLayers.ValueMember = "Mc";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            VgObjectclass objectclass = lstAllLayers.SelectedItem as VgObjectclass;
            if (objectclass == null)
                return;
            if (!_editLayers.Contains(objectclass))
                _editLayers.Add(objectclass);
            this.lstEditLayers.DataSource = null;
            this.lstEditLayers.DataSource = _editLayers;
            this.lstEditLayers.DisplayMember = "Zwmc";
            this.lstEditLayers.ValueMember = "Mc";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            VgObjectclass objectclass = lstEditLayers.SelectedItem as VgObjectclass;
            if (objectclass == null)
                return;
            _editLayers.Remove(objectclass);
            this.lstEditLayers.DataSource = null;
            this.lstEditLayers.DataSource = _editLayers;
            this.lstEditLayers.DisplayMember = "Zwmc";
            this.lstEditLayers.ValueMember = "Mc";
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            _editLayers.Clear();
            this.lstEditLayers.DataSource = null;
            this.lstEditLayers.DataSource = _editLayers;
            this.lstEditLayers.DisplayMember = "Zwmc";
            this.lstEditLayers.ValueMember = "Mc";
        }

        public List<VgObjectclass> GetEditLayers()
        {
            return _editLayers;
        }
    }
}
