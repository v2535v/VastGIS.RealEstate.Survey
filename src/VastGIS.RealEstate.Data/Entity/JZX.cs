using System;

namespace VastGIS.RealEstate.Data.Entity
{
    /// <summary>
    /// 实体类： JZX.
    /// </summary>
    public class JZX : BackFeature
    {

        private string _zDZHDM = String.Empty;
        private string _ySDM = String.Empty;
        private double _jZXCD;
        private string _jZXLB = String.Empty;
        private string _jZXWZ = String.Empty;
        private string _jXXZ = String.Empty;
        private string _qSJXXYSBH = String.Empty;
        private byte[] _qSJXXYS;
        private string _qSZYYYSBH = String.Empty;
        private byte[] _qSZYYYS;

        public JZX()
        {
        }

        #region 公共属性		

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

        public double JZXCD
        {
            get { return _jZXCD; }
            set { _jZXCD = value; }
        }

        public string JZXLB
        {
            get { return _jZXLB; }
            set { _jZXLB = value; }
        }

        public string JZXWZ
        {
            get { return _jZXWZ; }
            set { _jZXWZ = value; }
        }

        public string JXXZ
        {
            get { return _jXXZ; }
            set { _jXXZ = value; }
        }

        public string QSJXXYSBH
        {
            get { return _qSJXXYSBH; }
            set { _qSJXXYSBH = value; }
        }

        public byte[] QSJXXYS
        {
            get { return _qSJXXYS; }
            set { _qSJXXYS = value; }
        }

        public string QSZYYYSBH
        {
            get { return _qSZYYYSBH; }
            set { _qSZYYYSBH = value; }
        }

        public byte[] QSZYYYS
        {
            get { return _qSZYYYS; }
            set { _qSZYYYS = value; }
        }

        #endregion

    }
}