using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Attribute
{
    public partial class frmZDJBXXZJ:Form,IReAttributeForm
    {
        private string _objectKey;
        private Zdjbxxzj _linkedObject;
        private string _formName;
        private IAppContext _context;
        private IREDatabase _database;

        public frmZDJBXXZJ()
        {
            InitializeComponent();
            _objectKey = "ZDJBXXZJ";
            _formName = "frmZDJBXXZJ";

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
        }

        public string FormName
        {
            get { return _formName; }
            set { _formName = value; }
        }
        
        public void LoadEntity(string tableName, string entityName, long id)
        {
            _linkedObject = _database.ZdService.GetZdjbxxzj(id);
            LinkObject();
        }

        private  void LinkObject()
        {
            ((INotifyPropertyChanged)_linkedObject).PropertyChanged +=linkedObject_PropertyChanged;
            ucLinkObject.LinkObject(_database,_linkedObject);
        }

        private void linkedObject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            btnSave.Enabled = true;
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            _database.ZdService.SaveZdjbxxzj(_linkedObject as Zdjbxxzj);
        }
    }

}