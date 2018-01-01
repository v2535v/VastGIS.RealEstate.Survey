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
using VastGIS.Plugins.RealEstate.Model;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.Services.Views;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate.Forms
{
    //! 后期将初始化配置改为调用配置json文件
    public partial class frmAssignText : MapWindowForm
    {
        private List<TextAssignConfigure> configures;
        public frmAssignText(IAppContext context) :base(context)
        {
            InitializeComponent();
            InitAssins();
        }

        private void InitAssins()
        {
            configures=new List<TextAssignConfigure>();
            configures.Add(new TextAssignConfigure("CAD建筑物材质识别","DXTJMDM","FSXX2",AssignTextType.String, new string[] {"混","砖","砼","破","建"}));
            configures.Add(new TextAssignConfigure("CAD建筑物楼层识别", "DXTJMDM", "FSXX1", AssignTextType.Integer, null));
            chkAssigns.DataSource = configures;
            chkAssigns.DisplayMember = "Name";
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int count = chkAssigns.CheckedItems.Count;
            if (count == 0)
            {
                MessageService.Current.Warn("请选择要识别的内容");
                return;
            }

            ProjectLoadingView _loadingForm;
            _loadingForm = new ProjectLoadingView("CAD文本属性识别",false);
            _context.View.ShowChildView(_loadingForm, false);
            Application.DoEvents();
            _context.View.Lock();


           
            int step = 0;
            foreach (var checkedItem in chkAssigns.CheckedItems)
            {
                TextAssignConfigure configure = checkedItem as TextAssignConfigure ;
                int value = step * 100 / count;
                _loadingForm.ShowProgress(value, "进行分层:" + configure.Name);
                ((IRealEstateContext)_context).RealEstateDatabase.AssignTextToPolygon(configure.AssignType,configure.AssignTable,
                    configure.AssignField, configure.TextTable, configure.TextField,configure.TextWhereClause, configure.TextValues);
                step++;
            }

            _context.View.Unlock();
            _loadingForm.Close();
            _loadingForm.Dispose();
            MessageService.Current.Info("文本属性识别完成!");
        }
    }
}
