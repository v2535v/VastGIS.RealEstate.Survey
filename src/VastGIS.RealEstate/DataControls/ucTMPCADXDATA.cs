using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucTmpCadxdata:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private TmpCadxdata _tmpcadxdatum;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucTmpCadxdata()
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
            _tmpcadxdatum=entity as TmpCadxdata;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_tmpcadxdatum,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtHandle.DataBindings.Clear();
            txtHandle.DataBindings.Add("Text",_tmpcadxdatum,"Handle",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTc.DataBindings.Clear();
            txtTc.DataBindings.Add("Text",_tmpcadxdatum,"Tc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtWbnr.DataBindings.Clear();
            txtWbnr.DataBindings.Add("Text",_tmpcadxdatum,"Wbnr",true,DataSourceUpdateMode.OnPropertyChanged);
            txtCassdm.DataBindings.Clear();
            txtCassdm.DataBindings.Add("Text",_tmpcadxdatum,"Cassdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFsxx1.DataBindings.Clear();
            txtFsxx1.DataBindings.Add("Text",_tmpcadxdatum,"Fsxx1",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFsxx2.DataBindings.Clear();
            txtFsxx2.DataBindings.Add("Text",_tmpcadxdatum,"Fsxx2",true,DataSourceUpdateMode.OnPropertyChanged);
            dblXzjd.DataBindings.Clear();
            dblXzjd.DataBindings.Add("DoubleValue",_tmpcadxdatum,"Xzjd",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFh.DataBindings.Clear();
            txtFh.DataBindings.Add("Text",_tmpcadxdatum,"Fh",true,DataSourceUpdateMode.OnPropertyChanged);
            dblFhdx.DataBindings.Clear();
            dblFhdx.DataBindings.Add("DoubleValue",_tmpcadxdatum,"Fhdx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_tmpcadxdatum,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFileName.DataBindings.Clear();
            txtFileName.DataBindings.Add("Text",_tmpcadxdatum,"FileName",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_tmpcadxdatum).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_tmpcadxdatum);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_tmpcadxdatum);
        }        
        #endregion
        
        
    }
}