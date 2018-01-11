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
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Attribute
{
    public partial class frmDJZQ : Form,IReAttributeForm
    {
        private string _objectKey;
        private Djzq _linkedObject;
        private string _formName;
        private IAppContext _context;
        private IREDatabase _database;

        public frmDJZQ()
        {
            InitializeComponent();
            _objectKey = "DJZQ";
            _formName = "frmDJZQ";
        }


        public IAppContext Context
        {
            get { return _context; }
            set { _context = value; _database = ((IRealEstateContext)_context).RealEstateDatabase; }
        }
        public string ObjectKey
        {
            get { return _objectKey; }
            set { _objectKey = value; }
        }

        public IEntity LinkedObject
        {
            get { return _linkedObject; }
        }

        public void LoadEntity(string tableName, string entityName, long id)
        {
            _linkedObject = _database.ZdService.GetDjzq(id);
            LinkObject();
        }

        private  void LinkObject()
        {
            ((INotifyPropertyChanged)_linkedObject).PropertyChanged +=dzjq_PropertyChanged;
            ucDJZQ1.LinkObject(_linkedObject);
            ucWXInfo1.LinkObject(_linkedObject);
        }

        private void dzjq_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            btnSave.Enabled = true;
        }

        public string FormName
        {
            get { return _formName; }
            set { _formName = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _database.ZdService.SaveDjzq(_linkedObject as Djzq);
        }
    }
}
