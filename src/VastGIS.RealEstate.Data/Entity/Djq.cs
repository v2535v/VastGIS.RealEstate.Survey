using System;
using System.Data.Entity.Spatial;

namespace VastGIS.RealEstate.Data.Entity
{
    public class DJQ : BackFeature
    {
      
        private string _ySDM = String.Empty;
        private string _dJQDM = String.Empty;
        private string _dJQMC = String.Empty;
       
        public DJQ()
        {
        }
        

        #region Public Properties

        public string YSDM
        {
            get { return _ySDM; }
            set { _ySDM = value; }
        }

        public string DJQDM
        {
            get { return _dJQDM; }
            set { _dJQDM = value; }
        }

        public string DJQMC
        {
            get { return _dJQMC; }
            set { _dJQMC = value; }
        }

      
        #endregion


    }
}