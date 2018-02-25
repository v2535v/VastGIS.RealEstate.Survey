using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucZDBHQK:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Zdbhqk _zdbhqk;
        private IREDatabase _database;
        
        public ucZDBHQK()
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
        public void LinkObject(IREDatabase database,Zdbhqk zdbhqk)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",zdbhqk,"ID");
            txtZDDM.DataBindings.Clear();
            txtZDDM.DataBindings.Add("Text",zdbhqk,"Zddm");
            txtBHYY.DataBindings.Clear();
            txtBHYY.DataBindings.Add("Text",zdbhqk,"Bhyy");
            txtBHNR.DataBindings.Clear();
            txtBHNR.DataBindings.Add("Text",zdbhqk,"Bhnr");
            datDJSJ.DataBindings.Clear();
            datDJSJ.DataBindings.Add("BindableValue",zdbhqk,"Djsj");
            txtDBR.DataBindings.Clear();
            txtDBR.DataBindings.Add("Text",zdbhqk,"Dbr");
            txtFJ.DataBindings.Clear();
            txtFJ.DataBindings.Add("Text",zdbhqk,"Fj");
        }
        
    }

}