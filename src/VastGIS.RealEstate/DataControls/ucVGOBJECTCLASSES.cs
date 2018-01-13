using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGOBJECTCLASSES:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgObjectclasses _vgobjectclasses;
        private IREDatabase _database;
        
        public ucVGOBJECTCLASSES()
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
        public void LinkObject(IREDatabase database,VgObjectclasses vg_objectclasses)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_objectclasses,"ID");
            txtMC.DataBindings.Clear();
            txtMC.DataBindings.Add("Text",vg_objectclasses,"Mc");
            txtDXLX.DataBindings.Clear();
            txtDXLX.DataBindings.Add("Text",vg_objectclasses,"Dxlx");
            txtZWMC.DataBindings.Clear();
            txtZWMC.DataBindings.Add("Text",vg_objectclasses,"Zwmc");
            txtFBMC.DataBindings.Clear();
            txtFBMC.DataBindings.Add("Text",vg_objectclasses,"Fbmc");
            txtXHZDMC.DataBindings.Clear();
            txtXHZDMC.DataBindings.Add("Text",vg_objectclasses,"Xhzdmc");
            txtTXZDMC.DataBindings.Clear();
            txtTXZDMC.DataBindings.Add("Text",vg_objectclasses,"Txzdmc");
            txtTXLX.DataBindings.Clear();
            txtTXLX.DataBindings.Add("Text",vg_objectclasses,"Txlx");
            chkIDENTIFY.DataBindings.Clear();
            chkIDENTIFY.DataBindings.Add("Checked",vg_objectclasses,"Identify");
            chkEDITABLE.DataBindings.Clear();
            chkEDITABLE.DataBindings.Add("Checked",vg_objectclasses,"Editable");
            chkQUERYABLE.DataBindings.Clear();
            chkQUERYABLE.DataBindings.Add("Checked",vg_objectclasses,"Queryable");
            chkSNAPABLE.DataBindings.Clear();
            chkSNAPABLE.DataBindings.Add("Checked",vg_objectclasses,"Snapable");
            chkVISIBLE.DataBindings.Clear();
            chkVISIBLE.DataBindings.Add("Checked",vg_objectclasses,"Visible");
            intXSSX.DataBindings.Clear();
            intXSSX.DataBindings.Add("IntegerValue",vg_objectclasses,"Xssx");
            txtFILTER.DataBindings.Clear();
            txtFILTER.DataBindings.Add("Text",vg_objectclasses,"Filter");
            txtQSDM.DataBindings.Clear();
            txtQSDM.DataBindings.Add("Text",vg_objectclasses,"Qsdm");
            txtBJCT.DataBindings.Clear();
            txtBJCT.DataBindings.Add("Text",vg_objectclasses,"Bjct");
        }
        
    }

}