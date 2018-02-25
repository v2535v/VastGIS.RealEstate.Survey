using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucCfdj:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Cfdj _cfdj;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucCfdj()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Cflx", "CFLXZD");
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
            _cfdj=entity as Cfdj;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_cfdj,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_cfdj,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_cfdj,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_cfdj,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtCfjg.DataBindings.Clear();
            txtCfjg.DataBindings.Add("Text",_cfdj,"Cfjg",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbCflx.DataBindings.Clear();
            cmbCflx.DataBindings.Add("SelectedValue",_cfdj,"Cflx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtCfwj.DataBindings.Clear();
            txtCfwj.DataBindings.Add("Text",_cfdj,"Cfwj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtCfwh.DataBindings.Clear();
            txtCfwh.DataBindings.Add("Text",_cfdj,"Cfwh",true,DataSourceUpdateMode.OnPropertyChanged);
            datCfqssj.DataBindings.Clear();
            datCfqssj.DataBindings.Add("BindableValue",_cfdj,"Cfqssj",true,DataSourceUpdateMode.OnPropertyChanged);
            datCfjssj.DataBindings.Clear();
            datCfjssj.DataBindings.Add("BindableValue",_cfdj,"Cfjssj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtCffw.DataBindings.Clear();
            txtCffw.DataBindings.Add("Text",_cfdj,"Cffw",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_cfdj,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_cfdj,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_cfdj,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_cfdj,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJfywh.DataBindings.Clear();
            txtJfywh.DataBindings.Add("Text",_cfdj,"Jfywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJfjg.DataBindings.Clear();
            txtJfjg.DataBindings.Add("Text",_cfdj,"Jfjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJfwj.DataBindings.Clear();
            txtJfwj.DataBindings.Add("Text",_cfdj,"Jfwj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJfwh.DataBindings.Clear();
            txtJfwh.DataBindings.Add("Text",_cfdj,"Jfwh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJfdbr.DataBindings.Clear();
            txtJfdbr.DataBindings.Add("Text",_cfdj,"Jfdbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datJfdjsj.DataBindings.Clear();
            datJfdjsj.DataBindings.Add("BindableValue",_cfdj,"Jfdjsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_cfdj,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_cfdj,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_cfdj).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_cfdj);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_cfdj);
        }        
        #endregion
        
        
    }
}