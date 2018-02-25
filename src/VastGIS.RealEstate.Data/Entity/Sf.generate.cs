
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
    public partial class Sf : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "SF";	
        public const string LAYER_NAME = "收费";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YWH = "YWH";
		public const string COL_YSDM = "YSDM";
		public const string COL_JFRY = "JFRY";
		public const string COL_JFRQ = "JFRQ";
		public const string COL_SFKMMC = "SFKMMC";
		public const string COL_SFEWSF = "SFEWSF";
		public const string COL_SFJS = "SFJS";
		public const string COL_SFLX = "SFLX";
		public const string COL_YSJE = "YSJE";
		public const string COL_ZKHYSJE = "ZKHYSJE";
		public const string COL_SFRY = "SFRY";
		public const string COL_SFRQ = "SFRQ";
		public const string COL_FFF = "FFF";
		public const string COL_SJFFR = "SJFFR";
		public const string COL_SSJE = "SSJE";
		public const string COL_SFDW = "SFDW";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_JFRY = "@JFRY";	
        public const string PARAM_JFRQ = "@JFRQ";	
        public const string PARAM_SFKMMC = "@SFKMMC";	
        public const string PARAM_SFEWSF = "@SFEWSF";	
        public const string PARAM_SFJS = "@SFJS";	
        public const string PARAM_SFLX = "@SFLX";	
        public const string PARAM_YSJE = "@YSJE";	
        public const string PARAM_ZKHYSJE = "@ZKHYSJE";	
        public const string PARAM_SFRY = "@SFRY";	
        public const string PARAM_SFRQ = "@SFRQ";	
        public const string PARAM_FFF = "@FFF";	
        public const string PARAM_SJFFR = "@SJFFR";	
        public const string PARAM_SSJE = "@SSJE";	
        public const string PARAM_SFDW = "@SFDW";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_SF ="SELECT  Id,YWH,YSDM,JFRY,JFRQ,SFKMMC,SFEWSF,SFJS,SFLX,YSJE,ZKHYSJE,SFRY,SFRQ,FFF,SJFFR,SSJE,SFDW,DatabaseId,FLAGS,XGR,XGSJ FROM SF WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_SF = "INSERT INTO [SF] (YWH, YSDM, JFRY, JFRQ, SFKMMC, SFEWSF, SFJS, SFLX, YSJE, ZKHYSJE, SFRY, SFRQ, FFF, SJFFR, SSJE, SFDW, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YWH, @YSDM, @JFRY, @JFRQ, @SFKMMC, @SFEWSF, @SFJS, @SFLX, @YSJE, @ZKHYSJE, @SFRY, @SFRQ, @FFF, @SJFFR, @SSJE, @SFDW, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_SF = "UPDATE [SF] SET YWH = @YWH, YSDM = @YSDM, JFRY = @JFRY, JFRQ = @JFRQ, SFKMMC = @SFKMMC, SFEWSF = @SFEWSF, SFJS = @SFJS, SFLX = @SFLX, YSJE = @YSJE, ZKHYSJE = @ZKHYSJE, SFRY = @SFRY, SFRQ = @SFRQ, FFF = @FFF, SJFFR = @SJFFR, SSJE = @SSJE, SFDW = @SFDW, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_SF = "DELETE FROM [SF] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_SF = "UPDATE [SF] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///业务号
		protected string ywh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///计费人员
		protected string jfry = default(string);
        ///计费日期
		protected System.DateTime? jfrq = default(System.DateTime?);
        ///收费科目名称
		protected string sfkmmc = default(string);
        ///是否额外收费[字典:是否字典表-SFZD]
		protected string sfewsf = default(string);
        ///收费基数
		protected double? sfjs = default(double?);
        ///收费类型[字典:收费类型字典表-SFLXZD]
		protected string sflx = default(string);
        ///应收金额
		protected double? ysje = default(double?);
        ///折扣后应收金额
		protected double? zkhysje = default(double?);
        ///收费人员
		protected string sfry = default(string);
        ///收费日期
		protected System.DateTime? sfrq = default(System.DateTime?);
        ///付费方[字典:付费方字典表-FFFSZD]
		protected string fff = default(string);
        ///实际付费人
		protected string sjffr = default(string);
        ///实收金额
		protected double? ssje = default(double?);
        ///收费单位
		protected string sfdw = default(string);
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
            get{return "Sf";}
        }
         public string LayerName
        {
            get{return "收费";}
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
                return string.Format("{0} {1} ({2})","SF",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","收费",this.id,this.ysdm);
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
		
        ///计费人员
        ///[Column(COL_JFRY, PARAM_JFRY )]
        public virtual string Jfry 
        {
            get { return this.jfry; }
			set	{ 
                  if(this.jfry != value)
                    {
                        this.OnPropertyChanging("Jfry"); 
                        this.jfry = value;                        
                        this.OnPropertyChanged("Jfry");
                    }   
                }
        }	
		
        ///计费日期
        ///[Column(COL_JFRQ, PARAM_JFRQ )]
        public virtual System.DateTime? Jfrq 
        {
            get { return this.jfrq; }
			set	{ 
                  if(this.jfrq != value)
                    {
                        this.OnPropertyChanging("Jfrq"); 
                        this.jfrq = value;                        
                        this.OnPropertyChanged("Jfrq");
                    }   
                }
        }	
		
        ///收费科目名称
        ///[Column(COL_SFKMMC, PARAM_SFKMMC )]
        public virtual string Sfkmmc 
        {
            get { return this.sfkmmc; }
			set	{ 
                  if(this.sfkmmc != value)
                    {
                        this.OnPropertyChanging("Sfkmmc"); 
                        this.sfkmmc = value;                        
                        this.OnPropertyChanged("Sfkmmc");
                    }   
                }
        }	
		
        ///是否额外收费
        ///[Column(COL_SFEWSF, PARAM_SFEWSF )]
        public virtual string Sfewsf 
        {
            get { return this.sfewsf; }
			set	{ 
                  if(this.sfewsf != value)
                    {
                        this.OnPropertyChanging("Sfewsf"); 
                        this.sfewsf = value;                        
                        this.OnPropertyChanged("Sfewsf");
                    }   
                }
        }	
		
        ///收费基数
        ///[Column(COL_SFJS, PARAM_SFJS )]
        public virtual double? Sfjs 
        {
            get { return this.sfjs; }
			set	{ 
                  if(this.sfjs != value)
                    {
                        this.OnPropertyChanging("Sfjs"); 
                        this.sfjs = value;                        
                        this.OnPropertyChanged("Sfjs");
                    }   
                }
        }	
		
        ///收费类型
        ///[Column(COL_SFLX, PARAM_SFLX )]
        public virtual string Sflx 
        {
            get { return this.sflx; }
			set	{ 
                  if(this.sflx != value)
                    {
                        this.OnPropertyChanging("Sflx"); 
                        this.sflx = value;                        
                        this.OnPropertyChanged("Sflx");
                    }   
                }
        }	
		
        ///应收金额
        ///[Column(COL_YSJE, PARAM_YSJE )]
        public virtual double? Ysje 
        {
            get { return this.ysje; }
			set	{ 
                  if(this.ysje != value)
                    {
                        this.OnPropertyChanging("Ysje"); 
                        this.ysje = value;                        
                        this.OnPropertyChanged("Ysje");
                    }   
                }
        }	
		
        ///折扣后应收金额
        ///[Column(COL_ZKHYSJE, PARAM_ZKHYSJE )]
        public virtual double? Zkhysje 
        {
            get { return this.zkhysje; }
			set	{ 
                  if(this.zkhysje != value)
                    {
                        this.OnPropertyChanging("Zkhysje"); 
                        this.zkhysje = value;                        
                        this.OnPropertyChanged("Zkhysje");
                    }   
                }
        }	
		
        ///收费人员
        ///[Column(COL_SFRY, PARAM_SFRY )]
        public virtual string Sfry 
        {
            get { return this.sfry; }
			set	{ 
                  if(this.sfry != value)
                    {
                        this.OnPropertyChanging("Sfry"); 
                        this.sfry = value;                        
                        this.OnPropertyChanged("Sfry");
                    }   
                }
        }	
		
        ///收费日期
        ///[Column(COL_SFRQ, PARAM_SFRQ )]
        public virtual System.DateTime? Sfrq 
        {
            get { return this.sfrq; }
			set	{ 
                  if(this.sfrq != value)
                    {
                        this.OnPropertyChanging("Sfrq"); 
                        this.sfrq = value;                        
                        this.OnPropertyChanged("Sfrq");
                    }   
                }
        }	
		
        ///付费方
        ///[Column(COL_FFF, PARAM_FFF )]
        public virtual string Fff 
        {
            get { return this.fff; }
			set	{ 
                  if(this.fff != value)
                    {
                        this.OnPropertyChanging("Fff"); 
                        this.fff = value;                        
                        this.OnPropertyChanged("Fff");
                    }   
                }
        }	
		
        ///实际付费人
        ///[Column(COL_SJFFR, PARAM_SJFFR )]
        public virtual string Sjffr 
        {
            get { return this.sjffr; }
			set	{ 
                  if(this.sjffr != value)
                    {
                        this.OnPropertyChanging("Sjffr"); 
                        this.sjffr = value;                        
                        this.OnPropertyChanged("Sjffr");
                    }   
                }
        }	
		
        ///实收金额
        ///[Column(COL_SSJE, PARAM_SSJE )]
        public virtual double? Ssje 
        {
            get { return this.ssje; }
			set	{ 
                  if(this.ssje != value)
                    {
                        this.OnPropertyChanging("Ssje"); 
                        this.ssje = value;                        
                        this.OnPropertyChanged("Ssje");
                    }   
                }
        }	
		
        ///收费单位
        ///[Column(COL_SFDW, PARAM_SFDW )]
        public virtual string Sfdw 
        {
            get { return this.sfdw; }
			set	{ 
                  if(this.sfdw != value)
                    {
                        this.OnPropertyChanging("Sfdw"); 
                        this.sfdw = value;                        
                        this.OnPropertyChanged("Sfdw");
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
        public Sf()
        {
            this.id=0;
            this.ywh="";
            this.ysdm="";
            this.jfry="";
            this.jfrq=DateTime.Now;
            this.sfkmmc="";
            this.sfewsf="";
            this.sfjs=0.0;
            this.sflx="";
            this.ysje=0.0;
            this.zkhysje=0.0;
            this.sfry="";
            this.sfrq=DateTime.Now;
            this.fff="";
            this.sjffr="";
            this.ssje=0.0;
            this.sfdw="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Sf record = obj as Sf;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_SF,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_JFRY, this.Jfry);
				command.Parameters.AddWithValue(PARAM_JFRQ, this.Jfrq);
				command.Parameters.AddWithValue(PARAM_SFKMMC, this.Sfkmmc);
				command.Parameters.AddWithValue(PARAM_SFEWSF, this.Sfewsf);
				command.Parameters.AddWithValue(PARAM_SFJS, this.Sfjs);
				command.Parameters.AddWithValue(PARAM_SFLX, this.Sflx);
				command.Parameters.AddWithValue(PARAM_YSJE, this.Ysje);
				command.Parameters.AddWithValue(PARAM_ZKHYSJE, this.Zkhysje);
				command.Parameters.AddWithValue(PARAM_SFRY, this.Sfry);
				command.Parameters.AddWithValue(PARAM_SFRQ, this.Sfrq);
				command.Parameters.AddWithValue(PARAM_FFF, this.Fff);
				command.Parameters.AddWithValue(PARAM_SJFFR, this.Sjffr);
				command.Parameters.AddWithValue(PARAM_SSJE, this.Ssje);
				command.Parameters.AddWithValue(PARAM_SFDW, this.Sfdw);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_SF,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_JFRY, this.Jfry);
				command.Parameters.AddWithValue(PARAM_JFRQ, this.Jfrq);
				command.Parameters.AddWithValue(PARAM_SFKMMC, this.Sfkmmc);
				command.Parameters.AddWithValue(PARAM_SFEWSF, this.Sfewsf);
				command.Parameters.AddWithValue(PARAM_SFJS, this.Sfjs);
				command.Parameters.AddWithValue(PARAM_SFLX, this.Sflx);
				command.Parameters.AddWithValue(PARAM_YSJE, this.Ysje);
				command.Parameters.AddWithValue(PARAM_ZKHYSJE, this.Zkhysje);
				command.Parameters.AddWithValue(PARAM_SFRY, this.Sfry);
				command.Parameters.AddWithValue(PARAM_SFRQ, this.Sfrq);
				command.Parameters.AddWithValue(PARAM_FFF, this.Fff);
				command.Parameters.AddWithValue(PARAM_SJFFR, this.Sjffr);
				command.Parameters.AddWithValue(PARAM_SSJE, this.Ssje);
				command.Parameters.AddWithValue(PARAM_SFDW, this.Sfdw);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_SF,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_SF,dao.Connection))
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
			if (!reader.IsDBNull(3)) jfry = reader.GetString(3);
			if (!reader.IsDBNull(4)) jfrq = reader.GetDateTime(4);
			if (!reader.IsDBNull(5)) sfkmmc = reader.GetString(5);
			if (!reader.IsDBNull(6)) sfewsf = reader.GetString(6);
			if (!reader.IsDBNull(7)) sfjs = reader.GetDouble(7);
			if (!reader.IsDBNull(8)) sflx = reader.GetString(8);
			if (!reader.IsDBNull(9)) ysje = reader.GetDouble(9);
			if (!reader.IsDBNull(10)) zkhysje = reader.GetDouble(10);
			if (!reader.IsDBNull(11)) sfry = reader.GetString(11);
			if (!reader.IsDBNull(12)) sfrq = reader.GetDateTime(12);
			if (!reader.IsDBNull(13)) fff = reader.GetString(13);
			if (!reader.IsDBNull(14)) sjffr = reader.GetString(14);
			if (!reader.IsDBNull(15)) ssje = reader.GetDouble(15);
			if (!reader.IsDBNull(16)) sfdw = reader.GetString(16);
			if (!reader.IsDBNull(17)) databaseid = reader.GetInt64(17);
			if (!reader.IsDBNull(18)) flags = reader.GetInt16(18);
			if (!reader.IsDBNull(19)) xgr = reader.GetString(19);
			if (!reader.IsDBNull(20)) xgsj = reader.GetDateTime(20);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Sf target=new Sf();
            target.ID=0;
            target.Ywh=this.Ywh;
            target.Ysdm=this.Ysdm;
            target.Jfry=this.Jfry;
            target.Jfrq=this.Jfrq;
            target.Sfkmmc=this.Sfkmmc;
            target.Sfewsf=this.Sfewsf;
            target.Sfjs=this.Sfjs;
            target.Sflx=this.Sflx;
            target.Ysje=this.Ysje;
            target.Zkhysje=this.Zkhysje;
            target.Sfry=this.Sfry;
            target.Sfrq=this.Sfrq;
            target.Fff=this.Fff;
            target.Sjffr=this.Sjffr;
            target.Ssje=this.Ssje;
            target.Sfdw=this.Sfdw;
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
