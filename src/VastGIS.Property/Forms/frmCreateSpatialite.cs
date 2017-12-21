using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Interfaces.Projections;
using VastGIS.Plugins.Services;
using VastGIS.Projections.BL;
using VastGIS.Projections.Forms;
using VastGIS.UI.Forms;

namespace VastGIS.Property.Forms
{
    public partial class frmCreateSpatialite : MapWindowForm
    {
        private readonly IAppContext _context;
        public frmCreateSpatialite(IAppContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog=new SaveFileDialog();
            dialog.Title = "输入Sqlite数据库名称";
            dialog.Filter = "Spatialite数据库(*.sqlite)|*.sqlite";
            dialog.CheckPathExists = true;
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            txtDB.Text = dialog.FileName;
        }

        private void btnCoordSys_Click(object sender, EventArgs e)
        {
            using (var form = new ChooseProjectionForm(_context.Projections, _context))
            {
                if (_context.View.ShowChildView(form))
                {
                    CoordinateSystem cs = form.SelectedCoordinateSystem;
                    txtCoordSys.Text = cs.Name;
                    txtCoordSys.Tag = cs;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           DialogResult= DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDB.Text.Trim()))
            {
                MessageService.Current.Warn("请输入数据库名称");
                return;
            }
            FileInfo info=new FileInfo(txtDB.Text);
            if (info.Exists || info.Directory.Exists == false)
            {
                MessageService.Current.Warn("输入数据库已经存在或者数据库目录不存在，请检查后重新输入!");
                return;
            }
            if (txtCoordSys.Tag == null)
            {
                MessageService.Current.Warn("请选择坐标系！");
                return;
            }
            DialogResult=DialogResult.OK;
        }

        public string DatabaseName { get { return txtDB.Text; } }

        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                if (txtCoordSys.Tag == null) return null;
                return (ICoordinateSystem)txtCoordSys.Tag;
            }
        }
    }
}
