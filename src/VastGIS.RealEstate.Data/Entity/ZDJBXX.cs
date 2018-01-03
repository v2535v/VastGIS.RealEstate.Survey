using System;

namespace VastGIS.RealEstate.Data.Entity
{
    /// <summary>
    /// 实体类： ZDJBXX.
    /// </summary>
    public class ZDJBXX : BackFeature
    {

        private string _ySDM = String.Empty;
        private string _zDDM = String.Empty;
        private string _bDCDYH = String.Empty;
        private string _zDTZM = String.Empty;
        private string _zL = String.Empty;
        private double _zDMJ;
        private string _mJDW = String.Empty;
        private string _yT = String.Empty;
        private string _dJ = String.Empty;
        private double _jG;
        private string _qLLX = String.Empty;
        private string _qLXZ = String.Empty;
        private string _qLSDFS = String.Empty;
        private double _rJL;
        private double _jZMD;
        private double _jZXG;
        private string _zDSZD = String.Empty;
        private string _zDSZN = String.Empty;
        private string _zDSZX = String.Empty;
        private string _zDSZB = String.Empty;
        private byte[] _zDT;
        private string _tFH = String.Empty;
        private string _dJH = String.Empty;
        private string _dAH = String.Empty;
        private string _bZ = String.Empty;
        private string _zT = String.Empty;

        public ZDJBXX()
        {
        }

        #region 公共属性		

        public string YSDM
        {
            get { return _ySDM; }
            set { _ySDM = value; }
        }

        public string ZDDM
        {
            get { return _zDDM; }
            set { _zDDM = value; }
        }

        public string BDCDYH
        {
            get { return _bDCDYH; }
            set { _bDCDYH = value; }
        }

        public string ZDTZM
        {
            get { return _zDTZM; }
            set { _zDTZM = value; }
        }

        public string ZL
        {
            get { return _zL; }
            set { _zL = value; }
        }

        public double ZDMJ
        {
            get { return _zDMJ; }
            set { _zDMJ = value; }
        }

        public string MJDW
        {
            get { return _mJDW; }
            set { _mJDW = value; }
        }

        public string YT
        {
            get { return _yT; }
            set { _yT = value; }
        }

        public string DJ
        {
            get { return _dJ; }
            set { _dJ = value; }
        }

        public double JG
        {
            get { return _jG; }
            set { _jG = value; }
        }

        public string QLLX
        {
            get { return _qLLX; }
            set { _qLLX = value; }
        }

        public string QLXZ
        {
            get { return _qLXZ; }
            set { _qLXZ = value; }
        }

        public string QLSDFS
        {
            get { return _qLSDFS; }
            set { _qLSDFS = value; }
        }

        public double RJL
        {
            get { return _rJL; }
            set { _rJL = value; }
        }

        public double JZMD
        {
            get { return _jZMD; }
            set { _jZMD = value; }
        }

        public double JZXG
        {
            get { return _jZXG; }
            set { _jZXG = value; }
        }

        public string ZDSZD
        {
            get { return _zDSZD; }
            set { _zDSZD = value; }
        }

        public string ZDSZN
        {
            get { return _zDSZN; }
            set { _zDSZN = value; }
        }

        public string ZDSZX
        {
            get { return _zDSZX; }
            set { _zDSZX = value; }
        }

        public string ZDSZB
        {
            get { return _zDSZB; }
            set { _zDSZB = value; }
        }

        public byte[] ZDT
        {
            get { return _zDT; }
            set { _zDT = value; }
        }

        public string TFH
        {
            get { return _tFH; }
            set { _tFH = value; }
        }

        public string DJH
        {
            get { return _dJH; }
            set { _dJH = value; }
        }

        public string DAH
        {
            get { return _dAH; }
            set { _dAH = value; }
        }

        public string BZ
        {
            get { return _bZ; }
            set { _bZ = value; }
        }

        public string ZT
        {
            get { return _zT; }
            set { _zT = value; }
        }

        #endregion

    }
}