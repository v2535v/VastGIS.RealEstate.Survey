using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucDyaq:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Dyaq _dyaq;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucDyaq()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Dybdclx", "DYBDCLXZD");
            _dictionaryNames.Add("Dyfs", "DYFSZD");
            _dictionaryNames.Add("Djlx", "DJLXZD");
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
            _dyaq=entity as Dyaq;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_dyaq,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_dyaq,"Ysdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdyh.DataBindings.Clear();
            txtBdcdyh.DataBindings.Add("Text",_dyaq,"Bdcdyh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtYwh.DataBindings.Clear();
            txtYwh.DataBindings.Add("Text",_dyaq,"Ywh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDybdclx.DataBindings.Clear();
            cmbDybdclx.DataBindings.Add("SelectedValue",_dyaq,"Dybdclx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDyr.DataBindings.Clear();
            txtDyr.DataBindings.Add("Text",_dyaq,"Dyr",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDyfs.DataBindings.Clear();
            cmbDyfs.DataBindings.Add("SelectedValue",_dyaq,"Dyfs",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbDjlx.DataBindings.Clear();
            cmbDjlx.DataBindings.Add("SelectedValue",_dyaq,"Djlx",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjyy.DataBindings.Clear();
            txtDjyy.DataBindings.Add("Text",_dyaq,"Djyy",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZjjzwzl.DataBindings.Clear();
            txtZjjzwzl.DataBindings.Add("Text",_dyaq,"Zjjzwzl",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZjjzwdyfw.DataBindings.Clear();
            txtZjjzwdyfw.DataBindings.Add("Text",_dyaq,"Zjjzwdyfw",true,DataSourceUpdateMode.OnPropertyChanged);
            dblBdbzzqse.DataBindings.Clear();
            dblBdbzzqse.DataBindings.Add("DoubleValue",_dyaq,"Bdbzzqse",true,DataSourceUpdateMode.OnPropertyChanged);
            datZwlxqssj.DataBindings.Clear();
            datZwlxqssj.DataBindings.Add("BindableValue",_dyaq,"Zwlxqssj",true,DataSourceUpdateMode.OnPropertyChanged);
            datZwlxjssj.DataBindings.Clear();
            datZwlxjssj.DataBindings.Add("BindableValue",_dyaq,"Zwlxjssj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZgzqqdss.DataBindings.Clear();
            txtZgzqqdss.DataBindings.Add("Text",_dyaq,"Zgzqqdss",true,DataSourceUpdateMode.OnPropertyChanged);
            dblZgzqse.DataBindings.Clear();
            dblZgzqse.DataBindings.Add("DoubleValue",_dyaq,"Zgzqse",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZxdyywh.DataBindings.Clear();
            txtZxdyywh.DataBindings.Add("Text",_dyaq,"Zxdyywh",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZxdyyy.DataBindings.Clear();
            txtZxdyyy.DataBindings.Add("Text",_dyaq,"Zxdyyy",true,DataSourceUpdateMode.OnPropertyChanged);
            datZxsj.DataBindings.Clear();
            datZxsj.DataBindings.Add("BindableValue",_dyaq,"Zxsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtBdcdjzmh.DataBindings.Clear();
            txtBdcdjzmh.DataBindings.Add("Text",_dyaq,"Bdcdjzmh",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQxdm.DataBindings.Clear();
            cmbQxdm.DataBindings.Add("SelectedValue",_dyaq,"Qxdm",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDjjg.DataBindings.Clear();
            txtDjjg.DataBindings.Add("Text",_dyaq,"Djjg",true,DataSourceUpdateMode.OnPropertyChanged);
            txtDbr.DataBindings.Clear();
            txtDbr.DataBindings.Add("Text",_dyaq,"Dbr",true,DataSourceUpdateMode.OnPropertyChanged);
            datDjsj.DataBindings.Clear();
            datDjsj.DataBindings.Add("BindableValue",_dyaq,"Djsj",true,DataSourceUpdateMode.OnPropertyChanged);
            txtFj.DataBindings.Clear();
            txtFj.DataBindings.Add("Text",_dyaq,"Fj",true,DataSourceUpdateMode.OnPropertyChanged);
            cmbQszt.DataBindings.Clear();
            cmbQszt.DataBindings.Add("SelectedValue",_dyaq,"Qszt",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_dyaq).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_dyaq);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_dyaq);
        }        
        #endregion
        
        
    }
}