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
using netDxf;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Helpers;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.Services.Views;
using VastGIS.UI.Forms;
using VastGIS.RealEstate.Api.Concrete;
using VastGIS.Shared;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmImportDXF : MapWindowForm
    {
        public frmImportDXF(IAppContext context):base(context)
        {
            InitializeComponent();
            cmbCodepages.SelectedIndex = 0;
            cmbInsertMethod.SelectedIndex = 0;
        }

        private void btnDXF_Click(object sender, EventArgs e)
        {
            string fileName;
            
            bool returnBack = FileHelper.OpenFile("选择DXF文件", "DXF文件(*.dxf)|*.dxf", 0, _context.View as IMainView,
                out fileName);
            if (!returnBack) return;

            DxfDocument doc = DxfDocument.Load(fileName);
            string codePage = doc.DrawingVariables.DwgCodePage.ToUpper();
            int codepage = 0;
            int.TryParse(codePage.Split('_')[1], out codepage);
            codePage = Encoding.GetEncoding(codepage).BodyName.ToUpper();


            if (!cmbCodepages.Items.Contains(codePage))
            {
                cmbCodepages.Items.Add(codePage);
            }
            cmbCodepages.Text = codePage;
            doc = null;
            txtDXF.Text = fileName;
            IRealEstateContext reContext = ((IRealEstateContext)_context);
            IREDatabase database = reContext.RealEstateDatabase;
            bool hasData= reContext.RealEstateDatabase.HasCADData(fileName);
            if (hasData)
            {
                lblCAD.Text = "数据库里有该DXF文件数据";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string fileName = txtDXF.Text.Trim();
            if (!File.Exists(fileName))
            {
                MessageService.Current.Warn("DXF文件不存在!");
                return;
            }
            if (cmbCodepages.SelectedIndex < 0)
            {
                MessageService.Current.Warn("请选择DXF编码格式!");
                return;
            }
            if (cmbInsertMethod.SelectedIndex < 0)
            {
                MessageService.Current.Warn("请选择数据插入模式!");
                return;
            }

            if (((IRealEstateContext)_context).RealEstateDatabase == null)
            {
                ((IRealEstateContext)_context).CheckDatabase();
            }
            
            ProjectLoadingView _loadingForm;
            _loadingForm = new ProjectLoadingView("导入DXF操作:" + fileName);
            _context.View.ShowChildView(_loadingForm, false);
            Application.DoEvents();
            _context.View.Lock();
            ((IRealEstateContext)_context).RealEstateDatabase.ImportDxfDrawing(fileName, _loadingForm,cmbCodepages.Text,(CADInsertMethod)cmbInsertMethod.SelectedIndex);
            _context.View.Unlock();
            _loadingForm.Close();
            _loadingForm.Dispose();
        }
    }
}
