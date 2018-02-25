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
    public partial class frmDyiq:Form,IAttributeForm
    {	
        #region 变量
        protected string _objectKey;
        protected string _formName;
        protected Dyiq _linkedObject;
        protected IAppContext _context;
        protected IREDatabase _database;
        protected List<IEntity> _list;
        protected VgObjectclass _class;
        protected int _index;
        protected bool _isNew = false;
        #endregion

        public frmDyiq()
        {
            InitializeComponent();
             _objectKey = "Dyiq";
            _formName = "frmDyiq";
        }
        
        public void BindContext(IAppContext context,VgObjectclass currentObjectclass)
        {
            _context = context;
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            _list = _database.SystemService.GetEntities(currentObjectclass, string.Empty);
            if (_list.Count > 0)
            {
                LoadEntity(0);
            }
        }
        
        public void BindContext(IAppContext context,IEntity entity)
        {
            _context=context;
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            _index=-1;
            btnPrev.Visible=btnNext.Visible=btnQuery.Visible=btnDelete.Visible=false;
            _linkedObject=entity as Dyiq;
        }

        public void LoadEntities(List<IEntity> entities)
        {
            _list = entities;
            Current = entities.Count > 0 ? 0 : -1;
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
                _linkedObject=value as Dyiq;
                LinkObject();
            }            
        }

        public string FormName
        {
            get { return _formName; }
            set { _formName = value; }
        }
        
        public void LoadEntity(int index)
        {
            _linkedObject = _list[index] as Dyiq;
            LinkObject();
        }

        public int Current { get { return _index; } set { _index = value;LoadEntity(_index); } }

        public void GoToPrev()
        {
            if (_index >0)
            {
                Current = _index - 1;
            }
        }

        public void GoToNext()
        {
            if (_index < _list.Count - 1)
            {
                Current = _index + 1;
            }
        }

        public void CreateNew()
        {
            _isNew = true;
            _linkedObject=new Dyiq();
            LinkObject();
        }

        public void DeleteCurrent()
        {
            if (_linkedObject == null) return;
            if (_isNew)
            {
                btnDelete.Text = "删除";
                _isNew = false;
                Current = _index;
                return;
            }
            if (MessageBox.Show("你确定删除该记录吗?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.Cancel) return;
            _database.SystemService.Delete(_linkedObject);
            _list.RemoveAt(_index);
            if (_list.Count ==_index+1)
            {
                Current = _index;
            }
            else
            {
                int index = _index - 1;
                Current = index;
            }
        }

        public void Save()
        {
            _database.SystemService.Save(_linkedObject);
            if (_linkedObject.ID > 0)
            {
                if (_isNew && _list !=null)
                {
                    _list.Add(_linkedObject);
                    Current = _list.Count - 1;
                }

                return;
            }
            else
            {
                MessageBox.Show("对象未能正确保存!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public void FormClose()
        {
            DialogResult=DialogResult.Cancel;
        }

        public  void LinkObject()
        {
            ((INotifyPropertyChanged)_linkedObject).PropertyChanged +=linkedObject_PropertyChanged;
            ucLinkObject.LinkObject(_database,(IEntity)_linkedObject);
            if (_linkedObject.ID <= 0 || _isNew)
            {
                btnSave.Text = "新建";
                btnDelete.Text = "取消新建";
                btnPrev.Enabled = btnNext.Enabled = btnQuery.Enabled = false;
            }
            else
            {
                btnSave.Text = "保存";
                btnDelete.Text = "删除";
                btnPrev.Enabled = _index > 0;
                btnNext.Enabled =_list != null && _index < _list.Count - 1;
                btnQuery.Enabled = _list != null;
              
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
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            FormClose();
        }
        
        public bool HasPropertyChanged { get { return ucLinkObject.HasChanged; }}

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            GoToPrev();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GoToNext();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCurrent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNew();
        }
    }
}