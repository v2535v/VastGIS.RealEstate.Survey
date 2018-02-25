using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucZhjbxx:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Zhjbxx _zhjbxx;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucZhjbxx()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Zhtzm", "ZDZHTZMZD");
            _dictionaryNames.Add("Xmxz", "XMXZZD");
            _dictionaryNames.Add("Db", "HYDBZD");
            _dictionaryNames.Add("Yhlxa", "HYSYLXAZD");
            _dictionaryNames.Add("Yhlxb", "HYSYLXBZD");
            _dictionaryNames.Add("Hdyt", "WJMHDYTZD");
            _dictionaryNames.Add("Zt", "BDCDYZTZD");
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
            _zhjbxx=entity as Zhjbxx;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_zhjbxx,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_zhjbxx,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZhdm.DataBindings.Clear();
            txtZhdm.DataBindings.Add("Text",_zhjbxx,"Zhdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_zhjbxx,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbZhtzm.DataBindings.Clear();
            cmbZhtzm.DataBindings.Add("SelectedValue",_zhjbxx,"Zhtzm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXmmc.DataBindings.Clear();
            txtXmmc.DataBindings.Add("Text",_zhjbxx,"Xmmc",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbXmxz.DataBindings.Clear();
            cmbXmxz.DataBindings.Add("SelectedValue",_zhjbxx,"Xmxz",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYhzmj.DataBindings.Clear();
            dblYhzmj.DataBindings.Add("DoubleValue",_zhjbxx,"Yhzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZhmj.DataBindings.Clear();
            dblZhmj.DataBindings.Add("DoubleValue",_zhjbxx,"Zhmj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDb.DataBindings.Clear();
            cmbDb.DataBindings.Add("SelectedValue",_zhjbxx,"Db",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZhax.DataBindings.Clear();
            dblZhax.DataBindings.Add("DoubleValue",_zhjbxx,"Zhax",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbYhlxa.DataBindings.Clear();
            cmbYhlxa.DataBindings.Add("SelectedValue",_zhjbxx,"Yhlxa",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbYhlxb.DataBindings.Clear();
            cmbYhlxb.DataBindings.Add("SelectedValue",_zhjbxx,"Yhlxb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYhwzsm.DataBindings.Clear();
            txtYhwzsm.DataBindings.Add("Text",_zhjbxx,"Yhwzsm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtHdmc.DataBindings.Clear();
            txtHdmc.DataBindings.Add("Text",_zhjbxx,"Hdmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtHddm.DataBindings.Clear();
            txtHddm.DataBindings.Add("Text",_zhjbxx,"Hddm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYdfw.DataBindings.Clear();
            txtYdfw.DataBindings.Add("Text",_zhjbxx,"Ydfw",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYdmj.DataBindings.Clear();
            dblYdmj.DataBindings.Add("DoubleValue",_zhjbxx,"Ydmj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtHdwz.DataBindings.Clear();
            txtHdwz.DataBindings.Add("Text",_zhjbxx,"Hdwz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbHdyt.DataBindings.Clear();
            cmbHdyt.DataBindings.Add("SelectedValue",_zhjbxx,"Hdyt",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZht.DataBindings.Clear();
            txtZht.DataBindings.Add("Text",_zhjbxx,"Zht",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDah.DataBindings.Clear();
            txtDah.DataBindings.Add("Text",_zhjbxx,"Dah",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbZt.DataBindings.Clear();
            cmbZt.DataBindings.Add("SelectedValue",_zhjbxx,"Zt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_zhjbxx).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_zhjbxx);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_zhjbxx);
        }        
        #endregion
        
        
    }
}