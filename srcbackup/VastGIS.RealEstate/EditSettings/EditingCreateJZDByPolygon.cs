using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Spatial;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSGeo.OGR;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Model;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate.EditSettings
{
    public partial class EditingCreateJZDByPolygon : MapWindowForm
    {
        private List<SelectLayerConfigure> _selectedConfigures;
        private DataTable _vertexTable;
        public EditingCreateJZDByPolygon(IAppContext context):base(context)
        {
            InitializeComponent();
            InitSelectedConfigures();
            InitTables();
        }

        private void InitTables()
        {
            _vertexTable=new DataTable();
            _vertexTable.Columns.Add(new DataColumn("IsInsert")
                                         {
                                             Caption = "选择",
                                             DataType = typeof(System.Boolean),
                                             DefaultValue = true
                                         });
            _vertexTable.Columns.Add(new DataColumn("ID")
                                         {
                                             Caption = "序号",
                                             DataType = typeof(System.String),
                                             AllowDBNull = true
                                         });
            _vertexTable.Columns.Add(new DataColumn("JZDBH")
                                         {
                                             Caption = "已有编号",
                                             DataType = typeof(System.String),
                                             AllowDBNull = true
                                         });
            _vertexTable.Columns.Add(new DataColumn("X")
                                         {
                                             Caption = "X",
                                             DataType = typeof(System.Double),
                                             AllowDBNull = true
                                         });
            _vertexTable.Columns.Add(new DataColumn("Y")
                                         {
                                             Caption = "Y",
                                             DataType = typeof(System.Double),
                                             AllowDBNull = true
                                         });
            dataGridView1.DataSource = _vertexTable;
        }

        private void InitSelectedConfigures()
        {
            _selectedConfigures = new List<SelectLayerConfigure>();
            _selectedConfigures.Add(new SelectLayerConfigure()
                                        {
                                            CanSelect=true,
                                            GeometryType=GeometryType.Polygon,
                                            Layer="地形图居民地",
                                            Table="DXTJMDM"
                                        });
            lstSelectedLayers.DataSource = _selectedConfigures;
            lstSelectedLayers.DisplayMember = "Layer";
            for (int i = 0; i < lstSelectedLayers.Items.Count; i++)
            {
                lstSelectedLayers.SetItemChecked(i,_selectedConfigures[i].CanSelect);
            }
        }

        private void lstSelectedLayers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            _selectedConfigures[e.Index].CanSelect = e.NewValue == CheckState.Unchecked ? false : true;
        }

        public void SetPolygon(DbGeometry polygon)
        {
            _vertexTable.Rows.Clear();
            
            int? pntCount = polygon.PointCount;
            for (int i = 0; i < pntCount; i++)
            {
                DataRow row=_vertexTable.NewRow();
                row[1] = i + 1;
                row[2] = "";
                DbGeometry point = polygon.PointAt(i+1);
                row[3] = point.XCoordinate;
                row[4] = point.YCoordinate;
                _vertexTable.Rows.Add(row);
            }
        }

       

        private string[] GetSearchLayers()
        {
            string[] layers=new string[lstSelectedLayers.CheckedItems.Count];
            for (int i = 0; i<lstSelectedLayers.CheckedItems.Count; i++)
            {
                layers[i] = _selectedConfigures[i].Table;
            }
            return layers;
        }
        public void SetQueryPoint(double dx, double dy)
        {
           //IFeature pFeature= ((IRealEstateContext)_context).RealEstateDatabase.FindFirstRecord(GetSearchLayers(), dx, dy);
           // if (pFeature != null)
           // {
           //     SetPolygon(pFeature.Geometry);
           // }
        }
    }
}
