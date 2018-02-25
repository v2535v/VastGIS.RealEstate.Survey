using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucSurveyEntity:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private ISurveyEntity _c;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucSurveyEntity()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Fwlx", "FWLXZD");
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
            _c=entity as ISurveyEntity;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_c,"ID");
            cmbFwlx.DataBindings.Clear();
            cmbFwlx.DataBindings.Add("SelectedValue",_c,"Fwlx");
            dblJsbl.DataBindings.Clear();
            dblJsbl.DataBindings.Add("DoubleValue",_c,"Jsbl");
            txtCh.DataBindings.Clear();
            txtCh.DataBindings.Add("Text",_c,"Ch");
            txtZrzh.DataBindings.Clear();
            txtZrzh.DataBindings.Add("Text",_c,"Zrzh");
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_c,"Ysdm");
            intSjc.DataBindings.Clear();
            intSjc.DataBindings.Add("IntegerValue",_c,"Sjc");
            txtMyc.DataBindings.Clear();
            txtMyc.DataBindings.Add("Text",_c,"Myc");
            dblCjzmj.DataBindings.Clear();
            dblCjzmj.DataBindings.Add("DoubleValue",_c,"Cjzmj");
            dblCtnjzmj.DataBindings.Clear();
            dblCtnjzmj.DataBindings.Add("DoubleValue",_c,"Ctnjzmj");
            dblCytmj.DataBindings.Clear();
            dblCytmj.DataBindings.Add("DoubleValue",_c,"Cytmj");
            dblCgyjzmj.DataBindings.Clear();
            dblCgyjzmj.DataBindings.Add("DoubleValue",_c,"Cgyjzmj");
            dblCftjzmj.DataBindings.Clear();
            dblCftjzmj.DataBindings.Add("DoubleValue",_c,"Cftjzmj");
            dblCbqmj.DataBindings.Clear();
            dblCbqmj.DataBindings.Add("DoubleValue",_c,"Cbqmj");
            dblCg.DataBindings.Clear();
            dblCg.DataBindings.Add("DoubleValue",_c,"Cg");
            dblSptymj.DataBindings.Clear();
            dblSptymj.DataBindings.Add("DoubleValue",_c,"Sptymj");
            
            ((INotifyPropertyChanged)_c).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_c);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_c);
        }        
        #endregion
        
        
    }
}