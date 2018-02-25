using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGCADCODE:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgCadcode _vgcadcode;
        private IREDatabase _database;
        
        public ucVGCADCODE()
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
        public void LinkObject(IREDatabase database,VgCadcode vg_cadcode)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_cadcode,"ID");
            txtXH.DataBindings.Clear();
            txtXH.DataBindings.Add("Text",vg_cadcode,"Xh");
            intSFCY.DataBindings.Clear();
            intSFCY.DataBindings.Add("IntegerValue",vg_cadcode,"Sfcy");
            txtTC.DataBindings.Clear();
            txtTC.DataBindings.Add("Text",vg_cadcode,"Tc");
            txtCASSDM.DataBindings.Clear();
            txtCASSDM.DataBindings.Add("Text",vg_cadcode,"Cassdm");
            txtTXLX.DataBindings.Clear();
            txtTXLX.DataBindings.Add("Text",vg_cadcode,"Txlx");
            txtXTC.DataBindings.Clear();
            txtXTC.DataBindings.Add("Text",vg_cadcode,"Xtc");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",vg_cadcode,"Ysdm");
            txtYSLX.DataBindings.Clear();
            txtYSLX.DataBindings.Add("Text",vg_cadcode,"Yslx");
            intYSZL.DataBindings.Clear();
            intYSZL.DataBindings.Add("IntegerValue",vg_cadcode,"Yszl");
        }
        
    }

}