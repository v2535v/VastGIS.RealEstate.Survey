using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucBasemapPoint:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Dxtdldwd _dxtdldwd;
        private IREDatabase _database;
        
        public ucBasemapPoint()
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
        public void LinkObject(IREDatabase database,Dxtdldwd dxtdldwd)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",dxtdldwd,"ID");
            txtTC.DataBindings.Clear();
            txtTC.DataBindings.Add("Text",dxtdldwd,"Tc");
            txtCASSDM.DataBindings.Clear();
            txtCASSDM.DataBindings.Add("Text",dxtdldwd,"Cassdm");
            txtFH.DataBindings.Clear();
            txtFH.DataBindings.Add("Text",dxtdldwd,"Fh");
            dblFHDX.DataBindings.Clear();
            dblFHDX.DataBindings.Add("DoubleValue",dxtdldwd,"Fhdx");
            dblXZJD.DataBindings.Clear();
            dblXZJD.DataBindings.Add("DoubleValue",dxtdldwd,"Xzjd");
            txtFSXX1.DataBindings.Clear();
            txtFSXX1.DataBindings.Add("Text",dxtdldwd,"Fsxx1");
            txtFSXX2.DataBindings.Clear();
            txtFSXX2.DataBindings.Add("Text",dxtdldwd,"Fsxx2");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",dxtdldwd,"Ysdm");
        }
        
    }

}