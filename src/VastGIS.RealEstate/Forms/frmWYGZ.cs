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
    public partial class frmWYGZ:Form,IEditForm
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;
        
        public frmWYGZ(IAppContext context, RealEstateEditor plugin)
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
            _classes = classes;
            ucSelectLayer1.SetClasses(_classes);
            VgObjectclass currentObjectclass = LayerHelper.GetVgObjectClassByLegend(classes, _context.Legend);
            if (_plugin.Config.EditingClass != null && _plugin.Config.EditingClass.Txlx ==3)
                ucSelectLayer1.SelectedClass = _plugin.Config.EditingClass;
            else
            {
                ucSelectLayer1.GeometryType= GeometryType.Polygon;
                if (currentObjectclass != null && currentObjectclass.Txlx == 3)
                    ucSelectLayer1.SelectedClass = currentObjectclass;
            }
            ucEdgeList1.BindContext(_context);

            cmbModifyType.SelectedIndex = 0;
            ucSelectLayer1.ucSelectedClassChanged += UcSelectLayer1_ucSelectedClassChanged;
        }

        private void UcSelectLayer1_ucSelectedClassChanged(object sender, ObjectClassEventArgs e)
        {
            ucEdgeList1.ClearList();
            _plugin.Config.EditingClass = ucSelectLayer1.SelectedClass;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ucEdgeList1.ClearDrawing();
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
            if (ucEdgeList1.IsSelectingGeometry == false) return;
            List<IReFeature> findEntities= _database.SystemService.FindFeatures(ucSelectLayer1.SelectedClass, dx, dy);
            if (findEntities == null || findEntities.Count == 0)
            {
                lblInfo.Text = string.Format("在图层{0}找不到该位置的要素!",ucSelectLayer1.SelectedClass.Zwmc);
                return;
            }
          
            if (findEntities != null)
            {
                ucEdgeList1.Feature = findEntities[0];
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ucSelectLayer1.SelectedClass == null)
            {
                lblInfo.Text = "先选择编辑图层!";
                return;
            }
            if (ucEdgeList1.HasFeature() == false)
            {
                lblInfo.Text = "先选择编辑要素!";
                return;
            }
            if (ucEdgeList1.GetCurrentEdge() == null)
            {
                lblInfo.Text = "先选择需要修改的边!";
                return;
            }
            if (dblDistance.DoubleValue == 0)
            {
                lblInfo.Text = "先输入改正距离!";
                return;
            }
            double dist = dblDistance.DoubleValue;
            if (cmbModifyType.SelectedIndex == 1)
            {
                dist = dist * -1.0;
            }
            List<ReEdge> edges = ucEdgeList1.GetEdges();
            int edgeIndex = ucEdgeList1.GetCurrentEdgeIndex();
            List<ReEdge> updateEdges = GeometryHelper.MoveEdgeInPolygon(edges, edgeIndex, dist);
            ucEdgeList1.DrawTempEdges(updateEdges);
            if (MessageService.Current.Ask("确认对该多边形进行改正吗?") == false)
            {
                ucEdgeList1.LoadEdges();
                return;
            }
            ucEdgeList1.UpdateCurrentPart(updateEdges);
            IReFeature feature = ucEdgeList1.Feature;
            _database.SystemService.Save(feature);
            ucEdgeList1.ClearList();

        }
    }

}