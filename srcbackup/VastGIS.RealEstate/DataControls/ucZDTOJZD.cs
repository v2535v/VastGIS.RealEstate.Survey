using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucZDTOJZD:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Zdtojzd _zdtojzd;
        private IREDatabase _database;
        
        public ucZDTOJZD()
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
        public void LinkObject(IREDatabase database,Zdtojzd zdtojzd)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",zdtojzd,"ID");
            txtZD_WYDM.DataBindings.Clear();
            txtZD_WYDM.DataBindings.Add("Text",zdtojzd,"ZdWydm");
            txtJZD_WYDM.DataBindings.Clear();
            txtJZD_WYDM.DataBindings.Add("Text",zdtojzd,"JzdWydm");
            txtSXH.DataBindings.Clear();
            txtSXH.DataBindings.Add("Text",zdtojzd,"Sxh");
        }
        
    }

}