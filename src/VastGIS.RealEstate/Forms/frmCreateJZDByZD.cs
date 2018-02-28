using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Attribute;
using VastGIS.Plugins.RealEstate.DataControls;
using VastGIS.Plugins.RealEstate.Events;
using VastGIS.Plugins.RealEstate.Helpers;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Forms
{
	
    public partial class frmCreateJZDByZD:Form,IEditForm
    {	
        #region 变量
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private VgObjectclass _zdClass;
        private VgObjectclass _jzdClass;
        private VgObjectclass _jzxClass;
        private IReFeature _feature;
        private BindingList<JzdInfo> _jzdInfos;
        private BindingList<JzxInfo> _jzxInfos;
        private List<VgDictionary> _jblxDict;
        private List<VgDictionary> _jzdlxDict;
        private List<VgDictionary> _jzxlbDict;
        private List<VgDictionary> _jxxzDict;
        private List<VgDictionary> _jzxwzDict;
        #endregion

        public frmCreateJZDByZD(IAppContext context, RealEstateEditor plugin)
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
            _zdClass = classes.First(c => c.Mc == "ZDJBXX");
            _jzdClass = classes.First(c => c.Mc == "JZD");
            _jzxClass = classes.First(c => c.Mc == "JZX");
            _jzdInfos=new BindingList<JzdInfo>();
            _jzxInfos=new BindingList<JzxInfo>();
            InitDictionaries();
            InitJzdGrid();
            InitJzxGrid();
            chkSelFeature.Checked = true;
        }

        private void InitDictionaries()
        {
            _jzdlxDict = _database.DomainService.GetDictionaryByName("JZDLXZD");
            _jblxDict = _database.DomainService.GetDictionaryByName("JBLXZD");
            _jzxlbDict = _database.DomainService.GetDictionaryByName("JZXLBZD");
            _jzxwzDict = _database.DomainService.GetDictionaryByName("JZXWZZD");
            _jxxzDict = _database.DomainService.GetDictionaryByName("JXXZZD");
        }

        private DataTable ConvertDictionaryToDataTable(List<VgDictionary> dictionaries)
        {
            DataTable typeTable = new DataTable();
            DataColumn column = typeTable.Columns.Add("Zdz", typeof(string));
            typeTable.Columns.Add("Zdsm", typeof(string));
            foreach (var dict in dictionaries)
            {
                DataRow row = typeTable.NewRow();
                row["Zdz"] = dict.Zdz;
                row["Zdsm"] = dict.Zdsm;
                typeTable.Rows.Add(row);
            }
            return typeTable;
        }

        public void InitJzxGrid()
        {

            if (_jzxInfos == null)
            {
                _jzxInfos = new BindingList<JzxInfo>();
            }
          

            this.gridJzxs.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridJzxs.TableOptions.ListBoxSelectionMode = SelectionMode.One;

            this.gridJzxs.AllowProportionalColumnSizing = true;
            this.gridJzxs.TopLevelGroupOptions.ShowCaption = false;

            this.gridJzxs.TopLevelGroupOptions.ShowCaption = false;
            this.gridJzxs.ChildGroupOptions.ShowCaption = false;
            this.gridJzxs.NestedTableGroupOptions.ShowCaption = false;

            //to disable AddNewRecord.
            this.gridJzxs.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridJzxs.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridJzxs.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridJzxs.WantTabKey = false;

            this.gridJzxs.TableDescriptor.Relations.Clear();
            this.gridJzxs.DataSource = _jzxInfos;
            this.gridJzxs.AllowProportionalColumnSizing = false;
            GridTableDescriptor mainTd = gridJzxs.TableDescriptor;
            //DataTable jzxlbTable = ConvertDictionaryToDataTable(_jzxlbDict);
            //DataTable jzxwzTable = ConvertDictionaryToDataTable(_jzxwzDict);
            //DataTable jxxzTable = ConvertDictionaryToDataTable(_jxxzDict);
            //this.gridJzxs.Engine.SourceListSet.Add("JzxlbSet", jzxlbTable.DefaultView);
            //this.gridJzxs.Engine.SourceListSet.Add("JzxwzSet", jzxwzTable.DefaultView);
            //this.gridJzxs.Engine.SourceListSet.Add("JxxzSet", jxxzTable.DefaultView);
            //GridRelationDescriptor typesRd = new GridRelationDescriptor();
            //typesRd.Name = "Jzxlb";
            //typesRd.RelationKind = RelationKind.ForeignKeyReference;
            //typesRd.ChildTableName = "JzxlbSet";
            //typesRd.RelationKeys.Add("Jzxlb", "Zdz");
            //typesRd.ChildTableDescriptor.SortedColumns.Add("Zdz");
            //typesRd.ChildTableDescriptor.AllowEdit = false;
            //typesRd.ChildTableDescriptor.AllowNew = false;  // Make pencil icon disappear, users can't modify states.
            //mainTd.Relations.Add(typesRd);

            //typesRd = new GridRelationDescriptor();
            //typesRd.Name = "Jzxwz";
            //typesRd.RelationKind = RelationKind.ForeignKeyReference;
            //typesRd.ChildTableName = "JzxwzSet";
            //typesRd.RelationKeys.Add("Jzxwz", "Zdz");
            //typesRd.ChildTableDescriptor.SortedColumns.Add("Zdz");
            //typesRd.ChildTableDescriptor.AllowEdit = false;
            //typesRd.ChildTableDescriptor.AllowNew = false;  // Make pencil icon disappear, users can't modify states.
            //mainTd.Relations.Add(typesRd);

            //typesRd = new GridRelationDescriptor();
            //typesRd.Name = "Jxxz";
            //typesRd.RelationKind = RelationKind.ForeignKeyReference;
            //typesRd.ChildTableName = "JxxzSet";
            //typesRd.RelationKeys.Add("Jxxz", "Zdz");
            //typesRd.ChildTableDescriptor.SortedColumns.Add("Zdz");
            //typesRd.ChildTableDescriptor.AllowEdit = false;
            //typesRd.ChildTableDescriptor.AllowNew = false;  // Make pencil icon disappear, users can't modify states.
            //mainTd.Relations.Add(typesRd);

            string columns = ",Selected::40,Zdnsxh:宗地内序号:40,ID:序号:40,Jzxlb:类别:120,Jzxwz:位置:80,Jxxz:性质:80,";

            foreach (GridColumnDescriptor descriptor in mainTd.Columns)
            {
                string pName = descriptor.Name;
                int start = columns.IndexOf("," + pName + ":");
                if (start < 0)
                {
                    descriptor.Width = 0;
                    continue;
                }
                int end = columns.IndexOf(",", start + 1);
                string pDef = columns.Substring(start + 1, end - start - 1);
                string[] pDefs = pDef.Split(':');
                descriptor.HeaderText = pDefs[1];
                descriptor.Width = Convert.ToInt32(pDefs[2]);
            }
           

            this.gridJzxs.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            //Used for disabling Caption
            this.gridJzxs.TopLevelGroupOptions.ShowCaption = false;
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridJzxs.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridJzxs.Table.DefaultCaptionRowHeight = 25;
            this.gridJzxs.Table.DefaultColumnHeaderRowHeight = 30;
            this.gridJzxs.Table.DefaultRecordRowHeight = 22;
            this.gridJzxs.AllowProportionalColumnSizing = true;
            //GridColor settings
            this.gridJzxs.TableDescriptor.AllowNew = false;
            this.gridJzxs.TableDescriptor.AllowEdit = false;
            this.gridJzxs.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridJzxs.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridJzxs.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzxs.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzxs.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridJzxs.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridJzxs.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzxs.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzxs.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzxs.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzxs.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridJzxs.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridJzxs.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridJzxs.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridJzxs.TableDescriptor.TableOptions.RecordRowHeight = 20;

            //Navigate to other control using tabkey navigation
            this.gridJzxs.WantTabKey = false;

        }

        public void InitJzdGrid()
        {
            
            if (_jzdInfos == null)
            {
                _jzdInfos = new BindingList<JzdInfo>();
            }
       
            
            this.gridJzds.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridJzds.TableOptions.ListBoxSelectionMode = SelectionMode.One;
       
            this.gridJzds.AllowProportionalColumnSizing = true;
            this.gridJzds.TopLevelGroupOptions.ShowCaption = false;
       
            this.gridJzds.TopLevelGroupOptions.ShowCaption = false;
            this.gridJzds.ChildGroupOptions.ShowCaption = false;
            this.gridJzds.NestedTableGroupOptions.ShowCaption = false;

            //to disable AddNewRecord.
            this.gridJzds.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridJzds.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridJzds.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridJzds.WantTabKey = false;

            this.gridJzds.TableDescriptor.Relations.Clear();
            this.gridJzds.DataSource = _jzdInfos;
            this.gridJzds.AllowProportionalColumnSizing = false;
            GridTableDescriptor mainTd = gridJzds.TableDescriptor;
            //DataTable jblxTable = ConvertDictionaryToDataTable(_jblxDict);
            //DataTable jzdlxTable = ConvertDictionaryToDataTable(_jzdlxDict);
            //this.gridJzds.Engine.SourceListSet.Add("JblxSet", jblxTable.DefaultView);
            //this.gridJzds.Engine.SourceListSet.Add("JzdlxSet", jzdlxTable.DefaultView);
            //GridRelationDescriptor typesRd = new GridRelationDescriptor();
            //typesRd.Name = "Jblx";
            //typesRd.RelationKind = RelationKind.ForeignKeyReference;
            //typesRd.ChildTableName = "JblxSet";
            //typesRd.RelationKeys.Add("Jblx", "Zdz");
            //typesRd.ChildTableDescriptor.SortedColumns.Add("Zdz");
            //typesRd.ChildTableDescriptor.AllowEdit = false;
            //typesRd.ChildTableDescriptor.AllowNew = false;  // Make pencil icon disappear, users can't modify states.
            //mainTd.Relations.Add(typesRd);

            //typesRd = new GridRelationDescriptor();
            //typesRd.Name = "Jzdlx";
            //typesRd.RelationKind = RelationKind.ForeignKeyReference;
            //typesRd.ChildTableName = "JzdlxSet";
            //typesRd.RelationKeys.Add("Jzdlx", "Zdz");
            //typesRd.ChildTableDescriptor.SortedColumns.Add("Zdz");
            //typesRd.ChildTableDescriptor.AllowEdit = false;
            //typesRd.ChildTableDescriptor.AllowNew = false;  // Make pencil icon disappear, users can't modify states.
            //mainTd.Relations.Add(typesRd);

            string columns = ",Selected::40,Zdnsxh:宗地内序号:40,ID:序号:40,Jzdh:界址点号:120,Jblx:界标类型:80,Jzdlx:界址点类型:80,";

            foreach (GridColumnDescriptor descriptor in mainTd.Columns)
            {
                string pName = descriptor.Name;
                int start = columns.IndexOf("," + pName + ":");
                if (start<0)
                {
                    descriptor.Width = 0;
                    continue;
                }
                int end = columns.IndexOf(",", start+1);
                string pDef = columns.Substring(start+1, end - start-1);
                string[] pDefs = pDef.Split(':');
                descriptor.HeaderText = pDefs[1];
                descriptor.Width = Convert.ToInt32(pDefs[2]);
            }
          

            this.gridJzds.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            //Used for disabling Caption
            this.gridJzds.TopLevelGroupOptions.ShowCaption = false;
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridJzds.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridJzds.Table.DefaultCaptionRowHeight = 25;
            this.gridJzds.Table.DefaultColumnHeaderRowHeight = 30;
            this.gridJzds.Table.DefaultRecordRowHeight = 22;
            this.gridJzds.AllowProportionalColumnSizing = true;
            //GridColor settings
            this.gridJzds.TableDescriptor.AllowNew = false;
            this.gridJzds.TableDescriptor.AllowEdit = false;
            this.gridJzds.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridJzds.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridJzds.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzds.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzds.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridJzds.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridJzds.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzds.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzds.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzds.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridJzds.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridJzds.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridJzds.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridJzds.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridJzds.TableDescriptor.TableOptions.RecordRowHeight = 20;

            //Navigate to other control using tabkey navigation
            this.gridJzds.WantTabKey = false;

        }

        public void SetQueryPoint(double dx, double dy)
        {
            if (!chkSelFeature.Checked) return;
            List<IReFeature> features = _database.SystemService.FindFeatures(_zdClass, dx, dy,0.05);
            if (features != null && features.Count>0)
            {
                _feature = features[0];
                LoadJzdAndJzx();
                chkSelFeature.Checked = false;
                txtFeature.Text = _feature.FullLabelString;
            }
        }

        private void LoadJzdAndJzx()
        {
            if (_feature == null) return;
            if (_jzdInfos != null)
            {
                _jzdInfos.Clear();
                _jzxInfos.Clear();
            }
            else
            {
                _jzdInfos=new BindingList<JzdInfo>();
                _jzxInfos=new BindingList<JzxInfo>();
            }

            IGeometry geometry = _feature.Geometry;
            int i = 0;
            int pntCount = _feature.Geometry.Points.Count;
            double px, py;
            for (int j=0;j<pntCount-1;j++)
            {
                ICoordinate point = _feature.Geometry.Points[j];
                px = point.X;
                py = point.Y;
                JzdInfo jzd;
                i++;
                List<IReFeature> findPnts = _database.SystemService.FindFeatures(_jzdClass, px, py,0.05);
                if (findPnts != null && findPnts.Count == 1)
                {
                   jzd =new JzdInfo( findPnts[0] as Jzd);
                    jzd.Selected = false;
                }
                else
                {
                    jzd=new JzdInfo();
                    jzd.Selected = true;
                    jzd.Xzbz = px;
                    jzd.Yzbz = py;
                }
                jzd.Zdnsxh = i;
                jzd.Xzbz = px;
                jzd.Yzbz = py;
                _jzdInfos.Add(jzd);
            }

            int count = geometry.Points.Count;
            JzxInfo jzx;
            double px2, py2;
            for (i = 0; i < count - 1; i++)
            {
                _feature.Geometry.GetPoint(i, out px, out py);
                _feature.Geometry.GetPoint(i+1, out px2, out py2);
                double xx =(px+px2)/2.0;
                double yy = (py+py2) / 2.0;

                List<IReFeature> findLines = _database.SystemService.FindFeatures(_jzxClass, xx, yy,0.2);
                if (findLines != null && findLines.Count == 1)
                {
                    jzx =new JzxInfo(findLines[0] as Jzx);
                    jzx.Selected = false;
                }
                else
                {
                    jzx = new JzxInfo();
                    jzx.Selected = true;
                }
                jzx.Zdnsxh = i+1;
                jzx.CenterX = xx;
                jzx.CenterY = yy;
                jzx.StartX = px;
                jzx.StartY = py;
                jzx.EndX = px2;
                jzx.EndY = py2;
                _jzxInfos.Add(jzx);
            }
        }

        private void btnQueryDX_Click(object sender, EventArgs e)
        {
            if (_feature == null) return;
            LoadJzdAndJzx();
        }

        private void btnSelectAllJzd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _jzdInfos.Count; i++)
            {
                _jzdInfos[i].Selected = true;
            }

        }

        private void btnSelectNewJzd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _jzdInfos.Count; i++)
            {
                if(_jzdInfos[i].ID<0)
                _jzdInfos[i].Selected = true;
            }
        }

        private void btnCreateAllJzd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确认将创建所有选择的界址点吗?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;
            long maxId = _database.ZdService.GetMaxID("Jzd");
            maxId++;
            for (int i = 0; i < _jzdInfos.Count; i++)
            {
                if (_jzdInfos[i].Selected == false) continue;
                if (_jzdInfos[i].ID >0) continue;
                Jzd jzd = _jzdInfos[i].GetJzd();
                jzd.Jzdh = "J" + maxId.ToString();
                maxId++;
                _database.ZdService.SaveJzd(jzd);
                _jzdInfos[i].LoadJzd(jzd);
                _jzdInfos[i].Selected = false;
                
            }
            gridJzds.UseOldListChangedHandler = false;
            gridJzds.Refresh();
        }

        private void btnCreateNowJzd_Click(object sender, EventArgs e)
        {
            if (gridJzds.Table.SelectedRecords == null || gridJzds.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备创建的界址点!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridJzds.Table.SelectedRecords[0].GetSourcePosition();
            JzdInfo jzdInfo = _jzdInfos[recIndex];
            Jzd jzd = jzdInfo.GetJzd();
            if (jzd.ID > 0) return;
            long maxId = _database.ZdService.GetMaxID("Jzd");
            maxId++;
            jzd.Jzdh = "J" + maxId.ToString();
            maxId++;
            _database.ZdService.SaveJzd(jzd);
            jzdInfo.LoadJzd(jzd);
            jzdInfo.Selected = false;
            gridJzds.Refresh();
        }

        private void btnAttributeJzd_Click(object sender, EventArgs e)
        {
            if (gridJzds.Table.SelectedRecords == null || gridJzds.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备编辑的界址点!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridJzds.Table.SelectedRecords[0].GetSourcePosition();
            JzdInfo jzdInfo = _jzdInfos[recIndex];
            Jzd jzd = jzdInfo.GetJzd();
            frmJzd frm=new frmJzd();
            frm.Context = _context;
            frm.LinkedObject = jzd;
            frm.ShowDialog();
            jzdInfo.LoadJzd(frm.LinkedObject as Jzd);
            jzdInfo.Selected = false;
            gridJzds.Refresh();
        }

        private void btnLocateJzd_Click(object sender, EventArgs e)
        {
            if (gridJzds.Table.SelectedRecords == null || gridJzds.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备放大的界址点!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridJzds.Table.SelectedRecords[0].GetSourcePosition();
            JzdInfo jzdInfo = _jzdInfos[recIndex];
            IEnvelope env = _context.Map.Extents;
            env.MoveCenterTo(jzdInfo.Xzbz, jzdInfo.Yzbz);
            _context.Map.ZoomToExtents(env);
          
        }

        private void btnSelectAllJzx_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _jzxInfos.Count; i++)
            {
                _jzxInfos[i].Selected = true;
            }
        }

        private void btnSelectNewJzx_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _jzxInfos.Count; i++)
            {
                if (_jzxInfos[i].ID < 0)
                    _jzxInfos[i].Selected = true;
            }
        }

        private void btnCreateAllJzx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确认将创建所有选择的界址线吗?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;
          
            for (int i = 0; i < _jzxInfos.Count; i++)
            {
                if (_jzxInfos[i].Selected == false) continue;
                if (_jzxInfos[i].ID > 0) continue;
                Jzx jzx = _jzxInfos[i].GetJzx();
               
                _database.ZdService.SaveJzx(jzx);
                _jzxInfos[i].LoadJzx(jzx);
                _jzxInfos[i].Selected = false;
                
            }
            gridJzxs.Refresh();
        }

        private void btnCreateNowJzx_Click(object sender, EventArgs e)
        {
            if (gridJzxs.Table.SelectedRecords == null || gridJzxs.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备创建的界址线!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridJzxs.Table.SelectedRecords[0].GetSourcePosition();
            JzxInfo jzxInfo = _jzxInfos[recIndex];
            Jzx jzx = jzxInfo.GetJzx();
            if (jzx.ID > 0) return;
            _database.ZdService.SaveJzx(jzx);
            jzxInfo.LoadJzx(jzx);
            jzxInfo.Selected = false;
            gridJzxs.Refresh();
        }

        private void btnAttributeJzx_Click(object sender, EventArgs e)
        {
            if (gridJzxs.Table.SelectedRecords == null || gridJzxs.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备编辑的界址线!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridJzxs.Table.SelectedRecords[0].GetSourcePosition();
            JzxInfo jzxInfo = _jzxInfos[recIndex];
            Jzx jzx = jzxInfo.GetJzx();
            frmJzx frm = new frmJzx();
            frm.Context = _context;
            frm.LinkedObject = jzx;
            frm.ShowDialog();
            jzxInfo.LoadJzx(frm.LinkedObject as Jzx);
            jzxInfo.Selected = false;
            gridJzxs.Refresh();
        }

        private void btnLocateJzx_Click(object sender, EventArgs e)
        {
            if (gridJzxs.Table.SelectedRecords == null || gridJzxs.Table.SelectedRecords.Count != 1)
            {
                MessageBox.Show("请选择准备放大的界址线!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int recIndex = gridJzxs.Table.SelectedRecords[0].GetSourcePosition();
            JzxInfo jzxInfo = _jzxInfos[recIndex];
            IEnvelope env = _context.Map.Extents;
            env.MoveCenterTo(jzxInfo.CenterX, jzxInfo.CenterY);
            _context.Map.ZoomToExtents(env);
           
        }
    }


    internal class JzdInfo
    {
        private Jzd _jzd;


        public bool Selected { get; set; }
        public int Zdnsxh { get; set; }
        public long ID { get; set; }
        public string Jzdh { get; set; }
        public string Jblx { get; set; }
        public string Jzdlx { get; set; }
        public double Xzbz { get; set; }
        public double Yzbz { get; set; }
        public JzdInfo(Jzd jzd)
        {
            ID = jzd.ID;
            Jzdh = jzd.Jzdh;
            Jblx = jzd.Jblx;
            Jzdlx = jzd.Jzdlx;
            Xzbz = jzd.Geometry.Points[0].X;
            Yzbz = jzd.Geometry.Points[0].Y;
            Selected = false;
            _jzd = jzd;
        }

        public JzdInfo()
        {
            Selected = true;
            ID = -1;
            _jzd = new Jzd();
        }

        public void LoadJzd(Jzd jzd)
        {
            ID = jzd.ID;
            Jzdh = jzd.Jzdh;
            Jblx = jzd.Jblx;
            Jzdlx = jzd.Jzdlx;
            Xzbz = jzd.Geometry.Points[0].X;
            Yzbz = jzd.Geometry.Points[0].Y;
            Selected = false;
            _jzd = jzd;
        }

        public Jzd GetJzd()
        {
            if (_jzd.ID <= 0)
            {
                _jzd.Jzdh = Jzdh;
                _jzd.Jblx = Jblx;
                _jzd.Jzdlx = Jzdlx;
                _jzd.Geometry = GeometryHelper.CreatePoint(Xzbz, Yzbz);
                _jzd.Xzbz = Xzbz;
                _jzd.Yzbz = Yzbz;
            }
            return _jzd;
        }
    }

    internal class JzxInfo
    {
        private Jzx _jzx;
        public bool Selected { get; set; }
        public int Zdnsxh { get; set; }
        public long ID { get; set; }
        public string Jzxlb { get; set; }
        public string Jzxwz { get; set; }
        public string Jxxz { get; set; }
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double StartX { get; set; }
        public double StartY { get; set; }
        public double EndX { get; set; }
        public double EndY { get; set; }
        public JzxInfo(Jzx jzx)
        {
            ID = jzx.ID;
            Jzxlb = jzx.Jzxlb;
            Jzxwz = jzx.Jzxwz;
            Jxxz = jzx.Jxxz;
            Selected = false;
            StartX = jzx.Geometry.Points[0].X;
            StartY = jzx.Geometry.Points[0].Y;
            EndX = jzx.Geometry.Points[1].X;
            EndY = jzx.Geometry.Points[1].Y;
            CenterX = (StartX + EndX) / 2.0;
            CenterY = (StartY + EndY) / 2.0;
            _jzx = jzx;
        }

        public void LoadJzx(Jzx jzx)
        {
            ID = jzx.ID;
            Jzxlb = jzx.Jzxlb;
            Jzxwz = jzx.Jzxwz;
            Jxxz = jzx.Jxxz;
            Selected = false;
            StartX = jzx.Geometry.Points[0].X;
            StartY = jzx.Geometry.Points[0].Y;
            EndX = jzx.Geometry.Points[1].X;
            EndY = jzx.Geometry.Points[1].Y;
            CenterX = (StartX + EndX) / 2.0;
            CenterY = (StartY + EndY) / 2.0;
            _jzx = jzx;
        }

        public JzxInfo()
        {
            Selected = true;
            ID = -1;
            _jzx = new Jzx();
        }

        public Jzx GetJzx()
        {
            if (_jzx.ID <= 0)
            {
                _jzx.Jzxwz = Jzxwz;
                _jzx.Jxxz  = Jxxz;
                _jzx.Jzxlb = Jzxlb;
                _jzx.Geometry = GeometryHelper.CreateLine(StartX, StartY,EndX,EndY);
                _jzx.Jzxcd = Math.Sqrt((StartX - EndX) * (StartX - EndX) + (StartY - EndY) * (StartY - EndY));

            }
            return _jzx;
        }
    }
}