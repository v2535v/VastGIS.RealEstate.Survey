using System;
using System.Collections;
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
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmSelectFeature : Form,IEditForm
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;

        public frmSelectFeature()
        {
            InitializeComponent();
        }

        public frmSelectFeature(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" Identify = 1 And DXLX=1").ToList();
            ucSelectLayer1.SetClasses(classes);
            _classes = classes;
            ucSelectLayer1.Label = "选择图层";
            ucSelectLayer1.SingleSelect = false;
            ucSelectLayer1.GeometryType =GeometryType.None;
            ucFeatureLists1.CanMultiSelect = true;
            ucFeatureLists1.BindContext(context);
            ucSelectLayer1.ucSelectedClassChanged += UcSelectLayer1_ucSelectedClassChanged;
        }
        public void ClearDrawing()
        {
            _context.Map.Drawing.Clear();
        }
        private void UcSelectLayer1_ucSelectedClassChanged(object sender, Events.ObjectClassEventArgs e)
        {
            ucFeatureLists1.ClearList();
        }

        public void SetQueryPoint(double x, double y)
        {
            if (ucSelectLayer1.SelectedClasses == null || ucSelectLayer1.SelectedClasses.Count == 0)
            {
                lblInfo.Text = "请设置选择图层";
                return;
            }

            List<IReFeature> features = _database.SystemService.FindFeatures(ucSelectLayer1.SelectedClasses, x, y);
            if (features != null && features.Count > 0)
            { ucFeatureLists1.AddFeatures(features, ucSelectLayer1.SelectedClasses); }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ucFeatureLists1.ClearDrawing();
            DialogResult = DialogResult.Cancel;
            
            _context.CurrentTool = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<IReFeature> features = ucFeatureLists1.GetSelectedFeatures();
            if (features == null || features.Count == 0)
            {
                lblInfo.Text = "请先选择要素!";
                return;
            }
            string oldLayerName = "";
            ILayer pLayer = null;
            foreach (IReFeature feature in features)
            {
                string layerName = feature.TableName;
                if (oldLayerName != layerName)
                {
                    string zwmc = _classes.First(c => c.Mc == layerName).Zwmc;
                    pLayer = _context.Map.Layers.FirstOrDefault(c => c.Name == zwmc);
                }
                if (pLayer == null) continue;
                int[] result = null;
                string errorString = string.Empty;
                bool success = pLayer.FeatureSet.Table.Query("ID=" + feature.ID.ToString(), out result, out errorString);
                if(result !=null )
                    pLayer.FeatureSet.FeatureSelected(result[0], true);
                //pLayer.FeatureSet.SelectedIndices.Add((int)feature.ID);
                
                oldLayerName = layerName;
            }
            _context.Map.Redraw(RedrawType.All);
        }
    }
}
