using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucFz:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Fz _fz;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucFz()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Lzrzjlb", "ZJZLZD");
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
            _fz=entity as Fz;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_fz,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_fz,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_fz,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFzry.DataBindings.Clear();
            txtFzry.DataBindings.Add("Text",_fz,"Fzry",true,DataSourceUpdateMode.OnPropertyChanged);
            datFzsj.DataBindings.Clear();
            datFzsj.DataBindings.Add("BindableValue",_fz,"Fzsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFzmc.DataBindings.Clear();
            txtFzmc.DataBindings.Add("Text",_fz,"Fzmc",true,DataSourceUpdateMode.OnPropertyChanged);
            intFzsl.DataBindings.Clear();
            intFzsl.DataBindings.Add("IntegerValue",_fz,"Fzsl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtHfzsh.DataBindings.Clear();
            txtHfzsh.DataBindings.Add("Text",_fz,"Hfzsh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtLzrxm.DataBindings.Clear();
            txtLzrxm.DataBindings.Add("Text",_fz,"Lzrxm",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbLzrzjlb.DataBindings.Clear();
            cmbLzrzjlb.DataBindings.Add("SelectedValue",_fz,"Lzrzjlb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtLzrzjh.DataBindings.Clear();
            txtLzrzjh.DataBindings.Add("Text",_fz,"Lzrzjh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtLzrdh.DataBindings.Clear();
            txtLzrdh.DataBindings.Add("Text",_fz,"Lzrdh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtLzrdz.DataBindings.Clear();
            txtLzrdz.DataBindings.Add("Text",_fz,"Lzrdz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtLzryb.DataBindings.Clear();
            txtLzryb.DataBindings.Add("Text",_fz,"Lzryb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_fz,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_fz).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_fz);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_fz);
        }        
        #endregion
        
        
    }
}