using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmSelectLayer : MapWindowForm
    {
        private GeometryType _geometryType;
        private List<VgObjectclasses> _selectedClass;
        private List<VgObjectclasses> _sourceClass;
        public frmSelectLayer(List<VgObjectclasses> classes,GeometryType geometryType)
        {
            InitializeComponent();
            _geometryType = geometryType;
            if (geometryType != GeometryType.None)
            {
                _sourceClass = classes.Where(c => c.Txlx == (int)geometryType).ToList();
                lstLayers.DataSource = _sourceClass;
            }
            else
            {
                _sourceClass = classes;
                lstLayers.DataSource = classes;
            }
            lstLayers.DisplayMember = "Information";
        }

        public List<VgObjectclasses> SelectedObjectClasses
        {
            get { return _selectedClass; }
        }

        public SelectionMode SelectionMode
        {
            get { return lstLayers.SelectionMode; }
            set
            {
                lstLayers.SelectionMode=value;
                btnSelectAll.Enabled = value == SelectionMode.MultiSimple || value == SelectionMode.MultiExtended;
                btnRevSelect.Enabled = value == SelectionMode.MultiSimple || value == SelectionMode.MultiExtended;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lstLayers.Items.Count;i++)
            lstLayers.SetSelected(i,true);
        }

        private void btnRevSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLayers.Items.Count; i++)
                lstLayers.SetSelected(i, !lstLayers.GetSelected(i));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstLayers.SelectedItems.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _selectedClass = null;
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstLayers.SelectionMode == SelectionMode.One)
            {
                if (lstLayers.SelectedIndex < 0)
                {
                    MessageService.Current.Warn("请选择图层!");
                    return;
                }
                _selectedClass=new List<VgObjectclasses>();
                _selectedClass.Add((_sourceClass[lstLayers.SelectedIndex]));
                DialogResult = DialogResult.OK;
                return;
            }
            if (lstLayers.SelectedItems.Count<1)
            {
                MessageService.Current.Warn("请选择图层!");
                return;
            }
            _selectedClass = new List<VgObjectclasses>();
            foreach (var oneItem in lstLayers.SelectedItems)
            {
                _selectedClass.Add(oneItem as VgObjectclasses);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
