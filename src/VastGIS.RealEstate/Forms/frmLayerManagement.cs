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

        public frmLayerManagement(IAppContext context) : base(context)
        {
            InitializeComponent();
            this.dgvLayers.AutoGenerateColumns = false;
            _vgObjectclasseses = new BindingList<VgObjectclasses>();
            IlistToBindingList(((IRealEstateContext)_context).RealEstateDatabase.SystemService.GetObjectclasseses(true));
            LoadFromMap();
            this.dgvLayers.DataSource = _vgObjectclasseses;
        }

        private void IlistToBindingList(IEnumerable<VgObjectclasses> vgObjectclasseses)
        {
            foreach (VgObjectclasses oneClass in vgObjectclasseses)
            {
                if (oneClass.SubClasses == null && oneClass.Dxlx > 0)
                {
                    _vgObjectclasseses.Add(oneClass);
                }
                else
                {
                    IlistToBindingList(oneClass.SubClasses);
                }
            }
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
    }
}
