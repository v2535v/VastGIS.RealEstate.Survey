using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucJzd:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Jzd _jzd;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucJzd()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Jblx", "JBLXZD");
            _dictionaryNames.Add("Jzdlx", "JZDLXZD");
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
            _jzd=entity as Jzd;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_jzd,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdzhdm.DataBindings.Clear();
            txtZdzhdm.DataBindings.Add("Text",_jzd,"Zdzhdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_jzd,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJzdh.DataBindings.Clear();
            txtJzdh.DataBindings.Add("Text",_jzd,"Jzdh",true,DataSourceUpdateMode.OnPropertyChanged);
            intSxh.DataBindings.Clear();
            intSxh.DataBindings.Add("IntegerValue",_jzd,"Sxh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbJblx.DataBindings.Clear();
            cmbJblx.DataBindings.Add("SelectedValue",_jzd,"Jblx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbJzdlx.DataBindings.Clear();
            cmbJzdlx.DataBindings.Add("SelectedValue",_jzd,"Jzdlx",true,DataSourceUpdateMode.OnPropertyChanged);
            dblXzbz.DataBindings.Clear();
            dblXzbz.DataBindings.Add("DoubleValue",_jzd,"Xzbz",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYzbz.DataBindings.Clear();
            dblYzbz.DataBindings.Add("DoubleValue",_jzd,"Yzbz",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_jzd).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_jzd);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_jzd);
        }        
        #endregion
        
        
    }
}