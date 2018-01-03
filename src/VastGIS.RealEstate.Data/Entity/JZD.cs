using System;

namespace VastGIS.RealEstate.Data.Entity
{
    /// <summary>
    /// This object represents the properties and methods of a JZD.
    /// </summary>
    public class JZD : BackFeature
    {

        private string _zDZHDM = String.Empty;
        private string _ySDM = String.Empty;
        private string _jZDH = String.Empty;
        private long _sXH;
        private string _jBLX = String.Empty;
        private string _jZDLX = String.Empty;
        private double _xZBZ;
        private double _yZBZ;

        public JZD()
        {
        }

        #region ¹«¹²ÊôÐÔ		

        public string ZDZHDM
        {
            get { return _zDZHDM; }
            set { _zDZHDM = value; }
        }

        public string YSDM
        {
            get { return _ySDM; }
            set { _ySDM = value; }
        }

        public string JZDH
        {
            get { return _jZDH; }
            set { _jZDH = value; }
        }

        public long SXH
        {
            get { return _sXH; }
            set { _sXH = value; }
        }

        public string JBLX
        {
            get { return _jBLX; }
            set { _jBLX = value; }
        }

        public string JZDLX
        {
            get { return _jZDLX; }
            set { _jZDLX = value; }
        }

        public double XZBZ
        {
            get { return _xZBZ; }
            set { _xZBZ = value; }
        }

        public double YZBZ
        {
            get { return _yZBZ; }
            set { _yZBZ = value; }
        }

        #endregion


    }

    #region JZDTOZD

    #endregion

}