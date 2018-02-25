using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucFdcq2:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Fdcq2 _fdcq2;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucFdcq2()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Qllx", "QLLXZD");
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
            _fdcq2=entity as Fdcq2;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_fdcq2,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_fdcq2,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_fdcq2,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_fdcq2,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQllx.DataBindings.Clear();
            cmbQllx.DataBindings.Add("SelectedValue",_fdcq2,"Qllx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_fdcq2,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_fdcq2,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFdzl.DataBindings.Clear();
            txtFdzl.DataBindings.Add("Text",_fdcq2,"Fdzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTdsyqr.DataBindings.Clear();
            txtTdsyqr.DataBindings.Add("Text",_fdcq2,"Tdsyqr",true,DataSourceUpdateMode.OnPropertyChanged);
            dblDytdmj.DataBindings.Clear();
            dblDytdmj.DataBindings.Add("DoubleValue",_fdcq2,"Dytdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblFttdmj.DataBindings.Clear();
            dblFttdmj.DataBindings.Add("DoubleValue",_fdcq2,"Fttdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            datTdsyqssj.DataBindings.Clear();
            datTdsyqssj.DataBindings.Add("BindableValue",_fdcq2,"Tdsyqssj",true,DataSourceUpdateMode.OnPropertyChanged);
            datTdsyjssj.DataBindings.Clear();
            datTdsyjssj.DataBindings.Add("BindableValue",_fdcq2,"Tdsyjssj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblFdcjyjg.DataBindings.Clear();
            dblFdcjyjg.DataBindings.Add("DoubleValue",_fdcq2,"Fdcjyjg",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbGhyt.DataBindings.Clear();
            cmbGhyt.DataBindings.Add("SelectedValue",_fdcq2,"Ghyt",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwxz.DataBindings.Clear();
            cmbFwxz.DataBindings.Add("SelectedValue",_fdcq2,"Fwxz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwjg.DataBindings.Clear();
            cmbFwjg.DataBindings.Add("SelectedValue",_fdcq2,"Fwjg",true,DataSourceUpdateMode.OnPropertyChanged);
            intSzc.DataBindings.Clear();
            intSzc.DataBindings.Add("IntegerValue",_fdcq2,"Szc",true,DataSourceUpdateMode.OnPropertyChanged);
            intZcs.DataBindings.Clear();
            intZcs.DataBindings.Add("IntegerValue",_fdcq2,"Zcs",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJzmj.DataBindings.Clear();
            dblJzmj.DataBindings.Add("DoubleValue",_fdcq2,"Jzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZyjzmj.DataBindings.Clear();
            dblZyjzmj.DataBindings.Add("DoubleValue",_fdcq2,"Zyjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblFtjzmj.DataBindings.Clear();
            dblFtjzmj.DataBindings.Add("DoubleValue",_fdcq2,"Ftjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            datJgsj.DataBindings.Clear();
            datJgsj.DataBindings.Add("BindableValue",_fdcq2,"Jgsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcqzh.DataBindings.Clear();
            txtBdcqzh.DataBindings.Add("Text",_fdcq2,"Bdcqzh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_fdcq2,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_fdcq2,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_fdcq2,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_fdcq2,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_fdcq2,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_fdcq2,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_fdcq2).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_fdcq2);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_fdcq2);
        }        
        #endregion
        
        
    }
}