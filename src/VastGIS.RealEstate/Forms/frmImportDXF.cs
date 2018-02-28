﻿using System;
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
using VastGIS.Api.Interfaces;
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
    public partial class frmImportDXF : Form
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        public frmImportDXF(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
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

            bool hasData = reContext.RealEstateDatabase.CadService.HasCADData(fileName);
            if (hasData)
            {
                lblCAD.Text = "数据库里有该DXF文件数据";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
            string errMsg = "";
            bool retVal = ((IRealEstateContext)_context).RealEstateDatabase.CadService.ImportDxfDrawing(fileName, out errMsg);
            if (retVal == false)
            {
                MessageService.Current.Warn("导入CAD发生错误，" + errMsg);
                _context.View.Unlock();
                _loadingForm.Close();
                _loadingForm.Dispose();
                return;
            }
            _loadingForm.ShowProgress(50, "对导入数据进行分层处理");
            bool isDelete = cmbInsertMethod.SelectedIndex > 1 ? false : true;
            string deleteFileName = cmbInsertMethod.SelectedIndex == 1 ? "" : fileName;
            ((IRealEstateContext)_context).RealEstateDatabase.CadService.ImportTmpCadToBasemap(isDelete, deleteFileName);
            _loadingForm.ShowProgress(80, "对文本属性进行识别处理");
            ((IRealEstateContext)_context).RealEstateDatabase.BasemapService.AssignTextToAttribute();
            _loadingForm.ShowProgress(90, "对多边形数据进行排序处理");
            ((IRealEstateContext)_context).RealEstateDatabase.BasemapService.ReorderAllPolygon("DXTJMDM");
            _context.View.Unlock();
            _loadingForm.Close();
            _loadingForm.Dispose();
            IEnvelope envelope = ((IRealEstateContext)_context).RealEstateDatabase.GetDatabaseEnvelope();
            _context.Map.ZoomToExtents(envelope);
            DialogResult = DialogResult.OK;
        }
    }
}
