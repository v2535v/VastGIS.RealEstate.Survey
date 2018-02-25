using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Grouping;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;
using Geometry = VastGIS.Api.Concrete.Geometry;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucEdgeList : UserControl
    {
        private IAppContext _context;
        private GeometryType _geometryType;
        private int _layerHandle = -1;
        private IMuteMap _map;
        private int _partIndex;
        private BindingList<ReEdge> _edges;
        private IGeometry _geometry;
        private IReFeature _feature;

        public ucEdgeList()
        {
            InitializeComponent();
            this.gridEdges.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridEdges.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            //to set proportional column resizing to grid.
            this.gridEdges.AllowProportionalColumnSizing = true;
            this.gridEdges.TopLevelGroupOptions.ShowCaption = false;

            //to hide Caption.
            this.gridEdges.TopLevelGroupOptions.ShowCaption = false;
            this.gridEdges.ChildGroupOptions.ShowCaption = false;
            this.gridEdges.NestedTableGroupOptions.ShowCaption = false;

            //to disable AddNewRecord.
            this.gridEdges.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridEdges.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridEdges.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;

            this.gridEdges.WantTabKey = false;
            InitGrid();
            if (_geometry == null)
            {
                chkSelFeature.Checked = true;
            }
            txtFeature.Enabled = false;
        }
        [Browsable(false)]
        public IReFeature Feature
        {
            get
            {
                _feature.Wkt = _geometry.Clone().ExportToWkt();
                return _feature;
            }
            set
            {
                _feature = value;
                SetGeometry(_feature.Geometry.Clone());
                txtFeature.Text = _feature.FullLabelString;
            }
        }
        public void ClearList()
        {
            _map.Drawing.Clear();
            _geometry = null;
            _feature = null;
            _edges.Clear();
            cmbParts.Items.Clear();
            txtFeature.Text = "";
            chkSelFeature.Checked = true;
        }
        public void ClearDrawing()
        {
            _map.Drawing.Clear();
        }
        public GeometryType GeometryType
        {
            get { return _geometry.GeometryType; }
        }

        public bool IsSelectingGeometry
        {
            get { return chkSelFeature.Checked; }
        }

        public void BindContext(IAppContext context)
        {
            _context = context;
            _map = context.Map;
        }

        /// <summary>
        /// The BindMap
        /// </summary>
        /// <param name="pMap">The <see cref="IMuteMap"/></param>
        public void BindMap(IMuteMap pMap)
        {
            _map = pMap;
            _map.Drawing.Clear();
        }

        public void InitGrid()
        {
            if (_edges == null)
            {
                _edges = new BindingList<ReEdge>();
            }

            this.gridEdges.DataSource = _edges;

            this.gridEdges.AllowProportionalColumnSizing = false;

            //To gridEdges the HeaderText.
            this.gridEdges.TableDescriptor.Columns["Id"].HeaderText = "序号";
            this.gridEdges.TableDescriptor.Columns["Id"].Width = 40;
            this.gridEdges.TableDescriptor.Columns["X1"].HeaderText = "X1";
            this.gridEdges.TableDescriptor.Columns["X1"].Width = 80;
            this.gridEdges.TableDescriptor.Columns["Y1"].HeaderText = "Y1";
            this.gridEdges.TableDescriptor.Columns["Y1"].Width = 80;
            this.gridEdges.TableDescriptor.Columns["X2"].HeaderText = "X2";
            this.gridEdges.TableDescriptor.Columns["X2"].Width = 80;
            this.gridEdges.TableDescriptor.Columns["Y2"].HeaderText = "Y2";
            this.gridEdges.TableDescriptor.Columns["Y2"].Width = 80;
            this.gridEdges.TableDescriptor.Columns["Length"].HeaderText = "长度";
            this.gridEdges.TableDescriptor.Columns["Y2"].Width = 80;


        }


        private void SetGeometry(IGeometry geometry)
        {
            _geometry = geometry;
            cmbParts.Items.Clear();
            for (int i = 0; i < _geometry.Parts.Count; i++)
            {
                int lbl = i + 1;
                cmbParts.Items.Add(lbl.ToString());
            }
            _partIndex = 0;
            cmbParts.SelectedIndex = 0;
            LoadEdges();
            chkSelFeature.Checked = false;
        }

        public void LoadEdges()
        {
            if (_geometry == null || _partIndex<0)
            {
                _edges.Clear();
                DrawEdges();
                return;
            }
            IGeometry subGeometry = _geometry.Parts[_partIndex];
            if (subGeometry == null) return;
            _edges.Clear();
            for (int i = 0; i < subGeometry.Points.Count - 1; i++)
            {
                ICoordinate startPoint = subGeometry.Points[i];
                ICoordinate endPoint = subGeometry.Points[i + 1];
                ReEdge edge = new ReEdge(i+1, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
                _edges.Add(edge);
            }
            DrawEdges();
        }

        private void cmbParts_Click(object sender, EventArgs e)
        {

        }

        private void cmbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _partIndex = cmbParts.SelectedIndex;
            LoadEdges();
        }

        public ReEdge GetCurrentEdge()
        {
            Record record = gridEdges.Table.CurrentRecord;
            if (record == null) return null;
            return _edges[record.GetSourceIndex()];
        }

        public int GetCurrentEdgeIndex()
        {
            Record record = gridEdges.Table.CurrentRecord;
            if (record == null) return -1;
            return record.GetSourceIndex();
        }

        public List<ReEdge> GetEdges()
        {
            return _edges.ToList();
        }

        public bool UpdateStartPoint(double x, double y)
        {
            Record record = gridEdges.Table.CurrentRecord;
            if (record == null) return false;
            int sourceIndex = record.GetSourceIndex();
            IGeometry subGeometry = _geometry.Parts[_partIndex];
            ICoordinate coordinate = subGeometry.Points[sourceIndex];
            subGeometry.MovePoint(sourceIndex, x, y);
            LoadEdges();
            return true;
        }

        public bool UpdateEndPoint(double x, double y)
        {
            Record record = gridEdges.Table.CurrentRecord;
            if (record == null) return false;
            int sourceIndex = record.GetSourceIndex();
            IGeometry subGeometry = _geometry.Parts[_partIndex];
            subGeometry.MovePoint(sourceIndex + 1, x, y);
            LoadEdges();
            return true;
        }

        public bool InsertPoint(double x, double y)
        {
            Record record = gridEdges.Table.CurrentRecord;
            if (record == null) return false;
            int sourceIndex = record.GetSourceIndex();
            IGeometry subGeometry = _geometry.Parts[_partIndex];
            subGeometry.Points.Insert(sourceIndex + 1, new Coordinate(x, y));
            LoadEdges();
            return true;
        }

        public bool InsertPoint(int index, double x, double y)
        {
            IGeometry subGeometry = _geometry.Parts[_partIndex];
            subGeometry.Points.Insert(index, new Coordinate(x, y));
            LoadEdges();
            return true;
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
            if (_partIndex < 0) return;
            Color color2 = _context.Config.RealEstateActivedColor;
            Color color = _context.Config.RealEstateSelectedColor;
            Record record = gridEdges.Table.CurrentRecord;
            int sourceIndex = -1;
            if (record != null) sourceIndex = record.GetSourceIndex();
            int count = 0;
            foreach (ReEdge edge in _edges)
            {
                if (count == sourceIndex)
                {
                    _map.Drawing.DrawLine(_layerHandle, edge.X1, edge.Y1, edge.X2, edge.Y2, 4, color2);
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

        public IGeometry GetGeometry()
        {
            return _geometry.Clone();
        }

        public bool HasFeature()
        {
            return _feature != null;
        }

        public void DrawTempEdges(List<ReEdge> edges)
        {
            PrepareLayer();
            if (_geometry == null) return;
            if (_partIndex < 0) return;
            Color color2 =Color.Red;
            Color color = Color.Yellow;
            Record record = gridEdges.Table.CurrentRecord;
            int sourceIndex = -1;
            if (record != null) sourceIndex = record.GetSourceIndex();
            int count = 0;
            //foreach (ReEdge edge in _edges)
            //{
               
            //     _map.Drawing.DrawLine(_layerHandle, edge.X1, edge.Y1, edge.X2, edge.Y2, 3, color);
            //    _map.Drawing.DrawPoint(_layerHandle, edge.X1, edge.Y1, 12, color);
            //    count++;
            //    if (count == _edges.Count)
            //    {
            //        _map.Drawing.DrawPoint(_layerHandle, edge.X2, edge.Y2, 12, color);
            //    }
            //}
            //count = 0;
            foreach (ReEdge edge in edges)
            {
                if (count == sourceIndex)
                {
                    _map.Drawing.DrawLine(_layerHandle, edge.X1, edge.Y1, edge.X2, edge.Y2, 4, color2);
                    _map.Drawing.DrawLabel(_layerHandle, edge.Id.ToString(), edge.CenterX, edge.CenterY, 0);
                    _map.Drawing.DrawPoint(_layerHandle, edge.X1, edge.Y1, 12, color2);
                }
                else
                {
                    _map.Drawing.DrawLine(_layerHandle, edge.X1, edge.Y1, edge.X2, edge.Y2, 3, color);
                    _map.Drawing.DrawLabel(_layerHandle, edge.Id.ToString(), edge.CenterX, edge.CenterY, 0);
                    _map.Drawing.DrawPoint(_layerHandle, edge.X1, edge.Y1, 12, color);
                }

                
                count++;
                if (count == _edges.Count)
                {
                    _map.Drawing.DrawPoint(_layerHandle, edge.X2, edge.Y2, 12, color);
                }
            }
        }

        public IGeometry UpdateCurrentPart(List<ReEdge> edges)
        {
            List<Coordinate> coords=new List<Coordinate>();
            IGeometry newSubGeom=new Geometry(_geometry.GeometryType, ZValueType.None);
            foreach (ReEdge edge in edges)
            {
                newSubGeom.Points.Add(new Coordinate(edge.X1,edge.Y1));
            }
            int i = edges.Count - 1;
            newSubGeom.Points.Add(new Coordinate(edges[i].X2, edges[i].Y2));
            if (_geometry.Parts.Count == 1)
            {

                _geometry = newSubGeom.Clone();
                LoadEdges();
                return _geometry;
            }

            List<IGeometry> subItems=new List<IGeometry>();
            for (i = 0; i < _geometry.Parts.Count; i++)
            {
                if (i == _partIndex)
                {
                    subItems.Add(newSubGeom);
                }
                else
                {
                    subItems.Add(_geometry.Parts[i].Clone());
                }
            }
            IGeometry newGeometry = null;
            if (_geometry.GeometryType== GeometryType.Polygon)
             newGeometry = GeometryHelper.UnionPolygons(subItems);
            else
            {
                newGeometry = GeometryHelper.UnionPolylines(subItems);
            }
            _geometry = newGeometry;
            LoadEdges();
            return newGeometry;
        }

        private void gridEdges_SelectedRecordsChanged(object sender, SelectedRecordsChangedEventArgs e)
        {
            DrawEdges();
        }
    }
}

