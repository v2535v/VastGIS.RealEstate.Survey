using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmDistanceIntersection : MapEditingForm,IEditForm
    {
        private IREDatabase _database;
        private List<VgObjectclasses> _classes;
        private bool _isFirst = true;
        private ICoordinate _point1;
        private ICoordinate _point2;

        private ICoordinate _respoint1;
        private ICoordinate _respoint2;
        public frmDistanceIntersection(IAppContext context):base(context)
        {
            InitializeComponent();
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            List<VgObjectclasses> classes = _database.SystemService.GetVgObjectclassess(" Editable = 1 And Txlx=1 ").ToList();
            ucSelectLayer1.SetClasses(classes);
            _classes = classes;
            ucSelectLayer1.GeometryType= GeometryType.Point;
            ucSelectLayer1.Label = "编辑图层";
            ucSelectLayer1.SingleSelect = true;
            _isFirst = true;
            distPoint1.MinValue = 0;
            distPoint2.MinValue = 0;

            distPoint1.TextChanged += distPoint_TextChanged;
            distPoint2.TextChanged += distPoint_TextChanged;
        }

        public void distPoint_TextChanged(object sender, EventArgs args)
        {
            LoadText();
        }

        public void SetQueryPoint(double dx, double dy)
        {
            double x2=0.0;
            double y2=0.0;
            
            bool pFind=_context.Map.FindSnapPoint(_context.Config.MouseTolerance, dx, dy, ref x2, ref y2);
            if (pFind)
            {
                if (_isFirst)
                {
                    _point1=new Coordinate(x2,y2);
                    LoadText();
                    
                }
                else
                {
                    _point2 = new Coordinate(x2, y2);
                    LoadText();
                    //txtPoint2.Text = string.Format("X={0},Y={1}", x2, y2);
                }
            }
        }

        private void LoadText()
        {
            _context.Map.Drawing.Clear();
            _context.Map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
            if (_point1 != null)
            {
                txtPoint1.Text = string.Format("X={0},Y={1}", _point1.X, _point1.Y);
                _context.Map.Drawing.DrawCircle(_point1.X, _point1.Y, 0.3, Color.Red, true, 1);
                if (distPoint1.DoubleValue > 0)
                {
                    _context.Map.Drawing.DrawCircle(_point1.X, _point1.Y, distPoint1.DoubleValue, Color.Blue, false, 1);
                }
            }
            else
            {
                txtPoint1.Text = "";
            }
            if (_point2 != null)
            {
                txtPoint2.Text = string.Format("X={0},Y={1}", _point2.X, _point2.Y);
                _context.Map.Drawing.DrawCircle(_point2.X, _point2.Y, 0.3, Color.Red, true, 1);
                if (distPoint2.DoubleValue > 0)
                {
                    _context.Map.Drawing.DrawCircle(_point2.X, _point2.Y, distPoint2.DoubleValue, Color.Blue, false, 1);
                }
            }
            else
            {
                txtPoint2.Text = "";
            }


            if (_respoint2 != null)
            {
                _context.Map.Drawing.DrawLabel("2", _respoint2.X, _respoint2.Y, 0);
            }
            if (_respoint1 != null)
            {
                _context.Map.Drawing.DrawLabel("1", _respoint1.X, _respoint1.Y, 0);
            }
        }
        private void btnPoint1_Click(object sender, EventArgs e)
        {
            _isFirst = true;
        }

        private void btnPoint2_Click(object sender, EventArgs e)
        {
            _isFirst = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ICoordinate point1 = null;
            ICoordinate point2 = null;
            if (_point1 == null || _point2 == null)
            {
                lblInfo.Text = "请输入参考点";
                return;
            }
            if (distPoint1.DoubleValue <= 0 || distPoint2.DoubleValue <= 0)
            {
                lblInfo.Text = "请输入参考点距离";
                return;
            }
           int num= GeometryHelper.DistanceIntersection(_point1, distPoint1.DoubleValue, _point2, distPoint2.DoubleValue,
                out point1, out point2);
            chkCreate1.Enabled=  num > 0;
            chkCreate2.Enabled =  num > 1;
            if (num == 0)
            {
                lblInfo.Text = "无交点";
            }
            else if (num == 1)
            {
                lblInfo.Text = "两圆相切";
            }

            _respoint1 = point1;
            _respoint2 = point2;
            LoadText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            _point1 = null;
            _point2 = null;
            _respoint1 = null;
            _respoint2 = null;
            LoadText();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ucSelectLayer1.SelectedClass == null)
            {
                lblInfo.Text = "请选择目标图层";
                return;
            }
            if (_respoint1 == null && chkCreate1.Checked)
            {
                lblInfo.Text = "交点一不存在";
                return;
            }
            if (_respoint2 == null && chkCreate2.Checked)
            {
                lblInfo.Text = "交点二不存在";
                return;
            }
            SearchFeature feature;
            if (chkCreate1.Checked)
                feature = new SearchFeature()
                                      {
                                          Wkt=string.Format("POINT({0} {1})",_respoint1.X,_respoint1.Y),
                                          TableName=ucSelectLayer1.SelectedClass.Mc,
                                          Ysdm = ucSelectLayer1.SelectedClass.Qsdm
                                      };
            else
                feature = new SearchFeature()
                              {
                                  Wkt = string.Format("POINT({0} {1})", _respoint2.X, _respoint2.Y),
                                  TableName = ucSelectLayer1.SelectedClass.Mc,
                                  Ysdm = ucSelectLayer1.SelectedClass.Qsdm
                };

            long rowId=_database.SystemService.SaveSearchFeature(feature);
            if (rowId > 0)
            {
                if (MessageService.Current.Ask("编辑该对象属性吗?") == false)
                {
                    Clear();
                    return;
                }
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            _context.CurrentTool = null;
        }

        private void chkCreate1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
