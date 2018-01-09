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
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.Shared;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmCopyFeature : MapWindowForm
    {
        private IREDatabase _database;
        private List<VgObjectclasses> _classes;
        private List<VgObjectclasses> _sourceclasses;
        private VgObjectclasses _targetClass;
        private GeometryType _currentGeometryType;
        private List<SearchFeature> _searchFeatures;
        private MapSelectionMode _mapSelectionMode;
        private bool _isSingle;
        public frmCopyFeature(IAppContext context):base(context)
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
            frmSelectLayer frmSelection=new frmSelectLayer(_classes,_currentGeometryType);
            frmSelection.SelectionMode= SelectionMode.One;
            if (frmSelection.ShowDialog() != DialogResult.OK) return;
            _targetClass = frmSelection.SelectedObjectClasses != null ? frmSelection.SelectedObjectClasses[0] : null;
            if (_targetClass != null)
            {
                txtTarget.Text = _targetClass.Zwmc;
            }
            _searchFeatures = new List<SearchFeature>();
            lstSource.DataSource = _searchFeatures;
            lstSource.DisplayMember = "SimpleLabelString";
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
                if(_sourceclasses!=null)_sourceclasses.Clear();
                _targetClass = null;
                txtTarget.Text = "";
                if(_searchFeatures!=null)_searchFeatures.Clear();
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
                txtSource.Text = StringHelper.Join(names,",");
            }
        }

        private void radSingle_CheckedChanged(object sender, EventArgs e)
        {
            _isSingle = radSingle.Checked;
            if (_isSingle) RemoveExtendSource();
        }

        private void radMulti_CheckedChanged(object sender, EventArgs e)
        {
            _isSingle = !radMulti.Checked;
            if (_isSingle) RemoveExtendSource();
        }

        private void RemoveExtendSource()
        {
           
            if (lstSource.Items.Count > 1)
            {
                for (int i = lstSource.Items.Count; i >= 1; i--)
                {
                    lstSource.Items.RemoveAt(i);
                }
            }
            lstSource.SelectionMode = SelectionMode.One;
        }

        public void SetQueryPoint(double dx, double dy)
        {
            if (_sourceclasses == null || _sourceclasses.Count == 0) return;
            string[] classNames = _sourceclasses.Select(c => c.Mc).ToArray();
            List<SearchFeature> features = _database.SystemService.FindRecords(classNames, dx, dy);
            if (_searchFeatures == null)
            {
                _searchFeatures=new List<SearchFeature>();
            }
            if (features != null && features.Count > 0)
            {
                foreach (var feature in features)
                {
                    var find = _searchFeatures.Exists(c=>c.TableName==feature.TableName && c.ID==feature.ID);
                    
                    if(!find) _searchFeatures.Add(feature);
                }
                lstSource.DataSource = _searchFeatures;
                lstSource.DisplayMember = "FullLabelString";
                lstSource.Refresh();
            }
        }
    }
}
