using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucVgObjectysdm:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private VgObjectysdm _vgObjectysdm;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucVgObjectysdm()
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
            _vgObjectysdm=entity as VgObjectysdm;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_vgObjectysdm,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_vgObjectysdm,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsmc.DataBindings.Clear();
            txtYsmc.DataBindings.Add("Text",_vgObjectysdm,"Ysmc",true,DataSourceUpdateMode.OnPropertyChanged);
            intXssx.DataBindings.Clear();
            intXssx.DataBindings.Add("IntegerValue",_vgObjectysdm,"Xssx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQsbg.DataBindings.Clear();
            txtQsbg.DataBindings.Add("Text",_vgObjectysdm,"Qsbg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQsfh.DataBindings.Clear();
            txtQsfh.DataBindings.Add("Text",_vgObjectysdm,"Qsfh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSfkj.DataBindings.Clear();
            txtSfkj.DataBindings.Add("Text",_vgObjectysdm,"Sfkj",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_vgObjectysdm).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_vgObjectysdm);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_vgObjectysdm);
        }        
        #endregion
        
        
    }
}