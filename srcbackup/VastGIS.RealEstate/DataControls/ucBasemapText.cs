using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucBasemapText:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Dxtdldwzj _dxtdldwzj;
        private IREDatabase _database;
        
        public ucBasemapText()
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
        public void LinkObject(IREDatabase database,Dxtdldwzj dxtdldwzj)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",dxtdldwzj,"ID");
            txtWBNR.DataBindings.Clear();
            txtWBNR.DataBindings.Add("Text",dxtdldwzj,"Wbnr");
            txtTC.DataBindings.Clear();
            txtTC.DataBindings.Add("Text",dxtdldwzj,"Tc");
            txtCASSDM.DataBindings.Clear();
            txtCASSDM.DataBindings.Add("Text",dxtdldwzj,"Cassdm");
            txtFH.DataBindings.Clear();
            txtFH.DataBindings.Add("Text",dxtdldwzj,"Fh");
            dblFHDX.DataBindings.Clear();
            dblFHDX.DataBindings.Add("DoubleValue",dxtdldwzj,"Fhdx");
            dblXZJD.DataBindings.Clear();
            dblXZJD.DataBindings.Add("DoubleValue",dxtdldwzj,"Xzjd");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",dxtdldwzj,"Ysdm");
        }
        
    }

}