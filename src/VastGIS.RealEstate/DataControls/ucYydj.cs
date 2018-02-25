using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucYydj:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Yydj _yydj;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucYydj()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
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
            _yydj=entity as Yydj;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_yydj,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_yydj,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_yydj,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_yydj,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYysx.DataBindings.Clear();
            txtYysx.DataBindings.Add("Text",_yydj,"Yysx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdjzmh.DataBindings.Clear();
            txtBdcdjzmh.DataBindings.Add("Text",_yydj,"Bdcdjzmh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_yydj,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_yydj,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_yydj,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_yydj,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZxyyywh.DataBindings.Clear();
            txtZxyyywh.DataBindings.Add("Text",_yydj,"Zxyyywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZxyyyy.DataBindings.Clear();
            txtZxyyyy.DataBindings.Add("Text",_yydj,"Zxyyyy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZxyydbr.DataBindings.Clear();
            txtZxyydbr.DataBindings.Add("Text",_yydj,"Zxyydbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datZxyydjsj.DataBindings.Clear();
            datZxyydjsj.DataBindings.Add("BindableValue",_yydj,"Zxyydjsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_yydj,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_yydj,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_yydj).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_yydj);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_yydj);
        }        
        #endregion
        
        
    }
}