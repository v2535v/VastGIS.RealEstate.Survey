using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucVGATTACHMENT:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private VgAttachment _vgattachment;
        private IREDatabase _database;
        
        public ucVGATTACHMENT()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("FJLX", "FJLXZD");
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
        public void LinkObject(IREDatabase database,VgAttachment vg_attachment)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",vg_attachment,"ID");
            txtFJMC.DataBindings.Clear();
            txtFJMC.DataBindings.Add("Text",vg_attachment,"Fjmc");
            txtFJLJ.DataBindings.Clear();
            txtFJLJ.DataBindings.Add("Text",vg_attachment,"Fjlj");
            cmbFJLX.DataBindings.Clear();
            cmbFJLX.DataBindings.Add("SelectedValue",vg_attachment,"Fjlx");
            datHQSJ.DataBindings.Clear();
            datHQSJ.DataBindings.Add("BindableValue",vg_attachment,"Hqsj");
            txtFJSM.DataBindings.Clear();
            txtFJSM.DataBindings.Add("Text",vg_attachment,"Fjsm");
        }
        
    }

}