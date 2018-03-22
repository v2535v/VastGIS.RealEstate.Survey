using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmAssignEditFeature : Form, IEditForm2
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _editLayers;
        public frmAssignEditFeature(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> objectclasses = _database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1").ToList();
            _editLayers = objectclasses.Where(c => _context.Config.EditLayers.Contains(c.Mc)).ToList();
            ucFeatureListSingle1.BindContext(_context);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IReFeature feature = this.ucFeatureListSingle1.GetCurrentFeature();
            if (feature == null)
                return;
            EditFeature(feature);
        }

        private void EditFeature(IReFeature feature)
        {
            VgObjectclass vgObjectclass = _editLayers.FirstOrDefault(c => c.Mc == feature.TableName);
            if (vgObjectclass == null)
                return;
            if (string.IsNullOrEmpty(vgObjectclass.Bjct))
            {
                MessageBox.Show(@"未能找到该对象的属性编辑窗口!");
                return;
            }
            _plugin.LoadAttributeForm(feature.ObjectName, vgObjectclass.Bjct, feature.ID);
            this.Close();
        }

        public void SetQueryPoint(double x, double y)
        {
            if (_editLayers == null || _editLayers.Count == 0)
            {
                MessageBox.Show(@"未设置编辑图层");
                return;
            }

            List<IReFeature> features = _database.SystemService.FindFeatures(_editLayers, x, y);
            if (features != null && features.Count > 0)
            {
                if (features.Count == 1)
                {
                    EditFeature(features[0]);
                }
                else
                {
                    ucFeatureListSingle1.AddFeatures(features);
                    OnShowEvent();
                }
            }
        }

        public void ClearDrawing()
        {
            _context.Map.Drawing.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAssignEditFeature_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearDrawing();
        }

        public event EventHandler ShowEvent;

        protected virtual void OnShowEvent()
        {
            ShowEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
