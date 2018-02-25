using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucZdbhqk:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Zdbhqk _zdbhqk;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucZdbhqk()
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
            _zdbhqk=entity as Zdbhqk;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_zdbhqk,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZddm.DataBindings.Clear();
            txtZddm.DataBindings.Add("Text",_zdbhqk,"Zddm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBhyy.DataBindings.Clear();
            txtBhyy.DataBindings.Add("Text",_zdbhqk,"Bhyy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBhnr.DataBindings.Clear();
            txtBhnr.DataBindings.Add("Text",_zdbhqk,"Bhnr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_zdbhqk,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_zdbhqk,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_zdbhqk,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_zdbhqk).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_zdbhqk);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_zdbhqk);
        }        
        #endregion
        
        
    }
}