using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGAREACODES:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgAreacodes _vgareacodes;
        private IREDatabase _database;
        
        public ucVGAREACODES()
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
                List<VgDictionary> _dicts = _database.DomainService.GetDictionaryByName(dName);
                ComboBoxAdv combo = this.Controls["cmb" + onepair.Key] as ComboBoxAdv;
                combo.DataSource = _dicts;
                combo.DisplayMember = _dicts[0].Zdsm;
                combo.ValueMember = _dicts[0].Zdz;
            }
        }
        public void LinkObject(IREDatabase database,VgAreacodes vg_areacodes)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_areacodes,"ID");
            txtXZQHMC.DataBindings.Clear();
            txtXZQHMC.DataBindings.Add("Text",vg_areacodes,"Xzqhmc");
            txtXZQHDM.DataBindings.Clear();
            txtXZQHDM.DataBindings.Add("Text",vg_areacodes,"Xzqhdm");
            intXZQHJB.DataBindings.Clear();
            intXZQHJB.DataBindings.Add("IntegerValue",vg_areacodes,"Xzqhjb");
        }
        
    }

}