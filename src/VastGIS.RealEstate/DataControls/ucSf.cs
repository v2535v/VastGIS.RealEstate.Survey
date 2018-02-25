using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucSf:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Sf _sf;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucSf()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Sfewsf", "SFZD");
            _dictionaryNames.Add("Sflx", "SFLXZD");
            _dictionaryNames.Add("Fff", "FFFSZD");
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
            _sf=entity as Sf;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_sf,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_sf,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_sf,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJfry.DataBindings.Clear();
            txtJfry.DataBindings.Add("Text",_sf,"Jfry",true,DataSourceUpdateMode.OnPropertyChanged);
            datJfrq.DataBindings.Clear();
            datJfrq.DataBindings.Add("BindableValue",_sf,"Jfrq",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSfkmmc.DataBindings.Clear();
            txtSfkmmc.DataBindings.Add("Text",_sf,"Sfkmmc",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSfewsf.DataBindings.Clear();
            cmbSfewsf.DataBindings.Add("SelectedValue",_sf,"Sfewsf",true,DataSourceUpdateMode.OnPropertyChanged);
            dblSfjs.DataBindings.Clear();
            dblSfjs.DataBindings.Add("DoubleValue",_sf,"Sfjs",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSflx.DataBindings.Clear();
            cmbSflx.DataBindings.Add("SelectedValue",_sf,"Sflx",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYsje.DataBindings.Clear();
            dblYsje.DataBindings.Add("DoubleValue",_sf,"Ysje",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZkhysje.DataBindings.Clear();
            dblZkhysje.DataBindings.Add("DoubleValue",_sf,"Zkhysje",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSfry.DataBindings.Clear();
            txtSfry.DataBindings.Add("Text",_sf,"Sfry",true,DataSourceUpdateMode.OnPropertyChanged);
            datSfrq.DataBindings.Clear();
            datSfrq.DataBindings.Add("BindableValue",_sf,"Sfrq",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFff.DataBindings.Clear();
            cmbFff.DataBindings.Add("SelectedValue",_sf,"Fff",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSjffr.DataBindings.Clear();
            txtSjffr.DataBindings.Add("Text",_sf,"Sjffr",true,DataSourceUpdateMode.OnPropertyChanged);
            dblSsje.DataBindings.Clear();
            dblSsje.DataBindings.Add("DoubleValue",_sf,"Ssje",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSfdw.DataBindings.Clear();
            txtSfdw.DataBindings.Add("Text",_sf,"Sfdw",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_sf).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_sf);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_sf);
        }        
        #endregion
        
        
    }
}