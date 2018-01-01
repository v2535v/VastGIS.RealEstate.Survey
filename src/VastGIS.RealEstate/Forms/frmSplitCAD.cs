using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.Services.Views;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmSplitCAD : MapWindowForm
    {
        public frmSplitCAD(IAppContext context):base(context)
        {
            InitializeComponent();
            InitLayers();
        }

        private void InitLayers()
        {
            lstLayers.Items.Add("居民地,JMD,DXTJMD",true);
            lstLayers.Items.Add("控制点,KZD,DXTKZD", true);
            lstLayers.Items.Add("道路设施,DLSS,DXTDLSS", true);
            lstLayers.Items.Add("独立地物,DLDW,DXTDLDW", true);
            lstLayers.Items.Add("地貌土质,DMTZ,DXTDMTZ", true);
            lstLayers.Items.Add("注记,ZJ,DXTZJ", true);
        }

        private void lstLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = lstLayers.SelectedItem.ToString();
            txtPair.Text = selected;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtPair.Text.Trim() == "") return;
            string[] texts = this.txtPair.Text.Trim().Split(',');
            if (texts.Length != 3)
            {
                MessageService.Current.Warn("配置格式为：中文名称,CAD图层名称,数据库内表名");
                return;
            }
            lstLayers.Items.Add(txtPair.Text, true);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool isClear = chkClear.Checked;
            bool isOther = chkOther.Checked;
            ProjectLoadingView _loadingForm;
            _loadingForm = new ProjectLoadingView("CAD图层分层");
            _context.View.ShowChildView(_loadingForm, false);
            Application.DoEvents();
            _context.View.Lock();
           
        
            int total = isOther == true ? lstLayers.CheckedItems.Count + 1 : lstLayers.CheckedItems.Count;
            int step = 0;
            foreach (var checkedItem in lstLayers.CheckedItems)
            {
                string pairStr = checkedItem.ToString();
                string[] pairStrs = pairStr.Split(',');
                int value = step*100 / total;
                _loadingForm.ShowProgress(value,"进行分层:"+pairStrs[0]);
                ((IRealEstateContext)_context).RealEstateDatabase.SplitTmpCadIntoLayers(pairStrs[1],pairStrs[2],"",isClear);
            }
            if (isOther)
            {
                _loadingForm.ShowProgress(100, "进行分层:其他");
                ((IRealEstateContext)_context).RealEstateDatabase.SplitTmpCadIntoLayers("", "DXTQT", "", isClear);
            }
            _context.View.Unlock();
            _loadingForm.Close();
            _loadingForm.Dispose();
            MessageService.Current.Info("CAD数据分层完成!");
        }
    }
}
