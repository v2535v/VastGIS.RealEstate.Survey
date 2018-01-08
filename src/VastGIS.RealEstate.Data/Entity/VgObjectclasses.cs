using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class VgObjectclasses
    {
        protected IEnumerable<VgObjectclasses> subClasses;

        //public VgObjectclasses()
        //{
        //    dxlx = 0;
        //    txlx = 0;
        //    editable = false;
        //    visible = true;

        //}
        public IEnumerable<VgObjectclasses> SubClasses
        {
            get { return this.subClasses; }
            set
            {
                if (this.subClasses != value)
                {
                    this.OnPropertyChanging("SubClasses");
                    this.subClasses = value;
                    this.OnPropertyChanged("SubClasses");
                }
            }
        }
    }

}