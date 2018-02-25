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
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmUnionGeometry:Form,IEditForm
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;
        
        public frmUnionGeometry(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1 AND TXLX > 1").ToList();            
            _classes = classes; 
            ucSelectLayer1.SetClasses(classes);
            ucSelectLayer1.SingleSelect = true;
            ucSelectLayer1.Label = "编辑图层";
            if (_plugin.Config.EditingClass == null)
            {
                ucSelectLayer1.GeometryType = GeometryType.None;
            }
            else
            {
                if (_plugin.Config.EditingClass.Txlx == 1)
                {
                    _plugin.Config.EditingClass = null;
                    ucSelectLayer1.GeometryType = GeometryType.None;
                }
                else
                {
                    ucSelectLayer1.GeometryType = (GeometryType)_plugin.Config.EditingClass.Txlx;
                    ucSelectLayer1.SetCurrentClass(_plugin.Config.EditingClass);
                }
                
            }

            ucFeatureLists1.BindContext(_context);
            ucFeatureLists1.CanMultiSelect = true;
            ucSelectLayer1.ucSelectedClassChanged += UcSelectLayer1_ucSelectedClassChanged;

        }

        private void UcSelectLayer1_ucSelectedClassChanged(object sender, ObjectClassEventArgs e)
        {
            ucFeatureLists1.ClearList();
            ucFeatureLists1.ClearDrawing();
            _plugin.Config.EditingClass = ucSelectLayer1.SelectedClass;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ucFeatureLists1.ClearDrawing();
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
        }


        public void SetQueryPoint(double dx, double dy)
        {
            if (ucSelectLayer1.SelectedClass == null)
            {
                lblInfo.Text = "先选择编辑图层!";
                return;
            }
           
            string[] classNames = new string[1];
            classNames[0] = ucSelectLayer1.SelectedClass.Mc;
            List<SearchFeature> features = _database.SystemService.FindRecords(classNames, dx, dy);

            if (features != null && features.Count > 0)
            {
                ucFeatureLists1.AddFeatures(features, ucSelectLayer1.SelectedClasses);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ucFeatureLists1.HasSelected() == false)
            {
                MessageService.Current.Warn("请先选择要合并的要素!");
                return;
            }
            SearchFeature mainFeature = ucFeatureLists1.GetCurrentSelectedAndCheckedFeature();
            if (mainFeature == null)
            {
                MessageService.Current.Warn("请选择合并后的主要素!");
                return;
            }
            ucFeatureLists1.Redraw();
           
            IGeometry newGeometry = null;
            if (ucSelectLayer1.GeometryType == GeometryType.Polygon)
            {
                newGeometry = GeometryHelper.UnionPolygons(ucFeatureLists1.GetSelectedGeometries());
            }
            else if (ucSelectLayer1.GeometryType == GeometryType.Polyline)
            {
                newGeometry = GeometryHelper.UnionPolylines(ucFeatureLists1.GetSelectedGeometries());
            }
            ucFeatureLists1.DrawTempGeometry(newGeometry);
            string actionMsg = string.Format("你确认合并选中要素吗?");
            if (MessageService.Current.Ask(actionMsg) == false)
            {
                ucFeatureLists1.Redraw();
                return;
            }
            mainFeature.Wkt = newGeometry.ExportToWkt();
            long retVal=_database.SystemService.SaveSearchFeature(mainFeature);
            if (retVal < 1)
            {
                ucFeatureLists1.Redraw();
                MessageService.Current.Warn("图形未能正确保存!");
                return;
            }
            List<SearchFeature> deletFeatures = ucFeatureLists1.GetSelectedFeatures().Where(c=>c.ID != mainFeature.ID).ToList();
            long[] ids = deletFeatures.Select(c => c.ID).ToArray();
            _database.SystemService.DeleteFeatures(deletFeatures);
            ucFeatureLists1.ClearList();
            ucFeatureLists1.ClearDrawing();
        }
    }

}