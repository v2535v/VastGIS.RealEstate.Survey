using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucVgAttachment:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private VgAttachment _vgAttachment;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucVgAttachment()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Fjlx", "FJLXZD");
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
            _vgAttachment=entity as VgAttachment;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_vgAttachment,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFjmc.DataBindings.Clear();
            txtFjmc.DataBindings.Add("Text",_vgAttachment,"Fjmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFjlj.DataBindings.Clear();
            txtFjlj.DataBindings.Add("Text",_vgAttachment,"Fjlj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFjlx.DataBindings.Clear();
            cmbFjlx.DataBindings.Add("SelectedValue",_vgAttachment,"Fjlx",true,DataSourceUpdateMode.OnPropertyChanged);
            datHqsj.DataBindings.Clear();
            datHqsj.DataBindings.Add("BindableValue",_vgAttachment,"Hqsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFjsm.DataBindings.Clear();
            txtFjsm.DataBindings.Add("Text",_vgAttachment,"Fjsm",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_vgAttachment).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_vgAttachment);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_vgAttachment);
        }        
        #endregion
        
        
    }
}