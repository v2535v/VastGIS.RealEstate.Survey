using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucH:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private H _h;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucH()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Mjdw", "MJDWZD");
            _dictionaryNames.Add("Hx", "HXZD");
            _dictionaryNames.Add("Hxjg", "HXJGZD");
            _dictionaryNames.Add("Fwyt1", "FWYTZD");
            _dictionaryNames.Add("Fwyt2", "FWYTZD");
            _dictionaryNames.Add("Fwyt3", "FWYTZD");
            _dictionaryNames.Add("Fwlx", "FWLXZD");
            _dictionaryNames.Add("Fwxz", "FWXZZD");
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
            _h=entity as H;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_h,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_h,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFwbm.DataBindings.Clear();
            txtFwbm.DataBindings.Add("Text",_h,"Fwbm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_h,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZrzh.DataBindings.Clear();
            txtZrzh.DataBindings.Add("Text",_h,"Zrzh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtLjzh.DataBindings.Clear();
            txtLjzh.DataBindings.Add("Text",_h,"Ljzh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtCh.DataBindings.Clear();
            txtCh.DataBindings.Add("Text",_h,"Ch",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZl.DataBindings.Clear();
            txtZl.DataBindings.Add("Text",_h,"Zl",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbMjdw.DataBindings.Clear();
            cmbMjdw.DataBindings.Add("SelectedValue",_h,"Mjdw",true,DataSourceUpdateMode.OnPropertyChanged);
            dblSjcs.DataBindings.Clear();
            dblSjcs.DataBindings.Add("DoubleValue",_h,"Sjcs",true,DataSourceUpdateMode.OnPropertyChanged);
            intHh.DataBindings.Clear();
            intHh.DataBindings.Add("IntegerValue",_h,"Hh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtShbw.DataBindings.Clear();
            txtShbw.DataBindings.Add("Text",_h,"Shbw",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbHx.DataBindings.Clear();
            cmbHx.DataBindings.Add("SelectedValue",_h,"Hx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbHxjg.DataBindings.Clear();
            cmbHxjg.DataBindings.Add("SelectedValue",_h,"Hxjg",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwyt1.DataBindings.Clear();
            cmbFwyt1.DataBindings.Add("SelectedValue",_h,"Fwyt1",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwyt2.DataBindings.Clear();
            cmbFwyt2.DataBindings.Add("SelectedValue",_h,"Fwyt2",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwyt3.DataBindings.Clear();
            cmbFwyt3.DataBindings.Add("SelectedValue",_h,"Fwyt3",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYcjzmj.DataBindings.Clear();
            dblYcjzmj.DataBindings.Add("DoubleValue",_h,"Ycjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYctnjzmj.DataBindings.Clear();
            dblYctnjzmj.DataBindings.Add("DoubleValue",_h,"Yctnjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYcftjzmj.DataBindings.Clear();
            dblYcftjzmj.DataBindings.Add("DoubleValue",_h,"Ycftjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYcdxbfjzmj.DataBindings.Clear();
            dblYcdxbfjzmj.DataBindings.Add("DoubleValue",_h,"Ycdxbfjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYcqtjzmj.DataBindings.Clear();
            dblYcqtjzmj.DataBindings.Add("DoubleValue",_h,"Ycqtjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYcftxs.DataBindings.Clear();
            dblYcftxs.DataBindings.Add("DoubleValue",_h,"Ycftxs",true,DataSourceUpdateMode.OnPropertyChanged);
            dblScjzmj.DataBindings.Clear();
            dblScjzmj.DataBindings.Add("DoubleValue",_h,"Scjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblSctnjzmj.DataBindings.Clear();
            dblSctnjzmj.DataBindings.Add("DoubleValue",_h,"Sctnjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblScftjzmj.DataBindings.Clear();
            dblScftjzmj.DataBindings.Add("DoubleValue",_h,"Scftjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblScdxbfjzmj.DataBindings.Clear();
            dblScdxbfjzmj.DataBindings.Add("DoubleValue",_h,"Scdxbfjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblScqtjzmj.DataBindings.Clear();
            dblScqtjzmj.DataBindings.Add("DoubleValue",_h,"Scqtjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblScftxs.DataBindings.Clear();
            dblScftxs.DataBindings.Add("DoubleValue",_h,"Scftxs",true,DataSourceUpdateMode.OnPropertyChanged);
            dblGytdmj.DataBindings.Clear();
            dblGytdmj.DataBindings.Add("DoubleValue",_h,"Gytdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblFttdmj.DataBindings.Clear();
            dblFttdmj.DataBindings.Add("DoubleValue",_h,"Fttdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblDytdmj.DataBindings.Clear();
            dblDytdmj.DataBindings.Add("DoubleValue",_h,"Dytdmj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwlx.DataBindings.Clear();
            cmbFwlx.DataBindings.Add("SelectedValue",_h,"Fwlx",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwxz.DataBindings.Clear();
            cmbFwxz.DataBindings.Add("SelectedValue",_h,"Fwxz",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFcfht.DataBindings.Clear();
            txtFcfht.DataBindings.Add("Text",_h,"Fcfht",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbZt.DataBindings.Clear();
            cmbZt.DataBindings.Add("SelectedValue",_h,"Zt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_h).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_h);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_h);
        }        
        #endregion
        
        
    }
}