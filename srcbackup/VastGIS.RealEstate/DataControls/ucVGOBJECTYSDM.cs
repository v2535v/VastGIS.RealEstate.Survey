using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGOBJECTYSDM:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgObjectysdm _vgobjectysdm;
        private IREDatabase _database;
        
        public ucVGOBJECTYSDM()
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
        public void LinkObject(IREDatabase database,VgObjectysdm vg_objectysdm)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_objectysdm,"ID");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",vg_objectysdm,"Ysdm");
            txtYSMC.DataBindings.Clear();
            txtYSMC.DataBindings.Add("Text",vg_objectysdm,"Ysmc");
            intXSSX.DataBindings.Clear();
            intXSSX.DataBindings.Add("IntegerValue",vg_objectysdm,"Xssx");
            txtQSBG.DataBindings.Clear();
            txtQSBG.DataBindings.Add("Text",vg_objectysdm,"Qsbg");
            txtQSFH.DataBindings.Clear();
            txtQSFH.DataBindings.Add("Text",vg_objectysdm,"Qsfh");
            chkSFKJ.DataBindings.Clear();
            chkSFKJ.DataBindings.Add("Checked",vg_objectysdm,"Sfkj");
        }
        
    }

}