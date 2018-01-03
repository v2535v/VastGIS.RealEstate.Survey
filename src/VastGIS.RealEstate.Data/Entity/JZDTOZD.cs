using System;

namespace VastGIS.RealEstate.Data.Entity
{
    /// <summary>
    /// 实体类： JZDTOZD.
    /// </summary>
    public class JZDTOZD : IEntity
    {
        private int _id;
        private string _jZDH = String.Empty;
        private string _zDDM = String.Empty;
        private long _dXH;

        public JZDTOZD()
        {
        }

        #region 公共属性
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string JZDH
        {
            get { return _jZDH; }
            set { _jZDH = value; }
        }

        public string ZDDM
        {
            get { return _zDDM; }
            set { _zDDM = value; }
        }

        public long DXH
        {
            get { return _dXH; }
            set { _dXH = value; }
        }
        #endregion

    }
}