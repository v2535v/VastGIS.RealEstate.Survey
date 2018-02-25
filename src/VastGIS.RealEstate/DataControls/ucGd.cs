using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucGd:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Gd _gd;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucGd()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Djdl", "DJLXZD");
             intID.Enabled = false;
            _hasChanged=false;
        }
        
        private void InitDictionaries()
        {
            foreach (var onepair in _dictionaryNames)
            {
                string dName = onepair.Key;
                string dValue = onepair.Value;
                List<VgDictionary> _dicts = _database.DomainService.GetDictionaryByName(dValue);
                ComboBoxAdv combo = FindControl(this,"cmb" + onepair.Key) as ComboBoxAdv;
                combo.DataSource = _dicts;
                combo.DisplayMember ="Zdsm";
                combo.ValueMember ="Zdz";
            }
        }
        
        private Control FindControl(Control control, string controlName)
        {
            Control c1;
            foreach (Control c in control.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
                else if (c.Controls.Count > 0)
                {
                    c1 = FindControl(c, controlName);
                    if (c1 != null)
                    {
                        return c1;
                    }
                }
            }
            return null;
        }
        
        public void LinkObject(IREDatabase database,IEntity entity)
        {
            _database = database; 
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            _gd=entity as Gd;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_gd,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_gd,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_gd,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjdl.DataBindings.Clear();
            cmbDjdl.DataBindings.Add("SelectedValue",_gd,"Djdl",true,DataSourceUpdateMode.OnPropertyChanged);
            intDjxl.DataBindings.Clear();
            intDjxl.DataBindings.Add("IntegerValue",_gd,"Djxl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZl.DataBindings.Clear();
            txtZl.DataBindings.Add("Text",_gd,"Zl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQzhm.DataBindings.Clear();
            txtQzhm.DataBindings.Add("Text",_gd,"Qzhm",true,DataSourceUpdateMode.OnPropertyChanged);
            intWjjs.DataBindings.Clear();
            intWjjs.DataBindings.Add("IntegerValue",_gd,"Wjjs",true,DataSourceUpdateMode.OnPropertyChanged);
            intZys.DataBindings.Clear();
            intZys.DataBindings.Add("IntegerValue",_gd,"Zys",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGdry.DataBindings.Clear();
            txtGdry.DataBindings.Add("Text",_gd,"Gdry",true,DataSourceUpdateMode.OnPropertyChanged);
            datGdsj.DataBindings.Clear();
            datGdsj.DataBindings.Add("BindableValue",_gd,"Gdsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_gd,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_gd).PropertyChanged += Entity_PropertyChanged;
            _hasChanged=false;
        }

        private void Entity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _hasChanged=true;
        }
        
        #region IEntityControl接口
        public bool HasChanged{get{return _hasChanged;}}
        public bool Save()
        {
            return _database.SystemService.Save((IEntity)_gd);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_gd);
        }        
        #endregion
        
        
    }
}