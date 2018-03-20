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
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmCopyZrzByZd : Form, IEditForm
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        //private List<VgObjectclass> _editableclasses;
        private List<VgObjectclass> _sourceclasses;

        private MapSelectionMode _mapSelectionMode;
        private bool _isSingle;

        private VgObjectclass _zdObjectclass;
        private VgObjectclass _jmdObjectclass;
        private VgObjectclass _zrzObjectclass;

        //private List<IReFeature> _jmdFeatures;

        public frmCopyZrzByZd(IAppContext context, RealEstateEditor plugin)
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
            _sourceclasses = classes;
            _zdObjectclass = classes.FirstOrDefault(c => c.Mc == "ZDJBXX");
            _jmdObjectclass = classes.FirstOrDefault(c => c.Mc == "DXTJMDM");
            _zrzObjectclass = classes.FirstOrDefault(c => c.Mc == "ZRZ");
            //_jmdFeatures = new List<IReFeature>();
            //selTargetLayer.Label = "目标图层";
            //selTargetLayer.SetClasses(classes);
            //selTargetLayer.SingleSelect = true;
            //VgObjectclass currentObjectclass = LayerHelper.GetVgObjectClassByLegend(classes, _context.Legend);
            //if (_plugin.Config.EditingClass == null)
            //{
            //    selTargetLayer.GeometryType = GeometryType.None;
            //    selTargetLayer.SelectedClass = currentObjectclass;
            //}
            //else
            //{
            //    selTargetLayer.GeometryType = (GeometryType)_plugin.Config.EditingClass.Txlx;
            //    selTargetLayer.SelectedClass = _plugin.Config.EditingClass;
            //}
            //selTargetLayer.LimitedGeometryType = GeometryType.None;
            //_editableclasses = classes;

            //List<VgObjectclass> sourceclasses = _database.SystemService.GetVgObjectclasses(" IDENTIFY = 1 And DXLX=1").ToList();
            //selSourceLayer.Label = "来源图层";
            //selSourceLayer.SetClasses(sourceclasses);
            //selSourceLayer.SingleSelect = false;
            //if (_plugin.Config.EditingClass == null)
            //{
            //    selSourceLayer.GeometryType = GeometryType.None;
            //    if (currentObjectclass != null)
            //    {
            //        selSourceLayer.GeometryType = (GeometryType)currentObjectclass.Txlx;
            //    }
            //}
            //else
            //{
            //    selSourceLayer.LimitedGeometryType = (GeometryType)_plugin.Config.EditingClass.Txlx;
            //    if (_plugin.Config.SelectableClasses != null)
            //    {
            //        selSourceLayer.SelectedClasses = _plugin.Config.SelectableClasses
            //            .Where(c => c.Txlx == _plugin.Config.EditingClass.Txlx).ToList();
            //    }
            //}
            //_sourceclasses = sourceclasses;

            //selTargetLayer.ucSelectedClassChanged += SelTargetLayer_ucSelectedClassChanged;
            //selSourceLayer.ucSelectedClassChanged += SelSourceLayer_ucSelectedClassChanged;

            chkIsMoving.DataBindings.Add("Checked", _plugin.Config, "CopyIsMoving");
            ucFeatureLists1.BindContext(_context);
            ucFeatureLists1.CanMultiSelect = true;
        }

        //private void SelTargetLayer_ucSelectedClassChanged(object sender, ObjectClassEventArgs e)
        //{
        //    ucFeatureLists1.ClearList();
        //    selSourceLayer.LimitedGeometryType = selTargetLayer.GeometryType;
        //    _plugin.Config.EditingClass = selTargetLayer.SelectedClass;
        //    selSourceLayer.SelectedClasses = _plugin.Config.SelectableClasses;
        //}

        //private void SelSourceLayer_ucSelectedClassChanged(object sender, ObjectClassEventArgs e)
        //{
        //    ucFeatureLists1.ClearList();
        //    _plugin.Config.SelectableClasses = selSourceLayer.SelectedClasses;
        //}

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ucFeatureLists1.ClearDrawing();
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
            //_jmdFeatures.Clear();
        }


        public void SetQueryPoint(double dx, double dy)
        {
            if (_zdObjectclass == null) return;
            if (_zrzObjectclass == null) return;
            if (_jmdObjectclass == null) return;
            
            List<IReFeature> features = _database.SystemService.FindFeatures(_zdObjectclass, dx, dy);

            if (features != null && features.Count > 0)
            {
                foreach (IReFeature reFeature in features)
                {
                    List<IReFeature> jmdFeatures = _database.SystemService.FindFeatures(_jmdObjectclass,
                        reFeature.Geometry);
                    
                    ucFeatureLists1.AddFeatures(jmdFeatures, _sourceclasses);

                }
            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ucFeatureLists1.HasSelected() == false)
            {
                MessageService.Current.Warn("请先选择要拷贝的元素!");
                return;
            }
            ucFeatureLists1.Redraw();
            string actionMsg = chkIsMoving.Checked
                                   ? string.Format("你确认拷贝选中要素到{0}并删除原有要素?", _zrzObjectclass.Zwmc)
                                   : string.Format("你确认拷贝选中要素到{0}?", _zrzObjectclass.Zwmc);
            if (MessageService.Current.Ask(actionMsg) == false) return;
            _database.SystemService.CopyEntities(_zrzObjectclass, ucFeatureLists1.GetSelectedFeatures().ToList<IEntity>(),
                 chkIsMoving.Checked);
            ucFeatureLists1.ClearList();
            //_context.Map.Redraw(RedrawType.All);
        }

        private void chkIsMoving_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = chkIsMoving.Checked ? "移动要素" : "拷贝要素";
            btnOK.Text = chkIsMoving.Checked ? "移动要素" : "拷贝要素";
        }

        public void ClearDrawing()
        {
            _context.Map.Drawing.Clear();
        }
    }

}