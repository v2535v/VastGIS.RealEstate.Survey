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
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Forms
{

    public partial class frmCreateJZDByZD : Form, IEditForm
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
        private int _layerHandle = -1;
        private IMuteMap _map;
        #endregion

        public frmCreateJZDByZD(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            _map = _context.Map;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclass> classes = _database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1").ToList();
            _zdClass = classes.First(c => c.Mc == "ZDJBXX");
            _jzdClass = classes.First(c => c.Mc == "JZD");
            _jzxClass = classes.First(c => c.Mc == "JZX");
            _jzdInfos = new BindingList<JzdInfo>();
            _jzxInfos = new BindingList<JzxInfo>();
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
            DataTable jzxlbTable = ConvertDictionaryToDataTable(_jzxlbDict);
            DataTable jzxwzTable = ConvertDictionaryToDataTable(_jzxwzDict);
            DataTable jxxzTable = ConvertDictionaryToDataTable(_jxxzDict);

            mainTd.Columns["Jzxlb"].Appearance.AnyRecordFieldCell.CellType = "ComboBox";
            mainTd.Columns["Jzxlb"].Appearance.AnyRecordFieldCell.DataSource = _jzxlbDict;
            mainTd.Columns["Jzxlb"].Appearance.AnyRecordFieldCell.DisplayMember = "Zdsm";
            mainTd.Columns["Jzxlb"].Appearance.AnyRecordFieldCell.ValueMember = "Zdz";

            mainTd.Columns["Jzxwz"].Appearance.AnyRecordFieldCell.CellType = "ComboBox";
            mainTd.Columns["Jzxwz"].Appearance.AnyRecordFieldCell.DataSource = _jzxwzDict;
            mainTd.Columns["Jzxwz"].Appearance.AnyRecordFieldCell.DisplayMember = "Zdsm";
            mainTd.Columns["Jzxwz"].Appearance.AnyRecordFieldCell.ValueMember = "Zdz";

            mainTd.Columns["Jxxz"].Appearance.AnyRecordFieldCell.CellType = "ComboBox";
            mainTd.Columns["Jxxz"].Appearance.AnyRecordFieldCell.DataSource = _jxxzDict;
            mainTd.Columns["Jxxz"].Appearance.AnyRecordFieldCell.DisplayMember = "Zdsm";
            mainTd.Columns["Jxxz"].Appearance.AnyRecordFieldCell.ValueMember = "Zdz";


            string columns = ",Selected::40,Zdnsxh:宗地内序号:40,ID:序号:40,Jzxlb:类别:120,Jzxwz:位置:80,Jxxz:性质:80,";
            int visibleCount = mainTd.VisibleColumns.Count;
            for (int i = visibleCount - 1; i >= 0; i--)
            {
                GridVisibleColumnDescriptor descriptor = mainTd.VisibleColumns[i];
                string pName = descriptor.Name;
                int start = columns.IndexOf("," + pName + ":");
                if (start < 0)
                {
                    mainTd.VisibleColumns.RemoveAt(i);
                    continue;
                }
                int end = columns.IndexOf(",", start + 1);
                string pDef = columns.Substring(start + 1, end - start - 1);
                string[] pDefs = pDef.Split(':');
                mainTd.Columns[pName].HeaderText = pDefs[1];
                mainTd.Columns[pName].Width = Convert.ToInt32(pDefs[2]);
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
            DataTable jblxTable = ConvertDictionaryToDataTable(_jblxDict);
            DataTable jzdlxTable = ConvertDictionaryToDataTable(_jzdlxDict);
            mainTd.Columns["Jblx"].Appearance.AnyRecordFieldCell.CellType = "ComboBox";
            mainTd.Columns["Jblx"].Appearance.AnyRecordFieldCell.DataSource = _jblxDict;
            mainTd.Columns["Jblx"].Appearance.AnyRecordFieldCell.DisplayMember = "Zdsm";
            mainTd.Columns["Jblx"].Appearance.AnyRecordFieldCell.ValueMember = "Zdz";

            mainTd.Columns["Jzdlx"].Appearance.AnyRecordFieldCell.CellType = "ComboBox";
            mainTd.Columns["Jzdlx"].Appearance.AnyRecordFieldCell.DataSource = _jzdlxDict;
            mainTd.Columns["Jzdlx"].Appearance.AnyRecordFieldCell.DisplayMember = "Zdsm";
            mainTd.Columns["Jzdlx"].Appearance.AnyRecordFieldCell.ValueMember = "Zdz";


            string columns = ",Selected::40,Zdnsxh:宗地内序号:40,ID:序号:40,Jzdh:界址点号:120,Jblx:界标类型:80,Jzdlx:界址点类型:80,";

            int visibleCount = mainTd.VisibleColumns.Count;
            for (int i = visibleCount - 1; i >= 0; i--)
            {
                GridVisibleColumnDescriptor descriptor = mainTd.VisibleColumns[i];
                string pName = descriptor.Name;
                int start = columns.IndexOf("," + pName + ":");
                if (start < 0)
                {
                    mainTd.VisibleColumns.RemoveAt(i);
                    continue;
                }
                int end = columns.IndexOf(",", start + 1);
                string pDef = columns.Substring(start + 1, end - start - 1);
                string[] pDefs = pDef.Split(':');
                mainTd.Columns[pName].HeaderText = pDefs[1];
                mainTd.Columns[pName].Width = Convert.ToInt32(pDefs[2]);
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
            List<IReFeature> features = _database.SystemService.FindFeatures(_zdClass, dx, dy, 0.05);
            if (features != null && features.Count > 0)
            {
                _feature = features[0];
                LoadJzdAndJzx();
                chkSelFeature.Checked = false;
                txtFeature.Text = _feature.FullLabelString;
            }
        }

        public void ClearDrawing()
        {
            if (_map != null && _layerHandle > -1)
            {
                _map.Drawing.RemoveLayer(_layerHandle);
            }
            else
            {
                _map.Drawing.Clear();
            }
        }

        public void DrawData()
        {
            PrepareLayer();
            IGeometry editGeometry = _feature.Geometry;
            if (editGeometry == null) return;
            Color color = _context.Config.RealEstateSelectedColor;
            DrawGeometry(editGeometry, color);
            DrawJzd();
            DrawJzx();
            //List<JzdInfo> vertexs = _jzdInfos.Where(c => c.Selected == true).ToList();
            //foreach (JzdInfo vertex in vertexs)
            //{
            //    _map.Drawing.DrawLabel(_layerHandle, vertex.ID.ToString(), vertex.Xzbz, vertex.Yzbz, 0);
            //    _map.Drawing.DrawPoint(_layerHandle, vertex.Xzbz, vertex.Yzbz, 12, color);
            //}
        }
        private void PrepareLayer()
        {
            if (_layerHandle >= 0)
            {
                _map.Drawing.RemoveLayer(_layerHandle);
            }
            _layerHandle = _map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
        }
        public void DrawJzx()
        {
            if (_jzxInfos == null) return;
            Color color2 = _context.Config.RealEstateActivedColor;
            Color color = _context.Config.RealEstateSelectedColor;
            Record record = gridJzxs.Table.CurrentRecord;
            int sourceIndex = -1;
            if (record != null) sourceIndex = record.GetSourceIndex();
            int count = 0;
            foreach (JzxInfo edge in _jzxInfos)
            {
                if (count == sourceIndex)
                {
                    _map.Drawing.DrawLine(_layerHandle, edge.StartX, edge.StartY, edge.EndX, edge.EndY, 4, color2);
                }
                else
                {
                    _map.Drawing.DrawLine(_layerHandle, edge.StartX, edge.StartY, edge.EndX, edge.EndY, 3, color);
                }

                _map.Drawing.DrawLabel(_layerHandle,"L"+ edge.Zdnsxh.ToString(), edge.CenterX, edge.CenterY, 0);
                count++;
            }
        }

        private void DrawJzd()
        {
            Color color = _context.Config.RealEstateSelectedColor;
            List<JzdInfo> vertexs = _jzdInfos.ToList();
            foreach (JzdInfo vertex in vertexs)
            {
                _map.Drawing.DrawLabel(_layerHandle,"P"+ vertex.Zdnsxh.ToString(), vertex.Xzbz, vertex.Yzbz, 0);
                _map.Drawing.DrawPoint(_layerHandle, vertex.Xzbz, vertex.Yzbz, 12, color);
            }
        }

        private void DrawGeometry(IGeometry geometry, Color color, string labelString = "", double rotation = 0)
        {

            double x1 = 0.0;
            double y1 = 0.0;
            double x2 = 0.0;
            double y2 = 0.0;
            if (geometry.GeometryType == GeometryType.Polyline)
            {
                for (int j = 0; j < geometry.Parts.Count; j++)
                {
                    for (int i = 0; i < geometry.Parts[j].Points.Count - 1; i++)
                    {
                        x1 = geometry.Parts[j].Points[i].X;
                        y1 = geometry.Parts[j].Points[i].Y;
                        x2 = geometry.Parts[j].Points[i + 1].X;
                        y2 = geometry.Parts[j].Points[i + 1].Y;
                        _map.Drawing.DrawLine(_layerHandle, x1, y1, x2, y2, 3, color);
                    }
                }
                return;
            }
            else if (geometry.GeometryType == GeometryType.Polygon)
            {
                //for (int j = 0; j < geometry.Parts.Count; j++)
                //{
                //    double[] xs = geometry.Parts[j].Points.Select(c => c.X).ToArray();
                //    double[] ys = geometry.Parts[j].Points.Select(c => c.Y).ToArray();
                //    object xsObject = xs as object;
                //    object ysObject = ys as object;
                //    _map.Drawing.DrawPolygon(_layerHandle, ref xsObject, ref ysObject, geometry.Parts[j].Points.Count, color, true, 1);
                //}

                for (int j = 0; j < geometry.Parts.Count; j++)
                {
                    for (int i = 0; i < geometry.Parts[j].Points.Count - 1; i++)
                    {
                        x1 = geometry.Parts[j].Points[i].X;
                        y1 = geometry.Parts[j].Points[i].Y;
                        x2 = geometry.Parts[j].Points[i + 1].X;
                        y2 = geometry.Parts[j].Points[i + 1].Y;
                        _map.Drawing.DrawLine(_layerHandle, x1, y1, x2, y2, 3, color);
                    }
                }
                return;
            }
            else if (geometry.GeometryType == GeometryType.Point)
            {
                _map.Drawing.DrawPoint(_layerHandle, geometry.Points[0].X, geometry.Points[0].Y, 12, color);
            }
            else if (geometry.GeometryType == GeometryType.MultiPoint)
            {
                for (int i = 0; i < geometry.Points.Count; i++)
                {
                    _map.Drawing.DrawPoint(_layerHandle, geometry.Points[i].X, geometry.Points[i].Y, 12, color);
                }
            }
            else if (geometry.GeometryType == GeometryType.TextPoint)
            {
                _map.Drawing.DrawLabel(_layerHandle, labelString, geometry.Points[0].X, geometry.Points[0].Y, rotation);
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
                _jzdInfos = new BindingList<JzdInfo>();
                _jzxInfos = new BindingList<JzxInfo>();
            }

            IGeometry geometry = _feature.Geometry;
            int i = 0;
            int pntCount = _feature.Geometry.Points.Count;
            double px, py;
            for (int j = 0; j < pntCount - 1; j++)
            {
                ICoordinate point = _feature.Geometry.Points[j];
                px = point.X;
                py = point.Y;
                JzdInfo jzd;
                i++;
                List<IReFeature> findPnts = _database.SystemService.FindFeatures(_jzdClass, px, py, 0.05);
                if (findPnts != null && findPnts.Count == 1)
                {
                    jzd = new JzdInfo(findPnts[0] as Jzd);
                    jzd.Selected = false;
                }
                else
                {
                    jzd = new JzdInfo();
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
                ICoordinate startPnt = _feature.Geometry.Points[i];
                px = startPnt.X;
                py = startPnt.Y;
                ICoordinate endPnt = _feature.Geometry.Points[i + 1];
                px2 = endPnt.X;
                py2 = endPnt.Y;
                //_feature.Geometry.GetPoint(i + 1, out px2, out py2);
                double xx = (px + px2) / 2.0;
                double yy = (py + py2) / 2.0;

                List<IReFeature> findLines = _database.SystemService.FindFeatures(_jzxClass, xx, yy, 0.2);
                if (findLines != null && findLines.Count == 1)
                {
                    jzx = new JzxInfo(findLines[0] as Jzx);
                    jzx.Selected = false;
                }
                else
                {
                    jzx = new JzxInfo();
                    jzx.Selected = true;
                }
                jzx.Zdnsxh = i + 1;
                jzx.CenterX = xx;
                jzx.CenterY = yy;
                jzx.StartX = px;
                jzx.StartY = py;
                jzx.EndX = px2;
                jzx.EndY = py2;
                _jzxInfos.Add(jzx);
            }

            DrawData();
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
                if (_jzdInfos[i].ID < 0)
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
                if (_jzdInfos[i].ID > 0) continue;
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
            frmJzd frm = new frmJzd();
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

        private void frmCreateJZDByZD_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Map.Drawing.Clear();
        }
    }
}