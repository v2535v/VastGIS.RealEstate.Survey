using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGOBJECTCLASS:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgObjectclass _vgobjectclass;
        private IREDatabase _database;
        
        public ucVGOBJECTCLASS()
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
        public void LinkObject(IREDatabase database,VgObjectclass vg_objectclass)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_objectclass,"ID");
            txtMC.DataBindings.Clear();
            txtMC.DataBindings.Add("Text",vg_objectclass,"Mc");
            txtDXLX.DataBindings.Clear();
            txtDXLX.DataBindings.Add("Text",vg_objectclass,"Dxlx");
            txtZWMC.DataBindings.Clear();
            txtZWMC.DataBindings.Add("Text",vg_objectclass,"Zwmc");
            txtFBMC.DataBindings.Clear();
            txtFBMC.DataBindings.Add("Text",vg_objectclass,"Fbmc");
            txtXHZDMC.DataBindings.Clear();
            txtXHZDMC.DataBindings.Add("Text",vg_objectclass,"Xhzdmc");
            txtTXZDMC.DataBindings.Clear();
            txtTXZDMC.DataBindings.Add("Text",vg_objectclass,"Txzdmc");
            txtTXLX.DataBindings.Clear();
            txtTXLX.DataBindings.Add("Text",vg_objectclass,"Txlx");
            chkIDENTIFY.DataBindings.Clear();
            chkIDENTIFY.DataBindings.Add("Checked",vg_objectclass,"Identify");
            chkEDITABLE.DataBindings.Clear();
            chkEDITABLE.DataBindings.Add("Checked",vg_objectclass,"Editable");
            chkQUERYABLE.DataBindings.Clear();
            chkQUERYABLE.DataBindings.Add("Checked",vg_objectclass,"Queryable");
            chkSNAPABLE.DataBindings.Clear();
            chkSNAPABLE.DataBindings.Add("Checked",vg_objectclass,"Snapable");
            chkVISIBLE.DataBindings.Clear();
            chkVISIBLE.DataBindings.Add("Checked",vg_objectclass,"Visible");
            intXSSX.DataBindings.Clear();
            intXSSX.DataBindings.Add("IntegerValue",vg_objectclass,"Xssx");
            txtFILTER.DataBindings.Clear();
            txtFILTER.DataBindings.Add("Text",vg_objectclass,"Filter");
            txtQSDM.DataBindings.Clear();
            txtQSDM.DataBindings.Add("Text",vg_objectclass,"Qsdm");
            txtBJCT.DataBindings.Clear();
            txtBJCT.DataBindings.Add("Text",vg_objectclass,"Bjct");
            chkBHFJ.DataBindings.Clear();
            chkBHFJ.DataBindings.Add("Checked",vg_objectclass,"Bhfj");
        }
        
    }

}