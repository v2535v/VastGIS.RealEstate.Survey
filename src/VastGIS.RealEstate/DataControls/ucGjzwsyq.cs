using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucGjzwsyq:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Gjzwsyq _gjzwsyq;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucGjzwsyq()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Qllx", "QLLXZD");
            _dictionaryNames.Add("Djlx", "DJLXZD");
            _dictionaryNames.Add("Gjzwlx", "GJZWLXZD");
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
            _gjzwsyq=entity as Gjzwsyq;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_gjzwsyq,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_gjzwsyq,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_gjzwsyq,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_gjzwsyq,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQllx.DataBindings.Clear();
            cmbQllx.DataBindings.Add("SelectedValue",_gjzwsyq,"Qllx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_gjzwsyq,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_gjzwsyq,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZl.DataBindings.Clear();
            txtZl.DataBindings.Add("Text",_gjzwsyq,"Zl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTdhysyqr.DataBindings.Clear();
            txtTdhysyqr.DataBindings.Add("Text",_gjzwsyq,"Tdhysyqr",true,DataSourceUpdateMode.OnPropertyChanged);
            dblTdhysymj.DataBindings.Clear();
            dblTdhysymj.DataBindings.Add("DoubleValue",_gjzwsyq,"Tdhysymj",true,DataSourceUpdateMode.OnPropertyChanged);
            datTdhysyqssj.DataBindings.Clear();
            datTdhysyqssj.DataBindings.Add("BindableValue",_gjzwsyq,"Tdhysyqssj",true,DataSourceUpdateMode.OnPropertyChanged);
            datTdhysyjssj.DataBindings.Clear();
            datTdhysyjssj.DataBindings.Add("BindableValue",_gjzwsyq,"Tdhysyjssj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbGjzwlx.DataBindings.Clear();
            cmbGjzwlx.DataBindings.Add("SelectedValue",_gjzwsyq,"Gjzwlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGjzwghyt.DataBindings.Clear();
            txtGjzwghyt.DataBindings.Add("Text",_gjzwsyq,"Gjzwghyt",true,DataSourceUpdateMode.OnPropertyChanged);
            dblGjzwmj.DataBindings.Clear();
            dblGjzwmj.DataBindings.Add("DoubleValue",_gjzwsyq,"Gjzwmj",true,DataSourceUpdateMode.OnPropertyChanged);
            datJgsj.DataBindings.Clear();
            datJgsj.DataBindings.Add("BindableValue",_gjzwsyq,"Jgsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcqzh.DataBindings.Clear();
            txtBdcqzh.DataBindings.Add("Text",_gjzwsyq,"Bdcqzh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_gjzwsyq,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_gjzwsyq,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_gjzwsyq,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_gjzwsyq,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_gjzwsyq,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGjzwpmt.DataBindings.Clear();
            txtGjzwpmt.DataBindings.Add("Text",_gjzwsyq,"Gjzwpmt",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_gjzwsyq,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_gjzwsyq).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_gjzwsyq);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_gjzwsyq);
        }        
        #endregion
        
        
    }
}