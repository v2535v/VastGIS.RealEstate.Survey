using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucAttachmentList : UserControl
    {
        private IMuteMap _map;
        private IEntity _entity;
        private IAppContext _context;
        private int _layerHandle = -1;
        private BindingList<VgAttachment> _attachments;
        private IREDatabase _database;
        public ucAttachmentList()
        {
            InitializeComponent();
            _entity = null;
            InitStatus();
        }

        private void ucAttachmentList_Resize(object sender, EventArgs e)
        {
            int btnWidth = (this.Width - 30) / 6;
            btnNewPhoto.Width = btnWidth;
            btnNewVideo.Left = btnNewPhoto.Width + btnNewPhoto.Left;
            btnNewVideo.Width = btnWidth;
            btnNewAudio.Left = btnNewVideo.Width + btnNewVideo.Left;
            btnNewAudio.Width = btnWidth;
            btnView.Left = btnNewAudio.Width + btnNewAudio.Left;
            btnView.Width = btnWidth;
            btnDelete.Left = btnView.Width + btnView.Left;
            btnDelete.Width = btnWidth;
            btnSaveAs.Left = btnDelete.Width + btnDelete.Left;
            btnSaveAs.Width = btnWidth;
           

            gridAttachments.Height =this.Height - 57;
            this.gridAttachments.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridAttachments.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            //to set proportional column resizing to grid.
            this.gridAttachments.AllowProportionalColumnSizing = true;
            this.gridAttachments.TopLevelGroupOptions.ShowCaption = false;
            //to hide Caption.
            this.gridAttachments.TopLevelGroupOptions.ShowCaption = false;
            this.gridAttachments.ChildGroupOptions.ShowCaption = false;
            this.gridAttachments.NestedTableGroupOptions.ShowCaption = false;

            //to disable AddNewRecord.
            this.gridAttachments.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridAttachments.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridAttachments.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridAttachments.WantTabKey = false;
        }

        public void InitGrid()
        {
            if (_entity == null)
            {
                this.gridAttachments.DataSource = null;
                return;
            }
            if (_attachments == null)
            {
                _attachments=new BindingList<VgAttachment>();
            }
            this.gridAttachments.DataSource = _attachments;

            this.gridAttachments.AllowProportionalColumnSizing = false;

            //To change the HeaderText.
            this.gridAttachments.TableDescriptor.Columns["ID"].HeaderText = "序号";
            this.gridAttachments.TableDescriptor.Columns["ID"].Width = 40;
            this.gridAttachments.TableDescriptor.Columns["Fjmc"].HeaderText = "名称";
            this.gridAttachments.TableDescriptor.Columns["Fjmc"].Width = 120;
            this.gridAttachments.TableDescriptor.Columns["Fjlx"].HeaderText = "类型";
            this.gridAttachments.TableDescriptor.Columns["Fjlx"].Width = 80;
            this.gridAttachments.TableDescriptor.Columns["Hqsj"].HeaderText = "获取时间";
            this.gridAttachments.TableDescriptor.Columns["Hqsj"].Width = 80;
            this.gridAttachments.TableDescriptor.Columns["Fjlj"].HeaderText = "路径";
            this.gridAttachments.TableDescriptor.Columns["Fjlj"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["Fjsm"].HeaderText = "说明";
            this.gridAttachments.TableDescriptor.Columns["Fjsm"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["ObjectName"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["TableName"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["EntityName"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["SimpleLabelString"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["FullLabelString"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["WxWydm"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["DatabaseID"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["Flags"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["Xgr"].Width = 0;
            this.gridAttachments.TableDescriptor.Columns["Xgsj"].Width = 0;
        }

        public void BindContext(IAppContext context)
        {
            _context = context;
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            BindMap(_context.Map);
        }

        public void BindMap(IMuteMap pMap)
        {
            _map = pMap;
            _map.Drawing.Clear();
        }

        private void InitStatus()
        {
            if (_attachments == null)
            {
                _attachments = new BindingList<VgAttachment>();
            }
            gridAttachments.Enabled = _entity != null;
            btnDelete.Enabled = gridAttachments.Table != null && gridAttachments.Table.CurrentRecord != null;
            btnNewPhoto.Enabled = _entity != null;
            btnSaveAs.Enabled = gridAttachments.Table != null && gridAttachments.Table.CurrentRecord != null;
            btnView.Enabled = gridAttachments.Table != null && gridAttachments.Table.CurrentRecord != null;
            gridAttachments.DataSource = _attachments;
            btnNewAudio.Enabled = btnNewPhoto.Enabled;
            btnNewVideo.Enabled = btnNewPhoto.Enabled;
        }

        public void SetFeature(IReFeature pFeature)
        {
            _entity = pFeature;
            LoadEntity();
        }

        private void LoadEntity()
        {
            _attachments.Clear();
            if (((IGlobalEntity)_entity).WxWydm == null)
            {
                _entity = null;
                InitGrid();
                InitStatus();
                return;
            }
            List<VgAttachment> attachments = _database.SystemService.GetVgAttachmentsByWydm(((IGlobalEntity)_entity).WxWydm.ToString()).ToList();
            foreach (var attachment in attachments)
            {
                _attachments.Add(attachment);
            }
            InitGrid();
            InitStatus();
        }

        public void LinkObject(IEntity entity)
        {
            if (entity is IGlobalEntity)
            {
                _entity = entity;
                LoadEntity();
            }
        }
        private void gridAttachments_SelectedRecordsChanged(object sender, Syncfusion.Grouping.SelectedRecordsChangedEventArgs e)
        {
            InitStatus();
        }

       

        private void btnNewPhoto_Click(object sender, EventArgs e)
        {
            frmCameraCapture frm=new frmCameraCapture();
            frm.ShowDialog();
        }
    }
}
