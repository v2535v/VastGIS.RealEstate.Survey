using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate
{
    [DataContract(Name = "RealEstateSettings")]
    public class PluginConfig
    {
        public PluginConfig()
        {
            SetDefaults();
        }
        public static PluginConfig Instance { get; internal set; }
        private void SetDefaults()
        {
            IsSnapping = true;
            EditingClass = null;
            SelectableClasses = null;
            CopyIsMoving = false;
        }


        [DataMember]
        public bool IsSnapping { get; set; }
        [DataMember]
        public VgObjectclass EditingClass { get; set; }

        [DataMember]
        public List<VgObjectclass> SelectableClasses { get; set; }
        [DataMember]
        public bool CopyIsMoving { get; set; }
    }
}
