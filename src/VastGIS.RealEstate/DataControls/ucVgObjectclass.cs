using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucVgObjectclass:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private VgObjectclass _vgObjectclass;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucVgObjectclass()
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
            _vgObjectclass=entity as VgObjectclass;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_vgObjectclass,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtMc.DataBindings.Clear();
            txtMc.DataBindings.Add("Text",_vgObjectclass,"Mc",true,DataSourceUpdateMode.OnPropertyChanged);
            intDxlx.DataBindings.Clear();
            intDxlx.DataBindings.Add("IntegerValue",_vgObjectclass,"Dxlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZwmc.DataBindings.Clear();
            txtZwmc.DataBindings.Add("Text",_vgObjectclass,"Zwmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFbmc.DataBindings.Clear();
            txtFbmc.DataBindings.Add("Text",_vgObjectclass,"Fbmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXhzdmc.DataBindings.Clear();
            txtXhzdmc.DataBindings.Add("Text",_vgObjectclass,"Xhzdmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTxzdmc.DataBindings.Clear();
            txtTxzdmc.DataBindings.Add("Text",_vgObjectclass,"Txzdmc",true,DataSourceUpdateMode.OnPropertyChanged);
            intTxlx.DataBindings.Clear();
            intTxlx.DataBindings.Add("IntegerValue",_vgObjectclass,"Txlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtIdentify.DataBindings.Clear();
            txtIdentify.DataBindings.Add("Text",_vgObjectclass,"Identify",true,DataSourceUpdateMode.OnPropertyChanged);
            txtEditable.DataBindings.Clear();
            txtEditable.DataBindings.Add("Text",_vgObjectclass,"Editable",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQueryable.DataBindings.Clear();
            txtQueryable.DataBindings.Add("Text",_vgObjectclass,"Queryable",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSnapable.DataBindings.Clear();
            txtSnapable.DataBindings.Add("Text",_vgObjectclass,"Snapable",true,DataSourceUpdateMode.OnPropertyChanged);
            txtVisible.DataBindings.Clear();
            txtVisible.DataBindings.Add("Text",_vgObjectclass,"Visible",true,DataSourceUpdateMode.OnPropertyChanged);
            intXssx.DataBindings.Clear();
            intXssx.DataBindings.Add("IntegerValue",_vgObjectclass,"Xssx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFilter.DataBindings.Clear();
            txtFilter.DataBindings.Add("Text",_vgObjectclass,"Filter",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQsdm.DataBindings.Clear();
            txtQsdm.DataBindings.Add("Text",_vgObjectclass,"Qsdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBjct.DataBindings.Clear();
            txtBjct.DataBindings.Add("Text",_vgObjectclass,"Bjct",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBhfj.DataBindings.Clear();
            txtBhfj.DataBindings.Add("Text",_vgObjectclass,"Bhfj",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_vgObjectclass).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_vgObjectclass);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_vgObjectclass);
        }        
        #endregion
        
        
    }
}