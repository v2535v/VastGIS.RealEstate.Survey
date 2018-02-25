using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucFdcqxm:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Fdcqxm _fdcqxm;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucFdcqxm()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Ghyt", "FWYTZD");
            _dictionaryNames.Add("Fwjg", "FWJGZD");
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
            _fdcqxm=entity as Fdcqxm;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_fdcqxm,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_fdcqxm,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXmmc.DataBindings.Clear();
            txtXmmc.DataBindings.Add("Text",_fdcqxm,"Xmmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZh.DataBindings.Clear();
            txtZh.DataBindings.Add("Text",_fdcqxm,"Zh",true,DataSourceUpdateMode.OnPropertyChanged);
            intZcs.DataBindings.Clear();
            intZcs.DataBindings.Add("IntegerValue",_fdcqxm,"Zcs",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbGhyt.DataBindings.Clear();
            cmbGhyt.DataBindings.Add("SelectedValue",_fdcqxm,"Ghyt",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwjg.DataBindings.Clear();
            cmbFwjg.DataBindings.Add("SelectedValue",_fdcqxm,"Fwjg",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJzmj.DataBindings.Clear();
            dblJzmj.DataBindings.Add("DoubleValue",_fdcqxm,"Jzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            datJgsj.DataBindings.Clear();
            datJgsj.DataBindings.Add("BindableValue",_fdcqxm,"Jgsj",true,DataSourceUpdateMode.OnPropertyChanged);
            intZts.DataBindings.Clear();
            intZts.DataBindings.Add("IntegerValue",_fdcqxm,"Zts",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_fdcqxm).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_fdcqxm);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_fdcqxm);
        }        
        #endregion
        
        
    }
}