using System.Collections.Generic;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Events
{
    public class ObjectClassEventArgs
    {
        private List<VgObjectclass> _selectedClasses;
        private bool _isSingle;

        public List<VgObjectclass> SelectedClasses
        {
            get { return _selectedClasses; }
            set { _selectedClasses = value; }
        }

        public bool IsSingle
        {
            get { return _isSingle; }
            set { _isSingle = value; }
        }

        public ObjectClassEventArgs(bool isSingle, List<VgObjectclass> selectedClasses)
        {
            _isSingle = isSingle;
            _selectedClasses = selectedClasses;
        }
    }
}