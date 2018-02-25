using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucLq:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Lq _lq;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucLq()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Qllx", "QLLXZD");
            _dictionaryNames.Add("Djlx", "DJLXZD");
            _dictionaryNames.Add("Ldsyqxz", "TDSYQXZZD");
            _dictionaryNames.Add("Lz", "LZZD");
            _dictionaryNames.Add("Qy", "QYZD");
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
            _lq=entity as Lq;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_lq,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_lq,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_lq,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_lq,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQllx.DataBindings.Clear();
            cmbQllx.DataBindings.Add("SelectedValue",_lq,"Qllx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_lq,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_lq,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFbf.DataBindings.Clear();
            txtFbf.DataBindings.Add("Text",_lq,"Fbf",true,DataSourceUpdateMode.OnPropertyChanged);
            dblSyqmj.DataBindings.Clear();
            dblSyqmj.DataBindings.Add("DoubleValue",_lq,"Syqmj",true,DataSourceUpdateMode.OnPropertyChanged);
            datLdsyqssj.DataBindings.Clear();
            datLdsyqssj.DataBindings.Add("BindableValue",_lq,"Ldsyqssj",true,DataSourceUpdateMode.OnPropertyChanged);
            datLdsyjssj.DataBindings.Clear();
            datLdsyjssj.DataBindings.Add("BindableValue",_lq,"Ldsyjssj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbLdsyqxz.DataBindings.Clear();
            cmbLdsyqxz.DataBindings.Add("SelectedValue",_lq,"Ldsyqxz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSllmsyqr1.DataBindings.Clear();
            txtSllmsyqr1.DataBindings.Add("Text",_lq,"Sllmsyqr1",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSllmsyqr2.DataBindings.Clear();
            txtSllmsyqr2.DataBindings.Add("Text",_lq,"Sllmsyqr2",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZysz.DataBindings.Clear();
            txtZysz.DataBindings.Add("Text",_lq,"Zysz",true,DataSourceUpdateMode.OnPropertyChanged);
            intZs.DataBindings.Clear();
            intZs.DataBindings.Add("IntegerValue",_lq,"Zs",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbLz.DataBindings.Clear();
            cmbLz.DataBindings.Add("SelectedValue",_lq,"Lz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQy.DataBindings.Clear();
            cmbQy.DataBindings.Add("SelectedValue",_lq,"Qy",true,DataSourceUpdateMode.OnPropertyChanged);
            intZlnd.DataBindings.Clear();
            intZlnd.DataBindings.Add("IntegerValue",_lq,"Zlnd",true,DataSourceUpdateMode.OnPropertyChanged);
            txtLb.DataBindings.Clear();
            txtLb.DataBindings.Add("Text",_lq,"Lb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXb.DataBindings.Clear();
            txtXb.DataBindings.Add("Text",_lq,"Xb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXdm.DataBindings.Clear();
            txtXdm.DataBindings.Add("Text",_lq,"Xdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcqzh.DataBindings.Clear();
            txtBdcqzh.DataBindings.Add("Text",_lq,"Bdcqzh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_lq,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_lq,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_lq,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_lq,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_lq,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_lq,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_lq).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_lq);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_lq);
        }        
        #endregion
        
        
    }
}