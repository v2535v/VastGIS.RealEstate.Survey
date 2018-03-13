using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucQlrSimple : UserControl, IEntityControl
    {
        #region 变量
        private Dictionary<string, string> _dictionaryNames;
        private Qlr _qlr;
        private IAppContext _context;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion

        public ucQlrSimple()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("Gyfs", "GYFSZD");
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
                if (combo == null)
                    continue;
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

        public void LinkObject(IAppContext context, IEntity entity)
        {
            _context = context;
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            if (_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            _qlr = entity as Qlr;
            txtQlrmc.DataBindings.Clear();
            txtQlrmc.DataBindings.Add("Text", _qlr, "Qlrmc", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDh.DataBindings.Clear();
            txtDh.DataBindings.Add("Text", _qlr, "Dh", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDz.DataBindings.Clear();
            txtDz.DataBindings.Add("Text", _qlr, "Dz", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbGyfs.DataBindings.Clear();
            cmbGyfs.DataBindings.Add("SelectedValue", _qlr, "Gyfs", true, DataSourceUpdateMode.OnPropertyChanged);

            ((INotifyPropertyChanged)_qlr).PropertyChanged += Entity_PropertyChanged;
            _hasChanged = false;
        }

        private void Entity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _hasChanged = true;
        }

        #region IEntityControl接口
        public bool HasChanged { get { return _hasChanged; } }
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