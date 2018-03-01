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
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmDeleteFeature2:Form,IEditForm
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;
        
        public frmDeleteFeature2(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1").ToList();            
            _classes = classes;      
            ucSelectLayer1.SetClasses(classes);
            ucSelectLayer1.SingleSelect = true;
            ucFeatureLists1.BindContext(_context);
            ucFeatureLists1.CanMultiSelect = true;
            VgObjectclass currentObjectclass = LayerHelper.GetVgObjectClassByLegend(classes, _context.Legend);
           
            if (_plugin.Config.EditingClass != null)
            {
                ucSelectLayer1.SetCurrentClass(_plugin.Config.EditingClass);
            }
            else
            {
                ucSelectLayer1.SetCurrentClass(currentObjectclass);
            }
            ucSelectLayer1.LimitedGeometryType= GeometryType.None;
            ucSelectLayer1.ucSelectedClassChanged += UcSelectLayer1_ucSelectedClassChanged;
        }

        private void UcSelectLayer1_ucSelectedClassChanged(object sender, ObjectClassEventArgs e)
        {
            ucFeatureLists1.ClearList();
            //ucFeatureLists1.GeometryType = ucSelectLayer1.GeometryType;
            _plugin.Config.EditingClass = ucSelectLayer1.SelectedClass;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ucFeatureLists1.ClearList();
            ucFeatureLists1.ClearDrawing();
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
        }


        public void SetQueryPoint(double dx, double dy)
        {
            if(ucSelectLayer1.SelectedClass == null)
            {
                lblInfo.Text = "先选择编辑图层!";
                return;
            }
            List<IReFeature> features = _database.SystemService.FindFeatures(ucSelectLayer1.SelectedClass, dx, dy);
            if (features != null && features.Count > 0)
            {
                ucFeatureLists1.AddFeatures(features, ucSelectLayer1.SelectedClasses);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ucFeatureLists1.HasSelected() == false)
            {
                MessageService.Current.Warn("请先选择要拷贝的元素!");
                return;
            }
            ucFeatureLists1.Redraw();
            string actionMsg = string.Format("你确认从{0}中删除选中要素?", ucSelectLayer1.SelectedClass.Zwmc);
            if (MessageService.Current.Ask(actionMsg) == false) return;
            _database.SystemService.Delete(ucFeatureLists1.GetSelectedFeatures().ToList<IEntity>());
            ucFeatureLists1.ClearList();
            ucFeatureLists1.ClearDrawing();
        }

        public void ClearDrawing()
        {
           _context.Map.Drawing.Clear();
        }
    }

}