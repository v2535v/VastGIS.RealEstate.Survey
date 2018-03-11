using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manina.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.DataControls;
using VastGIS.Plugins.RealEstate.Events;
using VastGIS.Plugins.RealEstate.Helpers;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;
using SortOrder = System.Windows.Forms.SortOrder;

namespace VastGIS.Plugins.RealEstate.Forms
{
	
    public partial class frmAssignPhoto:Form,IEditForm
    {	
        #region 变量
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private List<VgObjectclass> _classes;
        private VgObjectclass _currentClass;
        private List<VgAttachment> _attachments;
        private IReFeature _feature;
        #endregion
        
        public frmAssignPhoto(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
             _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1 ").ToList();            
            _classes =new List<VgObjectclass>();
            _classes.Add( classes.First(c=>c.Mc=="ZDJBXX"));
            _classes.Add(classes.First(c => c.Mc == "ZRZ"));
            _classes.Add(classes.First(c => c.Mc == "JZD"));
            _classes.Add(classes.First(c => c.Mc == "JZX"));
            cmbObjectClasses.DataSource = _classes;
            cmbObjectClasses.DisplayMember = "Zwmc";
            cmbObjectClasses.ValueMember = "Mc";
            cmbObjectClasses.SelectedIndex = 0;
            chkSelectFeature.Checked = true;
            imageListView1.AllowDuplicateFileNames = true;
            imageListView1.SetRenderer(new ImageListViewRenderers.DefaultRenderer());
            imageListView1.SortColumn = 0;
            imageListView1.SortOrder =Manina.Windows.Forms.SortOrder.AscendingNatural;
            Assembly assembly = Assembly.GetAssembly(typeof(ImageListView));
            string cacheDir = Path.Combine(
                Path.GetDirectoryName(new Uri(assembly.GetName().CodeBase).LocalPath),
                "Cache"
            );
            if (!Directory.Exists(cacheDir))
                Directory.CreateDirectory(cacheDir);
            imageListView1.PersistentCacheDirectory = cacheDir;
            imageListView1.Columns.Add(ColumnType.Name);
            imageListView1.Columns.Add(ColumnType.Artist);
            imageListView1.Columns.Add(ColumnType.FolderName);
        }

       

        private void btnCancle_Click(object sender, EventArgs e)
        {            
            DialogResult = DialogResult.Cancel;
            _context.CurrentTool = null;
        }


        public void SetQueryPoint(double dx, double dy)
        {
            if (_currentClass == null)
            {
                lblInfo.Text = "先选择编辑图层!";
                return;
            }
            if (chkSelectFeature.Checked == false) return;
            List<IReFeature> features = _database.SystemService.FindFeatures(_currentClass, dx, dy);
            if (features != null && features.Count > 0)
            {
                _feature = features[0];
                LoadFeature();
            }
        }

        public void ClearDrawing()
        {
            _context.Map.Drawing.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_currentClass == null)
            {
                lblInfo.Text = "先选择编辑图层!";
                return;
            }

            if (_feature == null)
            {
                lblInfo.Text = "先选择编辑要素!";
                return;
            }

            frmCameraCapture frm = new frmCameraCapture(_context, null);
            DialogResult result = frm.ShowDialog();
            if (result != DialogResult.OK) return;
            VgAttachment attachment = frm.GetAttachment();
            attachment.WxWydm = ((IGlobalEntity)_feature).WxWydm;
            _database.SystemService.SaveVgAttachment(attachment);
            _attachments.Add(attachment);
            string fileName = _database.GetAbsolutePath(attachment.Fjlj);
            imageListView1.Items.Add(fileName);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (_currentClass == null)
            {
                lblInfo.Text = "先选择编辑图层!";
                return;
            }
        }

        private void cmbObjectClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentClass=cmbObjectClasses.SelectedItem as VgObjectclass;
            _feature = null;
            LoadFeature();
        }

        private void LoadFeature()
        {
            _attachments = null;
            imageListView1.Items.Clear();
            if (_feature == null) return;
            if (_attachments == null)
            {
                _attachments=new List<VgAttachment>();
            }
            List<VgAttachment> attachments = _database.SystemService.GetVgAttachmentsByWydm(((IGlobalEntity)_feature).WxWydm.ToString()).ToList();
            imageListView1.Items.Clear();
            imageListView1.SuspendLayout();
            int i = 0;
            foreach (var attachment in attachments)
            {
                AttachmentFileType curFileType = attachment.FileType;
                if (curFileType == AttachmentFileType.Image)
                {
                    string fileName = _database.GetAbsolutePath(attachment.Fjlj);
                    imageListView1.Items.Add(fileName);
                    if (i == 1) imageListView1.Items[imageListView1.Items.Count - 1].Enabled = false;
                    i++;
                    if (i == 3) i = 0;
                    _attachments.Add(attachment);
                }
              
            }
            imageListView1.ResumeLayout();
        }
    }
}