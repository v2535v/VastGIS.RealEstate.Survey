using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucQtxgql:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Qtxgql _qtxgql;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucQtxgql()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Qllx", "QLLXZD");
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
            _qtxgql=entity as Qtxgql;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_qtxgql,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_qtxgql,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_qtxgql,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_qtxgql,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQllx.DataBindings.Clear();
            cmbQllx.DataBindings.Add("SelectedValue",_qtxgql,"Qllx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_qtxgql,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_qtxgql,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            datQlqssj.DataBindings.Clear();
            datQlqssj.DataBindings.Add("BindableValue",_qtxgql,"Qlqssj",true,DataSourceUpdateMode.OnPropertyChanged);
            datQljssj.DataBindings.Clear();
            datQljssj.DataBindings.Add("BindableValue",_qtxgql,"Qljssj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQsfs.DataBindings.Clear();
            txtQsfs.DataBindings.Add("Text",_qtxgql,"Qsfs",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSylx.DataBindings.Clear();
            txtSylx.DataBindings.Add("Text",_qtxgql,"Sylx",true,DataSourceUpdateMode.OnPropertyChanged);
            dblQsl.DataBindings.Clear();
            dblQsl.DataBindings.Add("DoubleValue",_qtxgql,"Qsl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQsyt.DataBindings.Clear();
            txtQsyt.DataBindings.Add("Text",_qtxgql,"Qsyt",true,DataSourceUpdateMode.OnPropertyChanged);
            dblKcmj.DataBindings.Clear();
            dblKcmj.DataBindings.Add("DoubleValue",_qtxgql,"Kcmj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtKcfs.DataBindings.Clear();
            txtKcfs.DataBindings.Add("Text",_qtxgql,"Kcfs",true,DataSourceUpdateMode.OnPropertyChanged);
            txtKckz.DataBindings.Clear();
            txtKckz.DataBindings.Add("Text",_qtxgql,"Kckz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtScgm.DataBindings.Clear();
            txtScgm.DataBindings.Add("Text",_qtxgql,"Scgm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcqzh.DataBindings.Clear();
            txtBdcqzh.DataBindings.Add("Text",_qtxgql,"Bdcqzh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_qtxgql,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_qtxgql,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_qtxgql,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_qtxgql,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_qtxgql,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFt.DataBindings.Clear();
            txtFt.DataBindings.Add("Text",_qtxgql,"Ft",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_qtxgql,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_qtxgql).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_qtxgql);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_qtxgql);
        }        
        #endregion
        
        
    }
}