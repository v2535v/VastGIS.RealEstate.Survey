using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using netDxf.Entities;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Attribute;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Viewer;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
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
        private List<VgDictionary> _typeDict;
        public ucAttachmentList()
        {
            InitializeComponent();
            _entity = null;
            InitStatus();
            _attachments=new BindingList<VgAttachment>();
            InitGrid();
        }

        private void ucAttachmentList_Resize(object sender, EventArgs e)
        {
            //int btnWidth = (this.Width - 30) / 8;
            //btnNewPhoto.Width = btnWidth;
            //btnNewVideo.Left = btnNewPhoto.Width + btnNewPhoto.Left;
            //btnNewVideo.Width = btnWidth;
            //btnNewAudio.Left = btnNewVideo.Width + btnNewVideo.Left;
            //btnNewAudio.Width = btnWidth;
            //btnUpload.Left = btnNewAudio.Width + btnNewAudio.Left;
            //btnUpload.Width = btnWidth;
            //btnView.Left = btnUpload.Width + btnUpload.Left;
            //btnView.Width = btnWidth;
            //btnDelete.Left = btnView.Width + btnView.Left;
            //btnDelete.Width = btnWidth;
            //btnAttribute.Left = btnDelete.Width + btnDelete.Left;
            //btnAttribute.Width = btnWidth;
            //btnSaveAs.Left = btnAttribute.Width + btnAttribute.Left;
            //btnSaveAs.Width = btnWidth;

            //gridAttachments.Height =this.Height - 57;
            
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
            _typeDict = _database.DomainService.GetDictionaryByName("FJLXZD");
            DataTable typeTable = new DataTable();
            DataColumn column = typeTable.Columns.Add("Zdz", typeof(string));
            typeTable.Columns.Add("Zdsm", typeof(string));
            foreach (var dict in _typeDict)
            {
                DataRow row = typeTable.NewRow();
                row["Zdz"] = dict.Zdz;
                row["Zdsm"] = dict.Zdsm;
                typeTable.Rows.Add(row);
            }
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

            this.gridAttachments.TableDescriptor.Relations.Clear();
            this.gridAttachments.DataSource = _attachments;
            this.gridAttachments.AllowProportionalColumnSizing = false;
            GridTableDescriptor mainTd = gridAttachments.TableDescriptor;
            this.gridAttachments.Engine.SourceListSet.Add("AttachmentTypes", typeTable.DefaultView);
            GridRelationDescriptor typesRd = new GridRelationDescriptor();
            typesRd.Name = "Fjlx";
            typesRd.RelationKind = RelationKind.ForeignKeyReference;
            typesRd.ChildTableName = "AttachmentTypes";
            typesRd.RelationKeys.Add("Fjlx", "Zdz");
            typesRd.ChildTableDescriptor.SortedColumns.Add("Zdz");
            typesRd.ChildTableDescriptor.AllowEdit = false;
            typesRd.ChildTableDescriptor.AllowNew = false;  // Make pencil icon disappear, users can't modify states.
            mainTd.Relations.Add(typesRd);


            //To change the HeaderText.
           mainTd.Columns["ID"].HeaderText = "序号";
           mainTd.Columns["ID"].Width = 40;
           mainTd.Columns["Fjmc"].HeaderText = "名称";
           mainTd.Columns["Fjmc"].Width = 120;
           mainTd.Columns["Fjlx_Zdsm"].HeaderText = "类型";
           mainTd.Columns["Fjlx_Zdsm"].Width = 80;
           mainTd.Columns["Hqsj"].HeaderText = "获取时间";
           mainTd.Columns["Hqsj"].Width = 80;
           mainTd.Columns["Fjlj"].HeaderText = "路径";
           mainTd.Columns["Fjlj"].Width = 0;
           mainTd.Columns["Fjsm"].HeaderText = "说明";
           mainTd.Columns["Fjsm"].Width = 0;
           mainTd.Columns["ObjectName"].Width = 0;
           mainTd.Columns["TableName"].Width = 0;
           mainTd.Columns["EntityName"].Width = 0;
           mainTd.Columns["SimpleLabelString"].Width = 0;
           mainTd.Columns["FullLabelString"].Width = 0;
           mainTd.Columns["WxWydm"].Width = 0;
           mainTd.Columns["DatabaseID"].Width = 0;
           mainTd.Columns["Flags"].Width = 0;
           mainTd.Columns["Xgr"].Width = 0;
           mainTd.Columns["Xgsj"].Width = 0;
           mainTd.Columns["HasFlag"].Width = 0;
           mainTd.Columns["HasGlobal"].Width = 0;
           mainTd.Columns["HasYsdm"].Width = 0;
           mainTd.Columns["HasSurvey"].Width = 0;
           mainTd.Columns["HasGeometry"].Width = 0;
           mainTd.Columns["GeometryType"].Width = 0;
            mainTd.Columns["FileType"].Width = 0;
            mainTd.Columns["NoCopyName_Length"].Width = 0;
            mainTd.Columns["LayerName"].Width = 0;

            this.gridAttachments.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            //Used for disabling Caption
            this.gridAttachments.TopLevelGroupOptions.ShowCaption = false;
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridAttachments.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridAttachments.Table.DefaultCaptionRowHeight = 25;
            this.gridAttachments.Table.DefaultColumnHeaderRowHeight = 30;
            this.gridAttachments.Table.DefaultRecordRowHeight = 22;
            this.gridAttachments.AllowProportionalColumnSizing = true;
            //GridColor settings
            this.gridAttachments.TableDescriptor.AllowNew = false;
            this.gridAttachments.TableDescriptor.AllowEdit = false;
            this.gridAttachments.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridAttachments.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridAttachments.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridAttachments.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridAttachments.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridAttachments.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridAttachments.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridAttachments.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridAttachments.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridAttachments.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridAttachments.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridAttachments.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridAttachments.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridAttachments.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridAttachments.TableDescriptor.TableOptions.RecordRowHeight = 20;

            //Navigate to other control using tabkey navigation
            this.gridAttachments.WantTabKey = false;

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
            frmCameraCapture frm=new frmCameraCapture(_context,null);
            DialogResult result=frm.ShowDialog();
            if (result != DialogResult.OK) return;
            VgAttachment attachment= frm.GetAttachment();
            attachment.WxWydm = ((IGlobalEntity)_entity).WxWydm;
            _database.SystemService.SaveVgAttachment(attachment);
            _attachments.Add(attachment);
        }

        private void btnNewVideo_Click(object sender, EventArgs e)
        {
            frmVideoCapture frm = new frmVideoCapture(_context, null);
            DialogResult result = frm.ShowDialog();
            if (result != DialogResult.OK) return;
            VgAttachment attachment = frm.GetAttachment();
            attachment.WxWydm = ((IGlobalEntity)_entity).WxWydm;
            _database.SystemService.SaveVgAttachment(attachment);
            _attachments.Add(attachment);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridAttachments.Table.SelectedRecords == null || gridAttachments.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备删除的附件!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex=gridAttachments.Table.SelectedRecords[0].GetSourcePosition();
            VgAttachment attachment = _attachments[recIndex];
            if (MessageBox.Show(string.Format("你确认删除{0}吗?", attachment.Fjlj), "询问", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            _database.SystemService.DeleteVgAttachment(attachment);
            _attachments.RemoveAt(recIndex);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (gridAttachments.Table.SelectedRecords == null || gridAttachments.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备导出的附件!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridAttachments.Table.SelectedRecords[0].GetSourcePosition();
            VgAttachment attachment = _attachments[recIndex];
            string newFile = _database.GetAbsolutePath(attachment.Fjlj);
            FileInfo newInfo = new FileInfo(newFile);
            if (newInfo.Exists == false)
            {
                MessageBox.Show("无法找到该附件!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog dialog=new SaveFileDialog();
            dialog.FileName = newInfo.Name;
            dialog.Title = "附件另存为";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            newInfo.CopyTo(dialog.FileName);
        }

        private void btnNewAudio_Click(object sender, EventArgs e)
        {
            frmAudioCapture frm = new frmAudioCapture(_context, null);
            DialogResult result = frm.ShowDialog();
            if (result != DialogResult.OK) return;
            VgAttachment attachment = frm.GetAttachment();
            attachment.WxWydm = ((IGlobalEntity)_entity).WxWydm;
            _database.SystemService.SaveVgAttachment(attachment);
            _attachments.Add(attachment);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog=new OpenFileDialog()
                                      {
                                          Title = "选择加载文件",
                                          CheckFileExists = true,
                                          Multiselect = false
                                      };
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            FileInfo fileInfo = new FileInfo(dialog.FileName);
            string copyFile = Path.Combine(_database.GetAttachmentPath() , fileInfo.Name);
            if (File.Exists(copyFile))
            {
                result =MessageBox.Show("数据库内已经已经存在该附件!继续覆盖吗？", "警告", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if(result!=DialogResult.Yes)
                return;
            }
            fileInfo.CopyTo(copyFile,true);
            VgAttachment attachment=new VgAttachment()
                                        {
                                            Fjlj = _database.GetRelativePath(copyFile),
                                            Fjmc = fileInfo.Name,
                                            Fjsm = string.Format( "{0}在{1}加载该文件",Environment.UserName,DateTime.Now.ToString("yyyy年MM月dd日hh时mm分"))
                                        };
            frmVgAttachment frm=new frmVgAttachment();
            frm.BindContext(_context, attachment);
            result = frm.ShowDialog();
            if (result != DialogResult.OK) return;
            attachment=frm.LinkedObject as VgAttachment;
            _attachments.Add(attachment);
        }

        private void btnAttribute_Click(object sender, EventArgs e)
        {
            if (gridAttachments.Table.SelectedRecords == null || gridAttachments.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备编辑的附件!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridAttachments.Table.SelectedRecords[0].GetSourcePosition();
            VgAttachment attachment = _attachments[recIndex];
            frmVgAttachment frm = new frmVgAttachment();
            frm.BindContext(_context, attachment);
            DialogResult result = frm.ShowDialog();
            if (result != DialogResult.OK) return;
            attachment = frm.LinkedObject as VgAttachment;
            if (frm.HasPropertyChanged == false) return;
            //_attachments.Add(attachment);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (gridAttachments.Table.Records.Count == 0) return;
            if (gridAttachments.Table.SelectedRecords == null) return;
            int recIndex = gridAttachments.Table.SelectedRecords[0].GetSourcePosition();
            VgAttachment curAttachment = _attachments[recIndex];
            AttachmentFileType curFileType = curAttachment.FileType;
            string fileName = _database.GetAbsolutePath(curAttachment.Fjlj);
            List<string> files=new List<string>();
            int findIndex = 0;
            for(int i=0; i< _attachments.Count;i++)
            {
                if(i==recIndex) { files.Add(fileName);
                    findIndex = files.Count - 1;
                    continue;
                }
                VgAttachment attachment = _attachments[i];
                if (attachment.FileType== curFileType)
                {
                    string fName = _database.GetAbsolutePath(attachment.Fjlj);
                    files.Add(fName);
                }
            }
            if (files.Count > 0)
            {
                if (curFileType == AttachmentFileType.Image)
                {
                    Viewer.frmImageViewer frm=new Viewer.frmImageViewer(files,fileName);
                    frm.ShowDialog();
                }
                else if (curFileType == AttachmentFileType.Audio)
                {
                    List<VgAttachment> attachments = _attachments.Where(c => c.FileType == AttachmentFileType.Audio)
                        .ToList();
                    Viewer.frmAudioViewer frm=new frmAudioViewer(_database);
                    frm.LoadAttachments(attachments, findIndex);
                    frm.ShowDialog();
                }
                else if (curFileType == AttachmentFileType.Video || curFileType==AttachmentFileType.Audio)
                {

                    Viewer.frmVideoViewer frm = new frmVideoViewer();
                    frm.LoadVideos(files, fileName);
                    frm.ShowDialog();
                }
                else
                {
                    System.Diagnostics.Process.Start(fileName);
                }
            }
        }
    }
}
