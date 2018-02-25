using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.Plugins.RealEstate.DataControls;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Attribute
{
    public partial class frmTmpCadx:Form,IReAttributeForm
    {	
        #region 变量
        private string _objectKey;
        private string _formName;
        private TmpCadx _linkedObject;        
        private IAppContext _context;
        private IREDatabase _database;
        #endregion
        
        public frmTmpCadx()
        {
            InitializeComponent();
             _objectKey = "TmpCadx";
            _formName = "frmTmpCadx";
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
                _linkedObject=value as TmpCadx;
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
            _linkedObject = _database.CadService.GetTmpCadx(id);
            LinkObject();
        }
        private  void LinkObject()
        {
            ((INotifyPropertyChanged)_linkedObject).PropertyChanged +=linkedObject_PropertyChanged;
            ucLinkObject.LinkObject(_database,(IEntity)_linkedObject);
            if(_linkedObject.ID<=0)
            {
                btnSave.Text="新建";
            }
            else
                btnSave.Text="保存";
        }

        private void linkedObject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            btnSave.Enabled = true;           
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {
            _database.CadService.SaveTmpCadx(_linkedObject as TmpCadx);
            if(_linkedObject.ID > 0)
            {
                DialogResult=DialogResult.OK;
                return;
            }
            else
            {
                MessageBox.Show("对象未能正确保存!","警告",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
        
        public bool HasPropertyChanged { get { return ucLinkObject.HasChanged; }}
        
    }
}