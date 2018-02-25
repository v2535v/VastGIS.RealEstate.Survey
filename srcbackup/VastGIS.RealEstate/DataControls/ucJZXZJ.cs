using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucJZXZJ:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Jzxzj _jzxzj;
        private IREDatabase _database;
        
        public ucJZXZJ()
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
        public void LinkObject(IREDatabase database,Jzxzj jzxzj)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",jzxzj,"ID");
            txtGLYSBH.DataBindings.Clear();
            txtGLYSBH.DataBindings.Add("Text",jzxzj,"Glysbh");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",jzxzj,"Ysdm");
            txtZJNR.DataBindings.Clear();
            txtZJNR.DataBindings.Add("Text",jzxzj,"Zjnr");
            txtZT.DataBindings.Clear();
            txtZT.DataBindings.Add("Text",jzxzj,"Zt");
            txtYS.DataBindings.Clear();
            txtYS.DataBindings.Add("Text",jzxzj,"Ys");
            intBS.DataBindings.Clear();
            intBS.DataBindings.Add("IntegerValue",jzxzj,"Bs");
            txtXZ.DataBindings.Clear();
            txtXZ.DataBindings.Add("Text",jzxzj,"Xz");
            txtXHX.DataBindings.Clear();
            txtXHX.DataBindings.Add("Text",jzxzj,"Xhx");
            dblKD.DataBindings.Clear();
            dblKD.DataBindings.Add("DoubleValue",jzxzj,"Kd");
            dblGD.DataBindings.Clear();
            dblGD.DataBindings.Add("DoubleValue",jzxzj,"Gd");
            dblZJDZXJXZB.DataBindings.Clear();
            dblZJDZXJXZB.DataBindings.Add("DoubleValue",jzxzj,"Zjdzxjxzb");
            dblZJDZXJYZB.DataBindings.Clear();
            dblZJDZXJYZB.DataBindings.Add("DoubleValue",jzxzj,"Zjdzxjyzb");
            dblZJFX.DataBindings.Clear();
            dblZJFX.DataBindings.Add("DoubleValue",jzxzj,"Zjfx");
        }
        
    }

}