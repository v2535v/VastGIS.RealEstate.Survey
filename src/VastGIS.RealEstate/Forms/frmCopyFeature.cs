using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Spatial;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.Shared;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmCopyFeature : MapEditingForm,IEditForm
    {
        private IREDatabase _database;
        private List<VgObjectclasses> _classes;
        private List<VgObjectclasses> _sourceclasses;
        private VgObjectclasses _targetClass;
        private GeometryType _currentGeometryType;
        private BindingList<SearchFeature> _searchFeatures;
        private MapSelectionMode _mapSelectionMode;
        private bool _isSingle;

        public frmCopyFeature(IAppContext context)
            : base(context)
        {
            InitializeComponent();
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            _currentGeometryType = GeometryType.Polygon;
            _classes = _database.SystemService.GetObjectclasseses(false);
            _isSingle = true;
        }



        private void btnTargetLayer_Click(object sender, EventArgs e)
        {
            //List<VgObjectclasses> findClass = null;
            //if (_currentGeometryType != GeometryType.TextPoint)
            //{
            //    findClass = _classes.Where(c => c.Txlx == (int)_currentGeometryType).ToList();
            //}
            //else
            //{
            //    findClass = _classes.Where(c => c.Txlx == (int)_currentGeometryType && c.Mc.ToUpper().EndsWith("ZJ")).ToList();
            //}
            frmSelectLayer frmSelection = new frmSelectLayer(_classes, _currentGeometryType);
            frmSelection.SelectionMode = SelectionMode.One;
            if (frmSelection.ShowDialog() != DialogResult.OK) return;
            _targetClass = frmSelection.SelectedObjectClasses != null ? frmSelection.SelectedObjectClasses[0] : null;
            if (_targetClass != null)
            {
                txtTarget.Text = _targetClass.Zwmc;
            }
            _searchFeatures = new BindingList<SearchFeature>();
            lstSource.DataSource = _searchFeatures;
            lstSource.DisplayMember = "FullLabelString";
            lstSource.ValueMember = "InListID";
            
        }

        private void radPoint_CheckedChanged(object sender, EventArgs e)
        {

            SetGeometryType(GeometryType.Point);
        }

        private void radLine_CheckedChanged(object sender, EventArgs e)
        {
            SetGeometryType(GeometryType.Polyline);
        }

        private void radArea_CheckedChanged(object sender, EventArgs e)
        {
            SetGeometryType(GeometryType.Polygon);
        }

        private void radText_CheckedChanged(object sender, EventArgs e)
        {
            SetGeometryType(GeometryType.TextPoint);
        }

        private void SetGeometryType(GeometryType geometryType)
        {
            if (_currentGeometryType != geometryType)
            {
                if (_sourceclasses != null) _sourceclasses.Clear();
                _targetClass = null;
                txtTarget.Text = "";
                if (_searchFeatures != null) _searchFeatures.Clear();
                txtSource.Text = "";
                _currentGeometryType = geometryType;
            }
        }

        private void btnSourceLayer_Click(object sender, EventArgs e)
        {
            //}
            frmSelectLayer frmSelection = new frmSelectLayer(_classes, _currentGeometryType);
            frmSelection.SelectionMode = SelectionMode.MultiExtended;
            if (frmSelection.ShowDialog() != DialogResult.OK) return;
            _sourceclasses = frmSelection.SelectedObjectClasses != null ? frmSelection.SelectedObjectClasses : null;
            if (_sourceclasses != null)
            {
                string[] names = _sourceclasses.Select(c => c.Zwmc).ToArray();
                txtSource.Text = StringHelper.Join(names, ",");
            }
        }

        private void radSingle_CheckedChanged(object sender, EventArgs e)
        {
            _isSingle = radSingle.Checked;
            if (_isSingle) lstSource.SelectionMode = SelectionMode.One;
            else
            {
                lstSource.SelectionMode = SelectionMode.MultiExtended;
            }
        }

        private void radMulti_CheckedChanged(object sender, EventArgs e)
        {
            _isSingle = !radMulti.Checked;
            if (_isSingle) lstSource.SelectionMode = SelectionMode.One;
            else
            {
                lstSource.SelectionMode = SelectionMode.MultiExtended;
            }
        }
      

        public void SetQueryPoint(double dx, double dy)
        {
            if (_sourceclasses == null || _sourceclasses.Count == 0) return;
            string[] classNames = _sourceclasses.Select(c => c.Mc).ToArray();
            List<SearchFeature> features = _database.SystemService.FindRecords(classNames, dx, dy);
            if (_searchFeatures == null)
            {
                _searchFeatures = new BindingList<SearchFeature>();
            }
            if (features != null && features.Count > 0)
            {
                foreach (var feature in features)
                {
                    var find = _searchFeatures.Where(c => c.TableName == feature.TableName && c.ID == feature.ID);
                    if (find==null || find.Count()==0 ) _searchFeatures.Add(feature);
                }
                int i = 0;
                foreach (var searchFeature in _searchFeatures)
                {
                    searchFeature.InListID = i;
                    i++;
                }
                lstSource.DataSource = _searchFeatures;
                lstSource.DisplayMember = "FullLabelString";
                //lstSource.ValueMember = "InListID";
                lstSource.Refresh();
            }
        }

        private void lstSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSource.SelectedIndex < 0)
            {
                _context.Map.Drawing.Clear();
                return;
            }
            SearchFeature feature = lstSource.SelectedItem as SearchFeature;
            _context.Map.Drawing.Clear();
            _context.Map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
            IGeometry geometry2 = feature.Geometry;
            double[] x2Array = geometry2.Points.Select(c => c.X).ToArray();
            double[] y2Array = geometry2.Points.Select(c => c.Y).ToArray();
            Color color = Color.Yellow;
            if (geometry2.GeometryType == GeometryType.Polygon)
                _context.Map.Drawing.DrawPolygon(x2Array, y2Array, geometry2.Points.Count, color, true, 1);
            else if (geometry2.GeometryType == GeometryType.Polyline)
            {
                for (int i = 0; i < geometry2.Points.Count - 1; i++)
                {
                    _context.Map.Drawing.DrawLine(geometry2.Points[i].X, geometry2.Points[i].Y,
                        geometry2.Points[i + 1].X, geometry2.Points[i + 1].Y, 4, Color.Red);

                }
            }
            else if (geometry2.GeometryType == GeometryType.Point)
            {
                _context.Map.Drawing.DrawCircle(geometry2.Points[0].X, geometry2.Points[0].Y, 10, Color.Red, true, 1);
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lstSource.SelectedItems == null || lstSource.SelectedItems.Count < 1)
            {
                MessageService.Current.Warn("请先选择要拷贝的元素!");
                return;
            }

            foreach (SearchFeature selectedItem in lstSource.SelectedItems)
            {
                _database.SystemService.CopyFeature(selectedItem.TableName, selectedItem.ID, _targetClass.Mc,
                    chkDeleteOrginal.Checked, true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _searchFeatures.Clear();
        }
    }
}
