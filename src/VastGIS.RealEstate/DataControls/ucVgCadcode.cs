using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucVgCadcode:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private VgCadcode _vgCadcode;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucVgCadcode()
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
            _vgCadcode=entity as VgCadcode;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_vgCadcode,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXh.DataBindings.Clear();
            txtXh.DataBindings.Add("Text",_vgCadcode,"Xh",true,DataSourceUpdateMode.OnPropertyChanged);
            intSfcy.DataBindings.Clear();
            intSfcy.DataBindings.Add("IntegerValue",_vgCadcode,"Sfcy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTc.DataBindings.Clear();
            txtTc.DataBindings.Add("Text",_vgCadcode,"Tc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtCassdm.DataBindings.Clear();
            txtCassdm.DataBindings.Add("Text",_vgCadcode,"Cassdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTxlx.DataBindings.Clear();
            txtTxlx.DataBindings.Add("Text",_vgCadcode,"Txlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXtc.DataBindings.Clear();
            txtXtc.DataBindings.Add("Text",_vgCadcode,"Xtc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_vgCadcode,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYslx.DataBindings.Clear();
            txtYslx.DataBindings.Add("Text",_vgCadcode,"Yslx",true,DataSourceUpdateMode.OnPropertyChanged);
            intYszl.DataBindings.Clear();
            intYszl.DataBindings.Add("IntegerValue",_vgCadcode,"Yszl",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_vgCadcode).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_vgCadcode);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_vgCadcode);
        }        
        #endregion
        
        
    }
}