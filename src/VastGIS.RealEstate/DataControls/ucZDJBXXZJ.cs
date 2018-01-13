using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucZDJBXXZJ:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Zdjbxxzj _zdjbxxzj;
        private IREDatabase _database;
        
        public ucZDJBXXZJ()
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
        public void LinkObject(IREDatabase database,Zdjbxxzj zdjbxxzj)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",zdjbxxzj,"ID");
            txtGLYSDM.DataBindings.Clear();
            txtGLYSDM.DataBindings.Add("Text",zdjbxxzj,"Glysdm");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",zdjbxxzj,"Ysdm");
            txtZJNR.DataBindings.Clear();
            txtZJNR.DataBindings.Add("Text",zdjbxxzj,"Zjnr");
            txtZT.DataBindings.Clear();
            txtZT.DataBindings.Add("Text",zdjbxxzj,"Zt");
            txtYS.DataBindings.Clear();
            txtYS.DataBindings.Add("Text",zdjbxxzj,"Ys");
            intBS.DataBindings.Clear();
            intBS.DataBindings.Add("IntegerValue",zdjbxxzj,"Bs");
            txtXZ.DataBindings.Clear();
            txtXZ.DataBindings.Add("Text",zdjbxxzj,"Xz");
            txtXHX.DataBindings.Clear();
            txtXHX.DataBindings.Add("Text",zdjbxxzj,"Xhx");
            dblKD.DataBindings.Clear();
            dblKD.DataBindings.Add("DoubleValue",zdjbxxzj,"Kd");
            dblGD.DataBindings.Clear();
            dblGD.DataBindings.Add("DoubleValue",zdjbxxzj,"Gd");
            dblZJDZXJXZB.DataBindings.Clear();
            dblZJDZXJXZB.DataBindings.Add("DoubleValue",zdjbxxzj,"Zjdzxjxzb");
            dblZJDZXJYZB.DataBindings.Clear();
            dblZJDZXJYZB.DataBindings.Add("DoubleValue",zdjbxxzj,"Zjdzxjyzb");
            dblZJFX.DataBindings.Clear();
            dblZJFX.DataBindings.Add("DoubleValue",zdjbxxzj,"Zjfx");
        }
        
    }

}