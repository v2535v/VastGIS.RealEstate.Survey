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

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmSelectFeature : Form,IEditForm
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclasses> _classes;

        public frmSelectFeature()
        {
            InitializeComponent();
        }

        public frmSelectFeature(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclasses> classes = _database.SystemService.GetVgObjectclassess(" Identify = 1 And DXLX=1").ToList();
            ucSelectLayer1.SetClasses(classes);
            _classes = classes;
            ucSelectLayer1.Label = "选择图层";
            ucSelectLayer1.SingleSelect = false;
            ucSelectLayer1.GeometryType =GeometryType.None;
            ucFeatureLists1.CanMultiSelect = true;
            ucFeatureLists1.BindContext(context);
        }

        public void SetQueryPoint(double x, double y)
        {
            if (ucSelectLayer1.SelectedClasses == null || ucSelectLayer1.SelectedClasses.Count == 0)
            {
                lblInfo.Text = "请设置选择图层";
                return;
            }

            List<SearchFeature> features = _database.SystemService.FindRecords(ucSelectLayer1.SelectedClasses, x, y);
            if (features != null && features.Count > 0)
            { ucFeatureLists1.AddFeatures(features, ucSelectLayer1.SelectedClasses); }

            //IEnvelope pEnvelope=new Envelope(x-2,x+2,y-2,y+2);
            //foreach (VgObjectclasses objectclasses in ucSelectLayer1.SelectedClasses)
            //{
            //    ILayer pLayer = _context.Map.Layers.FirstOrDefault(c => c.Name == objectclasses.Zwmc);
            //    IEnumerable<IFeature> selectFeatures=pLayer.FeatureSet.SelectShapes(pEnvelope, 10, MapSelectionMode.Intersection);
            //    if (selectFeatures != null)
            //    {
            //        int[] ids = selectFeatures.Select(c => c.Index).ToArray();
            //        List<SearchFeature> searchFeatures = _database.SystemService.FindRecords(objectclasses, ids);
            //        ucFeatureLists1.AddFeatures(searchFeatures, ucSelectLayer1.SelectedClasses);
            //    }
            //}
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ucFeatureLists1.ClearDrawing();
            DialogResult = DialogResult.Cancel;
            
            _context.CurrentTool = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<SearchFeature> features = ucFeatureLists1.GetSelectedFeatures();
            if (features == null || features.Count == 0)
            {
                lblInfo.Text = "请先选择要素!";
                return;
            }
            string oldLayerName = "";
            ILayer pLayer = null;
            foreach (SearchFeature feature in features)
            {
                string layerName = feature.TableName;
                if (oldLayerName != layerName)
                {
                    string zwmc = _classes.First(c => c.Mc == layerName).Zwmc;
                    pLayer = _context.Map.Layers.FirstOrDefault(c => c.Name == zwmc);
                }
                if (pLayer == null) continue;
                pLayer.FeatureSet.SelectedIndices.Add((int)feature.ID);

                oldLayerName = layerName;
            }
        }
    }
}
