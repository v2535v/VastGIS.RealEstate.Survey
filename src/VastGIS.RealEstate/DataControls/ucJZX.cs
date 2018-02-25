using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucJzx:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Jzx _jzx;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucJzx()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Jzxlb", "JZXLBZD");
            _dictionaryNames.Add("Jzxwz", "JZXWZZD");
            _dictionaryNames.Add("Jxxz", "JXXZZD");
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
            _jzx=entity as Jzx;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_jzx,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdzhdm.DataBindings.Clear();
            txtZdzhdm.DataBindings.Add("Text",_jzx,"Zdzhdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_jzx,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJzxcd.DataBindings.Clear();
            dblJzxcd.DataBindings.Add("DoubleValue",_jzx,"Jzxcd",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbJzxlb.DataBindings.Clear();
            cmbJzxlb.DataBindings.Add("SelectedValue",_jzx,"Jzxlb",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbJzxwz.DataBindings.Clear();
            cmbJzxwz.DataBindings.Add("SelectedValue",_jzx,"Jzxwz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbJxxz.DataBindings.Clear();
            cmbJxxz.DataBindings.Add("SelectedValue",_jzx,"Jxxz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQsjxxysbh.DataBindings.Clear();
            txtQsjxxysbh.DataBindings.Add("Text",_jzx,"Qsjxxysbh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQsjxxys.DataBindings.Clear();
            txtQsjxxys.DataBindings.Add("Text",_jzx,"Qsjxxys",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQszyyysbh.DataBindings.Clear();
            txtQszyyysbh.DataBindings.Add("Text",_jzx,"Qszyyysbh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQszyyys.DataBindings.Clear();
            txtQszyyys.DataBindings.Add("Text",_jzx,"Qszyyys",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_jzx).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_jzx);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_jzx);
        }        
        #endregion
        
        
    }
}