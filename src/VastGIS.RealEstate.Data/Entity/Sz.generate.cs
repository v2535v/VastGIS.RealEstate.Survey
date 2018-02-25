
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
    public partial class Sz : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "SZ";	
        public const string LAYER_NAME = "缮证";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YWH = "YWH";
		public const string COL_YSDM = "YSDM";
		public const string COL_SZMC = "SZMC";
		public const string COL_SZZH = "SZZH";
		public const string COL_YSXLH = "YSXLH";
		public const string COL_SZRY = "SZRY";
		public const string COL_SZSJ = "SZSJ";
		public const string COL_BZ = "BZ";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_SZMC = "@SZMC";	
        public const string PARAM_SZZH = "@SZZH";	
        public const string PARAM_YSXLH = "@YSXLH";	
        public const string PARAM_SZRY = "@SZRY";	
        public const string PARAM_SZSJ = "@SZSJ";	
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_SZ ="SELECT  Id,YWH,YSDM,SZMC,SZZH,YSXLH,SZRY,SZSJ,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM SZ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_SZ = "INSERT INTO [SZ] (YWH, YSDM, SZMC, SZZH, YSXLH, SZRY, SZSJ, BZ, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YWH, @YSDM, @SZMC, @SZZH, @YSXLH, @SZRY, @SZSJ, @BZ, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_SZ = "UPDATE [SZ] SET YWH = @YWH, YSDM = @YSDM, SZMC = @SZMC, SZZH = @SZZH, YSXLH = @YSXLH, SZRY = @SZRY, SZSJ = @SZSJ, BZ = @BZ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_SZ = "DELETE FROM [SZ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_SZ = "UPDATE [SZ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///业务号
		protected string ywh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///缮证名称
		protected string szmc = default(string);
        ///缮证证号
		protected string szzh = default(string);
        ///印刷序列号
		protected string ysxlh = default(string);
        ///缮证人员
		protected string szry = default(string);
        ///缮证时间
		protected System.DateTime? szsj = default(System.DateTime?);
        ///备注
		protected string bz = default(string);
        ///原数据库内序号
		protected long? databaseid = default(long?);
        ///修改标记
		protected short? flags = default(short?);
        ///修改人
		protected string xgr = default(string);
        ///修改时间
		protected System.DateTime? xgsj = default(System.DateTime?);
        
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
            get{return "Sz";}
        }
         public string LayerName
        {
            get{return "缮证";}
        }
        public string EntityName{
            get{return "IDatabaseEntity,IYsdmEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","SZ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","缮证",this.id,this.ysdm);
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
		
        ///业务号
        ///[Column(COL_YWH, PARAM_YWH )]
        public virtual string Ywh 
        {
            get { return this.ywh; }
			set	{ 
                  if(this.ywh != value)
                    {
                        this.OnPropertyChanging("Ywh"); 
                        this.ywh = value;                        
                        this.OnPropertyChanged("Ywh");
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
		
        ///缮证名称
        ///[Column(COL_SZMC, PARAM_SZMC )]
        public virtual string Szmc 
        {
            get { return this.szmc; }
			set	{ 
                  if(this.szmc != value)
                    {
                        this.OnPropertyChanging("Szmc"); 
                        this.szmc = value;                        
                        this.OnPropertyChanged("Szmc");
                    }   
                }
        }	
		
        ///缮证证号
        ///[Column(COL_SZZH, PARAM_SZZH )]
        public virtual string Szzh 
        {
            get { return this.szzh; }
			set	{ 
                  if(this.szzh != value)
                    {
                        this.OnPropertyChanging("Szzh"); 
                        this.szzh = value;                        
                        this.OnPropertyChanged("Szzh");
                    }   
                }
        }	
		
        ///印刷序列号
        ///[Column(COL_YSXLH, PARAM_YSXLH )]
        public virtual string Ysxlh 
        {
            get { return this.ysxlh; }
			set	{ 
                  if(this.ysxlh != value)
                    {
                        this.OnPropertyChanging("Ysxlh"); 
                        this.ysxlh = value;                        
                        this.OnPropertyChanged("Ysxlh");
                    }   
                }
        }	
		
        ///缮证人员
        ///[Column(COL_SZRY, PARAM_SZRY )]
        public virtual string Szry 
        {
            get { return this.szry; }
			set	{ 
                  if(this.szry != value)
                    {
                        this.OnPropertyChanging("Szry"); 
                        this.szry = value;                        
                        this.OnPropertyChanged("Szry");
                    }   
                }
        }	
		
        ///缮证时间
        ///[Column(COL_SZSJ, PARAM_SZSJ )]
        public virtual System.DateTime? Szsj 
        {
            get { return this.szsj; }
			set	{ 
                  if(this.szsj != value)
                    {
                        this.OnPropertyChanging("Szsj"); 
                        this.szsj = value;                        
                        this.OnPropertyChanged("Szsj");
                    }   
                }
        }	
		
        ///备注
        ///[Column(COL_BZ, PARAM_BZ )]
        public virtual string Bz 
        {
            get { return this.bz; }
			set	{ 
                  if(this.bz != value)
                    {
                        this.OnPropertyChanging("Bz"); 
                        this.bz = value;                        
                        this.OnPropertyChanged("Bz");
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
        #endregion        
        
        #region 创建方法
        public Sz()
        {
            this.id=0;
            this.ywh="";
            this.ysdm="";
            this.szmc="";
            this.szzh="";
            this.ysxlh="";
            this.szry="";
            this.szsj=DateTime.Now;
            this.bz="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Sz record = obj as Sz;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_SZ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_SZMC, this.Szmc);
				command.Parameters.AddWithValue(PARAM_SZZH, this.Szzh);
				command.Parameters.AddWithValue(PARAM_YSXLH, this.Ysxlh);
				command.Parameters.AddWithValue(PARAM_SZRY, this.Szry);
				command.Parameters.AddWithValue(PARAM_SZSJ, this.Szsj);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_SZ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_SZMC, this.Szmc);
				command.Parameters.AddWithValue(PARAM_SZZH, this.Szzh);
				command.Parameters.AddWithValue(PARAM_YSXLH, this.Ysxlh);
				command.Parameters.AddWithValue(PARAM_SZRY, this.Szry);
				command.Parameters.AddWithValue(PARAM_SZSJ, this.Szsj);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
			   
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_SZ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_SZ,dao.Connection))
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
			if (!reader.IsDBNull(1)) ywh = reader.GetString(1);
			if (!reader.IsDBNull(2)) ysdm = reader.GetString(2);
			if (!reader.IsDBNull(3)) szmc = reader.GetString(3);
			if (!reader.IsDBNull(4)) szzh = reader.GetString(4);
			if (!reader.IsDBNull(5)) ysxlh = reader.GetString(5);
			if (!reader.IsDBNull(6)) szry = reader.GetString(6);
			if (!reader.IsDBNull(7)) szsj = reader.GetDateTime(7);
			if (!reader.IsDBNull(8)) bz = reader.GetString(8);
			if (!reader.IsDBNull(9)) databaseid = reader.GetInt64(9);
			if (!reader.IsDBNull(10)) flags = reader.GetInt16(10);
			if (!reader.IsDBNull(11)) xgr = reader.GetString(11);
			if (!reader.IsDBNull(12)) xgsj = reader.GetDateTime(12);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Sz target=new Sz();
            target.ID=0;
            target.Ywh=this.Ywh;
            target.Ysdm=this.Ysdm;
            target.Szmc=this.Szmc;
            target.Szzh=this.Szzh;
            target.Ysxlh=this.Ysxlh;
            target.Szry=this.Szry;
            target.Szsj=this.Szsj;
            target.Bz=this.Bz;
            target.DatabaseID=0;
            target.Flags=1;
            target.Xgr=Environment.UserName;
            target.Xgsj=DateTime.Now;
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
