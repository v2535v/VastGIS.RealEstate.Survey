using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucTMPCADM:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private TmpCadm _tmpcadm;
        private IREDatabase _database;
        
        public ucTMPCADM()
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
        public void LinkObject(IREDatabase database,TmpCadm tmpcadm)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",tmpcadm,"ID");
            txtENTITYTYPE.DataBindings.Clear();
            txtENTITYTYPE.DataBindings.Add("Text",tmpcadm,"EntityType");
            txtHANDLE.DataBindings.Clear();
            txtHANDLE.DataBindings.Add("Text",tmpcadm,"Handle");
            txtFILENAME.DataBindings.Clear();
            txtFILENAME.DataBindings.Add("Text",tmpcadm,"FileName");
        }
        
    }

}