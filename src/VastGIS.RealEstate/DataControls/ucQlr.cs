using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucQlr:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Qlr _qlr;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucQlr()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Sfczr", "SFZD");
            _dictionaryNames.Add("Zjzl", "ZJZLZD");
            _dictionaryNames.Add("Gj", "GJHDQZD");
            _dictionaryNames.Add("Hjszss", "SSZD");
            _dictionaryNames.Add("Xb", "XBZD");
            _dictionaryNames.Add("Qlrlx", "QLRLXZD");
            _dictionaryNames.Add("Gyfs", "GYFSZD");
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
            _qlr=entity as Qlr;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_qlr,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_qlr,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_qlr,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            intSxh.DataBindings.Clear();
            intSxh.DataBindings.Add("IntegerValue",_qlr,"Sxh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlrmc.DataBindings.Clear();
            txtQlrmc.DataBindings.Add("Text",_qlr,"Qlrmc",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcqzh.DataBindings.Clear();
            txtBdcqzh.DataBindings.Add("Text",_qlr,"Bdcqzh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQzysxlh.DataBindings.Clear();
            txtQzysxlh.DataBindings.Add("Text",_qlr,"Qzysxlh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbSfczr.DataBindings.Clear();
            cmbSfczr.DataBindings.Add("SelectedValue",_qlr,"Sfczr",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbZjzl.DataBindings.Clear();
            cmbZjzl.DataBindings.Add("SelectedValue",_qlr,"Zjzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZjh.DataBindings.Clear();
            txtZjh.DataBindings.Add("Text",_qlr,"Zjh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFzjg.DataBindings.Clear();
            txtFzjg.DataBindings.Add("Text",_qlr,"Fzjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtSshy.DataBindings.Clear();
            txtSshy.DataBindings.Add("Text",_qlr,"Sshy",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbGj.DataBindings.Clear();
            cmbGj.DataBindings.Add("SelectedValue",_qlr,"Gj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbHjszss.DataBindings.Clear();
            cmbHjszss.DataBindings.Add("SelectedValue",_qlr,"Hjszss",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbXb.DataBindings.Clear();
            cmbXb.DataBindings.Add("SelectedValue",_qlr,"Xb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDh.DataBindings.Clear();
            txtDh.DataBindings.Add("Text",_qlr,"Dh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDz.DataBindings.Clear();
            txtDz.DataBindings.Add("Text",_qlr,"Dz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYb.DataBindings.Clear();
            txtYb.DataBindings.Add("Text",_qlr,"Yb",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGzdw.DataBindings.Clear();
            txtGzdw.DataBindings.Add("Text",_qlr,"Gzdw",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDzyj.DataBindings.Clear();
            txtDzyj.DataBindings.Add("Text",_qlr,"Dzyj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQlrlx.DataBindings.Clear();
            cmbQlrlx.DataBindings.Add("SelectedValue",_qlr,"Qlrlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtQlbl.DataBindings.Clear();
            txtQlbl.DataBindings.Add("Text",_qlr,"Qlbl",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbGyfs.DataBindings.Clear();
            cmbGyfs.DataBindings.Add("SelectedValue",_qlr,"Gyfs",true,DataSourceUpdateMode.OnPropertyChanged);
            txtGyqk.DataBindings.Clear();
            txtGyqk.DataBindings.Add("Text",_qlr,"Gyqk",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_qlr,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_qlr).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_qlr);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_qlr);
        }        
        #endregion
        
        
    }
}