using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucJzxzj:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Jzxzj _jzxzj;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucJzxzj()
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
            _jzxzj=entity as Jzxzj;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_jzxzj,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGlysbh.DataBindings.Clear();
            txtGlysbh.DataBindings.Add("Text",_jzxzj,"Glysbh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_jzxzj,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZjnr.DataBindings.Clear();
            txtZjnr.DataBindings.Add("Text",_jzxzj,"Zjnr",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZt.DataBindings.Clear();
            txtZt.DataBindings.Add("Text",_jzxzj,"Zt",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYs.DataBindings.Clear();
            txtYs.DataBindings.Add("Text",_jzxzj,"Ys",true,DataSourceUpdateMode.OnPropertyChanged);
            intBs.DataBindings.Clear();
            intBs.DataBindings.Add("IntegerValue",_jzxzj,"Bs",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXz.DataBindings.Clear();
            txtXz.DataBindings.Add("Text",_jzxzj,"Xz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXhx.DataBindings.Clear();
            txtXhx.DataBindings.Add("Text",_jzxzj,"Xhx",true,DataSourceUpdateMode.OnPropertyChanged);
            dblKd.DataBindings.Clear();
            dblKd.DataBindings.Add("DoubleValue",_jzxzj,"Kd",true,DataSourceUpdateMode.OnPropertyChanged);
            dblGd.DataBindings.Clear();
            dblGd.DataBindings.Add("DoubleValue",_jzxzj,"Gd",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZjdzxjxzb.DataBindings.Clear();
            dblZjdzxjxzb.DataBindings.Add("DoubleValue",_jzxzj,"Zjdzxjxzb",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZjdzxjyzb.DataBindings.Clear();
            dblZjdzxjyzb.DataBindings.Add("DoubleValue",_jzxzj,"Zjdzxjyzb",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZjfx.DataBindings.Clear();
            dblZjfx.DataBindings.Add("DoubleValue",_jzxzj,"Zjfx",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_jzxzj).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_jzxzj);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_jzxzj);
        }        
        #endregion
        
        
    }
}