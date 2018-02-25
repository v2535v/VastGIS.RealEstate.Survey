using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGLAYERGROUPDETAIL:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgLayergroupdetail _vglayergroupdetail;
        private IREDatabase _database;
        
        public ucVGLAYERGROUPDETAIL()
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
        public void LinkObject(IREDatabase database,VgLayergroupdetail vg_layergroupdetail)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_layergroupdetail,"ID");
            txtZM.DataBindings.Clear();
            txtZM.DataBindings.Add("Text",vg_layergroupdetail,"Zm");
            txtMC.DataBindings.Clear();
            txtMC.DataBindings.Add("Text",vg_layergroupdetail,"Mc");
            chkIDENTIFY.DataBindings.Clear();
            chkIDENTIFY.DataBindings.Add("Checked",vg_layergroupdetail,"Identify");
            chkEDITABLE.DataBindings.Clear();
            chkEDITABLE.DataBindings.Add("Checked",vg_layergroupdetail,"Editable");
            chkQUERYABLE.DataBindings.Clear();
            chkQUERYABLE.DataBindings.Add("Checked",vg_layergroupdetail,"Queryable");
            chkSNAPABLE.DataBindings.Clear();
            chkSNAPABLE.DataBindings.Add("Checked",vg_layergroupdetail,"Snapable");
            chkVISIBLE.DataBindings.Clear();
            chkVISIBLE.DataBindings.Add("Checked",vg_layergroupdetail,"Visible");
        }
        
    }

}