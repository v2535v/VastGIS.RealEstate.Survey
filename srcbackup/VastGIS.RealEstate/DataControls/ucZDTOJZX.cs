using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucZDTOJZX:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Zdtojzx _zdtojzx;
        private IREDatabase _database;
        
        public ucZDTOJZX()
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
        public void LinkObject(IREDatabase database,Zdtojzx zdtojzx)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",zdtojzx,"ID");
            txtZD_WYDM.DataBindings.Clear();
            txtZD_WYDM.DataBindings.Add("Text",zdtojzx,"ZdWydm");
            txtJZX_WYDM.DataBindings.Clear();
            txtJZX_WYDM.DataBindings.Add("Text",zdtojzx,"JzxWydm");
            txtSXH.DataBindings.Clear();
            txtSXH.DataBindings.Add("Text",zdtojzx,"Sxh");
        }
        
    }

}