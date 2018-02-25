using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucVgClassrelation:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private VgClassrelation _vgClassrelation;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucVgClassrelation()
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
            _vgClassrelation=entity as VgClassrelation;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_vgClassrelation,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsbm.DataBindings.Clear();
            txtYsbm.DataBindings.Add("Text",_vgClassrelation,"Ysbm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGlbm.DataBindings.Clear();
            txtGlbm.DataBindings.Add("Text",_vgClassrelation,"Glbm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYszd.DataBindings.Clear();
            txtYszd.DataBindings.Add("Text",_vgClassrelation,"Yszd",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGlzd.DataBindings.Clear();
            txtGlzd.DataBindings.Add("Text",_vgClassrelation,"Glzd",true,DataSourceUpdateMode.OnPropertyChanged);
            intGllx.DataBindings.Clear();
            intGllx.DataBindings.Add("IntegerValue",_vgClassrelation,"Gllx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGxb.DataBindings.Clear();
            txtGxb.DataBindings.Add("Text",_vgClassrelation,"Gxb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsgx.DataBindings.Clear();
            txtYsgx.DataBindings.Add("Text",_vgClassrelation,"Ysgx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGlgx.DataBindings.Clear();
            txtGlgx.DataBindings.Add("Text",_vgClassrelation,"Glgx",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_vgClassrelation).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_vgClassrelation);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_vgClassrelation);
        }        
        #endregion
        
        
    }
}