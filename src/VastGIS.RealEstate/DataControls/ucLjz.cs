using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucLjz:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Ljz _ljz;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucLjz()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Fwjg1", "FWJGZD");
            _dictionaryNames.Add("Fwjg2", "FWJGZD");
            _dictionaryNames.Add("Fwjg3", "FWJGZD");
            _dictionaryNames.Add("Jzwzt", "JZWZTZD");
            _dictionaryNames.Add("Fwyt1", "FWYTZD");
            _dictionaryNames.Add("Fwyt2", "FWYTZD");
            _dictionaryNames.Add("Fwyt3", "FWYTZD");
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
            _ljz=entity as Ljz;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_ljz,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtLjzh.DataBindings.Clear();
            txtLjzh.DataBindings.Add("Text",_ljz,"Ljzh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZrzh.DataBindings.Clear();
            txtZrzh.DataBindings.Add("Text",_ljz,"Zrzh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_ljz,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtMph.DataBindings.Clear();
            txtMph.DataBindings.Add("Text",_ljz,"Mph",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYcjzmj.DataBindings.Clear();
            dblYcjzmj.DataBindings.Add("DoubleValue",_ljz,"Ycjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYcdxmj.DataBindings.Clear();
            dblYcdxmj.DataBindings.Add("DoubleValue",_ljz,"Ycdxmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblYcqtmj.DataBindings.Clear();
            dblYcqtmj.DataBindings.Add("DoubleValue",_ljz,"Ycqtmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblScjzmj.DataBindings.Clear();
            dblScjzmj.DataBindings.Add("DoubleValue",_ljz,"Scjzmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblScdxmj.DataBindings.Clear();
            dblScdxmj.DataBindings.Add("DoubleValue",_ljz,"Scdxmj",true,DataSourceUpdateMode.OnPropertyChanged);
            dblScqtmj.DataBindings.Clear();
            dblScqtmj.DataBindings.Add("DoubleValue",_ljz,"Scqtmj",true,DataSourceUpdateMode.OnPropertyChanged);
            datJgrq.DataBindings.Clear();
            datJgrq.DataBindings.Add("BindableValue",_ljz,"Jgrq",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwjg1.DataBindings.Clear();
            cmbFwjg1.DataBindings.Add("SelectedValue",_ljz,"Fwjg1",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwjg2.DataBindings.Clear();
            cmbFwjg2.DataBindings.Add("SelectedValue",_ljz,"Fwjg2",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwjg3.DataBindings.Clear();
            cmbFwjg3.DataBindings.Add("SelectedValue",_ljz,"Fwjg3",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbJzwzt.DataBindings.Clear();
            cmbJzwzt.DataBindings.Add("SelectedValue",_ljz,"Jzwzt",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwyt1.DataBindings.Clear();
            cmbFwyt1.DataBindings.Add("SelectedValue",_ljz,"Fwyt1",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwyt2.DataBindings.Clear();
            cmbFwyt2.DataBindings.Add("SelectedValue",_ljz,"Fwyt2",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbFwyt3.DataBindings.Clear();
            cmbFwyt3.DataBindings.Add("SelectedValue",_ljz,"Fwyt3",true,DataSourceUpdateMode.OnPropertyChanged);
            intZcs.DataBindings.Clear();
            intZcs.DataBindings.Add("IntegerValue",_ljz,"Zcs",true,DataSourceUpdateMode.OnPropertyChanged);
            intDscs.DataBindings.Clear();
            intDscs.DataBindings.Add("IntegerValue",_ljz,"Dscs",true,DataSourceUpdateMode.OnPropertyChanged);
            intDxcs.DataBindings.Clear();
            intDxcs.DataBindings.Add("IntegerValue",_ljz,"Dxcs",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBz.DataBindings.Clear();
            txtBz.DataBindings.Add("Text",_ljz,"Bz",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_ljz).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_ljz);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_ljz);
        }        
        #endregion
        
        
    }
}