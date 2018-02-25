using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucSqr:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Sqr _sqr;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucSqr()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Qlrzjzl", "ZJZLZD");
            _dictionaryNames.Add("Ywrzjzl", "ZJZLZD");
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
            _sqr=entity as Sqr;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_sqr,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_sqr,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_sqr,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrmc.DataBindings.Clear();
            txtQlrmc.DataBindings.Add("Text",_sqr,"Qlrmc",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQlrzjzl.DataBindings.Clear();
            cmbQlrzjzl.DataBindings.Add("SelectedValue",_sqr,"Qlrzjzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrzjh.DataBindings.Clear();
            txtQlrzjh.DataBindings.Add("Text",_sqr,"Qlrzjh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrtxdz.DataBindings.Clear();
            txtQlrtxdz.DataBindings.Add("Text",_sqr,"Qlrtxdz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlryb.DataBindings.Clear();
            txtQlryb.DataBindings.Add("Text",_sqr,"Qlryb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrfrmc.DataBindings.Clear();
            txtQlrfrmc.DataBindings.Add("Text",_sqr,"Qlrfrmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrfrdh.DataBindings.Clear();
            txtQlrfrdh.DataBindings.Add("Text",_sqr,"Qlrfrdh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrdlrmc.DataBindings.Clear();
            txtQlrdlrmc.DataBindings.Add("Text",_sqr,"Qlrdlrmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrdlrdh.DataBindings.Clear();
            txtQlrdlrdh.DataBindings.Add("Text",_sqr,"Qlrdlrdh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrdljg.DataBindings.Clear();
            txtQlrdljg.DataBindings.Add("Text",_sqr,"Qlrdljg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwrmc.DataBindings.Clear();
            txtYwrmc.DataBindings.Add("Text",_sqr,"Ywrmc",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbYwrzjzl.DataBindings.Clear();
            cmbYwrzjzl.DataBindings.Add("SelectedValue",_sqr,"Ywrzjzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwrzjh.DataBindings.Clear();
            txtYwrzjh.DataBindings.Add("Text",_sqr,"Ywrzjh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwrtxdz.DataBindings.Clear();
            txtYwrtxdz.DataBindings.Add("Text",_sqr,"Ywrtxdz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwryb.DataBindings.Clear();
            txtYwryb.DataBindings.Add("Text",_sqr,"Ywryb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwrfrmc.DataBindings.Clear();
            txtYwrfrmc.DataBindings.Add("Text",_sqr,"Ywrfrmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwrfrdh.DataBindings.Clear();
            txtYwrfrdh.DataBindings.Add("Text",_sqr,"Ywrfrdh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwrdlrmc.DataBindings.Clear();
            txtYwrdlrmc.DataBindings.Add("Text",_sqr,"Ywrdlrmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwrdlrdh.DataBindings.Clear();
            txtYwrdlrdh.DataBindings.Add("Text",_sqr,"Ywrdlrdh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwrdljg.DataBindings.Clear();
            txtYwrdljg.DataBindings.Add("Text",_sqr,"Ywrdljg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_sqr,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_sqr).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_sqr);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_sqr);
        }        
        #endregion
        
        
    }
}