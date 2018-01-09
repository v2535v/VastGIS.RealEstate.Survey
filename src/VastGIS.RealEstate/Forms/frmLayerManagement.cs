using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Config;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Dao.Impl;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Service;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmLayerManagement : VastGIS.UI.Forms.MapWindowForm
    {
        private BindingList<VgObjectclasses> _vgObjectclasseses;
        private List<VgObjectclasses> _tclbList;
        private CheckBox _checkVisible = new CheckBox();
        private CheckBox _checkIdentify = new CheckBox();
        private CheckBox _checkEditable = new CheckBox();
        private CheckBox _checkQueryable = new CheckBox();
        private CheckBox _checkSnapable = new CheckBox();

        public frmLayerManagement(IAppContext context) : base(context)
        {
            InitializeComponent();
            this.dgvLayers.AutoGenerateColumns = false;

            _tclbList = ((IRealEstateContext)_context).RealEstateDatabase.SystemService.GetObjectclasseses(true).Where(c => c.Dxlx == 0).OrderByDescending(c=>c.ID).ToList();
            cmbLayerType.DataSource = _tclbList;
            cmbLayerType.DisplayMember = "Zwmc";
        }
        
        private void LoadFromMap()
        {
            foreach (ILegendLayer legendLayer in _context.Legend.Layers)
            {
                VgObjectclasses oneClass = _vgObjectclasseses.FirstOrDefault(c => c.Zwmc == legendLayer.Name);
                if (oneClass == null)
                    continue;
                oneClass.Visible = legendLayer.Visible;
            }
        }

        private void ApplyToMap()
        {
            foreach (ILegendLayer legendLayer in _context.Legend.Layers)
            {
                VgObjectclasses oneClass = _vgObjectclasseses.FirstOrDefault(c => c.Zwmc == legendLayer.Name);
                if (oneClass == null)
                    continue;
                legendLayer.Visible = oneClass.Visible == true;
            }
        }

        private void UpdateDB()
        {
            SystemService service = ServiceFactory.GetSystemService();
            service.SaveVgObjectclassess(new List<VgObjectclasses>(_vgObjectclasseses));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ApplyToMap();
            UpdateDB();
            this.Close();
        }

        private void cmbLayerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            VgObjectclasses oneClass = cmbLayerType.SelectedItem as VgObjectclasses;
            if (oneClass == null)
                return;
            _vgObjectclasseses = new BindingList<VgObjectclasses>(oneClass.SubClasses.OrderByDescending(c => c.ID).ToList());

            LoadFromMap();
            this.dgvLayers.DataSource = _vgObjectclasseses;
        }

        private void frmLayerManagement_Load(object sender, EventArgs e)
        {
            _checkVisible.CheckedChanged += CheckVisibleOnCheckedChanged;
            _checkIdentify.CheckedChanged += CheckIdentifyOnCheckedChanged;
            _checkEditable.CheckedChanged += CheckEditableOnCheckedChanged;
            _checkQueryable.CheckedChanged += CheckQueryableOnCheckedChanged;
            _checkSnapable.CheckedChanged += CheckSnapableOnCheckedChanged;
            dgvLayers.CellPainting += DgvLayersOnCellPainting;
            dgvLayers.AllowUserToResizeRows = false;
            dgvLayers.AllowUserToResizeColumns = true;
            this.dgvLayers.Controls.Add(_checkVisible);
            this.dgvLayers.Controls.Add(_checkIdentify);
            this.dgvLayers.Controls.Add(_checkEditable);
            this.dgvLayers.Controls.Add(_checkQueryable);
            this.dgvLayers.Controls.Add(_checkSnapable);
        }

        private void DgvLayersOnCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        {
                            var cell = dgvLayers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                            _checkVisible.Left = cell.Left + 5;
                            _checkVisible.Top = cell.Top + 4;
                            _checkVisible.Size = new Size(15, 15);
                            _checkVisible.Visible = true;
                            _checkVisible.BringToFront();
                        }
                        break;
                    case 2:
                        {
                            var cell = dgvLayers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                            _checkIdentify.Left = cell.Left + 5;
                            _checkIdentify.Top = cell.Top + 4;
                            _checkIdentify.Size = new Size(15, 15);
                            _checkIdentify.Visible = true;
                            _checkIdentify.BringToFront();
                        }
                        break;
                    case 3:
                        {
                            var cell = dgvLayers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                            _checkEditable.Left = cell.Left + 5;
                            _checkEditable.Top = cell.Top + 4;
                            _checkEditable.Size = new Size(15, 15);
                            _checkEditable.Visible = true;
                            _checkEditable.BringToFront();
                        }
                        break;
                    case 4:
                        {
                            var cell = dgvLayers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                            _checkQueryable.Left = cell.Left + 5;
                            _checkQueryable.Top = cell.Top + 4;
                            _checkQueryable.Size = new Size(15, 15);
                            _checkQueryable.Visible = true;
                            _checkQueryable.BringToFront();
                        }
                        break;
                    case 5:
                        {
                            var cell = dgvLayers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                            _checkSnapable.Left = cell.Left + 5;
                            _checkSnapable.Top = cell.Top + 4;
                            _checkSnapable.Size = new Size(15, 15);
                            _checkSnapable.Visible = true;
                            _checkSnapable.BringToFront();
                        }
                        break;
                }
            }
        }

        private void CheckSnapableOnCheckedChanged(object sender, EventArgs eventArgs)
        {

            foreach (VgObjectclasses oneClass in _vgObjectclasseses)
            {
                oneClass.Snapable = _checkSnapable.Checked;
            }
        }

        private void CheckQueryableOnCheckedChanged(object sender, EventArgs eventArgs)
        {

            foreach (VgObjectclasses oneClass in _vgObjectclasseses)
            {
                oneClass.Queryable = _checkQueryable.Checked;
            }
        }

        private void CheckEditableOnCheckedChanged(object sender, EventArgs eventArgs)
        {

            foreach (VgObjectclasses oneClass in _vgObjectclasseses)
            {
                oneClass.Editable = _checkEditable.Checked;
            }
        }

        private void CheckIdentifyOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            foreach (VgObjectclasses oneClass in _vgObjectclasseses)
            {
                oneClass.Identify = _checkIdentify.Checked;
            }
        }

        private void CheckVisibleOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            foreach (VgObjectclasses oneClass in _vgObjectclasseses)
            {
                oneClass.Visible = _checkVisible.Checked;
            }
        }
    }
}
