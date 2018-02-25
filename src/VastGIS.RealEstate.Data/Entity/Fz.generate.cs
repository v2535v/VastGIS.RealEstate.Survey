
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
    public partial class Fz : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "FZ";	
        public const string LAYER_NAME = "发证";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YWH = "YWH";
		public const string COL_YSDM = "YSDM";
		public const string COL_FZRY = "FZRY";
		public const string COL_FZSJ = "FZSJ";
		public const string COL_FZMC = "FZMC";
		public const string COL_FZSL = "FZSL";
		public const string COL_HFZSH = "HFZSH";
		public const string COL_LZRXM = "LZRXM";
		public const string COL_LZRZJLB = "LZRZJLB";
		public const string COL_LZRZJH = "LZRZJH";
		public const string COL_LZRDH = "LZRDH";
		public const string COL_LZRDZ = "LZRDZ";
		public const string COL_LZRYB = "LZRYB";
		public const string COL_BZ = "BZ";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_FZRY = "@FZRY";	
        public const string PARAM_FZSJ = "@FZSJ";	
        public const string PARAM_FZMC = "@FZMC";	
        public const string PARAM_FZSL = "@FZSL";	
        public const string PARAM_HFZSH = "@HFZSH";	
        public const string PARAM_LZRXM = "@LZRXM";	
        public const string PARAM_LZRZJLB = "@LZRZJLB";	
        public const string PARAM_LZRZJH = "@LZRZJH";	
        public const string PARAM_LZRDH = "@LZRDH";	
        public const string PARAM_LZRDZ = "@LZRDZ";	
        public const string PARAM_LZRYB = "@LZRYB";	
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_FZ ="SELECT  Id,YWH,YSDM,FZRY,FZSJ,FZMC,FZSL,HFZSH,LZRXM,LZRZJLB,LZRZJH,LZRDH,LZRDZ,LZRYB,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM FZ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_FZ = "INSERT INTO [FZ] (YWH, YSDM, FZRY, FZSJ, FZMC, FZSL, HFZSH, LZRXM, LZRZJLB, LZRZJH, LZRDH, LZRDZ, LZRYB, BZ, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YWH, @YSDM, @FZRY, @FZSJ, @FZMC, @FZSL, @HFZSH, @LZRXM, @LZRZJLB, @LZRZJH, @LZRDH, @LZRDZ, @LZRYB, @BZ, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_FZ = "UPDATE [FZ] SET YWH = @YWH, YSDM = @YSDM, FZRY = @FZRY, FZSJ = @FZSJ, FZMC = @FZMC, FZSL = @FZSL, HFZSH = @HFZSH, LZRXM = @LZRXM, LZRZJLB = @LZRZJLB, LZRZJH = @LZRZJH, LZRDH = @LZRDH, LZRDZ = @LZRDZ, LZRYB = @LZRYB, BZ = @BZ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_FZ = "DELETE FROM [FZ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_FZ = "UPDATE [FZ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///业务号
		protected string ywh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///发证人员
		protected string fzry = default(string);
        ///发证时间
		protected System.DateTime? fzsj = default(System.DateTime?);
        ///发证名称
		protected string fzmc = default(string);
        ///发证数量
		protected long? fzsl = default(long?);
        ///核发证书号
		protected string hfzsh = default(string);
        ///领证人姓名
		protected string lzrxm = default(string);
        ///领证人证件类别[字典:证件种类字典表-ZJZLZD]
		protected string lzrzjlb = default(string);
        ///领证人证件号
		protected string lzrzjh = default(string);
        ///领证人电话
		protected string lzrdh = default(string);
        ///领证人地址
		protected string lzrdz = default(string);
        ///领证人邮编
		protected string lzryb = default(string);
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
            get{return "Fz";}
        }
         public string LayerName
        {
            get{return "发证";}
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
                return string.Format("{0} {1} ({2})","FZ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","发证",this.id,this.ysdm);
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
		
        ///发证人员
        ///[Column(COL_FZRY, PARAM_FZRY )]
        public virtual string Fzry 
        {
            get { return this.fzry; }
			set	{ 
                  if(this.fzry != value)
                    {
                        this.OnPropertyChanging("Fzry"); 
                        this.fzry = value;                        
                        this.OnPropertyChanged("Fzry");
                    }   
                }
        }	
		
        ///发证时间
        ///[Column(COL_FZSJ, PARAM_FZSJ )]
        public virtual System.DateTime? Fzsj 
        {
            get { return this.fzsj; }
			set	{ 
                  if(this.fzsj != value)
                    {
                        this.OnPropertyChanging("Fzsj"); 
                        this.fzsj = value;                        
                        this.OnPropertyChanged("Fzsj");
                    }   
                }
        }	
		
        ///发证名称
        ///[Column(COL_FZMC, PARAM_FZMC )]
        public virtual string Fzmc 
        {
            get { return this.fzmc; }
			set	{ 
                  if(this.fzmc != value)
                    {
                        this.OnPropertyChanging("Fzmc"); 
                        this.fzmc = value;                        
                        this.OnPropertyChanged("Fzmc");
                    }   
                }
        }	
		
        ///发证数量
        ///[Column(COL_FZSL, PARAM_FZSL )]
        public virtual long? Fzsl 
        {
            get { return this.fzsl; }
			set	{ 
                  if(this.fzsl != value)
                    {
                        this.OnPropertyChanging("Fzsl"); 
                        this.fzsl = value;                        
                        this.OnPropertyChanged("Fzsl");
                    }   
                }
        }	
		
        ///核发证书号
        ///[Column(COL_HFZSH, PARAM_HFZSH )]
        public virtual string Hfzsh 
        {
            get { return this.hfzsh; }
			set	{ 
                  if(this.hfzsh != value)
                    {
                        this.OnPropertyChanging("Hfzsh"); 
                        this.hfzsh = value;                        
                        this.OnPropertyChanged("Hfzsh");
                    }   
                }
        }	
		
        ///领证人姓名
        ///[Column(COL_LZRXM, PARAM_LZRXM )]
        public virtual string Lzrxm 
        {
            get { return this.lzrxm; }
			set	{ 
                  if(this.lzrxm != value)
                    {
                        this.OnPropertyChanging("Lzrxm"); 
                        this.lzrxm = value;                        
                        this.OnPropertyChanged("Lzrxm");
                    }   
                }
        }	
		
        ///领证人证件类别
        ///[Column(COL_LZRZJLB, PARAM_LZRZJLB )]
        public virtual string Lzrzjlb 
        {
            get { return this.lzrzjlb; }
			set	{ 
                  if(this.lzrzjlb != value)
                    {
                        this.OnPropertyChanging("Lzrzjlb"); 
                        this.lzrzjlb = value;                        
                        this.OnPropertyChanged("Lzrzjlb");
                    }   
                }
        }	
		
        ///领证人证件号
        ///[Column(COL_LZRZJH, PARAM_LZRZJH )]
        public virtual string Lzrzjh 
        {
            get { return this.lzrzjh; }
			set	{ 
                  if(this.lzrzjh != value)
                    {
                        this.OnPropertyChanging("Lzrzjh"); 
                        this.lzrzjh = value;                        
                        this.OnPropertyChanged("Lzrzjh");
                    }   
                }
        }	
		
        ///领证人电话
        ///[Column(COL_LZRDH, PARAM_LZRDH )]
        public virtual string Lzrdh 
        {
            get { return this.lzrdh; }
			set	{ 
                  if(this.lzrdh != value)
                    {
                        this.OnPropertyChanging("Lzrdh"); 
                        this.lzrdh = value;                        
                        this.OnPropertyChanged("Lzrdh");
                    }   
                }
        }	
		
        ///领证人地址
        ///[Column(COL_LZRDZ, PARAM_LZRDZ )]
        public virtual string Lzrdz 
        {
            get { return this.lzrdz; }
			set	{ 
                  if(this.lzrdz != value)
                    {
                        this.OnPropertyChanging("Lzrdz"); 
                        this.lzrdz = value;                        
                        this.OnPropertyChanged("Lzrdz");
                    }   
                }
        }	
		
        ///领证人邮编
        ///[Column(COL_LZRYB, PARAM_LZRYB )]
        public virtual string Lzryb 
        {
            get { return this.lzryb; }
			set	{ 
                  if(this.lzryb != value)
                    {
                        this.OnPropertyChanging("Lzryb"); 
                        this.lzryb = value;                        
                        this.OnPropertyChanged("Lzryb");
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
        public Fz()
        {
            this.id=0;
            this.ywh="";
            this.ysdm="";
            this.fzry="";
            this.fzsj=DateTime.Now;
            this.fzmc="";
            this.fzsl=0;
            this.hfzsh="";
            this.lzrxm="";
            this.lzrzjlb="";
            this.lzrzjh="";
            this.lzrdh="";
            this.lzrdz="";
            this.lzryb="";
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
            Fz record = obj as Fz;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_FZ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_FZRY, this.Fzry);
				command.Parameters.AddWithValue(PARAM_FZSJ, this.Fzsj);
				command.Parameters.AddWithValue(PARAM_FZMC, this.Fzmc);
				command.Parameters.AddWithValue(PARAM_FZSL, this.Fzsl);
				command.Parameters.AddWithValue(PARAM_HFZSH, this.Hfzsh);
				command.Parameters.AddWithValue(PARAM_LZRXM, this.Lzrxm);
				command.Parameters.AddWithValue(PARAM_LZRZJLB, this.Lzrzjlb);
				command.Parameters.AddWithValue(PARAM_LZRZJH, this.Lzrzjh);
				command.Parameters.AddWithValue(PARAM_LZRDH, this.Lzrdh);
				command.Parameters.AddWithValue(PARAM_LZRDZ, this.Lzrdz);
				command.Parameters.AddWithValue(PARAM_LZRYB, this.Lzryb);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_FZ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_FZRY, this.Fzry);
				command.Parameters.AddWithValue(PARAM_FZSJ, this.Fzsj);
				command.Parameters.AddWithValue(PARAM_FZMC, this.Fzmc);
				command.Parameters.AddWithValue(PARAM_FZSL, this.Fzsl);
				command.Parameters.AddWithValue(PARAM_HFZSH, this.Hfzsh);
				command.Parameters.AddWithValue(PARAM_LZRXM, this.Lzrxm);
				command.Parameters.AddWithValue(PARAM_LZRZJLB, this.Lzrzjlb);
				command.Parameters.AddWithValue(PARAM_LZRZJH, this.Lzrzjh);
				command.Parameters.AddWithValue(PARAM_LZRDH, this.Lzrdh);
				command.Parameters.AddWithValue(PARAM_LZRDZ, this.Lzrdz);
				command.Parameters.AddWithValue(PARAM_LZRYB, this.Lzryb);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FZ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_FZ,dao.Connection))
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
			if (!reader.IsDBNull(3)) fzry = reader.GetString(3);
			if (!reader.IsDBNull(4)) fzsj = reader.GetDateTime(4);
			if (!reader.IsDBNull(5)) fzmc = reader.GetString(5);
			if (!reader.IsDBNull(6)) fzsl = reader.GetInt64(6);
			if (!reader.IsDBNull(7)) hfzsh = reader.GetString(7);
			if (!reader.IsDBNull(8)) lzrxm = reader.GetString(8);
			if (!reader.IsDBNull(9)) lzrzjlb = reader.GetString(9);
			if (!reader.IsDBNull(10)) lzrzjh = reader.GetString(10);
			if (!reader.IsDBNull(11)) lzrdh = reader.GetString(11);
			if (!reader.IsDBNull(12)) lzrdz = reader.GetString(12);
			if (!reader.IsDBNull(13)) lzryb = reader.GetString(13);
			if (!reader.IsDBNull(14)) bz = reader.GetString(14);
			if (!reader.IsDBNull(15)) databaseid = reader.GetInt64(15);
			if (!reader.IsDBNull(16)) flags = reader.GetInt16(16);
			if (!reader.IsDBNull(17)) xgr = reader.GetString(17);
			if (!reader.IsDBNull(18)) xgsj = reader.GetDateTime(18);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Fz target=new Fz();
            target.ID=0;
            target.Ywh=this.Ywh;
            target.Ysdm=this.Ysdm;
            target.Fzry=this.Fzry;
            target.Fzsj=this.Fzsj;
            target.Fzmc=this.Fzmc;
            target.Fzsl=this.Fzsl;
            target.Hfzsh=this.Hfzsh;
            target.Lzrxm=this.Lzrxm;
            target.Lzrzjlb=this.Lzrzjlb;
            target.Lzrzjh=this.Lzrzjh;
            target.Lzrdh=this.Lzrdh;
            target.Lzrdz=this.Lzrdz;
            target.Lzryb=this.Lzryb;
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
