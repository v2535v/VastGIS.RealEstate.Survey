using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGDICTIONARY:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgDictionary _vgdictionary;
        private IREDatabase _database;
        
        public ucVGDICTIONARY()
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
        public void LinkObject(IREDatabase database,VgDictionary vg_dictionary)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_dictionary,"ID");
            txtZDMC.DataBindings.Clear();
            txtZDMC.DataBindings.Add("Text",vg_dictionary,"Zdmc");
            txtZDZ.DataBindings.Clear();
            txtZDZ.DataBindings.Add("Text",vg_dictionary,"Zdz");
            txtZDSM.DataBindings.Clear();
            txtZDSM.DataBindings.Add("Text",vg_dictionary,"Zdsm");
            chkSFQS.DataBindings.Clear();
            chkSFQS.DataBindings.Add("Checked",vg_dictionary,"Sfqs");
            txtPX.DataBindings.Clear();
            txtPX.DataBindings.Add("Text",vg_dictionary,"Px");
        }
        
    }

}