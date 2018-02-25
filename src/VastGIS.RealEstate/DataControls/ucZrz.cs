using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucZrz:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Zrz _zrz;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucZrz()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Ghyt", "FWYTZD");
            _dictionaryNames.Add("Fwjg", "FWJGZD");
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
            _zrz=entity as Zrz;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_zrz,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_zrz,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_zrz,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZddm.DataBindings.Clear();
            txtZddm.DataBindings.Add("Text",_zrz,"Zddm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZrzh.DataBindings.Clear();
            txtZrzh.DataBindings.Add("Text",_zrz,"Zrzh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtXmmc.DataBindings.Clear();
            txtXmmc.DataBindings.Add("Text",_zrz,"Xmmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJzwmc.DataBindings.Clear();
            txtJzwmc.DataBindings.Add("Text",_zrz,"Jzwmc",true,DataSourceUpdateMode.OnPropertyChanged);
            datJgrq.DataBindings.Clear();
            datJgrq.DataBindings.Add("BindableValue",_zrz,"Jgrq",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJzwgd.DataBindings.Clear();
            dblJzwgd.DataBindings.Add("DoubleValue",_zrz,"Jzwgd",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZzdmj.DataBindings.Clear();
            dblZzdmj.DataBindings.Add("DoubleValue",_zrz,"Zzdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZydmj.DataBindings.Clear();
            dblZydmj.DataBindings.Add("DoubleValue",_zrz,"Zydmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYcjzmj.DataBindings.Clear();
            dblYcjzmj.DataBindings.Add("DoubleValue",_zrz,"Ycjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblScjzmj.DataBindings.Clear();
            dblScjzmj.DataBindings.Add("DoubleValue",_zrz,"Scjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            intZcs.DataBindings.Clear();
            intZcs.DataBindings.Add("IntegerValue",_zrz,"Zcs",true,DataSourceUpdateMode.OnPropertyChanged);
            intDscs.DataBindings.Clear();
            intDscs.DataBindings.Add("IntegerValue",_zrz,"Dscs",true,DataSourceUpdateMode.OnPropertyChanged);
            intDxcs.DataBindings.Clear();
            intDxcs.DataBindings.Add("IntegerValue",_zrz,"Dxcs",true,DataSourceUpdateMode.OnPropertyChanged);
            dblDxsd.DataBindings.Clear();
            dblDxsd.DataBindings.Add("DoubleValue",_zrz,"Dxsd",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbGhyt.DataBindings.Clear();
            cmbGhyt.DataBindings.Add("SelectedValue",_zrz,"Ghyt",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwjg.DataBindings.Clear();
            cmbFwjg.DataBindings.Add("SelectedValue",_zrz,"Fwjg",true,DataSourceUpdateMode.OnPropertyChanged);
            intZts.DataBindings.Clear();
            intZts.DataBindings.Add("IntegerValue",_zrz,"Zts",true,DataSourceUpdateMode.OnPropertyChanged);
            txtJzwjbyt.DataBindings.Clear();
            txtJzwjbyt.DataBindings.Add("Text",_zrz,"Jzwjbyt",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDah.DataBindings.Clear();
            txtDah.DataBindings.Add("Text",_zrz,"Dah",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_zrz,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbZt.DataBindings.Clear();
            cmbZt.DataBindings.Add("SelectedValue",_zrz,"Zt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_zrz).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_zrz);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_zrz);
        }        
        #endregion
        
        
    }
}