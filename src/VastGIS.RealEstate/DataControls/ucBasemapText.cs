using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucBasemapText:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private IBasemapText _dxtdldwzj;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucBasemapText()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
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
            _dxtdldwzj=entity as IBasemapText;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_dxtdldwzj,"ID");
            txtWbnr.DataBindings.Clear();
            txtWbnr.DataBindings.Add("Text",_dxtdldwzj,"Wbnr");
            txtTc.DataBindings.Clear();
            txtTc.DataBindings.Add("Text",_dxtdldwzj,"Tc");
            txtCassdm.DataBindings.Clear();
            txtCassdm.DataBindings.Add("Text",_dxtdldwzj,"Cassdm");
            txtFh.DataBindings.Clear();
            txtFh.DataBindings.Add("Text",_dxtdldwzj,"Fh");
            dblFhdx.DataBindings.Clear();
            dblFhdx.DataBindings.Add("DoubleValue",_dxtdldwzj,"Fhdx");
            dblXzjd.DataBindings.Clear();
            dblXzjd.DataBindings.Add("DoubleValue",_dxtdldwzj,"Xzjd");
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_dxtdldwzj,"Ysdm");
            
            ((INotifyPropertyChanged)_dxtdldwzj).PropertyChanged += Entity_PropertyChanged;
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
            return _database.SystemService.Save((IEntity)_dxtdldwzj);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_dxtdldwzj);
        }        
        #endregion
        
        
    }
}