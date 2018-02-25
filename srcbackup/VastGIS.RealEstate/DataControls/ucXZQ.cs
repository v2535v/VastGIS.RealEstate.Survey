using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucXZQ:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Xzq _xzq;
        private IREDatabase _database;
        
        public ucXZQ()
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
        public void LinkObject(IREDatabase database,Xzq xzq)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",xzq,"ID");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",xzq,"Ysdm");
            txtXZQDM.DataBindings.Clear();
            txtXZQDM.DataBindings.Add("Text",xzq,"Xzqdm");
            txtXZQMC.DataBindings.Clear();
            txtXZQMC.DataBindings.Add("Text",xzq,"Xzqmc");
            dblXZQMJ.DataBindings.Clear();
            dblXZQMJ.DataBindings.Add("DoubleValue",xzq,"Xzqmj");
        }
        
    }

}