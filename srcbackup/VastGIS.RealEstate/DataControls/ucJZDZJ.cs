using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.DataControls
{

    public partial class ucJZDZJ:UserControl
    {
        private Dictionary<string,string> _dictionaryNames;
        private Jzdzj _jzdzj;
        private IREDatabase _database;
        
        public ucJZDZJ()
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
        public void LinkObject(IREDatabase database,Jzdzj jzdzj)
        {
            _database = database;
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",jzdzj,"ID");
            txtGLYSBH.DataBindings.Clear();
            txtGLYSBH.DataBindings.Add("Text",jzdzj,"Glysbh");
            txtYSDM.DataBindings.Clear();
            txtYSDM.DataBindings.Add("Text",jzdzj,"Ysdm");
            txtZJNR.DataBindings.Clear();
            txtZJNR.DataBindings.Add("Text",jzdzj,"Zjnr");
            txtZT.DataBindings.Clear();
            txtZT.DataBindings.Add("Text",jzdzj,"Zt");
            txtYS.DataBindings.Clear();
            txtYS.DataBindings.Add("Text",jzdzj,"Ys");
            intBS.DataBindings.Clear();
            intBS.DataBindings.Add("IntegerValue",jzdzj,"Bs");
            txtXZ.DataBindings.Clear();
            txtXZ.DataBindings.Add("Text",jzdzj,"Xz");
            txtXHX.DataBindings.Clear();
            txtXHX.DataBindings.Add("Text",jzdzj,"Xhx");
            dblKD.DataBindings.Clear();
            dblKD.DataBindings.Add("DoubleValue",jzdzj,"Kd");
            dblGD.DataBindings.Clear();
            dblGD.DataBindings.Add("DoubleValue",jzdzj,"Gd");
            dblZJDZXJXZB.DataBindings.Clear();
            dblZJDZXJXZB.DataBindings.Add("DoubleValue",jzdzj,"Zjdzxjxzb");
            dblZJDZXJYZB.DataBindings.Clear();
            dblZJDZXJYZB.DataBindings.Add("DoubleValue",jzdzj,"Zjdzxjyzb");
            dblZJFX.DataBindings.Clear();
            dblZJFX.DataBindings.Add("DoubleValue",jzdzj,"Zjfx");
        }
        
    }

}