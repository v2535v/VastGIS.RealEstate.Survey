using System.Data.Entity.Spatial;
using VastGIS.Plugins.RealEstate.Model;
using VastGIS.Plugins.RealEstate.Properties;
using VastGIS.RealEstate.Data.Helpers;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using VastGIS.Api.Concrete;
    using VastGIS.Api.Enums;
    using VastGIS.Api.Interfaces;
    using VastGIS.Plugins.Interfaces;
    using VastGIS.RealEstate.Data.Entity;

    /// <summary>
    /// Defines the <see cref="ucCoordinateList" />
    /// </summary>
    public partial class ucCoordinateList : UserControl
    {
        #region 变量

        /// <summary>
        /// Defines the _context
        /// </summary>
        private IAppContext _context;

        /// <summary>
        /// Defines the _editable
        /// </summary>
        private bool _editable;

        /// <summary>
        /// Defines the _geometryType
        /// </summary>
        private GeometryType _geometryType;

        /// <summary>
        /// Defines the _isDraw
        /// </summary>
        private bool _isDraw = true;

        /// <summary>
        /// Defines the _layerHandle
        /// </summary>
        private int _layerHandle = -1;

        /// <summary>
        /// Defines the _map
        /// </summary>
        private IMuteMap _map;

        private int _maxid;
        private int _maxpart;
        private bool _isUpdate;

        /// <summary>
        /// Defines the _vertexs
        /// </summary>
        private BindingList<ReVertex> _vertexs;

        #endregion

        #region 属性

        /// <summary>
        /// Gets or sets a value indicating whether Editable
        /// </summary>
        public bool Editable
        {
            get { return _editable; }
            set
            {
                _editable = value;
                dblX.Enabled = _editable;
                dblY.Enabled = _editable;
                btnVertexPick.Enabled = _editable;
                btnVertexUpdate.Enabled = _editable;
                btnInsertVertex.Enabled = _editable;
                btnRemoveVertex.Enabled = _editable;
                btnVertexDown.Enabled = _editable;
                btnVertexUp.Enabled = _editable;
            }
        }

        public bool IsUpdate
        {
            get { return _isUpdate; }
            set
            {
                _isUpdate = value;

            }
        }

        /// <summary>
        /// Gets or sets the GeometryType
        /// </summary>
        public GeometryType GeometryType
        {
            get { return _geometryType; }
            set { _geometryType = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether IsDraw
        /// </summary>
        public bool IsDraw
        {
            get { return _isDraw; }
            set { _isDraw = value; }
        }

        #endregion

        #region 创建

        /// <summary>
        /// Initializes a new instance of the <see cref="ucCoordinateList"/> class.
        /// </summary>
        public ucCoordinateList()
        {
            InitializeComponent();
            //setting metro theme to the grid.
            this.gridPoints.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridPoints.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            //to set proportional column resizing to grid.
            this.gridPoints.AllowProportionalColumnSizing = true;

            //to hide Caption.
            this.gridPoints.TopLevelGroupOptions.ShowCaption = false;
            this.gridPoints.ChildGroupOptions.ShowCaption = false;
            this.gridPoints.NestedTableGroupOptions.ShowCaption = false;

            //to disable AddNewRecord.
            this.gridPoints.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridPoints.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridPoints.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;

            this.gridPoints.WantTabKey = false;
            this.gridPoints.TableDescriptor.AllowNew = false;
            this.gridPoints.TableDescriptor.AllowEdit = false;
            _editable = false;
            dblX.Enabled = _editable;
            dblY.Enabled = _editable;
            btnVertexPick.Enabled = _editable;
            btnVertexUpdate.Enabled = _editable;
            btnInsertVertex.Enabled = _editable;
            btnRemoveVertex.Enabled = _editable;
            btnVertexDown.Enabled = _editable;
            btnVertexUp.Enabled = _editable;
        }

        #endregion

        #region 方法

        private void CheckVertexList()
        {
            if (_vertexs == null)
            {
                _vertexs = new BindingList<ReVertex>();
                _maxid = 0;
                _maxpart = 0;
            }
            else
            {
                if (_vertexs.Count > 0)
                {
                    _maxid = _vertexs.Select(c => c.ID).Max();
                    _maxpart = _vertexs.Select(c => c.Part).Max();
                }
                else
                {
                    _maxid = 0;
                    _maxpart = 0;
                }
            }
        }
        public void AddGeometry(IGeometry geometry)
        {

            CheckVertexList();
            switch (geometry.GeometryType)
            {
                case GeometryType.None:
                    return;
                case GeometryType.Point:
                    AddPoint(geometry.Points[0].X, geometry.Points[0].Y);
                    break;
                case GeometryType.Polyline:
                    foreach (IGeometry geometryPart in geometry.Parts)
                    {
                        foreach (var partPoint in geometryPart.Points)
                        {
                            _maxid++;
                            ReVertex oneVertex = new ReVertex(_maxpart, _maxid, partPoint.X, partPoint.Y, true);
                            _vertexs.Add(oneVertex);
                        }
                        _maxpart++;
                    }
                    //DrawData();
                    DrawPoints();
                    break;
                case GeometryType.Polygon:
                    foreach (IGeometry geometryPart in geometry.Parts)
                    {
                        foreach (var partPoint in geometryPart.Points)
                        {
                            _maxid++;
                            ReVertex oneVertex = new ReVertex(_maxpart, _maxid, partPoint.X, partPoint.Y, true);
                            _vertexs.Add(oneVertex);
                        }
                        _maxpart++;
                    }
                    //DrawData();
                    DrawPoints();
                    break;
                case GeometryType.MultiPoint:
                    foreach (var partPoint in geometry.Points)
                    {
                        _maxid++;
                        ReVertex oneVertex = new ReVertex(_maxpart, _maxid, partPoint.X, partPoint.Y, true);
                        _vertexs.Add(oneVertex);
                    }
                    //DrawData();
                    DrawPoints();
                    break;
                case GeometryType.TextPoint:
                    AddPoint(geometry.Points[0].X, geometry.Points[0].Y);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// The AddPoint
        /// </summary>
        /// <param name="x">The <see cref="double"/></param>
        /// <param name="y">The <see cref="double"/></param>
        public void AddPoint(double x, double y)
        {
            CheckVertexList();
            if (!_isUpdate)
            {
                _vertexs.Add(new ReVertex(_maxpart, _maxid + 1, x, y));
                _maxid++;
                //ReCalculateID();
                DrawPoints();
            }
            else
            {
                dblX.DoubleValue = x;
                dblY.DoubleValue = y;
            }
        }

        /// <summary>
        /// The AddPoint
        /// </summary>
        /// <param name="pPoint">The <see cref="ReVertex"/></param>
        public void AddPoint(ReVertex pPoint)
        {
            CheckVertexList();
            pPoint.ID = _maxid + 1;
            pPoint.Part = _maxpart;
            _maxid++;
            pPoint.Checked = true;
            _vertexs.Add(pPoint);
            //ReCalculateID();
            DrawPoints();
        }

        /// <summary>
        /// The AddPoints
        /// </summary>
        /// <param name="pPoints">The <see cref="List{ReVertex}"/></param>
        public void AddPoints(List<ReVertex> pPoints)
        {
            CheckVertexList();
            foreach (var rePoint in pPoints)
            {
                rePoint.Checked = true;
                rePoint.ID = _maxid + 1;
                rePoint.Part = _maxpart;
                _maxid++;
                _vertexs.Add(rePoint);
            }
            // ReCalculateID();
        }

        /// <summary>
        /// The BindContext
        /// </summary>
        /// <param name="context">The <see cref="IAppContext"/></param>
        public void BindContext(IAppContext context)
        {
            _context = context;
            _map = context.Map;
            _map.Drawing.Clear();
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

        /// <summary>
        /// The btnSelectAll_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ReVertex reVertex in _vertexs)
            {
                reVertex.Checked = true;
            }
        }

        /// <summary>
        /// The btnSelectClear_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void btnSelectClear_Click(object sender, EventArgs e)
        {
            _vertexs.Clear();
        }

        /// <summary>
        /// The btnSelectReserve_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void btnSelectReserve_Click(object sender, EventArgs e)
        {
            foreach (ReVertex reVertex in _vertexs)
            {
                reVertex.Checked = !reVertex.Checked;
            }
        }

        /// <summary>
        /// The btnSelectUnAll_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void btnSelectUnAll_Click(object sender, EventArgs e)
        {
            foreach (ReVertex reVertex in _vertexs)
            {
                reVertex.Checked = false;
            }
        }

        /// <summary>
        /// The ClearDrawing
        /// </summary>
        public void ClearDrawing()
        {
            if (_layerHandle >= 0)
            {
                _context.Map.Drawing.RemoveLayer(_layerHandle);
            }
        }

        /// <summary>
        /// The ClearList
        /// </summary>
        public void ClearList()
        {
            _vertexs.Clear();
            _maxid = 0;
            _maxpart = 0;
        }

        /// <summary>
        /// The DrawData
        /// </summary>
        public void DrawData()
        {
            IGeometry editGeometry = GetGeometry();
            if (editGeometry == null) return;
            Color color = _context.Config.RealEstateSelectedColor;
            DrawGeometry(editGeometry, color);
            List<ReVertex> vertexs = _vertexs.Where(c => c.Checked == true).ToList();
            foreach (ReVertex vertex in vertexs)
            {
                _map.Drawing.DrawLabel(_layerHandle, vertex.ID.ToString(), vertex.X, vertex.Y, 0);
                if (editGeometry.GeometryType != GeometryType.Point && editGeometry.GeometryType != GeometryType.MultiPoint)
                {
                    _map.Drawing.DrawPoint(_layerHandle, vertex.X, vertex.Y, 12, color);
                }

            }
        }

        /// <summary>
        /// The DrawGeometry
        /// </summary>
        /// <param name="geometry">The <see cref="IGeometry"/></param>
        /// <param name="color">The <see cref="Color"/></param>
        /// <param name="labelString">The <see cref="string"/></param>
        /// <param name="rotation">The <see cref="double"/></param>
        private void DrawGeometry(IGeometry geometry, Color color, string labelString = "", double rotation = 0)
        {

            double x1 = 0.0;
            double y1 = 0.0;
            double x2 = 0.0;
            double y2 = 0.0;
            if (geometry.GeometryType == GeometryType.Polyline)
            {
                for (int j = 0; j < geometry.Parts.Count; j++)
                {
                    for (int i = 0; i < geometry.Parts[j].Points.Count - 1; i++)
                    {
                        x1 = geometry.Parts[j].Points[i].X;
                        y1 = geometry.Parts[j].Points[i].Y;
                        x2 = geometry.Parts[j].Points[i + 1].X;
                        y2 = geometry.Parts[j].Points[i + 1].Y;
                        _map.Drawing.DrawLine(_layerHandle, x1, y1, x2, y2, 3, color);
                    }
                }
                return;
            }
            else if (geometry.GeometryType == GeometryType.Polygon)
            {
                for (int j = 0; j < geometry.Parts.Count; j++)
                {
                    double[] xs = geometry.Parts[j].Points.Select(c => c.X).ToArray();
                    double[] ys = geometry.Parts[j].Points.Select(c => c.Y).ToArray();
                    object xsObject = xs as object;
                    object ysObject = ys as object;
                    _map.Drawing.DrawPolygon(_layerHandle, ref xsObject, ref ysObject, geometry.Parts[j].Points.Count, color,
                        false, 4);
                }

                for (int j = 0; j < geometry.Parts.Count; j++)
                {
                    for (int i = 0; i < geometry.Parts[j].Points.Count - 1; i++)
                    {
                        x1 = geometry.Parts[j].Points[i].X;
                        y1 = geometry.Parts[j].Points[i].Y;
                        x2 = geometry.Parts[j].Points[i + 1].X;
                        y2 = geometry.Parts[j].Points[i + 1].Y;
                        ReLine line = new ReLine(x1, y1, x2, y2);
                        _map.Drawing.DrawLabel(_layerHandle, $"{line.Length:N}m", line.CenterPoint.X, line.CenterPoint.Y, 0);
                    }
                }
                _map.Drawing.DrawLabel(_layerHandle, $"{geometry.Area:N}㎡", geometry.Center.X, geometry.Center.Y, 0);
                return;
            }
            else if (geometry.GeometryType == GeometryType.Point)
            {
                _map.Drawing.DrawPoint(_layerHandle, geometry.Points[0].X, geometry.Points[0].Y, 12, color);
            }
            else if (geometry.GeometryType == GeometryType.MultiPoint)
            {
                for (int i = 0; i < geometry.Points.Count; i++)
                {
                    _map.Drawing.DrawPoint(_layerHandle, geometry.Points[i].X, geometry.Points[i].Y, 12, color);
                }
            }
            else if (geometry.GeometryType == GeometryType.TextPoint)
            {
                _map.Drawing.DrawLabel(_layerHandle, labelString, geometry.Points[0].X, geometry.Points[0].Y, rotation);
            }
        }

        /// <summary>
        /// The DrawPoints
        /// </summary>
        public void DrawPoints()
        {
            PrepareLayer();
            DrawData();
            foreach (ReVertex reVertex in _vertexs)
            {
                if (reVertex.Checked == false) continue;
                DrawVertex(reVertex);
            }
            //if (gridPoints.Table.SelectedRecords == null || gridPoints.Table.SelectedRecords.Count==0) return;
            //int id = gridPoints.Table.SelectedRecords[0].Record.GetSourceIndex();
            //ReVertex vertex = _vertexs[id];

        }

        /// <summary>
        /// The DrawVertex
        /// </summary>
        /// <param name="point">The <see cref="ReVertex"/></param>
        private void DrawVertex(ReVertex point)
        {
            Color color = _context.Config.RealEstateActivedColor;
            DrawGeometry(point.GetGeometry(), color);
        }




        /// <summary>
        /// The GetGeometry
        /// </summary>
        /// <returns>The <see cref="IGeometry"/></returns>
        public IGeometry GetGeometry()
        {
            IGeometry editGeometry = GeometryHelper.CreateGeometryFromVertexes(_vertexs.ToList(), _geometryType, true, true);
            return editGeometry;
        }

        /// <summary>
        /// The GetSelectedVertexs
        /// </summary>
        /// <returns>The <see cref="List{ReVertex}"/></returns>
        public List<ReVertex> GetSelectedVertexs()
        {
            if (_vertexs == null) return null;
            return _vertexs.Where(c => c.Checked == true).ToList();
        }

        /// <summary>
        /// The gridPoints_SelectedRecordsChanged
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="Syncfusion.Grouping.SelectedRecordsChangedEventArgs"/></param>
        private void gridPoints_SelectedRecordsChanged(object sender, Syncfusion.Grouping.SelectedRecordsChangedEventArgs e)
        {
            if (_map == null) return;
            if (e.SelectedRecord == null) return;
            DrawPoints();
            int id = e.SelectedRecord.Record.GetSourceIndex();
            if (id < 0) return;
            ReVertex vertex = _vertexs[id];
            dblX.DoubleValue = vertex.X;
            dblY.DoubleValue = vertex.Y;
        }

        /// <summary>
        /// The HasSelected
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        public bool HasSelected()
        {
            if (_vertexs == null) return false;
            IEnumerable<ReVertex> checkeds = _vertexs.Where(c => c.Checked == true);
            if (checkeds != null && checkeds.Count() > 0) return true;
            return false;
        }

        /// <summary>
        /// The InitGrid
        /// </summary>
        public void InitGrid()
        {
            if (_vertexs == null)
            {
                _vertexs = new BindingList<ReVertex>();
            }

            this.gridPoints.DataSource = _vertexs;

            this.gridPoints.AllowProportionalColumnSizing = false;

            //To change the HeaderText.
            this.gridPoints.TableDescriptor.Columns["ID"].HeaderText = "序号";
            this.gridPoints.TableDescriptor.Columns["ID"].Width = 40;
            this.gridPoints.TableDescriptor.Columns["ID"].ReadOnly = true;
            this.gridPoints.TableDescriptor.Columns["Checked"].HeaderText = "";
            this.gridPoints.TableDescriptor.Columns["Checked"].Width = 40;
            this.gridPoints.TableDescriptor.Columns["Part"].HeaderText = "组号";
            this.gridPoints.TableDescriptor.Columns["Part"].Width = 40;
            this.gridPoints.TableDescriptor.Columns["X"].HeaderText = "X坐标";
            this.gridPoints.TableDescriptor.Columns["X"].Width = 80;
            this.gridPoints.TableDescriptor.Columns["Y"].HeaderText = "Y坐标";
            this.gridPoints.TableDescriptor.Columns["Y"].Width = 80;

            btnSelectAll.Enabled = true;
            btnSelectReserve.Enabled = true;
            btnSelectUnAll.Enabled = true;
        }

        /// <summary>
        /// The PrepareLayer
        /// </summary>
        private void PrepareLayer()
        {
            if (_layerHandle >= 0)
            {
                _map.Drawing.RemoveLayer(_layerHandle);
            }
            _layerHandle = _map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
        }

        /// <summary>
        /// The ReCalculateID
        /// </summary>
        private void ReCalculateID()
        {
            if (_vertexs == null)
            {
                return;
            }
            for (int i = 0; i < _vertexs.Count; i++)
            {
                _vertexs[i].ID = i + 1;
            }
            //gridPoints.Update();
            //gridPoints.Refresh();
        }



        #endregion

        private void btnVertexPick_Click(object sender, EventArgs e)
        {
            _isUpdate = !_isUpdate;
            btnVertexPick.PushButton = _isUpdate;
            btnVertexPick.Image = _isUpdate ? Resources.img_pickpoint : Resources.img_pickfeature;
        }

        private void btnVertexUpdate_Click(object sender, EventArgs e)
        {
            if (gridPoints.Table.SelectedRecords.Count != 1)
            {
                return;
            }
            int id = gridPoints.Table.CurrentRecord.GetSourceIndex();
            _vertexs[id].X = dblX.DoubleValue;
            _vertexs[id].Y = dblY.DoubleValue;

        }

        private void btnInsertVertex_Click(object sender, EventArgs e)
        {
            if (gridPoints.Table.SelectedRecords.Count != 1)
            {
                return;
            }
            int id = gridPoints.Table.CurrentRecord.GetSourceIndex();
            ReVertex currentVertex = _vertexs[id];
            id = id + 1;
            ReVertex newVertex = new ReVertex(id, dblX.DoubleValue, dblY.DoubleValue, true);
            newVertex.Part = currentVertex.Part;
            _vertexs.Insert(id, newVertex);
            ReCalculateID();
            DrawPoints();
        }

        private void btnRemoveVertex_Click(object sender, EventArgs e)
        {
            if (gridPoints.Table.SelectedRecords.Count != 1)
            {
                return;
            }
            int id = gridPoints.Table.CurrentRecord.GetSourceIndex();
            if (MessageBox.Show("你确认将该端点从列表中移除吗?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.Cancel) return;
            _vertexs.RemoveAt(id);
            ReCalculateID();
            DrawPoints();
        }


        private void btnVertexUp_Click(object sender, EventArgs e)
        {
            if (gridPoints.Table.SelectedRecords.Count != 1)
            {
                return;
            }
            int id = gridPoints.Table.CurrentRecord.GetSourceIndex();
            if (id == 0) return;
            double xx = _vertexs[id - 1].X;
            double yy = _vertexs[id - 1].Y;
            _vertexs[id - 1].X = _vertexs[id].X;
            _vertexs[id - 1].Y = _vertexs[id].Y;
            _vertexs[id].X = xx;
            _vertexs[id].Y = yy;
            ReCalculateID();
            DrawPoints();
        }

        private void btnVertexDown_Click(object sender, EventArgs e)
        {
            if (gridPoints.Table.SelectedRecords.Count != 1)
            {
                return;
            }
            int id = gridPoints.Table.CurrentRecord.GetSourceIndex();
            if (id >= _vertexs.Count - 1) return;
            double xx = _vertexs[id + 1].X;
            double yy = _vertexs[id + 1].Y;
            _vertexs[id + 1].X = _vertexs[id].X;
            _vertexs[id + 1].Y = _vertexs[id].Y;
            _vertexs[id].X = xx;
            _vertexs[id].Y = yy;
            ReCalculateID();
            DrawPoints();
        }
    }
}
