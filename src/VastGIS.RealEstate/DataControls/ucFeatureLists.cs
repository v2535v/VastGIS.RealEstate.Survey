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
    public partial class ucFeatureLists : UserControl
    {
        private IMuteMap _map;
        private BindingList<IEntity> _features;
        private bool _canMultiSelected;
        private bool _isDraw = true;
        private IAppContext _context;
        private int _layerHandle=-1;
        public ucFeatureLists()
        {
            InitializeComponent();
            _canMultiSelected = false;
            InitSelectionMode();
        }

        private void ucFeatureLists_Resize(object sender, EventArgs e)
        {
            //int btnWidth = (this.Width - 30) /4;
            //btnSelectAll.Width = btnWidth;
            //btnSelectReserve.Width = btnWidth;
            //btnSelectClear.Width = btnWidth;
            //btnSelectUnAll.Width = btnWidth;
            //chkLstFeatures.Height = this.Height - 57;
            //lstFeatures.Height = this.Height - 57;
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

        public bool CanMultiSelect
        {
            get { return _canMultiSelected; }
            set
            {
                _canMultiSelected = value;
                InitSelectionMode();
            }
        }

        private void InitSelectionMode()
        {
            if (_features == null)
            {
                _features=new BindingList<IEntity>();
                return;
            }
            if (_canMultiSelected)
            {
                chkLstFeatures.Visible = true;
                chkLstFeatures.DataSource = _features;
                chkLstFeatures.DisplayMember = "FullLabelString";
                chkLstFeatures.ValueMember = "ID";
                lstFeatures.DataSource = null;
                lstFeatures.Visible = false;
                btnSelectAll.Enabled = true;
                btnSelectReserve.Enabled = true;
                btnSelectUnAll.Enabled = true;
            }
            else
            {

                lstFeatures.Visible = true;
                lstFeatures.DataSource = _features;
                lstFeatures.DisplayMember = "FullLabelString";
                lstFeatures.ValueMember = "ID";
                chkLstFeatures.DataSource = null;
                chkLstFeatures.Visible = false;
                btnSelectAll.Enabled = false;
                btnSelectReserve.Enabled = false;
                btnSelectUnAll.Enabled = false;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstFeatures.Items.Count; i++)
            {
                chkLstFeatures.SetItemChecked(i,true);
            }
        }

        private void btnSelectUnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstFeatures.Items.Count; i++)
            {
                chkLstFeatures.SetItemChecked(i, false);
            }
        }

        private void btnSelectReserve_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstFeatures.Items.Count; i++)
            {
                chkLstFeatures.SetItemChecked(i, !chkLstFeatures.GetItemChecked(i));
            }
        }

        private void btnSelectClear_Click(object sender, EventArgs e)
        {
            _features.Clear();
        }

        

        public void AddFeature(IReFeature pFeature,List<VgObjectclass> classes)
        {
            bool isFirst = false;
            if (_features == null)
            {
                _features=new BindingList<IEntity>();
            }
            if (_features.Count == 0) isFirst = true;
            PrepareLayer();
            if (_features.FirstOrDefault(c => c.TableName == pFeature.TableName && c.ID == pFeature.ID) != null) return;
            VgObjectclass vgObjectclasses = classes.FirstOrDefault(c => c.Mc == pFeature.TableName);
            //if (vgObjectclasses != null)
            //{
            //    pFeature.TableChineseName = vgObjectclasses.Zwmc;
            //}
            _features.Add(pFeature);
          //  if(isFirst) FeatureBind();
            FlashGeometry(pFeature.Geometry);

           // lstFeatures.Items.Add(pFeature.FullLabelString);
        }
        private void FeatureBind()
        {
            if (_canMultiSelected)
            {
                chkLstFeatures.Visible = true;
                chkLstFeatures.DataSource = _features;
                chkLstFeatures.DisplayMember = "FullLabelString";
                chkLstFeatures.ValueMember = "ID";
                lstFeatures.DataSource = null;
                lstFeatures.Visible = false;
                btnSelectAll.Enabled = true;
                btnSelectReserve.Enabled = true;
                btnSelectUnAll.Enabled = true;
            }
            else
            {

                lstFeatures.Visible = true;
                lstFeatures.DataSource = _features;
                lstFeatures.DisplayMember = "FullLabelString";
                lstFeatures.ValueMember = "ID";
                chkLstFeatures.DataSource = null;
                chkLstFeatures.Visible = false;
                btnSelectAll.Enabled = false;
                btnSelectReserve.Enabled = false;
                btnSelectUnAll.Enabled = false;
            }
        }

        public void AddFeatures(List<IReFeature> pFeatureList, VgObjectclass oneclass)
        {
            bool isFirst = false;
            if (_features == null)
            {
                _features = new BindingList<IEntity>();
            }
            if (_features.Count == 0) isFirst = true;
            PrepareLayer();
            string oldTableName = "";
            VgObjectclass vgObjectclasses = null;
            foreach (var pFeature in pFeatureList)
            {
                _features.Add(pFeature);
                FlashGeometry(pFeature.Geometry);
            }
        }
        public void AddFeatures(List<IReFeature> pFeatureList, List<VgObjectclass> classes)
        {
            bool isFirst = false;
            if (_features == null)
            {
                _features = new BindingList<IEntity>();
            }
            if (_features.Count == 0) isFirst = true;
            PrepareLayer();
            string oldTableName = "";
            VgObjectclass vgObjectclasses = null;
            foreach (var pFeature in pFeatureList)
            {
                if(_features.FirstOrDefault(c => c.TableName == pFeature.TableName && c.ID == pFeature.ID) != null)
                continue;
                if (oldTableName != pFeature.TableName)
                {
                    vgObjectclasses = classes.FirstOrDefault(c => c.Mc == pFeature.TableName);
                }
                //if (vgObjectclasses != null)
                //{
                //    pFeature.TableChineseName = vgObjectclasses.Zwmc;
                //}
                _features.Add(pFeature);
                FlashGeometry(pFeature.Geometry);
                oldTableName = pFeature.TableName;
            }
          //  if (isFirst) FeatureBind();
        }

        public bool IsDraw
        {
            get { return _isDraw; }
            set { _isDraw = value; }
        }

        private void lstFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_canMultiSelected) return;
            if (_map == null) return;
            PrepareLayer();
            if (lstFeatures.SelectedIndex < 0) return;
            IReFeature pFeature = lstFeatures.SelectedItem as IReFeature;
            DrawSelectFeature(pFeature.Geometry);
        }

        private void chkLstFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_canMultiSelected) return;
            if (_map == null) return;
            PrepareLayer();
            foreach (var selectedItem in chkLstFeatures.CheckedItems)
            {
                IReFeature pFeature = selectedItem as IReFeature;
                DrawSelectFeature(pFeature.Geometry);
            }
            if (chkLstFeatures.SelectedIndex < 0) return;
            IReFeature pSelectFeature = chkLstFeatures.SelectedItem as IReFeature;
            DrawActiveFeature(pSelectFeature.Geometry);
        }

        public void DrawTempGeometry(IGeometry pGeometry)
        {
            PrepareLayer();
            Color color = _context.Config.RealEstateActivedColor;
            DrawGeometry(pGeometry, color);
        }

        private void FlashGeometry(IGeometry pGeometry)
        {
            Color color = Color.Yellow;
            DrawGeometry(pGeometry, color);
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
        private void DrawActiveFeature(IGeometry pGeometry)
        {
            Color color = _context.Config.RealEstateActivedColor;
            DrawGeometry(pGeometry, color);
        }
        private void DrawGeometry(IGeometry geometry,Color color, string labelString="",double rotation=0)
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
                        true, 1);
                }
                return;
            }
            else if (geometry.GeometryType == GeometryType.Point)
            {
                _map.Drawing.DrawPoint(_layerHandle,geometry.Points[0].X, geometry.Points[0].Y,12,color);
            }
            else if (geometry.GeometryType == GeometryType.TextPoint)
            {
                _map.Drawing.DrawLabel(_layerHandle,labelString, geometry.Points[0].X, geometry.Points[0].Y, rotation);
            }
        }

        public List<IReFeature> GetSelectedFeatures()
        {
            List<IReFeature> features = new List<IReFeature>();
            if (_canMultiSelected)
            {
                foreach (var feature in chkLstFeatures.CheckedItems)
                {
                    features.Add(feature as IReFeature);
                }
            }
            else
            {
                if (lstFeatures.SelectedIndex >= 0)
                {
                    features.Add(lstFeatures.SelectedItem as IReFeature);
                }
            }
            return features;
        }

        public bool HasSelected()
        {
            if (_canMultiSelected)
            {
                if (chkLstFeatures.CheckedItems.Count > 0) return true;
                else return false;
               
            }
            else
            {
                return lstFeatures.SelectedIndex < 0 ? false : true;
            }
          
        }

        public void ClearDrawing()
        {
            if (_layerHandle >= 0)
            {
                _context.Map.Drawing.RemoveLayer(_layerHandle);
            }
        }

        public void ClearList()
        {
            _features.Clear();
        }

        public void Redraw()
        {
            if (_map == null) return;
            PrepareLayer();
            if (_canMultiSelected == true)
            {
                foreach (var selectedItem in chkLstFeatures.CheckedItems)
                {
                    IReFeature pFeature = selectedItem as IReFeature;
                    DrawSelectFeature(pFeature.Geometry);
                }
                if (chkLstFeatures.SelectedIndex < 0) return;
                IReFeature pSelectFeature = chkLstFeatures.SelectedItem as IReFeature;
                DrawActiveFeature(pSelectFeature.Geometry);
            }
            else
            {
                foreach (var selectedItem in lstFeatures.Items)
                {
                    IReFeature pFeature = selectedItem as IReFeature;
                    DrawSelectFeature(pFeature.Geometry);
                }
                if (lstFeatures.SelectedIndex < 0) return;
                IReFeature pSelectFeature = lstFeatures.SelectedItem as IReFeature;
                DrawActiveFeature(pSelectFeature.Geometry);
            }
            
        }

        public bool IsCurrentSelectedIsChecked()
        {
            if (chkLstFeatures.SelectedIndex < 0) return false;
            if (chkLstFeatures.GetItemChecked(chkLstFeatures.SelectedIndex) == false) return false;
            return true;
        }

        public IReFeature GetCurrentSelectedAndCheckedFeature()
        {
            if (chkLstFeatures.SelectedIndex < 0) return null;
            if (chkLstFeatures.GetItemChecked(chkLstFeatures.SelectedIndex) == false) return null;
            return chkLstFeatures.SelectedItem as IReFeature;
        }

        public List<IGeometry> GetSelectedGeometries()
        {
            List < IGeometry > geometries=new List<IGeometry>();
            foreach (IReFeature item in chkLstFeatures.CheckedItems)
            {
                geometries.Add(item.Geometry);
            }
            return geometries;
        }
    }
}
