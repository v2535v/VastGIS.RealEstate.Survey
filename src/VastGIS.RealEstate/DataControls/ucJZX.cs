using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucJZX:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Jzx _jzx;
        private IREDatabase _database;
        
        public ucJZX()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("JZXLB", "JZXLBZD");
            _dictionaryNames.Add("JZXWZ", "JZXWZZD");
            _dictionaryNames.Add("JXXZ", "JXXZZD");
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
        public void LinkObject(IREDatabase database,Jzx jzx)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",jzx,"ID");
            txtZDZHDM.DataBindings.Clear();
            txtZDZHDM.DataBindings.Add("Text",jzx,"Zdzhdm");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",jzx,"Ysdm");
            txtJZXGZBH.DataBindings.Clear();
            txtJZXGZBH.DataBindings.Add("Text",jzx,"Jzxgzbh");
            dblJZXCD.DataBindings.Clear();
            dblJZXCD.DataBindings.Add("DoubleValue",jzx,"Jzxcd");
            cmbJZXLB.DataBindings.Clear();
            cmbJZXLB.DataBindings.Add("SelectedValue",jzx,"Jzxlb");
            cmbJZXWZ.DataBindings.Clear();
            cmbJZXWZ.DataBindings.Add("SelectedValue",jzx,"Jzxwz");
            cmbJXXZ.DataBindings.Clear();
            cmbJXXZ.DataBindings.Add("SelectedValue",jzx,"Jxxz");
            txtQSJXXYSBH.DataBindings.Clear();
            txtQSJXXYSBH.DataBindings.Add("Text",jzx,"Qsjxxysbh");
            txtQSJXXYS.DataBindings.Clear();
            txtQSJXXYS.DataBindings.Add("Text",jzx,"Qsjxxys");
            txtQSZYYYSBH.DataBindings.Clear();
            txtQSZYYYSBH.DataBindings.Add("Text",jzx,"Qszyyysbh");
            txtQSZYYYS.DataBindings.Clear();
            txtQSZYYYS.DataBindings.Add("Text",jzx,"Qszyyys");
            txtQSJZDBH.DataBindings.Clear();
            txtQSJZDBH.DataBindings.Add("Text",jzx,"Qsjzdbh");
            txtJZJZDBH.DataBindings.Clear();
            txtJZJZDBH.DataBindings.Add("Text",jzx,"Jzjzdbh");
        }
        
    }

}