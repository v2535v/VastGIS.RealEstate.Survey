using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using NetTopologySuite.Geometries;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Model;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;
using Coordinate = GeoAPI.Geometries.Coordinate;
using IGeometry = VastGIS.Api.Interfaces.IGeometry;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmMeasure : Form, IEditForm
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private List<ReLine> _reLines;
        private List<ReVertex> _reVertices;
        private int _layer = -1;

        public frmMeasure()
        {
            InitializeComponent();
        }

        public frmMeasure(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
        }

        public void SetQueryPoint(double dx, double dy)
        {
            AddPoint(new ReVertex(0, _reVertices.Count, dx, dy));
            lblX.Text = $@"X={dx:N}";
            lblY.Text = $@"Y={dy:N}";
            if (_reLines.Count >= 1)
                lblLength.Text = $@"总长度={_reLines.Sum(c => c.Length):N} 米";
            else
                lblLength.Text = $@"总长度=0 米";
            if (_reLines.Count >= 2)
            {
                IGeometry polygon = GeometryHelper.CreateGeometryFromVertexes(_reVertices, GeometryType.Polygon);
                lblArea.Text = $@"面积={polygon.Area:N} 平方米";
            }
            else
                lblArea.Text = $@"面积=0 平方米";
        }

        private void AddPoint(ReVertex vertex)
        {
            _reVertices.Add(vertex);
            ReVertex cPoint = _reVertices[_reVertices.Count - 1];
            IMap map = _context.Map as IMap;
            map.Drawing.DrawPoint(_layer, cPoint.X, cPoint.Y, 5, _context.Config.MeasuringFillColor);
            map.Drawing.DrawLabel(_layer, $"{_reVertices.Count}", cPoint.X, cPoint.Y, 0);

            if (_reVertices.Count <= 1)
                return;

            ReVertex sPoint = _reVertices[_reVertices.Count - 2];
            ReVertex ePoint = _reVertices[_reVertices.Count - 1];
            ReLine line = new ReLine(sPoint.X, sPoint.Y, ePoint.X, ePoint.Y);
            _reLines.Add(line);
            map.Drawing.DrawLine(_layer, sPoint.X, sPoint.Y, ePoint.X, ePoint.Y, 2, _context.Config.MeasuringLineColor);
            map.Drawing.DrawLabel(_layer, $"{line.Length:N}m", line.CenterPoint.X, line.CenterPoint.Y, 0);

        }

        public void ClearDrawing()
        {
            if (_layer >= 0)
            {
                _context.Map.Drawing.RemoveLayer(_layer);
            }

            lblX.Text = $@"X=";
            lblY.Text = $@"Y=";
            lblLength.Text = $@"总长度=0 米";
            lblArea.Text = $@"面积=0 平方米";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IMap map = _context.Map as IMap;
            ClearDrawing();
            _layer = map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
            _reVertices = new List<ReVertex>();
            _reLines = new List<ReLine>();
            map.MouseUp -= Map_MouseUp;
            map.MouseUp += Map_MouseUp;
            map.MapCursor = MapCursor.None;
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            double dx = 0.0;
            double dy = 0.0;
            if (_context.Map.MapCursor != MapCursor.None) return;
            bool pFind = _context.Map.FindSnapPoint(_context.Config.MouseTolerance, e.X, e.Y, ref dx, ref dy);
            if (!pFind)
            {
                _context.Map.PixelToProj(e.X, e.Y, out dx, out dy);
            }

            SetQueryPoint(dx, dy);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            IMap map = _context.Map as IMap;
            map.MouseUp -= Map_MouseUp;
            map.MapCursor = MapCursor.Pan;
        }

        private void frmMeasure_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                btnStart_Click(null, null);
            else
                btnStop_Click(null, null);
        }

        private IGeometry CreatePolygon(List<RePoint> points)
        {
            List<GeoAPI.Geometries.Coordinate> coordinates = new List<Coordinate>();
            foreach (RePoint rePoint in points)
            {
                coordinates.Add(new Coordinate(rePoint.X, rePoint.Y));
            }
            GeometryFactory geometryFactory = new GeometryFactory();
            GeoAPI.Geometries.IGeometry editGeometry = geometryFactory.CreateMultiPoint(coordinates.ToArray());
            IGeometry newGeometry = new Api.Concrete.Geometry(GeometryType.MultiPoint, ZValueType.None);
            newGeometry.ImportFromWkt(editGeometry.AsText());
            return newGeometry;
        }
    }
}
