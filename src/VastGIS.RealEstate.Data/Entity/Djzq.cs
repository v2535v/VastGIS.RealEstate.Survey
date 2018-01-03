using System;
using System.Data.Entity.Spatial;

namespace VastGIS.RealEstate.Data.Entity
{
    public class DJZQ : BackFeature
    {

        private string _ySDM = String.Empty;
        private string _dJZQDM = String.Empty;
        private string _dJZQMC = String.Empty;
       

        public DJZQ()
        {
        }
        
        #region Public Properties		

        public string YSDM
        {
            get { return _ySDM; }
            set { _ySDM = value; }
        }

        public string DJZQDM
        {
            get { return _dJZQDM; }
            set { _dJZQDM = value; }
        }

        public string DJZQMC
        {
            get { return _dJZQMC; }
            set { _dJZQMC = value; }
        }

     
        #endregion


    }

    #region JZD

    #endregion
}