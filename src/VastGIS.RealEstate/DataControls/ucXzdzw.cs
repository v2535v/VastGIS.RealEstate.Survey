using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucXzdzw:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Xzdzw _xzdzw;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucXzdzw()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Mjdw", "MJDWZD");
            _dictionaryNames.Add("Zt", "BDCDYZTZD");
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
            _xzdzw=entity as Xzdzw;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_xzdzw,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_xzdzw,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_xzdzw,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdzhdm.DataBindings.Clear();
            txtZdzhdm.DataBindings.Add("Text",_xzdzw,"Zdzhdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXzdzwlx.DataBindings.Clear();
            txtXzdzwlx.DataBindings.Add("Text",_xzdzw,"Xzdzwlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDzwmc.DataBindings.Clear();
            txtDzwmc.DataBindings.Add("Text",_xzdzw,"Dzwmc",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbMjdw.DataBindings.Clear();
            cmbMjdw.DataBindings.Add("SelectedValue",_xzdzw,"Mjdw",true,DataSourceUpdateMode.OnPropertyChanged);
            dblMj.DataBindings.Clear();
            dblMj.DataBindings.Add("DoubleValue",_xzdzw,"Mj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDah.DataBindings.Clear();
            txtDah.DataBindings.Add("Text",_xzdzw,"Dah",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbZt.DataBindings.Clear();
            cmbZt.DataBindings.Add("SelectedValue",_xzdzw,"Zt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_xzdzw).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_xzdzw);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_xzdzw);
        }        
        #endregion
        
        
    }
}