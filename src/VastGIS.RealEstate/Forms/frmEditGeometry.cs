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
	
    public partial class frmEditGeometry:Form,IEditForm
    {	
        #region 变量
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;
        private IReFeature _feature;
        #endregion
        
        public frmEditGeometry(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
             _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1 ").ToList();            
            _classes = classes;
            ucSelectLayer1.SetClasses(_classes);
            VgObjectclass currentObjectclass = LayerHelper.GetVgObjectClassByLegend(classes, _context.Legend);
            if (_plugin.Config.EditingClass != null)
            {
                ucSelectLayer1.SetCurrentClass(_plugin.Config.EditingClass);
                ucCoordinateList1.GeometryType = (GeometryType)_plugin.Config.EditingClass.Txlx;
            }
            else
            {
                ucSelectLayer1.GeometryType = GeometryType.Point;
                if (currentObjectclass != null)
                {
                    ucSelectLayer1.SetCurrentClass(currentObjectclass);
                    ucCoordinateList1.GeometryType = (GeometryType)currentObjectclass.Txlx;
                }
            }
            ucSelectLayer1.LimitedGeometryType=GeometryType.None;
            ucSelectLayer1.Label = "编辑图层";
            ucSelectLayer1.SingleSelect = true;
            ucSelectLayer1.ucSelectedClassChanged += UcSelectLayer1_ucSelectedClassChanged;
            ucCoordinateList1.BindContext(_context);
            ucCoordinateList1.InitGrid();
            ucCoordinateList1.Editable = true;
            snapCheckbox1.BindPlugin(_plugin);
            chkSelectFeature.Checked = true;
        }

        private void UcSelectLayer1_ucSelectedClassChanged(object sender, ObjectClassEventArgs e)
        {            
            _plugin.Config.EditingClass = ucSelectLayer1.SelectedClass;
            ucCoordinateList1.GeometryType = (GeometryType)ucSelectLayer1.SelectedClass.Txlx;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {            
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
            double x2 = 0.0;
            double y2 = 0.0;
            if (_plugin.Config.IsSnapping)
            {
                bool pFind = _context.Map.FindSnapPoint(_context.Config.MouseTolerance, dx, dy, ref x2, ref y2);
                if (!pFind)
                {
                    x2 = dx;
                    y2 = dy;
                }
            }
            if (ucCoordinateList1.IsUpdate)
            {
                if (_feature == null)
                {
                    lblInfo.Text = "先选择编辑图形!";
                    return;
                }
                ucCoordinateList1.AddPoint(x2,y2);
                return;
            }
            if (chkSelectFeature.Checked == false) return;
            List<IReFeature> features = _database.SystemService.FindFeatures(ucSelectLayer1.SelectedClasses, x2, y2);
            if (_feature != null)
            {
                if (MessageBox.Show("你确定编辑另外的图形吗?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.Cancel) return;
                ucCoordinateList1.ClearList();
                ucCoordinateList1.ClearDrawing();
            }
           
            if (features != null && features.Count==1)
            {
                _feature = features[0];
                chkSelectFeature.Checked = false;
                this.Text = "图形编辑-" + _feature.FullLabelString;
                ucCoordinateList1.AddGeometry(_feature.Geometry.Clone());
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validate() == false) return;
            IGeometry newGeometry = ucCoordinateList1.GetGeometry();
            if (newGeometry.IsEmpty == true)
            {
                lblInfo.Text = "当前坐标不能生成正确图形!";
                return ;
            }
            if (newGeometry.IsValid == false)
            {
                lblInfo.Text = "错误:"+newGeometry.IsValidReason;
                return;
            }
            ucCoordinateList1.DrawData();
            if (MessageBox.Show("你确定修改该图形吗?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.Cancel) return;
            _feature.Wkt = newGeometry.ExportToWkt();
            _database.SystemService.Save(_feature);
            ucCoordinateList1.ClearList();
            ucCoordinateList1.ClearDrawing();
            _feature = null;
            this.Text = "图形编辑";
        }
        public void ClearDrawing()
        {
          _context.Map.Drawing.Clear();
        }
        private bool Validate()
        {
            if (ucSelectLayer1.SelectedClass == null)
            {
                lblInfo.Text = "先选择编辑图层!";
                return false;
            }
            if (_feature == null)
            {
                lblInfo.Text = "先选择编辑要素!";
                return false;
            }
            return true;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (Validate() == false) return;
           ucCoordinateList1.DrawPoints();
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            if (Validate() == false) return;
            IGeometry newGeometry = ucCoordinateList1.GetGeometry();
            if (newGeometry.IsEmpty == true)
            {
                lblInfo.Text = "当前坐标不能生成正确图形!";
                return;
            }
            if (newGeometry.GeometryType != GeometryType.Polygon)
            {
                lblInfo.Text = "排序功能只针对多边形!";
            }
            //if (newGeometry.IsValid == false)
            //{
            //    lblInfo.Text = "错误:" + newGeometry.IsValidReason;
            //    return;
            //}
            IGeometry newGeometry2 = SpatialHelper.ReorderPolygonVertex(newGeometry);
            if (newGeometry2 != null)
            {
                ucCoordinateList1.ClearList();
                ucCoordinateList1.ClearDrawing();
                ucCoordinateList1.AddGeometry(newGeometry2);
            }
            
        }
    }
}