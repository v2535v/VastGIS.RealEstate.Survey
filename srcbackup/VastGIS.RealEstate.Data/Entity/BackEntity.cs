using System.Data.SQLite;

namespace VastGIS.RealEstate.Data.Entity
{
    using System;
    using VastGIS.RealEstate.Data.Interface;

    /// <summary>
    /// Defines the <see cref="BackEntity" />
    /// </summary>
    public abstract class BackEntity : ISurveyEntity
    {
        private string _ysdm;
        private string _tableName;
        private string _simpleLabelString;
        private string _fullLabelString;
        private long? _databaseId;
        private short? _flags;
        private string _xgr;
        private DateTime? _xgsj;

        #region  Ù–‘

        /// <summary>
        /// Gets the EntityName
        /// </summary>
        public string EntityName { get; }

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public long ID { get; set; }

        public string Ysdm
        {
            get { return _ysdm; }
            set { _ysdm = value; }
        }

        /// <summary>
        /// Gets the ObjectName
        /// </summary>
        public string ObjectName { get; }

        /// <summary>
        /// Gets or sets the WxClsj
        /// </summary>
        public System.DateTime? WxClsj { get; set; }

        /// <summary>
        /// Gets or sets the WxCly
        /// </summary>
        public string WxCly { get; set; }

        /// <summary>
        /// Gets or sets the WxDcsj
        /// </summary>
        public System.DateTime? WxDcsj { get; set; }

        /// <summary>
        /// Gets or sets the WxDcy
        /// </summary>
        public string WxDcy { get; set; }

        /// <summary>
        /// Gets or sets the WxWydm
        /// </summary>
        public System.Guid? WxWydm { get; set; }

        /// <summary>
        /// Gets or sets the WxZjsj
        /// </summary>
        public System.DateTime? WxZjsj { get; set; }

        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        public string SimpleLabelString
        {
            get { return _simpleLabelString; }
        }

        public string FullLabelString
        {
            get { return _fullLabelString; }
        }

        public bool Save(ISQLiteDao dao)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ISQLiteDao dao)
        {
            throw new NotImplementedException();
        }

       

      

        /// <summary>
        /// Gets or sets the WxZjy
        /// </summary>
        public string WxZjy { get; set; }

        /// <summary>
        /// Gets or sets the WxZtsj
        /// </summary>
        public System.DateTime? WxZtsj { get; set; }

        /// <summary>
        /// Gets or sets the WxZty
        /// </summary>
        public string WxZty { get; set; }

        #endregion

        public long? DatabaseID
        {
            get { return _databaseId; }
            set { _databaseId = value; }
        }

        public short? Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }

        public string Xgr
        {
            get { return _xgr; }
            set { _xgr = value; }
        }

        public DateTime? Xgsj
        {
            get { return _xgsj; }
            set { _xgsj = value; }
        }
    }
}
