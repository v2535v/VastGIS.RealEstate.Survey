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
        private VgObjectclass _editingClass;
        private List<VgObjectclass> _selectedClasses;
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
            _editingClass = null;
            _selectedClasses = null;
        }


        [DataMember]
        public bool IsSnapping { get; set; }
        [DataMember]
        public VgObjectclass EditingClass { get { return _editingClass; }
            set
            {
                _editingClass = value;
                if (_editingClass!=null && _editingClass.Txlx!=0 && _selectedClasses != null)
                {
                    _selectedClasses = _selectedClasses.Where(c => c.Txlx == _editingClass.Txlx).ToList();
                }
            }
        }

        [DataMember]
        public List<VgObjectclass> SelectableClasses {
            get { return _selectedClasses; }
            set { _selectedClasses = value; } }
        [DataMember]
        public bool CopyIsMoving { get; set; }
    }
}
