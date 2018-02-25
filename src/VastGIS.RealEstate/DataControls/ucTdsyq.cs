using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucTdsyq:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Tdsyq _tdsyq;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucTdsyq()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Qllx", "QLLXZD");
            _dictionaryNames.Add("Djlx", "DJLXZD");
            _dictionaryNames.Add("Mjdw", "MJDWZD");
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
            _tdsyq=entity as Tdsyq;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_tdsyq,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_tdsyq,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZddm.DataBindings.Clear();
            txtZddm.DataBindings.Add("Text",_tdsyq,"Zddm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_tdsyq,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_tdsyq,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQllx.DataBindings.Clear();
            cmbQllx.DataBindings.Add("SelectedValue",_tdsyq,"Qllx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_tdsyq,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_tdsyq,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbMjdw.DataBindings.Clear();
            cmbMjdw.DataBindings.Add("SelectedValue",_tdsyq,"Mjdw",true,DataSourceUpdateMode.OnPropertyChanged);
            dblNydmj.DataBindings.Clear();
            dblNydmj.DataBindings.Add("DoubleValue",_tdsyq,"Nydmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblGdmj.DataBindings.Clear();
            dblGdmj.DataBindings.Add("DoubleValue",_tdsyq,"Gdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblLdmj.DataBindings.Clear();
            dblLdmj.DataBindings.Add("DoubleValue",_tdsyq,"Ldmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblCdmj.DataBindings.Clear();
            dblCdmj.DataBindings.Add("DoubleValue",_tdsyq,"Cdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblQtnydmj.DataBindings.Clear();
            dblQtnydmj.DataBindings.Add("DoubleValue",_tdsyq,"Qtnydmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJsydmj.DataBindings.Clear();
            dblJsydmj.DataBindings.Add("DoubleValue",_tdsyq,"Jsydmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblWlydmj.DataBindings.Clear();
            dblWlydmj.DataBindings.Add("DoubleValue",_tdsyq,"Wlydmj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcqzh.DataBindings.Clear();
            txtBdcqzh.DataBindings.Add("Text",_tdsyq,"Bdcqzh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_tdsyq,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_tdsyq,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_tdsyq,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_tdsyq,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_tdsyq,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_tdsyq,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_tdsyq).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_tdsyq);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_tdsyq);
        }        
        #endregion
        
        
    }
}