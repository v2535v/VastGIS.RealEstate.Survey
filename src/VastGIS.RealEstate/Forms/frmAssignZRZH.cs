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
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Forms
{
	
    public partial class frmAssignZRZH:Form,IEditForm
    {	
        #region 变量
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private VgObjectclass  _class;
        #endregion
        
        public frmAssignZRZH(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
             _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1 And TXLX > 2").ToList();
            _class = classes.First(c => c.Mc == "ZRZ");
            ucFeatureLists1.BindContext(_context);
            ucFeatureLists1.CanMultiSelect = true;
        }

      

        private void btnCancle_Click(object sender, EventArgs e)
        {            
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
        }


        public void SetQueryPoint(double dx, double dy)
        {
            List<IReFeature> features = _database.SystemService.FindFeatures(_class, dx, dy);
            if (features != null && features.Count > 0)
            {
                ucFeatureLists1.AddFeatures(features, _class);
            }
        }

        public void ClearDrawing()
        {
            _context.Map.Drawing.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbZRZH.SelectedIndex < 0)
            {
                lblInfo.Text = "请选择自然幢号!";
                return;
            }
            if (MessageBox.Show("你确认修改被选择的自然幢的自然幢号属性吗?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.Cancel)
            {
                return;}
            AssignZRZH();
            ucFeatureLists1.ClearList();
            DialogResult = DialogResult.OK;

        }

        private void AssignZRZH()
        {
            List<IEntity> features = ucFeatureLists1.GetSelectedFeatures().ToList<IEntity>();
            if (features == null || features.Count == 0) return;
            foreach (IEntity feature in features)
            {
                Zrz zrz = feature as Zrz;
                zrz.Zrzh = cmbZRZH.Text;
            }
            _database.SystemService.Save(features);
        }
        
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cmbZRZH.SelectedIndex < 0)
            {
                lblInfo.Text = "请选择自然幢号!";
                return;
            }
            AssignZRZH();
            ucFeatureLists1.ClearList();
        }
        
    }
}