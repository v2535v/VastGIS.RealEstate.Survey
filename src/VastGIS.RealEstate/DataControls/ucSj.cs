using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucSj:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Sj _sj;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucSj()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Sjlx", "SJLXZD");
            _dictionaryNames.Add("Sfsjsy", "SFZD");
            _dictionaryNames.Add("Sfewsj", "SFZD");
            _dictionaryNames.Add("Sfbcsj", "SFZD");
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
            _sj=entity as Sj;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_sj,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_sj,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_sj,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            datSjsj.DataBindings.Clear();
            datSjsj.DataBindings.Add("BindableValue",_sj,"Sjsj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSjlx.DataBindings.Clear();
            cmbSjlx.DataBindings.Add("SelectedValue",_sj,"Sjlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSjmc.DataBindings.Clear();
            txtSjmc.DataBindings.Add("Text",_sj,"Sjmc",true,DataSourceUpdateMode.OnPropertyChanged);
            intSjsl.DataBindings.Clear();
            intSjsl.DataBindings.Add("IntegerValue",_sj,"Sjsl",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSfsjsy.DataBindings.Clear();
            cmbSfsjsy.DataBindings.Add("SelectedValue",_sj,"Sfsjsy",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSfewsj.DataBindings.Clear();
            cmbSfewsj.DataBindings.Add("SelectedValue",_sj,"Sfewsj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSfbcsj.DataBindings.Clear();
            cmbSfbcsj.DataBindings.Add("SelectedValue",_sj,"Sfbcsj",true,DataSourceUpdateMode.OnPropertyChanged);
            intYs.DataBindings.Clear();
            intYs.DataBindings.Add("IntegerValue",_sj,"Ys",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_sj,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_sj).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_sj);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_sj);
        }        
        #endregion
        
        
    }
}