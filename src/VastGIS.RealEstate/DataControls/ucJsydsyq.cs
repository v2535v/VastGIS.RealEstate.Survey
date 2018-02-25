using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucJsydsyq:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Jsydsyq _jsydsyq;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucJsydsyq()
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
            _jsydsyq=entity as Jsydsyq;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_jsydsyq,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_jsydsyq,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZddm.DataBindings.Clear();
            txtZddm.DataBindings.Add("Text",_jsydsyq,"Zddm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_jsydsyq,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_jsydsyq,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQllx.DataBindings.Clear();
            cmbQllx.DataBindings.Add("SelectedValue",_jsydsyq,"Qllx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_jsydsyq,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_jsydsyq,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            dblSyqmj.DataBindings.Clear();
            dblSyqmj.DataBindings.Add("DoubleValue",_jsydsyq,"Syqmj",true,DataSourceUpdateMode.OnPropertyChanged);
            datSyqqssj.DataBindings.Clear();
            datSyqqssj.DataBindings.Add("BindableValue",_jsydsyq,"Syqqssj",true,DataSourceUpdateMode.OnPropertyChanged);
            datSyqjssj.DataBindings.Clear();
            datSyqjssj.DataBindings.Add("BindableValue",_jsydsyq,"Syqjssj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblQdjg.DataBindings.Clear();
            dblQdjg.DataBindings.Add("DoubleValue",_jsydsyq,"Qdjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcqzh.DataBindings.Clear();
            txtBdcqzh.DataBindings.Add("Text",_jsydsyq,"Bdcqzh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_jsydsyq,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_jsydsyq,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_jsydsyq,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_jsydsyq,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_jsydsyq,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_jsydsyq,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_jsydsyq).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_jsydsyq);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_jsydsyq);
        }        
        #endregion
        
        
    }
}