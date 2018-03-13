using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucZdjbxx:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Zdjbxx _zdjbxx;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucZdjbxx()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Zdtzm", "ZDZHTZMZD");
            _dictionaryNames.Add("Mjdw", "MJDWZD");
            _dictionaryNames.Add("Dj", "TDDJZD");
            _dictionaryNames.Add("Qllx", "QLLXZD");
            _dictionaryNames.Add("Qlxz", "QLXZZD");
            _dictionaryNames.Add("Qlsdfs", "QLSDFSZD");
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
            _zdjbxx=entity as Zdjbxx;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_zdjbxx,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_zdjbxx,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZddm.DataBindings.Clear();
            txtZddm.DataBindings.Add("Text",_zdjbxx,"Zddm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_zdjbxx,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbZdtzm.DataBindings.Clear();
            cmbZdtzm.DataBindings.Add("SelectedValue",_zdjbxx,"Zdtzm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZl.DataBindings.Clear();
            txtZl.DataBindings.Add("Text",_zdjbxx,"Zl",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZdmj.DataBindings.Clear();
            dblZdmj.DataBindings.Add("DoubleValue",_zdjbxx,"Zdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbMjdw.DataBindings.Clear();
            cmbMjdw.DataBindings.Add("SelectedValue",_zdjbxx,"Mjdw",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYt.DataBindings.Clear();
            txtYt.DataBindings.Add("Text",_zdjbxx,"Yt",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDj.DataBindings.Clear();
            cmbDj.DataBindings.Add("SelectedValue",_zdjbxx,"Dj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJg.DataBindings.Clear();
            dblJg.DataBindings.Add("DoubleValue",_zdjbxx,"Jg",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQllx.DataBindings.Clear();
            cmbQllx.DataBindings.Add("SelectedValue",_zdjbxx,"Qllx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQlxz.DataBindings.Clear();
            cmbQlxz.DataBindings.Add("SelectedValue",_zdjbxx,"Qlxz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQlsdfs.DataBindings.Clear();
            cmbQlsdfs.DataBindings.Add("SelectedValue",_zdjbxx,"Qlsdfs",true,DataSourceUpdateMode.OnPropertyChanged);
            dblRjl.DataBindings.Clear();
            dblRjl.DataBindings.Add("DoubleValue",_zdjbxx,"Rjl",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJzmd.DataBindings.Clear();
            dblJzmd.DataBindings.Add("DoubleValue",_zdjbxx,"Jzmd",true,DataSourceUpdateMode.OnPropertyChanged);
            dblJzxg.DataBindings.Clear();
            dblJzxg.DataBindings.Add("DoubleValue",_zdjbxx,"Jzxg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdszd.DataBindings.Clear();
            txtZdszd.DataBindings.Add("Text",_zdjbxx,"Zdszd",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdszn.DataBindings.Clear();
            txtZdszn.DataBindings.Add("Text",_zdjbxx,"Zdszn",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdszx.DataBindings.Clear();
            txtZdszx.DataBindings.Add("Text",_zdjbxx,"Zdszx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdszb.DataBindings.Clear();
            txtZdszb.DataBindings.Add("Text",_zdjbxx,"Zdszb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZdt.DataBindings.Clear();
            txtZdt.DataBindings.Add("Text",_zdjbxx,"Zdt",true,DataSourceUpdateMode.OnPropertyChanged);
            txtTfh.DataBindings.Clear();
            txtTfh.DataBindings.Add("Text",_zdjbxx,"Tfh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjh.DataBindings.Clear();
            txtDjh.DataBindings.Add("Text",_zdjbxx,"Djh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDah.DataBindings.Clear();
            txtDah.DataBindings.Add("Text",_zdjbxx,"Dah",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_zdjbxx,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbZt.DataBindings.Clear();
            cmbZt.DataBindings.Add("SelectedValue",_zdjbxx,"Zt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_zdjbxx).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_zdjbxx);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_zdjbxx);
        }

        #endregion
    }
}