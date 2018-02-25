using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucVgFieldinfo:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private VgFieldinfo _vgFieldinfo;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucVgFieldinfo()
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
            _vgFieldinfo=entity as VgFieldinfo;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_vgFieldinfo,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBm.DataBindings.Clear();
            txtBm.DataBindings.Add("Text",_vgFieldinfo,"Bm",true,DataSourceUpdateMode.OnPropertyChanged);
            intBnsx.DataBindings.Clear();
            intBnsx.DataBindings.Add("IntegerValue",_vgFieldinfo,"Bnsx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdzwmc.DataBindings.Clear();
            txtZdzwmc.DataBindings.Add("Text",_vgFieldinfo,"Zdzwmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdmc.DataBindings.Clear();
            txtZdmc.DataBindings.Add("Text",_vgFieldinfo,"Zdmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdlx.DataBindings.Clear();
            txtZdlx.DataBindings.Add("Text",_vgFieldinfo,"Zdlx",true,DataSourceUpdateMode.OnPropertyChanged);
            intZdcd.DataBindings.Clear();
            intZdcd.DataBindings.Add("IntegerValue",_vgFieldinfo,"Zdcd",true,DataSourceUpdateMode.OnPropertyChanged);
            intZdxsws.DataBindings.Clear();
            intZdxsws.DataBindings.Add("IntegerValue",_vgFieldinfo,"Zdxsws",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSyzd.DataBindings.Clear();
            txtSyzd.DataBindings.Add("Text",_vgFieldinfo,"Syzd",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYs.DataBindings.Clear();
            txtYs.DataBindings.Add("Text",_vgFieldinfo,"Ys",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSyzdyw.DataBindings.Clear();
            txtSyzdyw.DataBindings.Add("Text",_vgFieldinfo,"Syzdyw",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_vgFieldinfo).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_vgFieldinfo);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_vgFieldinfo);
        }        
        #endregion
        
        
    }
}