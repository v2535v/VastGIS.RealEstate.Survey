using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGCLASSDETAIL:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgClassdetail _vgclassdetail;
        private IREDatabase _database;
        
        public ucVGCLASSDETAIL()
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
        public void LinkObject(IREDatabase database,VgClassdetail vg_classdetail)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_classdetail,"ID");
            txtGROUPNAME.DataBindings.Clear();
            txtGROUPNAME.DataBindings.Add("Text",vg_classdetail,"GroupName");
            txtTABLENAME.DataBindings.Clear();
            txtTABLENAME.DataBindings.Add("Text",vg_classdetail,"TableName");
            chkCREATEIMPL.DataBindings.Clear();
            chkCREATEIMPL.DataBindings.Add("Checked",vg_classdetail,"CreateImpl");
            txtINTERFACENAME.DataBindings.Clear();
            txtINTERFACENAME.DataBindings.Add("Text",vg_classdetail,"InterfaceName");
        }
        
    }

}