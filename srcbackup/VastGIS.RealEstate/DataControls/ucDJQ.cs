using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucDJQ:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Djq _djq;
        private IREDatabase _database;
        
        public ucDJQ()
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
        public void LinkObject(IREDatabase database,Djq djq)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",djq,"ID");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",djq,"Ysdm");
            txtDJQDM.DataBindings.Clear();
            txtDJQDM.DataBindings.Add("Text",djq,"Djqdm");
            txtDJQMC.DataBindings.Clear();
            txtDJQMC.DataBindings.Add("Text",djq,"Djqmc");
        }
        
    }

}