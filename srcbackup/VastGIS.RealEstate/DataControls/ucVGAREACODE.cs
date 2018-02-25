using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGAREACODE:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgAreacode _vgareacode;
        private IREDatabase _database;
        
        public ucVGAREACODE()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
        }
        
        private void InitDictionaries()
        {
            foreach (var onepair in _dictionaryNames)
            {
                string dName = onepair.Key;
                string dValue = onepair.Value;
                List<VgDictionary> _dicts = _database.DomainService.GetDictionaryByName(dValue);
                ComboBoxAdv combo = this.Controls["cmb" + onepair.Key] as ComboBoxAdv;
                combo.DataSource = _dicts;
                combo.DisplayMember ="Zdsm";
                combo.ValueMember ="Zdz";
            }
        }
        public void LinkObject(IREDatabase database,VgAreacode vg_areacode)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_areacode,"ID");
            txtXZQHMC.DataBindings.Clear();
            txtXZQHMC.DataBindings.Add("Text",vg_areacode,"Xzqhmc");
            txtXZQHDM.DataBindings.Clear();
            txtXZQHDM.DataBindings.Add("Text",vg_areacode,"Xzqhdm");
            intXZQHJB.DataBindings.Clear();
            intXZQHJB.DataBindings.Add("IntegerValue",vg_areacode,"Xzqhjb");
        }
        
    }

}