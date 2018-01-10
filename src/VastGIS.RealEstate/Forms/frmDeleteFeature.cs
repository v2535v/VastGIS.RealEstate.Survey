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
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.Shared;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmDeleteFeature : MapEditingForm,IEditForm
    {
        private IREDatabase _database;
        private List<VgObjectclasses> _classes;
        private List<VgObjectclasses> _targetClasses;
        private BindingList<SearchFeature> _searchFeatures;
        public frmDeleteFeature(IAppContext context)
            : base(context)
        {
            InitializeComponent();
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            _classes = _database.SystemService.GetObjectclasseses(false).Where(c=>c.Editable==true).ToList();
        }

        private void btnTargetLayer_Click(object sender, EventArgs e)
        {
            frmSelectLayer frmSelection = new frmSelectLayer(_classes,GeometryType.None);
            frmSelection.SelectionMode = SelectionMode.MultiExtended;
            if (frmSelection.ShowDialog() != DialogResult.OK) return;
            _targetClasses = frmSelection.SelectedObjectClasses != null ? frmSelection.SelectedObjectClasses : null;
            if (_targetClasses != null)
            {
                string[] names = _targetClasses.Select(c => c.Zwmc).ToArray();
                txtTarget.Text = StringHelper.Join(names, ",");
            }
            _searchFeatures = new BindingList<SearchFeature>();
            lstSource.DataSource = _searchFeatures;
            lstSource.DisplayMember = "FullLabelString";
            lstSource.ValueMember = "InListID";
        }

        public void SetQueryPoint(double dx, double dy)
        {
            if (_targetClasses == null || _targetClasses.Count == 0) return;
            string[] classNames = _targetClasses.Select(c => c.Mc).ToArray();
            
            List<SearchFeature> features = _database.SystemService.FindRecords(_targetClasses, dx, dy);
            if (_searchFeatures == null)
            {
                _searchFeatures = new BindingList<SearchFeature>();
            }
            if (features != null && features.Count > 0)
            {
                foreach (var feature in features)
                {
                    var find = _searchFeatures.Where(c => c.TableName == feature.TableName && c.ID == feature.ID);
                    if (find == null || find.Count() == 0) _searchFeatures.Add(feature);
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

        private void btnCanel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _searchFeatures.Clear();
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
                _context.Map.Drawing.DrawCircle(geometry2.Points[0].X, geometry2.Points[0].Y,10,Color.Red,true,1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _context.Map.Drawing.Clear();
            if (lstSource.CheckedItems == null || lstSource.CheckedItems.Count < 1)
            {
                return;
            }
            foreach (SearchFeature checkedItem in lstSource.CheckedItems)
            {
                _database.SystemService.DeleteFeature(checkedItem.TableName, checkedItem.ID);
                
            }
            for (int i = lstSource.Items.Count - 1; i >= 0; i--)
            {
                if (lstSource.GetItemChecked(i))
                {
                    _searchFeatures.RemoveAt(i);
                }
            }
            
        }
    }
}
