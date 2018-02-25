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
    public partial class frmNewFeature : Form, IEditForm
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;
        public frmNewFeature(IAppContext context, RealEstateEditor plugin)
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
            ucSelectLayer1.SetClasses(classes);
            _classes = classes;
            ucSelectLayer1.Label = "编辑图层";
            ucSelectLayer1.SingleSelect = true;
            ucSelectLayer1.GeometryType = GeometryType.None;
            ucCoordinateList1.BindContext(context);
            ucCoordinateList1.InitGrid();
            snapCheckbox1.BindPlugin(_plugin);
            VgObjectclass currentObjectclass = LayerHelper.GetVgObjectClassByLegend(classes, _context.Legend);
            if (_plugin.Config.EditingClass == null)
            {
                ucSelectLayer1.GeometryType = GeometryType.None;
                ucSelectLayer1.SelectedClass = currentObjectclass;
            }
            else
            {
                ucSelectLayer1.SetCurrentClass(_plugin.Config.EditingClass);
            }
            
            ucCoordinateList1.GeometryType = ucSelectLayer1.GeometryType;
            ucSelectLayer1.ucSelectedClassChanged += UcSelectLayer1_ucSelectedClassChanged;
        }

        private void UcSelectLayer1_ucSelectedClassChanged(object sender, ObjectClassEventArgs e)
        {
            ucCoordinateList1.GeometryType =(GeometryType) ucSelectLayer1.SelectedClass.Txlx;
            _plugin.Config.EditingClass = ucSelectLayer1.SelectedClass;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ucCoordinateList1.ClearDrawing();
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
        }

        public void SetQueryPoint(double dx, double dy)
        {
            if (ucSelectLayer1.SelectedClass == null )
            {
                lblInfo.Text = "请设置编辑图层";
                return;
            }
            double x2 = 0.0;
            double y2 = 0.0;
            if (_plugin.Config.IsSnapping)
            {
               bool pFind = _context.Map.FindSnapPoint(_context.Config.MouseTolerance, dx, dy, ref x2, ref y2);
                if (pFind)
                {
                    ucCoordinateList1.AddPoint(x2, y2);
                }
                else
                {
                    _context.Map.PixelToProj(dx,dy,out x2,out y2);
                    ucCoordinateList1.AddPoint(x2, y2);
                }
            }
            else
            {
                _context.Map.PixelToProj(dx, dy, out x2, out y2);
                ucCoordinateList1.AddPoint(x2, y2);
            }
             

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ucSelectLayer1.SelectedClass == null)
            {
                lblInfo.Text = "选择编辑图层!";
                return;
            }
            IGeometry geometry = ucCoordinateList1.GetGeometry();
            if (geometry == null)
            {
                lblInfo.Text = "请输入数据!";
                return;
            }
           
            
            if (ucSelectLayer1.SelectedClass.Txlx != 1)
            {
                IReFeature feature = _database.SystemService.CreateEntity(ucSelectLayer1.SelectedClass) as IReFeature;
                feature.Wkt = geometry.ExportToWkt();
               bool retVal= _database.SystemService.Save(feature);
                if (retVal && feature.ID > 0)
                {
                    ucCoordinateList1.ClearList();
                }
            }
            else
            {
                List<IEntity> inFeatures = new List<IEntity>();
                for (int i = 0; i < geometry.Points.Count; i++)
                {
                    IReFeature feature = _database.SystemService.CreateEntity(ucSelectLayer1.SelectedClass) as IReFeature;
                    feature.Wkt = string.Format("POINT({0} {1})", geometry.Points[i].X, geometry.Points[i].Y);
                    inFeatures.Add(feature);
                }
               _database.SystemService.Save(inFeatures);
                ucCoordinateList1.ClearList();
            }
        }

    }
}
