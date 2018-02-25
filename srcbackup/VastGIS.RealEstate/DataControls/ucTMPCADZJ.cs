using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucTMPCADZJ:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private TmpCadzj _tmpcadzj;
        private IREDatabase _database;
        
        public ucTMPCADZJ()
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
        public void LinkObject(IREDatabase database,TmpCadzj tmpcadzj)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",tmpcadzj,"ID");
            txtENTITYTYPE.DataBindings.Clear();
            txtENTITYTYPE.DataBindings.Add("Text",tmpcadzj,"EntityType");
            txtHANDLE.DataBindings.Clear();
            txtHANDLE.DataBindings.Add("Text",tmpcadzj,"Handle");
            txtFILENAME.DataBindings.Clear();
            txtFILENAME.DataBindings.Add("Text",tmpcadzj,"FileName");
        }
        
    }

}