using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucSlsq:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Slsq _slsq;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucSlsq()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Djdl", "DJLXZD");
            _dictionaryNames.Add("Sqzsbs", "ZSBSZD");
            _dictionaryNames.Add("Sqfbcz", "SFZD");
            _dictionaryNames.Add("Qxdm", "VG_AREACODES");
            _dictionaryNames.Add("Tzfs", "TZFSZD");
            _dictionaryNames.Add("Sfwtaj", "SFZD");
            _dictionaryNames.Add("Ajzt", "AJZTZD");
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
            _slsq=entity as Slsq;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_slsq,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_slsq,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_slsq,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjdl.DataBindings.Clear();
            cmbDjdl.DataBindings.Add("SelectedValue",_slsq,"Djdl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjxl.DataBindings.Clear();
            txtDjxl.DataBindings.Add("Text",_slsq,"Djxl",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSqzsbs.DataBindings.Clear();
            cmbSqzsbs.DataBindings.Add("SelectedValue",_slsq,"Sqzsbs",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSqfbcz.DataBindings.Clear();
            cmbSqfbcz.DataBindings.Add("SelectedValue",_slsq,"Sqfbcz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_slsq,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSlry.DataBindings.Clear();
            txtSlry.DataBindings.Add("Text",_slsq,"Slry",true,DataSourceUpdateMode.OnPropertyChanged);
            datSlsj.DataBindings.Clear();
            datSlsj.DataBindings.Add("BindableValue",_slsq,"Slsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZl.DataBindings.Clear();
            txtZl.DataBindings.Add("Text",_slsq,"Zl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTzrxm.DataBindings.Clear();
            txtTzrxm.DataBindings.Add("Text",_slsq,"Tzrxm",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbTzfs.DataBindings.Clear();
            cmbTzfs.DataBindings.Add("SelectedValue",_slsq,"Tzfs",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTzrdh.DataBindings.Clear();
            txtTzrdh.DataBindings.Add("Text",_slsq,"Tzrdh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTzryddh.DataBindings.Clear();
            txtTzryddh.DataBindings.Add("Text",_slsq,"Tzryddh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTzrdzyj.DataBindings.Clear();
            txtTzrdzyj.DataBindings.Add("Text",_slsq,"Tzrdzyj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSfwtaj.DataBindings.Clear();
            cmbSfwtaj.DataBindings.Add("SelectedValue",_slsq,"Sfwtaj",true,DataSourceUpdateMode.OnPropertyChanged);
            datJssj.DataBindings.Clear();
            datJssj.DataBindings.Add("BindableValue",_slsq,"Jssj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbAjzt.DataBindings.Clear();
            cmbAjzt.DataBindings.Add("SelectedValue",_slsq,"Ajzt",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_slsq,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_slsq).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_slsq);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_slsq);
        }        
        #endregion
        
        
    }
}