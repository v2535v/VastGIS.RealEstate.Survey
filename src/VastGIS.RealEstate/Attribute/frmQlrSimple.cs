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
    public partial class frmQlrSimple : Form
    {	
        #region 变量
        protected string _objectKey;
        protected string _formName;
        private Qlr _linkedObject;
        protected IAppContext _context;
        protected IREDatabase _database;
        protected VgObjectclass _class;
        protected int _index;
        protected bool _isNew = false;
        #endregion

        public frmQlrSimple()
        {
            InitializeComponent();
             _objectKey = "Qlr";
            _formName = "frmQlrSimple";
        }
        
        public void BindContext(IAppContext context,IEntity entity)
        {
            _context=context;
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            _index=-1;
            LinkedObject = entity as Qlr;
            
        }
        
        public IEntity LinkedObject
        {
            get { return _linkedObject as IEntity; }
            set{
                _linkedObject=value as Qlr;
                if (_linkedObject == null)
                    return;
                LinkObject();
            }            
        }
        
        
        public void CreateNew()
        {
            _isNew = true;
            _linkedObject=new Qlr();
            LinkObject();
        }
        
        public void Save()
        {
            _database.SystemService.Save(_linkedObject);
            if (_linkedObject.ID > 0)
            {
            }
            else
            {
                MessageBox.Show("对象未能正确保存!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        
        public  void LinkObject()
        {
            ((INotifyPropertyChanged)_linkedObject).PropertyChanged +=linkedObject_PropertyChanged;
            ucLinkObject.LinkObject(_context,(IEntity)_linkedObject);
            if (_linkedObject.ID <= 0 || _isNew)
            {
                btnSave.Text = "新建";
            }
            else
            {
                btnSave.Text = "保存";
            }

        }

        private void linkedObject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            btnSave.Enabled = true;           
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        
        public bool HasPropertyChanged { get { return ucLinkObject.HasChanged; }}
    }
}