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
using VastGIS.Plugins.RealEstate.DataControls;
using VastGIS.Plugins.RealEstate.Events;
using VastGIS.Plugins.RealEstate.Helpers;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmEditFeature : Form, IEditForm
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;
        private VgObjectclass _jmdObjectclass;
        private IDictionary<long, IReFeature> _jmdReFeatures;

        public frmEditFeature(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1").ToList();
            _classes = classes;
            ucSelectLayer1.SetClasses(classes);
            _classes = classes;
            ucSelectLayer1.Label = "选择图层";
            ucSelectLayer1.SingleSelect = true;
            VgObjectclass currentObjectclass = LayerHelper.GetVgObjectClassByLegend(classes, _context.Legend);
            if (_plugin.Config.EditingClass == null)
            {
                ucSelectLayer1.GeometryType = GeometryType.None;
                ucSelectLayer1.SelectedClass = currentObjectclass;
            }
            else
            {
                ucSelectLayer1.GeometryType = (GeometryType)_plugin.Config.EditingClass.Txlx;
                ucSelectLayer1.SelectedClass = _plugin.Config.EditingClass;
            }
            ucSelectLayer1.GeometryType = GeometryType.None;
            ucFeatureLists1.CanMultiSelect = false;
            ucFeatureLists1.BindContext(context);
            ucSelectLayer1.ucSelectedClassChanged += UcSelectLayer1_ucSelectedClassChanged;
            _jmdObjectclass = _classes.FirstOrDefault(c => c.Mc == "DXTJMDM");
            _jmdReFeatures = new Dictionary<long, IReFeature>();
        }
        private void UcSelectLayer1_ucSelectedClassChanged(object sender, Events.ObjectClassEventArgs e)
        {
            _plugin.Config.EditingClass = ucSelectLayer1.SelectedClass;
            ucFeatureLists1.ClearList();
            _jmdReFeatures.Clear();
        }


        private void btnCancle_Click(object sender, EventArgs e)
        {
            ucFeatureLists1.ClearDrawing();
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
            _jmdReFeatures.Clear();
        }
        public void ClearDrawing()
        {
            _context.Map.Drawing.Clear();
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
            {
                ucFeatureLists1.AddFeatures(features, ucSelectLayer1.SelectedClasses);

                if (ucSelectLayer1.SelectedClass.Mc == "ZRZ")
                {
                    List<IReFeature> jmdFeatures = _database.SystemService.FindFeatures(_jmdObjectclass, x, y);
                    foreach (IReFeature reFeature in features)
                    {
                        _jmdReFeatures.Add(reFeature.ID, jmdFeatures.First());
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<IReFeature> features = ucFeatureLists1.GetSelectedFeatures();
            if (features == null || features.Count == 0 || features.Count > 1)
            {
                lblInfo.Text = "请先选择准备编辑的一个要素!";
                return;
            }
            long id = features[0].ID;
            //获得表对象
            //VgClassdetail detail = _database.SystemService.GetVgClassdetailByTableName(features[0].TableName);
            //if (detail == null)
            //{
            //    lblInfo.Text = "未能找到该对象的属性编辑窗口!";
            //    return;
            //}

            VgObjectclass objectclass = ucSelectLayer1.SelectedClass;
            if (string.IsNullOrEmpty(objectclass.Bjct))
            {
                lblInfo.Text = "未能找到该对象的属性编辑窗口!";
                return;
            }

            if (_jmdReFeatures.ContainsKey(id))
            {
                IReFeature jmdFeature = _jmdReFeatures[id];
                Dxtjmdm dxtjmdm = jmdFeature as Dxtjmdm;
                Zrz zrz = features[0] as Zrz;
                long fsxx;
                bool isLong = long.TryParse(dxtjmdm.Fsxx1, out fsxx);
                if (zrz.Zcs == 0)
                    zrz.Zcs = isLong ? fsxx : 0;
                if (zrz.Dscs == 0)
                    zrz.Dscs = isLong ? fsxx : 0;
                _database.ZdService.SaveZrz(zrz);
            }
            _plugin.LoadAttributeForm(features[0].ObjectName, objectclass.Bjct, features[0].ID);
        }
    }

}