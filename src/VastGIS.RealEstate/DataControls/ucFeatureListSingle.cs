using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucFeatureListSingle : UserControl
    {
        private IMuteMap _map;
        private BindingList<IEntity> _features;
        private IAppContext _context;
        private int _layerHandle = -1;

        public ucFeatureListSingle()
        {
            InitializeComponent();

            if (_features == null)
                _features = new BindingList<IEntity>();

            lstFeatureList.DataSource = _features;
            lstFeatureList.DisplayMember = "FullLabelString";
            lstFeatureList.ValueMember = "ID";
        }

        public void BindContext(IAppContext context)
        {
            _context = context;
            BindMap(_context.Map);
        }

        public void BindMap(IMuteMap pMap)
        {
            _map = pMap;
            _map.Drawing.Clear();
        }

        public void AddFeatures(List<IReFeature> features)
        {
            if (_features == null)
                _features = new BindingList<IEntity>();
            PrepareLayer();

            foreach (IReFeature feature in features)
            {
                if (!_features.Contains(feature))
                    _features.Add(feature);
                FlashGeometry(feature.Geometry);
            }
        }

        private void FlashGeometry(IGeometry pGeometry)
        {
            Color color = _context.Config.RealEstateSelectedColor;

            DrawGeometry(pGeometry, color);
        }

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
                return;
            }
            else if (geometry.GeometryType == GeometryType.Point)
            {
                _map.Drawing.DrawPoint(_layerHandle, geometry.Points[0].X, geometry.Points[0].Y, 12, color);
            }
            else if (geometry.GeometryType == GeometryType.TextPoint)
            {
                _map.Drawing.DrawLabel(_layerHandle, labelString, geometry.Points[0].X, geometry.Points[0].Y, rotation);
            }
        }

        private void PrepareLayer()
        {
            if (_layerHandle >= 0)
            {
                _map.Drawing.RemoveLayer(_layerHandle);
            }
            _layerHandle = _map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
        }

        private void DrawSelectFeature(IGeometry pGeometry)
        {
            Color color = _context.Config.RealEstateSelectedColor;
            DrawGeometry(pGeometry, color);
        }

        private void lstFeatureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareLayer();
            IReFeature feature = lstFeatureList.SelectedItem as IReFeature;
            if (feature == null)
                return;
            DrawSelectFeature(feature.Geometry);
        }

        public IReFeature GetCurrentFeature()
        {
            return this.lstFeatureList.SelectedItem as IReFeature;
        }
    }
}
