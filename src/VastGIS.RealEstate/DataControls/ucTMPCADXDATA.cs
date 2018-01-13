using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucTMPCADXDATA:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private TmpCadxdata _tmpcadxdata;
        private IREDatabase _database;
        
        public ucTMPCADXDATA()
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
        public void LinkObject(IREDatabase database,TmpCadxdata tmpcadxdata)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",tmpcadxdata,"ID");
            txtHANDLE.DataBindings.Clear();
            txtHANDLE.DataBindings.Add("Text",tmpcadxdata,"Handle");
            txtTC.DataBindings.Clear();
            txtTC.DataBindings.Add("Text",tmpcadxdata,"Tc");
            txtWBNR.DataBindings.Clear();
            txtWBNR.DataBindings.Add("Text",tmpcadxdata,"Wbnr");
            txtCASSDM.DataBindings.Clear();
            txtCASSDM.DataBindings.Add("Text",tmpcadxdata,"Cassdm");
            txtFSXX1.DataBindings.Clear();
            txtFSXX1.DataBindings.Add("Text",tmpcadxdata,"Fsxx1");
            txtFSXX2.DataBindings.Clear();
            txtFSXX2.DataBindings.Add("Text",tmpcadxdata,"Fsxx2");
            dblXZJD.DataBindings.Clear();
            dblXZJD.DataBindings.Add("DoubleValue",tmpcadxdata,"Xzjd");
            txtFH.DataBindings.Clear();
            txtFH.DataBindings.Add("Text",tmpcadxdata,"Fh");
            dblFHDX.DataBindings.Clear();
            dblFHDX.DataBindings.Add("DoubleValue",tmpcadxdata,"Fhdx");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",tmpcadxdata,"Ysdm");
            txtFILENAME.DataBindings.Clear();
            txtFILENAME.DataBindings.Add("Text",tmpcadxdata,"FileName");
        }
        
    }

}