using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucFdcq3:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Fdcq3 _fdcq3;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucFdcq3()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Qllx", "QLLXZD");
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
            _fdcq3=entity as Fdcq3;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_fdcq3,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_fdcq3,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_fdcq3,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_fdcq3,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQllx.DataBindings.Clear();
            cmbQllx.DataBindings.Add("SelectedValue",_fdcq3,"Qllx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJgzwbh.DataBindings.Clear();
            txtJgzwbh.DataBindings.Add("Text",_fdcq3,"Jgzwbh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJgzwmc.DataBindings.Clear();
            txtJgzwmc.DataBindings.Add("Text",_fdcq3,"Jgzwmc",true,DataSourceUpdateMode.OnPropertyChanged);
            intJgzwsl.DataBindings.Clear();
            intJgzwsl.DataBindings.Add("IntegerValue",_fdcq3,"Jgzwsl",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJgzwmj.DataBindings.Clear();
            dblJgzwmj.DataBindings.Add("DoubleValue",_fdcq3,"Jgzwmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblFttdmj.DataBindings.Clear();
            dblFttdmj.DataBindings.Add("DoubleValue",_fdcq3,"Fttdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_fdcq3,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_fdcq3,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_fdcq3,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_fdcq3,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_fdcq3,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_fdcq3,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_fdcq3).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_fdcq3);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_fdcq3);
        }        
        #endregion
        
        
    }
}