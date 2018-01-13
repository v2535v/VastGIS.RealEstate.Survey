using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucZDJBXX:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Zdjbxx _zdjbxx;
        private IREDatabase _database;
        
        public ucZDJBXX()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("ZDTZM", "ZDZHTZMZD");
            _dictionaryNames.Add("MJDW", "MJDWZD");
            _dictionaryNames.Add("DJ", "TDDJZD");
            _dictionaryNames.Add("QLLX", "QLLXZD");
            _dictionaryNames.Add("QLXZ", "QLXZZD");
            _dictionaryNames.Add("QLSDFS", "QLSDFSZD");
            _dictionaryNames.Add("ZT", "BDCDYZTZD");
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
        public void LinkObject(IREDatabase database,Zdjbxx zdjbxx)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",zdjbxx,"ID");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",zdjbxx,"Ysdm");
            txtZDDM.DataBindings.Clear();
            txtZDDM.DataBindings.Add("Text",zdjbxx,"Zddm");
            txtBDCDYH.DataBindings.Clear();
            txtBDCDYH.DataBindings.Add("Text",zdjbxx,"Bdcdyh");
            cmbZDTZM.DataBindings.Clear();
            cmbZDTZM.DataBindings.Add("SelectedValue",zdjbxx,"Zdtzm");
            txtZL.DataBindings.Clear();
            txtZL.DataBindings.Add("Text",zdjbxx,"Zl");
            dblZDMJ.DataBindings.Clear();
            dblZDMJ.DataBindings.Add("DoubleValue",zdjbxx,"Zdmj");
            cmbMJDW.DataBindings.Clear();
            cmbMJDW.DataBindings.Add("SelectedValue",zdjbxx,"Mjdw");
            txtYT.DataBindings.Clear();
            txtYT.DataBindings.Add("Text",zdjbxx,"Yt");
            cmbDJ.DataBindings.Clear();
            cmbDJ.DataBindings.Add("SelectedValue",zdjbxx,"Dj");
            dblJG.DataBindings.Clear();
            dblJG.DataBindings.Add("DoubleValue",zdjbxx,"Jg");
            cmbQLLX.DataBindings.Clear();
            cmbQLLX.DataBindings.Add("SelectedValue",zdjbxx,"Qllx");
            cmbQLXZ.DataBindings.Clear();
            cmbQLXZ.DataBindings.Add("SelectedValue",zdjbxx,"Qlxz");
            cmbQLSDFS.DataBindings.Clear();
            cmbQLSDFS.DataBindings.Add("SelectedValue",zdjbxx,"Qlsdfs");
            dblRJL.DataBindings.Clear();
            dblRJL.DataBindings.Add("DoubleValue",zdjbxx,"Rjl");
            dblJZMD.DataBindings.Clear();
            dblJZMD.DataBindings.Add("DoubleValue",zdjbxx,"Jzmd");
            dblJZXG.DataBindings.Clear();
            dblJZXG.DataBindings.Add("DoubleValue",zdjbxx,"Jzxg");
            txtZDSZD.DataBindings.Clear();
            txtZDSZD.DataBindings.Add("Text",zdjbxx,"Zdszd");
            txtZDSZN.DataBindings.Clear();
            txtZDSZN.DataBindings.Add("Text",zdjbxx,"Zdszn");
            txtZDSZX.DataBindings.Clear();
            txtZDSZX.DataBindings.Add("Text",zdjbxx,"Zdszx");
            txtZDSZB.DataBindings.Clear();
            txtZDSZB.DataBindings.Add("Text",zdjbxx,"Zdszb");
            txtZDT.DataBindings.Clear();
            txtZDT.DataBindings.Add("Text",zdjbxx,"Zdt");
            txtTFH.DataBindings.Clear();
            txtTFH.DataBindings.Add("Text",zdjbxx,"Tfh");
            txtDJH.DataBindings.Clear();
            txtDJH.DataBindings.Add("Text",zdjbxx,"Djh");
            txtDAH.DataBindings.Clear();
            txtDAH.DataBindings.Add("Text",zdjbxx,"Dah");
            txtBZ.DataBindings.Clear();
            txtBZ.DataBindings.Add("Text",zdjbxx,"Bz");
            cmbZT.DataBindings.Clear();
            cmbZT.DataBindings.Add("SelectedValue",zdjbxx,"Zt");
        }
        
    }

}