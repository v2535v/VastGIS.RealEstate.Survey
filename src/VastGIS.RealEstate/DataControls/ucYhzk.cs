using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucYhzk:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Yhzk _yhzk;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucYhzk()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Yhfs", "YHFSZD");
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
            _yhzk=entity as Yhzk;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_yhzk,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZhdm.DataBindings.Clear();
            txtZhdm.DataBindings.Add("Text",_yhzk,"Zhdm",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbYhfs.DataBindings.Clear();
            cmbYhfs.DataBindings.Add("SelectedValue",_yhzk,"Yhfs",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYhmj.DataBindings.Clear();
            dblYhmj.DataBindings.Add("DoubleValue",_yhzk,"Yhmj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJtyt.DataBindings.Clear();
            txtJtyt.DataBindings.Add("Text",_yhzk,"Jtyt",true,DataSourceUpdateMode.OnPropertyChanged);
            dblSyjse.DataBindings.Clear();
            dblSyjse.DataBindings.Add("DoubleValue",_yhzk,"Syjse",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_yhzk).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_yhzk);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_yhzk);
        }        
        #endregion
        
        
    }
}