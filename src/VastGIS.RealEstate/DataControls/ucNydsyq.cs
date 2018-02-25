using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucNydsyq:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Nydsyq _nydsyq;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucNydsyq()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Qllx", "QLLXZD");
            _dictionaryNames.Add("Djlx", "DJLXZD");
            _dictionaryNames.Add("Tdsyqxz", "TDSYQXZZD");
            _dictionaryNames.Add("Syttlx", "SYTTLXZD");
            _dictionaryNames.Add("Yzyfs", "YZYFSZD");
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
            _nydsyq=entity as Nydsyq;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_nydsyq,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_nydsyq,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_nydsyq,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_nydsyq,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQllx.DataBindings.Clear();
            cmbQllx.DataBindings.Add("SelectedValue",_nydsyq,"Qllx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_nydsyq,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_nydsyq,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZl.DataBindings.Clear();
            txtZl.DataBindings.Add("Text",_nydsyq,"Zl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFbfdm.DataBindings.Clear();
            txtFbfdm.DataBindings.Add("Text",_nydsyq,"Fbfdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFbfmc.DataBindings.Clear();
            txtFbfmc.DataBindings.Add("Text",_nydsyq,"Fbfmc",true,DataSourceUpdateMode.OnPropertyChanged);
            dblCbmj.DataBindings.Clear();
            dblCbmj.DataBindings.Add("DoubleValue",_nydsyq,"Cbmj",true,DataSourceUpdateMode.OnPropertyChanged);
            datCbqssj.DataBindings.Clear();
            datCbqssj.DataBindings.Add("BindableValue",_nydsyq,"Cbqssj",true,DataSourceUpdateMode.OnPropertyChanged);
            datCbjssj.DataBindings.Clear();
            datCbjssj.DataBindings.Add("BindableValue",_nydsyq,"Cbjssj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbTdsyqxz.DataBindings.Clear();
            cmbTdsyqxz.DataBindings.Add("SelectedValue",_nydsyq,"Tdsyqxz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSyttlx.DataBindings.Clear();
            cmbSyttlx.DataBindings.Add("SelectedValue",_nydsyq,"Syttlx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbYzyfs.DataBindings.Clear();
            cmbYzyfs.DataBindings.Add("SelectedValue",_nydsyq,"Yzyfs",true,DataSourceUpdateMode.OnPropertyChanged);
            txtCyzl.DataBindings.Clear();
            txtCyzl.DataBindings.Add("Text",_nydsyq,"Cyzl",true,DataSourceUpdateMode.OnPropertyChanged);
            intSyzcl.DataBindings.Clear();
            intSyzcl.DataBindings.Add("IntegerValue",_nydsyq,"Syzcl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcqzh.DataBindings.Clear();
            txtBdcqzh.DataBindings.Add("Text",_nydsyq,"Bdcqzh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_nydsyq,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_nydsyq,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_nydsyq,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_nydsyq,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_nydsyq,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_nydsyq,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_nydsyq).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_nydsyq);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_nydsyq);
        }        
        #endregion
        
        
    }
}