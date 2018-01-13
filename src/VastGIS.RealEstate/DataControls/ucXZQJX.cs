using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucXZQJX:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Xzqjx _xzqjx;
        private IREDatabase _database;
        
        public ucXZQJX()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
            _dictionaryNames.Add("JXLX", "JXLXZD");
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
        public void LinkObject(IREDatabase database,Xzqjx xzqjx)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",xzqjx,"ID");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",xzqjx,"Ysdm");
            cmbJXLX.DataBindings.Clear();
            cmbJXLX.DataBindings.Add("SelectedValue",xzqjx,"Jxlx");
            cmbJXXZ.DataBindings.Clear();
            cmbJXXZ.DataBindings.Add("SelectedValue",xzqjx,"Jxxz");
            txtJXSM.DataBindings.Clear();
            txtJXSM.DataBindings.Add("Text",xzqjx,"Jxsm");
        }
        
    }

}