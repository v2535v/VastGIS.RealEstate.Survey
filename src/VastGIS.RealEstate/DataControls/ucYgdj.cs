using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucYgdj:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Ygdj _ygdj;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucYgdj()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Ywrzjzl", "ZJZLZD");
            _dictionaryNames.Add("Ygdjzl", "YGDJZLZD");
            _dictionaryNames.Add("Djlx", "DJLXZD");
            _dictionaryNames.Add("Ghyt", "FWYTZD");
            _dictionaryNames.Add("Fwxz", "FWXZZD");
            _dictionaryNames.Add("Fwjg", "FWJGZD");
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
            _ygdj=entity as Ygdj;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_ygdj,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_ygdj,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_ygdj,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_ygdj,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdczl.DataBindings.Clear();
            txtBdczl.DataBindings.Add("Text",_ygdj,"Bdczl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwr.DataBindings.Clear();
            txtYwr.DataBindings.Add("Text",_ygdj,"Ywr",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbYwrzjzl.DataBindings.Clear();
            cmbYwrzjzl.DataBindings.Add("SelectedValue",_ygdj,"Ywrzjzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwrzjh.DataBindings.Clear();
            txtYwrzjh.DataBindings.Add("Text",_ygdj,"Ywrzjh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbYgdjzl.DataBindings.Clear();
            cmbYgdjzl.DataBindings.Add("SelectedValue",_ygdj,"Ygdjzl",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_ygdj,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_ygdj,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTdsyqr.DataBindings.Clear();
            txtTdsyqr.DataBindings.Add("Text",_ygdj,"Tdsyqr",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbGhyt.DataBindings.Clear();
            cmbGhyt.DataBindings.Add("SelectedValue",_ygdj,"Ghyt",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwxz.DataBindings.Clear();
            cmbFwxz.DataBindings.Add("SelectedValue",_ygdj,"Fwxz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwjg.DataBindings.Clear();
            cmbFwjg.DataBindings.Add("SelectedValue",_ygdj,"Fwjg",true,DataSourceUpdateMode.OnPropertyChanged);
            intSzc.DataBindings.Clear();
            intSzc.DataBindings.Add("IntegerValue",_ygdj,"Szc",true,DataSourceUpdateMode.OnPropertyChanged);
            intZcs.DataBindings.Clear();
            intZcs.DataBindings.Add("IntegerValue",_ygdj,"Zcs",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJzmj.DataBindings.Clear();
            dblJzmj.DataBindings.Add("DoubleValue",_ygdj,"Jzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblQdjg.DataBindings.Clear();
            dblQdjg.DataBindings.Add("DoubleValue",_ygdj,"Qdjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdjzmh.DataBindings.Clear();
            txtBdcdjzmh.DataBindings.Add("Text",_ygdj,"Bdcdjzmh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_ygdj,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_ygdj,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_ygdj,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_ygdj,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_ygdj,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_ygdj,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_ygdj).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_ygdj);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_ygdj);
        }        
        #endregion
        
        
    }
}