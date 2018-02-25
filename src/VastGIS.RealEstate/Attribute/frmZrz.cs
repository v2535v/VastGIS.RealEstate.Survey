using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.Plugins.RealEstate.DataControls;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Attribute
{
    public partial class frmZrz:Form,IReAttributeForm
    {	
        #region 变量
        private string _objectKey;
        private string _formName;
        private Zrz _linkedObject;        
        private IAppContext _context;
        private IREDatabase _database;
        private BindingList<C> _linkedCs;
        #endregion
        
        public frmZrz()
        {
            InitializeComponent();
             _objectKey = "Zrz";
            _formName = "frmZrz";
        }
        
        public IAppContext Context
        {
            get { return _context; }
            set
            {
                _context = value;
                _database = ((IRealEstateContext)_context).RealEstateDatabase;
            }
        }
        public string ObjectKey
        {
            get { return _objectKey; }
            set { _objectKey = value; }
        }

        public IEntity LinkedObject
        {
            get { return _linkedObject as IEntity; }
            set{
                _linkedObject=value as Zrz;
                LinkObject();
            }            
        }

        public string FormName
        {
            get { return _formName; }
            set { _formName = value; }
        }
        
        public void LoadEntity(string tableName, string entityName, long id)
        {
            _linkedObject = _database.ZdService.GetZrz(id);
            LinkObject();
        }
        private  void LinkObject()
        {
            ((INotifyPropertyChanged)_linkedObject).PropertyChanged +=linkedObject_PropertyChanged;
            ucLinkObject.LinkObject(_database,(IEntity)_linkedObject);
            ucWXInfo1.LinkObject(_linkedObject as ISurveyEntity);
            ucAttachmentList1.BindContext(_context);
            ucAttachmentList1.LinkObject(_linkedObject as IGlobalEntity);
            if (_linkedObject.ID <= 0)
            {
                btnSave.Text = "新建";
                pageC.Visible = false;
            }
            else
            {
                btnSave.Text = "保存";
                pageC.Visible = true;
                LoadC();
            }
        }

        private void linkedObject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            btnSave.Enabled = true;           
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {
            _database.ZdService.SaveZrz(_linkedObject as Zrz);
            if(_linkedObject.ID > 0)
            {
               // DialogResult=DialogResult.OK;
                LoadC();
                return;
            }
            else
            {
                MessageBox.Show("对象未能正确保存!","警告",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
        }

        private void LoadC()
        {
            pageC.Visible = true;
            List<C> cs = _database.ZdService.GetCS("WX_WYDM='" + _linkedObject.WxWydm + "'").ToList();
            intQSCS.IntegerValue = _linkedObject.Dxcs.Value;
            intJSCS.IntegerValue = _linkedObject.Dscs.Value;
            _linkedCs = new BindingList<C>();
            if (cs != null && cs.Count > 0)
            {
                foreach (C c in cs)
                {
                    _linkedCs.Add(c);
                }
            }
                
            lstC.DataSource = _linkedCs;
            lstC.DisplayMember = "FullLabelString";
            lstC.ValueMember = "ID";
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
        
        public bool HasPropertyChanged { get { return ucLinkObject.HasChanged; }}

        private void btnCreateC_Click(object sender, EventArgs e)
        {
            long qsC = intQSCS.IntegerValue;
            long jsC = intJSCS.IntegerValue;
            if (jsC <= qsC)
            {
                MessageBox.Show("起始层数必须小于结束层数!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (long i = qsC; i <= jsC; i++)
            {
                //开始创建层，创建层之前先检查原来层是否存在!
                if (i == 0) continue;
                C findC = _linkedCs.FirstOrDefault(c => c.Sjc == i);
                if (findC != null && findC.Sjc==i) continue;
                C newC=new C();
                newC.Sjc = i;
                newC.Myc = i.ToString();
                newC.Jsbl = 1.0;
                newC.Cfwlx = "1";
                newC.WxWydm = _linkedObject.WxWydm;
                _linkedCs.Add(newC);
            }
        }

        private void lstC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstC.SelectedIndex < 0)
            {
                btnDeleteC.Enabled = btnDeleteCAll.Enabled=btnOpenCForm.Enabled =btnSaveC.Enabled= false;
                return;
            }
            btnDeleteC.Enabled = btnDeleteCAll.Enabled = btnOpenCForm.Enabled = btnSaveC.Enabled = true;
            C currentC = lstC.SelectedItem as C;
            ucC1.LinkObject(_database,currentC);
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if (lstC.SelectedIndex < 0)
            {
                return;
            }
            if (MessageBox.Show("你确认要删除该层信息吗?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No) return;

            C currentC = lstC.SelectedItem as C;
            if (currentC.ID <= 0)
            {
                _linkedCs.RemoveAt(lstC.SelectedIndex);
            }
            else
            {
                _database.ZdService.DeleteC(currentC);
            }
        }

        private void btnDeleteCAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确认要删除所有层信息吗?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No) return;
            int count = _linkedCs.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                C currentC = _linkedCs[i];
                if (currentC.ID <= 0)
                {
                    _linkedCs.RemoveAt(i);
                }
                else
                {
                    _database.ZdService.DeleteC(currentC);
                }
            }
            _linkedCs.Clear();
        }

        private void btnOpenCForm_Click(object sender, EventArgs e)
        {
            if (lstC.SelectedIndex < 0)
            {
                return;
            }
            frmC frm=new frmC();
            C currentC = lstC.SelectedItem as C;
            frm.BindContext(_context,currentC);
            frm.LinkObject();
            frm.ShowDialog();
        }

        private void btnSaveC_Click(object sender, EventArgs e)
        {
            if (lstC.SelectedIndex < 0)
            {
                return;
            }
            ucC1.Save();
        }
    }
}