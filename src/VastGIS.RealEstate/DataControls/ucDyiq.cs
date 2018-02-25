using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucDyiq:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Dyiq _dyiq;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucDyiq()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Gydqlrzjzl", "ZJZLZD");
            _dictionaryNames.Add("Xydqlrzjzl", "ZJZLZD");
            _dictionaryNames.Add("Djlx", "DJLXZD");
            _dictionaryNames.Add("Qxdm", "VG_AREACODES");
            _dictionaryNames.Add("Qszt", "QSZTZD");
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
            _dyiq=entity as Dyiq;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_dyiq,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_dyiq,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_dyiq,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGydbdcdyh.DataBindings.Clear();
            txtGydbdcdyh.DataBindings.Add("Text",_dyiq,"Gydbdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGydqlr.DataBindings.Clear();
            txtGydqlr.DataBindings.Add("Text",_dyiq,"Gydqlr",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbGydqlrzjzl.DataBindings.Clear();
            cmbGydqlrzjzl.DataBindings.Add("SelectedValue",_dyiq,"Gydqlrzjzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGydqlrzjh.DataBindings.Clear();
            txtGydqlrzjh.DataBindings.Add("Text",_dyiq,"Gydqlrzjh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXydbdcdyh.DataBindings.Clear();
            txtXydbdcdyh.DataBindings.Add("Text",_dyiq,"Xydbdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXydzl.DataBindings.Clear();
            txtXydzl.DataBindings.Add("Text",_dyiq,"Xydzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXydqlr.DataBindings.Clear();
            txtXydqlr.DataBindings.Add("Text",_dyiq,"Xydqlr",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbXydqlrzjzl.DataBindings.Clear();
            cmbXydqlrzjzl.DataBindings.Add("SelectedValue",_dyiq,"Xydqlrzjzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXydqlrzjh.DataBindings.Clear();
            txtXydqlrzjh.DataBindings.Add("Text",_dyiq,"Xydqlrzjh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_dyiq,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_dyiq,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDyqnr.DataBindings.Clear();
            txtDyqnr.DataBindings.Add("Text",_dyiq,"Dyqnr",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdjzmh.DataBindings.Clear();
            txtBdcdjzmh.DataBindings.Add("Text",_dyiq,"Bdcdjzmh",true,DataSourceUpdateMode.OnPropertyChanged);
            datQlqssj.DataBindings.Clear();
            datQlqssj.DataBindings.Add("BindableValue",_dyiq,"Qlqssj",true,DataSourceUpdateMode.OnPropertyChanged);
            datQljssj.DataBindings.Clear();
            datQljssj.DataBindings.Add("BindableValue",_dyiq,"Qljssj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_dyiq,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_dyiq,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_dyiq,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_dyiq,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_dyiq,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_dyiq,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_dyiq).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_dyiq);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_dyiq);
        }        
        #endregion
        
        
    }
}