using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGCADCODES:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgCadcodes _vgcadcodes;
        private IREDatabase _database;
        
        public ucVGCADCODES()
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
        public void LinkObject(IREDatabase database,VgCadcodes vg_cadcodes)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_cadcodes,"ID");
            txtXH.DataBindings.Clear();
            txtXH.DataBindings.Add("Text",vg_cadcodes,"Xh");
            intSFCY.DataBindings.Clear();
            intSFCY.DataBindings.Add("IntegerValue",vg_cadcodes,"Sfcy");
            txtTC.DataBindings.Clear();
            txtTC.DataBindings.Add("Text",vg_cadcodes,"Tc");
            txtCASSDM.DataBindings.Clear();
            txtCASSDM.DataBindings.Add("Text",vg_cadcodes,"Cassdm");
            txtTXLX.DataBindings.Clear();
            txtTXLX.DataBindings.Add("Text",vg_cadcodes,"Txlx");
            txtXTC.DataBindings.Clear();
            txtXTC.DataBindings.Add("Text",vg_cadcodes,"Xtc");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",vg_cadcodes,"Ysdm");
            txtYSLX.DataBindings.Clear();
            txtYSLX.DataBindings.Add("Text",vg_cadcodes,"Yslx");
            intYSZL.DataBindings.Clear();
            intYSZL.DataBindings.Add("IntegerValue",vg_cadcodes,"Yszl");
        }
        
    }

}