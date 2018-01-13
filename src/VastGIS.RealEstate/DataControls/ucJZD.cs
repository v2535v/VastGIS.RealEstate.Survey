using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucJZD:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Jzd _jzd;
        private IREDatabase _database;
        
        public ucJZD()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("JBLX", "JBLXZD");
            _dictionaryNames.Add("JZDLX", "JZDLXZD");
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
        public void LinkObject(IREDatabase database,Jzd jzd)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",jzd,"ID");
            txtZDZHDM.DataBindings.Clear();
            txtZDZHDM.DataBindings.Add("Text",jzd,"Zdzhdm");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",jzd,"Ysdm");
            txtJZDH.DataBindings.Clear();
            txtJZDH.DataBindings.Add("Text",jzd,"Jzdh");
            txtJZDGZBH.DataBindings.Clear();
            txtJZDGZBH.DataBindings.Add("Text",jzd,"Jzdgzbh");
            intSXH.DataBindings.Clear();
            intSXH.DataBindings.Add("IntegerValue",jzd,"Sxh");
            cmbJBLX.DataBindings.Clear();
            cmbJBLX.DataBindings.Add("SelectedValue",jzd,"Jblx");
            cmbJZDLX.DataBindings.Clear();
            cmbJZDLX.DataBindings.Add("SelectedValue",jzd,"Jzdlx");
            dblXZBZ.DataBindings.Clear();
            dblXZBZ.DataBindings.Add("DoubleValue",jzd,"Xzbz");
            dblYZBZ.DataBindings.Clear();
            dblYZBZ.DataBindings.Add("DoubleValue",jzd,"Yzbz");
        }
        
    }

}