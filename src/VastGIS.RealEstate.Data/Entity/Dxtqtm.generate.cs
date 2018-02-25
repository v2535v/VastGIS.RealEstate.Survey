
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;
using VastGIS.Shared;


namespace VastGIS.RealEstate.Data.Entity
{
    public partial class Dxtqtm : INotifyPropertyChanging, INotifyPropertyChanged,IBasemapPolygon,IDatabaseFeature,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "DXTQTM";	
        public const string LAYER_NAME = "其他图层面";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.Polygon;
     
		public const string COL_ID = "Id";
		public const string COL_TC = "TC";
		public const string COL_CASSDM = "CASSDM";
		public const string COL_FSXX1 = "FSXX1";
		public const string COL_FSXX2 = "FSXX2";
		public const string COL_YSDM = "YSDM";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		public const string COL_GEOMETRY = "geometry";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_TC = "@TC";	
        public const string PARAM_CASSDM = "@CASSDM";	
        public const string PARAM_FSXX1 = "@FSXX1";	
        public const string PARAM_FSXX2 = "@FSXX2";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
        public const string PARAM_GEOMETRY = "@geometry";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_DXTQTM ="SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTQTM WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_DXTQTM = "INSERT INTO [DXTQTM] (TC, CASSDM, FSXX1, FSXX2, YSDM, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @TC, @CASSDM, @FSXX1, @FSXX2, @YSDM, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_DXTQTM = "UPDATE [DXTQTM] SET TC = @TC, CASSDM = @CASSDM, FSXX1 = @FSXX1, FSXX2 = @FSXX2, YSDM = @YSDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ,  geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
		
		private const string SQL_DELETE_DXTQTM = "DELETE FROM [DXTQTM] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_DXTQTM = "UPDATE [DXTQTM] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///图层
		protected string tc = default(string);
        ///CASS代码
		protected string cassdm = default(string);
        ///附加属性1
		protected string fsxx1 = default(string);
        ///附加属性2
		protected string fsxx2 = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///原数据库内序号
		protected long? databaseid = default(long?);
        ///修改标记
		protected short? flags = default(short?);
        ///修改人
		protected string xgr = default(string);
        ///修改时间
		protected System.DateTime? xgsj = default(System.DateTime?);
        ///图形对象
        protected IGeometry _geometry;
        ///WKT字段
        protected string _wkt=default(string);
        
        private event PropertyChangingEventHandler propertyChanging;
        
        private event PropertyChangedEventHandler propertyChanged;
        #endregion

 		#region 事件属性
        
        event PropertyChangingEventHandler INotifyPropertyChanging.PropertyChanging
        {
            add { this.propertyChanging += value; }
            remove { this.propertyChanging -= value; }
        }
        
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        { 
            add { this.propertyChanged += value; }
            remove { this.propertyChanged -= value; }
        }
        #endregion
        
        #region IEntity 属性
         //对应数据库内表名称
        public string ObjectName
        {
            get{return "Dxtqtm";}
        }
         public string LayerName
        {
            get{return "其他图层面";}
        }
        public string EntityName{
            get{return "IBasemapPolygon,IDatabaseFeature,IYsdmEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return true;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","DXTQTM",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","其他图层面",this.id,this.ysdm);
            }
        }        
        #endregion
        
        #region 对象属性
        ///标识码
        ///[Column(COL_ID, PARAM_ID, default(long))]
        public virtual long ID 
        {
            get { return this.id; }
			set	{ 
                  if(this.id != value)
                    {
                        this.OnPropertyChanging("ID"); 
                        this.id = value;                        
                        this.OnPropertyChanged("ID");
                    }   
                }
        }	
		
        ///图层
        ///[Column(COL_TC, PARAM_TC )]
        public virtual string Tc 
        {
            get { return this.tc; }
			set	{ 
                  if(this.tc != value)
                    {
                        this.OnPropertyChanging("Tc"); 
                        this.tc = value;                        
                        this.OnPropertyChanged("Tc");
                    }   
                }
        }	
		
        ///CASS代码
        ///[Column(COL_CASSDM, PARAM_CASSDM )]
        public virtual string Cassdm 
        {
            get { return this.cassdm; }
			set	{ 
                  if(this.cassdm != value)
                    {
                        this.OnPropertyChanging("Cassdm"); 
                        this.cassdm = value;                        
                        this.OnPropertyChanged("Cassdm");
                    }   
                }
        }	
		
        ///附加属性1
        ///[Column(COL_FSXX1, PARAM_FSXX1 )]
        public virtual string Fsxx1 
        {
            get { return this.fsxx1; }
			set	{ 
                  if(this.fsxx1 != value)
                    {
                        this.OnPropertyChanging("Fsxx1"); 
                        this.fsxx1 = value;                        
                        this.OnPropertyChanged("Fsxx1");
                    }   
                }
        }	
		
        ///附加属性2
        ///[Column(COL_FSXX2, PARAM_FSXX2 )]
        public virtual string Fsxx2 
        {
            get { return this.fsxx2; }
			set	{ 
                  if(this.fsxx2 != value)
                    {
                        this.OnPropertyChanging("Fsxx2"); 
                        this.fsxx2 = value;                        
                        this.OnPropertyChanged("Fsxx2");
                    }   
                }
        }	
		
        ///要素代码
        ///[Column(COL_YSDM, PARAM_YSDM )]
        public virtual string Ysdm 
        {
            get { return this.ysdm; }
			set	{ 
                  if(this.ysdm != value)
                    {
                        this.OnPropertyChanging("Ysdm"); 
                        this.ysdm = value;                        
                        this.OnPropertyChanged("Ysdm");
                    }   
                }
        }	
		
        ///原数据库内序号
        ///[Column(COL_DATABASEID, PARAM_DATABASEID )]
        public virtual long? DatabaseID 
        {
            get { return this.databaseid; }
			set	{ 
                  if(this.databaseid != value)
                    {
                        this.OnPropertyChanging("DatabaseID"); 
                        this.databaseid = value;                        
                        this.OnPropertyChanged("DatabaseID");
                    }   
                }
        }	
		
        ///修改标记
        ///[Column(COL_FLAGS, PARAM_FLAGS )]
        public virtual short? Flags 
        {
            get { return this.flags; }
			set	{ 
                  if(this.flags != value)
                    {
                        this.OnPropertyChanging("Flags"); 
                        this.flags = value;                        
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
		
        ///修改人
        ///[Column(COL_XGR, PARAM_XGR )]
        public virtual string Xgr 
        {
            get { return this.xgr; }
			set	{ 
                  if(this.xgr != value)
                    {
                        this.OnPropertyChanging("Xgr"); 
                        this.xgr = value;                        
                        this.OnPropertyChanged("Xgr");
                    }   
                }
        }	
		
        ///修改时间
        ///[Column(COL_XGSJ, PARAM_XGSJ )]
        public virtual System.DateTime? Xgsj 
        {
            get { return this.xgsj; }
			set	{ 
                  if(this.xgsj != value)
                    {
                        this.OnPropertyChanging("Xgsj"); 
                        this.xgsj = value;                        
                        this.OnPropertyChanged("Xgsj");
                    }   
                }
        }	
		
      
       ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
        }
        ///图形对象
       public IGeometry Geometry
        {
            get{return _geometry;}
            set{
                this.OnPropertyChanging("Geometry");  
                _geometry=value;
                _wkt = _geometry.ExportToWkt();
                this.OnPropertyChanged("Geometry");
                }
        }
        ///WKT字段
        public string Wkt
        {
            get{return _wkt;}
            set{
               this.OnPropertyChanging("Geometry");  
                _wkt=value;               
                _geometry.ImportFromWkt(_wkt);
                this.OnPropertyChanged("Geometry"); 
            }
        }
        #endregion        
        
        #region 创建方法
        public Dxtqtm()
        {
            _geometry=new Geometry(GEOMETRY_TYPE,ZValueType.None);
            this.id=0;
            this.tc="";
            this.cassdm="";
            this.fsxx1="";
            this.fsxx2="";
            this.ysdm="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
            
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Dxtqtm record = obj as Dxtqtm;           
            
            return (object.ReferenceEquals(this, record)                    
                    || (record != null            
                        && this.ID == record.ID
                        && this.ID != default(long)
                        )
                    );           
        }
        
        public override int GetHashCode()
        {            
            int hashCode = 7;
            
            hashCode = (11 * hashCode) + this.id.GetHashCode();
                        
            return hashCode;          
        }
        
		
		
		public long Create(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_DXTQTM,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_TC, this.Tc);
				command.Parameters.AddWithValue(PARAM_CASSDM, this.Cassdm);
				command.Parameters.AddWithValue(PARAM_FSXX1, this.Fsxx1);
				command.Parameters.AddWithValue(PARAM_FSXX2, this.Fsxx2);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
                command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_DXTQTM,dao.Connection))
            {
                if(this.databaseid>0)
                {
                    this.flags=2;
                }
                else
                {
                    this.flags=1;
                }
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now; 
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_TC, this.Tc);
				command.Parameters.AddWithValue(PARAM_CASSDM, this.Cassdm);
				command.Parameters.AddWithValue(PARAM_FSXX1, this.Fsxx1);
				command.Parameters.AddWithValue(PARAM_FSXX2, this.Fsxx2);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
                command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
			   
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
         public bool Save(ISQLiteService dao)
        {
            if(this.id == default(long))
            {
                return Create(dao)>0;
            }
            else
            {
                return Update(dao);
            }
            
        }  
        
        public bool Delete(ISQLiteService dao)
        {
            if(this.databaseid==0)
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_DXTQTM,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_DXTQTM,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);  
                    command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);  
                    return (command.ExecuteNonQuery() == 1);
                }
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) tc = reader.GetString(1);
			if (!reader.IsDBNull(2)) cassdm = reader.GetString(2);
			if (!reader.IsDBNull(3)) fsxx1 = reader.GetString(3);
			if (!reader.IsDBNull(4)) fsxx2 = reader.GetString(4);
			if (!reader.IsDBNull(5)) ysdm = reader.GetString(5);
			if (!reader.IsDBNull(6)) databaseid = reader.GetInt64(6);
			if (!reader.IsDBNull(7)) flags = reader.GetInt16(7);
			if (!reader.IsDBNull(8)) xgr = reader.GetString(8);
			if (!reader.IsDBNull(9)) xgsj = reader.GetDateTime(9);
			if (!reader.IsDBNull(10)) this.Wkt=reader.GetString(10);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Dxtqtm target=new Dxtqtm();
            target.ID=0;
            target.Tc=this.Tc;
            target.Cassdm=this.Cassdm;
            target.Fsxx1=this.Fsxx1;
            target.Fsxx2=this.Fsxx2;
            target.Ysdm=this.Ysdm;
            target.DatabaseID=0;
            target.Flags=1;
            target.Xgr=Environment.UserName;
            target.Xgsj=DateTime.Now;
            target.Wkt=this._wkt;
            return target as IEntity;
           
        }
        ///从另外一个不知名的Entity中获得属性字段
        public void CopyProperties(IEntity sourceEntity)
        {
            Reflection.CopyProperties(sourceEntity,this);
        }
        #endregion
		
        
        protected virtual void OnPropertyChanging(string propertyName)
        {
            if(this.propertyChanging != null)
                this.propertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if(this.propertyChanged != null)
                this.propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        
        
    }
}
