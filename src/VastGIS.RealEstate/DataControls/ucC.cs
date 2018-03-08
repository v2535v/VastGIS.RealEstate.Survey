using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucC : UserControl, IEntityControl
    {
        #region 变量
        private Dictionary<string, string> _dictionaryNames;
        private C _c;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion

        public ucC()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Cfwlx", "CFWLXZD");
            _dictionaryNames.Add("Jsbl", "CJSBLZD");
            intID.Enabled = false;
            _hasChanged = false;
        }

        private void InitDictionaries()
        {
            foreach (var onepair in _dictionaryNames)
            {
                string dName = onepair.Key;
                string dValue = onepair.Value;
                List<VgDictionary> _dicts = _database.DomainService.GetDictionaryByName(dValue);
                ComboBoxAdv combo = FindControl(this, "cmb" + onepair.Key) as ComboBoxAdv;
                combo.DataSource = _dicts;
                combo.DisplayMember = "Zdsm";
                combo.ValueMember = "Zdz";
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

        public void LinkObject(IREDatabase database, IEntity entity)
        {
            _database = database;
            if (_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            _c = entity as C;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue", _c, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbCfwlx.DataBindings.Clear();
            cmbCfwlx.DataBindings.Add("SelectedValue", _c, "Cfwlx", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbJsbl.DataBindings.Clear();
            //cmbJsbl.DataBindings.Add("SelectedValue", _c, "Jsbl", true, DataSourceUpdateMode.OnPropertyChanged);

            Binding binding = new Binding("SelectedValue", _c, "Jsbl", true, DataSourceUpdateMode.OnPropertyChanged, _c);
            binding.Format += Binding_Format;
            binding.Parse += Binding_Parse;
            cmbJsbl.DataBindings.Add(binding);

            txtCh.DataBindings.Clear();
            txtCh.DataBindings.Add("Text", _c, "Ch", true, DataSourceUpdateMode.OnPropertyChanged);
            txtZrzh.DataBindings.Clear();
            txtZrzh.DataBindings.Add("Text", _c, "Zrzh", true, DataSourceUpdateMode.OnPropertyChanged);
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text", _c, "Ysdm", true, DataSourceUpdateMode.OnPropertyChanged);
            intSjc.DataBindings.Clear();
            intSjc.DataBindings.Add("IntegerValue", _c, "Sjc", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMyc.DataBindings.Clear();
            txtMyc.DataBindings.Add("Text", _c, "Myc", true, DataSourceUpdateMode.OnPropertyChanged);
            dblCjzmj.DataBindings.Clear();
            dblCjzmj.DataBindings.Add("DoubleValue", _c, "Cjzmj", true, DataSourceUpdateMode.OnPropertyChanged);
            dblCtnjzmj.DataBindings.Clear();
            dblCtnjzmj.DataBindings.Add("DoubleValue", _c, "Ctnjzmj", true, DataSourceUpdateMode.OnPropertyChanged);
            dblCytmj.DataBindings.Clear();
            dblCytmj.DataBindings.Add("DoubleValue", _c, "Cytmj", true, DataSourceUpdateMode.OnPropertyChanged);
            dblCgyjzmj.DataBindings.Clear();
            dblCgyjzmj.DataBindings.Add("DoubleValue", _c, "Cgyjzmj", true, DataSourceUpdateMode.OnPropertyChanged);
            dblCftjzmj.DataBindings.Clear();
            dblCftjzmj.DataBindings.Add("DoubleValue", _c, "Cftjzmj", true, DataSourceUpdateMode.OnPropertyChanged);
            dblCbqmj.DataBindings.Clear();
            dblCbqmj.DataBindings.Add("DoubleValue", _c, "Cbqmj", true, DataSourceUpdateMode.OnPropertyChanged);
            dblCg.DataBindings.Clear();
            dblCg.DataBindings.Add("DoubleValue", _c, "Cg", true, DataSourceUpdateMode.OnPropertyChanged);
            dblSptymj.DataBindings.Clear();
            dblSptymj.DataBindings.Add("DoubleValue", _c, "Sptymj", true, DataSourceUpdateMode.OnPropertyChanged);


            ((INotifyPropertyChanged)_c).PropertyChanged += Entity_PropertyChanged;
            _hasChanged = false;
        }

        private void Binding_Parse(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType == typeof(double))
                return;

            List<VgDictionary> dicts = _database.DomainService.GetDictionaryByName("CJSBLZD");
            e.Value = Convert.ToDouble(dicts.FirstOrDefault(c => c.Zdz == e.Value.ToString()).Zdsm);
        }

        private void Binding_Format(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType == typeof(string))
                return;

            List<VgDictionary> dicts = _database.DomainService.GetDictionaryByName("CJSBLZD");
            e.Value = dicts.FirstOrDefault(c => c.Zdsm == e.Value.ToString()).Zdz;
        }

        private void Entity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _hasChanged = true;
        }

        #region IEntityControl接口
        public bool HasChanged { get { return _hasChanged; } }
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