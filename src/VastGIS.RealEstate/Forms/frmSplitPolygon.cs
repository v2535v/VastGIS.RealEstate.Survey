using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
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
	
    public partial class frmSplitPolygon:Form,IEditForm
    {	
        #region 变量
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;
        private IReFeature _feature;
        private int _layerHandle=-1;
        private List<ReEdge> _edges;
        private List<ReEdge> _edges2;
        private IGeometry _geometry;
        private IMuteMap _map;
        #endregion

        public frmSplitPolygon(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
             _context = context;
            _plugin = plugin;
            _map = context.Map;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1 And TXLX > 2").ToList();            
            _classes = classes;
            ucSelectLayer1.SetClasses(_classes);
            VgObjectclass currentObjectclass = LayerHelper.GetVgObjectClassByLegend(classes, _context.Legend);
            if (_plugin.Config.EditingClass == null) _plugin.Config.EditingClass = currentObjectclass;
            if (_plugin.Config.EditingClass != null && _plugin.Config.EditingClass.Txlx ==3)
                ucSelectLayer1.SelectedClass = _plugin.Config.EditingClass;
            else
            {
                ucSelectLayer1.GeometryType= GeometryType.Polygon;
                if (currentObjectclass != null && currentObjectclass.Txlx == 3)
                    ucSelectLayer1.SelectedClass = currentObjectclass;
            }            
            ucSelectLayer1.ucSelectedClassChanged += UcSelectLayer1_ucSelectedClassChanged;
            txtFeature.Enabled = false;
            chkSelFeature.Checked = true;
            cmbPoint1.SelectedIndex = 0;
            cmbPoint2.SelectedIndex = 0;
            _edges=new List<ReEdge>();
            _edges2 = new List<ReEdge>();
        }

        private void UcSelectLayer1_ucSelectedClassChanged(object sender, ObjectClassEventArgs e)
        {            
            _plugin.Config.EditingClass = ucSelectLayer1.SelectedClass;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {            
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
        }

        public void ClearDrawing()
        {
            if(_map.Drawing!=null)_map.Drawing.Clear();
        }
        public void SetQueryPoint(double dx, double dy)
        {
            if (ucSelectLayer1.SelectedClass == null)
            {
                lblInfo.Text = "先选择编辑图层!";
                return;
            }
            if (!chkSelFeature.Checked) return;
            List<IReFeature> features = _database.SystemService.FindFeatures(ucSelectLayer1.SelectedClass, dx, dy);
            if (features != null  && features.Count==1)
            {
                if (features[0].Geometry.Parts.Count > 1)
                {
                    lblInfo.Text = "你选择的要素为复杂面要素，先打散该要素!";
                    return;
                }
                LoadFeature(features[0]);
            }
        }

        private void LoadFeature(IReFeature reFeature)
        {
            _feature = reFeature;
            txtFeature.Text = _feature.FullLabelString;
            SetGeometry(_feature.Geometry.Clone());
        }

        private void SetGeometry(IGeometry geometry)
        {
            _geometry = geometry;
            ClearDrawing();
            PrepareLayer();
            LoadEdges();
            if (geometry == null)
            {
                txtFeature.Text = "";
            }
            chkSelFeature.Checked = geometry == null;
        }

        public void LoadEdges()
        {
            if (_geometry == null )
            {
                _edges.Clear();
                _edges2.Clear();
                DrawEdges();
                return;
            }
            _edges.Clear();
            _edges2.Clear();
           
            for (int i = 0; i < _geometry.Points.Count - 1; i++)
            {
                ICoordinate startPoint = _geometry.Points[i];
                ICoordinate endPoint = _geometry.Points[i + 1];
                ReEdge edge = new ReEdge(i + 1, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
                _edges.Add(edge);
                _edges2.Add(edge.Clone());
            }
            cmbLine1.DataSource = _edges;
            cmbLine1.DisplayMember = "Id";
            cmbLine1.ValueMember = "Id";
            cmbLine2.DataSource = _edges2;
            cmbLine2.DisplayMember = "Id";
            cmbLine2.ValueMember = "Id";
            DrawEdges();
        }

        private void PrepareLayer()
        {
            if (_layerHandle >= 0)
            {
                _map.Drawing.RemoveLayer(_layerHandle);
            }
            _layerHandle = _map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
        }

        public void DrawEdges()
        {
            PrepareLayer();
            if (_geometry == null) return;
         
            Color color2 = _context.Config.RealEstateActivedColor;
            Color color = _context.Config.RealEstateSelectedColor;
            int firstId = cmbLine1.SelectedIndex;
            int twoId = cmbLine2.SelectedIndex;
       
            int count = 0;
            foreach (ReEdge edge in _edges)
            {
                if (count == firstId)
                {
                    _map.Drawing.DrawLine(_layerHandle, edge.X1, edge.Y1, edge.X2, edge.Y2, 4, color2);
                }
                else if (count == twoId)
                {
                    _map.Drawing.DrawLine(_layerHandle, edge.X1, edge.Y1, edge.X2, edge.Y2, 4, Color.Black);
                }
                else
                {
                    _map.Drawing.DrawLine(_layerHandle, edge.X1, edge.Y1, edge.X2, edge.Y2, 3, color);
                }

                _map.Drawing.DrawLabel(_layerHandle, edge.Id.ToString(), edge.CenterX, edge.CenterY, 0);
                _map.Drawing.DrawPoint(_layerHandle, edge.X1, edge.Y1, 12, color);
                count++;
                if (count == _edges.Count)
                {
                    _map.Drawing.DrawPoint(_layerHandle, edge.X2, edge.Y2, 12, color);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateParameters() == false) return;
            ReEdge edge1 = _edges[cmbLine1.SelectedIndex];
            ReEdge edge2 = _edges[cmbLine2.SelectedIndex];
            bool isForward1 = cmbPoint1.SelectedIndex == 0 ? true : false;
            bool isForward2 = cmbPoint2.SelectedIndex == 0 ? true : false;
            ICoordinate coord1 = GeometryHelper.QueryLinePointByDistance(edge1, dblDist1.DoubleValue, isForward1);
            ICoordinate coord2 = GeometryHelper.QueryLinePointByDistance(edge2, dblDist2.DoubleValue, isForward2);
            DrawTempEdge(coord1, coord2);
            if (MessageBox.Show("图形将被地图显示下分割，继续吗?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) !=
                DialogResult.OK) return;

            IGeometry splitGeometry=new Geometry(GeometryType.Polyline,ZValueType.None);
            double xx1, yy1,xx2, yy2;
            double edgeLen = Math.Sqrt((coord1.X - coord2.X) * (coord1.X - coord2.X) +
                                       (coord1.Y - coord2.Y) * (coord1.Y - coord2.Y))*1.01;
            GeometryHelper.QueryLinePointByDistance(coord2.X, coord2.Y, coord1.X, coord1.Y, edgeLen, out xx1, out yy1);
            GeometryHelper.QueryLinePointByDistance(coord1.X, coord1.Y, coord2.X, coord2.Y, edgeLen, out xx2, out yy2);
            ICoordinate ncoord1 = new Coordinate(xx1, yy1);
            ICoordinate ncoord2= new Coordinate(xx2, yy2);
            splitGeometry.Points.Add(ncoord1);
            splitGeometry.Points.Add(ncoord2);
            DrawTempEdge(ncoord1, ncoord2);
            List<IGeometry> splits= _geometry.SplitByPolyline(splitGeometry).ToList();
            if (splits.Count< 2)
            {
                MessageBox.Show("图形未能成功分割！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _feature.Wkt = splits[0].ExportToWkt();
            _database.SystemService.Save(_feature);
            for (int i = 1; i < splits.Count; i++)
            {
                IReFeature newFeature = _feature.Copy() as IReFeature;
                newFeature.Wkt = splits[i].ExportToWkt();
                _database.SystemService.Save(newFeature);
            }
            SetGeometry(null);
        }
        
        private  bool ValidateParameters()
        {
            if (_edges == null || _edges.Count < 3) return false;
            if (ucSelectLayer1.SelectedClass == null)
            {
                lblInfo.Text = "先选择编辑图层!";
                return false;
            }
            if (cmbLine1.SelectedIndex < 0 || cmbPoint1.SelectedIndex < 0)
            {
                lblInfo.Text = "先选择起点所在线段及参数!";
                return false;
            }
            if (cmbLine2.SelectedIndex < 0 || cmbPoint2.SelectedIndex < 0)
            {
                lblInfo.Text = "先选择终点所在线段及参数!";
                return false;
            }
            if (cmbLine1.SelectedIndex == cmbLine2.SelectedIndex)
            {
                lblInfo.Text = "起终点不能在同一条线段上!";
                return false;
            }
            return true;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ValidateParameters() == false) return;
            ReEdge edge1 = _edges[cmbLine1.SelectedIndex];
            ReEdge edge2 = _edges[cmbLine2.SelectedIndex];
            bool isForward1 = cmbPoint1.SelectedIndex == 0 ? true : false;
            bool isForward2 = cmbPoint2.SelectedIndex == 0 ? true : false;
            ICoordinate coord1 = GeometryHelper.QueryLinePointByDistance(edge1, dblDist1.DoubleValue, isForward1);
            ICoordinate coord2 = GeometryHelper.QueryLinePointByDistance(edge2, dblDist2.DoubleValue, isForward2);
            DrawTempEdge(coord1, coord2);

        }

        private void DrawTempEdge(ICoordinate pnt1, ICoordinate pnt2)
        {
            PrepareLayer();
            DrawEdges();
            _map.Drawing.DrawLine(_layerHandle, pnt1.X,pnt1.Y,pnt2.X,pnt2.Y, 3, Color.OrangeRed);

        }


    }
}