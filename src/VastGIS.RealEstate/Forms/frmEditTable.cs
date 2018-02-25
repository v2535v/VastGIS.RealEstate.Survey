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
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.DataControls;
using VastGIS.Plugins.RealEstate.Events;
using VastGIS.Plugins.RealEstate.Helpers;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;

namespace VastGIS.Plugins.RealEstate.Forms
{
	
    public partial class frmEditTable:Form
    {	
        #region 变量
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;
        private DataTable _table;
        #endregion
        
        public frmEditTable(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
             _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" DXLX=2").ToList();            
            _classes = classes;
            lstClasses.DataSource = _classes;
            lstClasses.DisplayMember = "Zwmc";
            lstClasses.ValueMember = "Mc";
        }

      
        private void btnCancle_Click(object sender, EventArgs e)
        {            
            DialogResult = DialogResult.Cancel;
        }

        public VgObjectclass SelectedObjectClass()
        {
            if (lstClasses.SelectedIndex < 0)
            {
                return null;
            }
            string mc = lstClasses.SelectedValue.ToString();
            VgObjectclass objectclass = _classes.FirstOrDefault(c => c.Mc == mc);
            return objectclass;
        }
    

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstClasses.SelectedIndex < 0) return;
            DialogResult=DialogResult.OK;

        }
        
       
        
    }
}