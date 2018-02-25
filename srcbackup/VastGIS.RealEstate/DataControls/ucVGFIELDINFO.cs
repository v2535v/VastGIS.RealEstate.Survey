using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGFIELDINFO:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgFieldinfo _vgfieldinfo;
        private IREDatabase _database;
        
        public ucVGFIELDINFO()
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
        public void LinkObject(IREDatabase database,VgFieldinfo vg_fieldinfo)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            txtBM.DataBindings.Clear();
            txtBM.DataBindings.Add("Text",vg_fieldinfo,"Bm");
            intBNSX.DataBindings.Clear();
            intBNSX.DataBindings.Add("IntegerValue",vg_fieldinfo,"Bnsx");
            txtZDZWMC.DataBindings.Clear();
            txtZDZWMC.DataBindings.Add("Text",vg_fieldinfo,"Zdzwmc");
            txtZDMC.DataBindings.Clear();
            txtZDMC.DataBindings.Add("Text",vg_fieldinfo,"Zdmc");
            txtZDLX.DataBindings.Clear();
            txtZDLX.DataBindings.Add("Text",vg_fieldinfo,"Zdlx");
            intZDCD.DataBindings.Clear();
            intZDCD.DataBindings.Add("IntegerValue",vg_fieldinfo,"Zdcd");
            intZDXSWS.DataBindings.Clear();
            intZDXSWS.DataBindings.Add("IntegerValue",vg_fieldinfo,"Zdxsws");
            txtSYZD.DataBindings.Clear();
            txtSYZD.DataBindings.Add("Text",vg_fieldinfo,"Syzd");
            txtYS.DataBindings.Clear();
            txtYS.DataBindings.Add("Text",vg_fieldinfo,"Ys");
            txtSYZDYW.DataBindings.Clear();
            txtSYZDYW.DataBindings.Add("Text",vg_fieldinfo,"Syzdyw");
        }
        
    }

}