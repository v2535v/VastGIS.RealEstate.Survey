using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucR:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private R _r;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucR()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
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
            _r=entity as R;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_r,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_r,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrmc.DataBindings.Clear();
            txtQlrmc.DataBindings.Add("Text",_r,"Qlrmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrpy.DataBindings.Clear();
            txtQlrpy.DataBindings.Add("Text",_r,"Qlrpy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtPysx.DataBindings.Clear();
            txtPysx.DataBindings.Add("Text",_r,"Pysx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZjzl.DataBindings.Clear();
            txtZjzl.DataBindings.Add("Text",_r,"Zjzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZjh.DataBindings.Clear();
            txtZjh.DataBindings.Add("Text",_r,"Zjh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFzjg.DataBindings.Clear();
            txtFzjg.DataBindings.Add("Text",_r,"Fzjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSshy.DataBindings.Clear();
            txtSshy.DataBindings.Add("Text",_r,"Sshy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGj.DataBindings.Clear();
            txtGj.DataBindings.Add("Text",_r,"Gj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtHjszss.DataBindings.Clear();
            txtHjszss.DataBindings.Add("Text",_r,"Hjszss",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXb.DataBindings.Clear();
            txtXb.DataBindings.Add("Text",_r,"Xb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDh.DataBindings.Clear();
            txtDh.DataBindings.Add("Text",_r,"Dh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDz.DataBindings.Clear();
            txtDz.DataBindings.Add("Text",_r,"Dz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYb.DataBindings.Clear();
            txtYb.DataBindings.Add("Text",_r,"Yb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGzdw.DataBindings.Clear();
            txtGzdw.DataBindings.Add("Text",_r,"Gzdw",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDzyj.DataBindings.Clear();
            txtDzyj.DataBindings.Add("Text",_r,"Dzyj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_r,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_r).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_r);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_r);
        }        
        #endregion
        
        
    }
}