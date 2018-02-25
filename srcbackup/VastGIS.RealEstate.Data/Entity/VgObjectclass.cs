using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class VgObjectclass
    {
        protected IEnumerable<VgObjectclass> subClasses;

      public IEnumerable<VgObjectclass> SubClasses
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

        public string Information
        {
            get { return string.Format("{0}--{1}", zwmc, mc); }
        }
    }

}