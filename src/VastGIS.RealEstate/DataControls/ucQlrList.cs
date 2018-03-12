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
    public partial class ucQlrList : UserControl
    {
        private IMuteMap _map;
        private Zdjbxx _zdjbxx;
        private IAppContext _context;
        private int _layerHandle = -1;
        private BindingList<Qlr> _qlrs;
        private IREDatabase _database;
        private List<VgDictionary> _gyfsDict;
        public ucQlrList()
        {
            InitializeComponent();
            _zdjbxx = null;
            InitStatus();
            _qlrs = new BindingList<Qlr>();
            InitGrid();
        }

        private void ucAttachmentList_Resize(object sender, EventArgs e)
        {
        }

        public void InitGrid()
        {
            if (_zdjbxx == null)
            {
                this.gridQlrs.DataSource = null;
                return;
            }
            if (_qlrs == null)
            {
                _qlrs = new BindingList<Qlr>();
            }
            _gyfsDict = _database.DomainService.GetDictionaryByName("GYFSZD");
            DataTable gyfsTable = new DataTable();
            gyfsTable.Columns.Add("Zdz", typeof(string));
            gyfsTable.Columns.Add("Zdsm", typeof(string));
            foreach (var dict in _gyfsDict)
            {
                DataRow row = gyfsTable.NewRow();
                row["Zdz"] = dict.Zdz;
                row["Zdsm"] = dict.Zdsm;
                gyfsTable.Rows.Add(row);
            }

            this.gridQlrs.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridQlrs.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            //to set proportional column resizing to grid.
            this.gridQlrs.AllowProportionalColumnSizing = true;
            this.gridQlrs.TopLevelGroupOptions.ShowCaption = false;
            //to hide Caption.
            this.gridQlrs.TopLevelGroupOptions.ShowCaption = false;
            this.gridQlrs.ChildGroupOptions.ShowCaption = false;
            this.gridQlrs.NestedTableGroupOptions.ShowCaption = false;

            //to disable AddNewRecord.
            this.gridQlrs.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridQlrs.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridQlrs.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridQlrs.WantTabKey = false;

            this.gridQlrs.TableDescriptor.Relations.Clear();
            this.gridQlrs.DataSource = _qlrs;
            this.gridQlrs.AllowProportionalColumnSizing = false;
            GridTableDescriptor mainTd = gridQlrs.TableDescriptor;
            this.gridQlrs.Engine.SourceListSet.Add("QlrGyfs", gyfsTable.DefaultView);
            GridRelationDescriptor gyfsRd = new GridRelationDescriptor();
            gyfsRd.Name = "Gyfs";
            gyfsRd.RelationKind = RelationKind.ForeignKeyReference;
            gyfsRd.ChildTableName = "QlrGyfs";
            gyfsRd.RelationKeys.Add("Gyfs", "Zdz");
            gyfsRd.ChildTableDescriptor.SortedColumns.Add("Zdz");
            gyfsRd.ChildTableDescriptor.AllowEdit = false;
            gyfsRd.ChildTableDescriptor.AllowNew = false;  // Make pencil icon disappear, users can't modify states.
            mainTd.Relations.Add(gyfsRd);


            //To change the HeaderText.
            mainTd.Columns["ID"].HeaderText = "序号";
            mainTd.Columns["ID"].Width = 40;
            mainTd.Columns["Qlrmc"].HeaderText = "权利人名称";
            mainTd.Columns["Qlrmc"].Width = 120;
            mainTd.Columns["Dh"].HeaderText = "电话";
            mainTd.Columns["Dh"].Width = 80;
            mainTd.Columns["Dz"].HeaderText = "门牌号";
            mainTd.Columns["Dz"].Width = 80;
            mainTd.Columns["Bz"].HeaderText = "建房年份";
            mainTd.Columns["Bz"].Width = 80;
            mainTd.Columns["Gyfs_Zdsm"].HeaderText = "共有方式";
            mainTd.Columns["Gyfs_Zdsm"].Width = 80;

            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Ysdm"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Bdcdyh"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Sxh"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Bdcqzh"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Qzysxlh"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Sfczr"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Zjzl"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Zjh"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Fzjg"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Sshy"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Gj"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Hjszss"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Xb"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Yb"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Gzdw"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Dzyj"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Qlrlx"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Qlbl"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Gyqk"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Databaseid"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Flags"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Xgr"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Xgsj"]);

            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["TableName"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["ObjectName"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["EntityName"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["SimpleLabelString"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["FullLabelString"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["WxWydm"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["DatabaseID"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Flags"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Xgr"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["Xgsj"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["HasFlag"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["HasGlobal"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["HasYsdm"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["HasSurvey"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["HasGeometry"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["GeometryType"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["FileType"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["NoCopyName_Length"]);
            mainTd.VisibleColumns.Remove(mainTd.VisibleColumns["LayerName"]);


            this.gridQlrs.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            //Used for disabling Caption
            this.gridQlrs.TopLevelGroupOptions.ShowCaption = false;
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridQlrs.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridQlrs.Table.DefaultCaptionRowHeight = 25;
            this.gridQlrs.Table.DefaultColumnHeaderRowHeight = 30;
            this.gridQlrs.Table.DefaultRecordRowHeight = 22;
            this.gridQlrs.AllowProportionalColumnSizing = true;
            //GridColor settings
            this.gridQlrs.TableDescriptor.AllowNew = false;
            this.gridQlrs.TableDescriptor.AllowEdit = false;
            this.gridQlrs.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridQlrs.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridQlrs.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridQlrs.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridQlrs.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridQlrs.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridQlrs.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridQlrs.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridQlrs.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridQlrs.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridQlrs.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridQlrs.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridQlrs.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridQlrs.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridQlrs.TableDescriptor.TableOptions.RecordRowHeight = 20;

            //Navigate to other control using tabkey navigation
            this.gridQlrs.WantTabKey = false;

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
            if (_qlrs == null)
            {
                _qlrs = new BindingList<Qlr>();
            }
            gridQlrs.Enabled = _zdjbxx != null;
            btnNewQlr.Enabled = _zdjbxx != null;
            gridQlrs.DataSource = _qlrs;
            btnDeleteQlr.Enabled = btnNewQlr.Enabled;
            btnEditQlr.Enabled = btnNewQlr.Enabled;
        }

        public void SetFeature(Zdjbxx zdjbxx)
        {
            _zdjbxx = zdjbxx;
            LoadEntity();
        }

        private void LoadEntity()
        {
            _qlrs.Clear();
            if (_zdjbxx.Bdcdyh == null)
            {
                _zdjbxx = null;
                InitGrid();
                InitStatus();
                return;
            }
            //List<VgAttachment> attachments = _database.SystemService.GetVgAttachmentsByWydm(((IGlobalEntity)_entity).WxWydm.ToString()).ToList();
            List<Qlr> qlrs = _database.SystemService.GetQlrsByBdcdyh(_zdjbxx.Bdcdyh).ToList();
            foreach (var attachment in qlrs)
            {
                _qlrs.Add(attachment);
            }
            InitGrid();
            InitStatus();
        }

        public void LinkObject(IEntity entity)
        {
            if (entity is Zdjbxx)
            {
                _zdjbxx = entity as Zdjbxx;
                LoadEntity();
            }
        }
        private void gridAttachments_SelectedRecordsChanged(object sender, Syncfusion.Grouping.SelectedRecordsChangedEventArgs e)
        {
            InitStatus();
        }



        private void btnNewQlr_Click(object sender, EventArgs e)
        {
            frmQlrSimple frm = new frmQlrSimple();
            frm.BindContext(_context, null);
            frm.CreateNew();
            DialogResult result = frm.ShowDialog();
            if (result != DialogResult.OK) return;
            Qlr qlr = frm.LinkedObject as Qlr;
            qlr.Bdcdyh = _zdjbxx.Bdcdyh;
            _database.SystemService.Save(qlr);
            _qlrs.Add(qlr);
        }

        private void btnEditQlr_Click(object sender, EventArgs e)
        {
            if (gridQlrs.Table.SelectedRecords == null || gridQlrs.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备编辑的权利人信息!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridQlrs.Table.SelectedRecords[0].GetSourcePosition();
            Qlr qlr = _qlrs[recIndex];
            frmQlrSimple frm = new frmQlrSimple();
            frm.BindContext(_context, qlr);
            DialogResult result = frm.ShowDialog();
            if (result != DialogResult.OK) return;
            qlr = frm.LinkedObject as Qlr;
            if (frm.HasPropertyChanged == false) return;
        }

        private void btnDeleteQlr_Click(object sender, EventArgs e)
        {
            if (gridQlrs.Table.SelectedRecords == null || gridQlrs.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备删除的权利人!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridQlrs.Table.SelectedRecords[0].GetSourcePosition();
            Qlr qlr = _qlrs[recIndex];
            if (MessageBox.Show(string.Format("你确认删除{0}吗?", qlr.Qlrmc), "询问", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            _database.SystemService.Delete(qlr);
            _qlrs.RemoveAt(recIndex);
        }
    }
}
