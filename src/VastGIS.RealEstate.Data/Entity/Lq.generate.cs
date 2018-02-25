
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
    public partial class Lq : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "LQ";	
        public const string LAYER_NAME = "林权";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_QLLX = "QLLX";
		public const string COL_DJLX = "DJLX";
		public const string COL_DJYY = "DJYY";
		public const string COL_FBF = "FBF";
		public const string COL_SYQMJ = "SYQMJ";
		public const string COL_LDSYQSSJ = "LDSYQSSJ";
		public const string COL_LDSYJSSJ = "LDSYJSSJ";
		public const string COL_LDSYQXZ = "LDSYQXZ";
		public const string COL_SLLMSYQR1 = "SLLMSYQR1";
		public const string COL_SLLMSYQR2 = "SLLMSYQR2";
		public const string COL_ZYSZ = "ZYSZ";
		public const string COL_ZS = "ZS";
		public const string COL_LZ = "LZ";
		public const string COL_QY = "QY";
		public const string COL_ZLND = "ZLND";
		public const string COL_LB = "LB";
		public const string COL_XB = "XB";
		public const string COL_XDM = "XDM";
		public const string COL_BDCQZH = "BDCQZH";
		public const string COL_QXDM = "QXDM";
		public const string COL_DJJG = "DJJG";
		public const string COL_DBR = "DBR";
		public const string COL_DJSJ = "DJSJ";
		public const string COL_FJ = "FJ";
		public const string COL_QSZT = "QSZT";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_QLLX = "@QLLX";	
        public const string PARAM_DJLX = "@DJLX";	
        public const string PARAM_DJYY = "@DJYY";	
        public const string PARAM_FBF = "@FBF";	
        public const string PARAM_SYQMJ = "@SYQMJ";	
        public const string PARAM_LDSYQSSJ = "@LDSYQSSJ";	
        public const string PARAM_LDSYJSSJ = "@LDSYJSSJ";	
        public const string PARAM_LDSYQXZ = "@LDSYQXZ";	
        public const string PARAM_SLLMSYQR1 = "@SLLMSYQR1";	
        public const string PARAM_SLLMSYQR2 = "@SLLMSYQR2";	
        public const string PARAM_ZYSZ = "@ZYSZ";	
        public const string PARAM_ZS = "@ZS";	
        public const string PARAM_LZ = "@LZ";	
        public const string PARAM_QY = "@QY";	
        public const string PARAM_ZLND = "@ZLND";	
        public const string PARAM_LB = "@LB";	
        public const string PARAM_XB = "@XB";	
        public const string PARAM_XDM = "@XDM";	
        public const string PARAM_BDCQZH = "@BDCQZH";	
        public const string PARAM_QXDM = "@QXDM";	
        public const string PARAM_DJJG = "@DJJG";	
        public const string PARAM_DBR = "@DBR";	
        public const string PARAM_DJSJ = "@DJSJ";	
        public const string PARAM_FJ = "@FJ";	
        public const string PARAM_QSZT = "@QSZT";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_LQ ="SELECT  Id,YSDM,BDCDYH,YWH,QLLX,DJLX,DJYY,FBF,SYQMJ,LDSYQSSJ,LDSYJSSJ,LDSYQXZ,SLLMSYQR1,SLLMSYQR2,ZYSZ,ZS,LZ,QY,ZLND,LB,XB,XDM,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM LQ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_LQ = "INSERT INTO [LQ] (YSDM, BDCDYH, YWH, QLLX, DJLX, DJYY, FBF, SYQMJ, LDSYQSSJ, LDSYJSSJ, LDSYQXZ, SLLMSYQR1, SLLMSYQR2, ZYSZ, ZS, LZ, QY, ZLND, LB, XB, XDM, BDCQZH, QXDM, DJJG, DBR, DJSJ, FJ, QSZT, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @BDCDYH, @YWH, @QLLX, @DJLX, @DJYY, @FBF, @SYQMJ, @LDSYQSSJ, @LDSYJSSJ, @LDSYQXZ, @SLLMSYQR1, @SLLMSYQR2, @ZYSZ, @ZS, @LZ, @QY, @ZLND, @LB, @XB, @XDM, @BDCQZH, @QXDM, @DJJG, @DBR, @DJSJ, @FJ, @QSZT, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_LQ = "UPDATE [LQ] SET YSDM = @YSDM, BDCDYH = @BDCDYH, YWH = @YWH, QLLX = @QLLX, DJLX = @DJLX, DJYY = @DJYY, FBF = @FBF, SYQMJ = @SYQMJ, LDSYQSSJ = @LDSYQSSJ, LDSYJSSJ = @LDSYJSSJ, LDSYQXZ = @LDSYQXZ, SLLMSYQR1 = @SLLMSYQR1, SLLMSYQR2 = @SLLMSYQR2, ZYSZ = @ZYSZ, ZS = @ZS, LZ = @LZ, QY = @QY, ZLND = @ZLND, LB = @LB, XB = @XB, XDM = @XDM, BDCQZH = @BDCQZH, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, FJ = @FJ, QSZT = @QSZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_LQ = "DELETE FROM [LQ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_LQ = "UPDATE [LQ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///不动产单元号
		protected string bdcdyh = default(string);
        ///业务号
		protected string ywh = default(string);
        ///权利类型[字典:权利类型字典表-QLLXZD]
		protected string qllx = default(string);
        ///登记类型[字典:登记类型字典表-DJLXZD]
		protected string djlx = default(string);
        ///登记原因
		protected string djyy = default(string);
        ///发包方
		protected string fbf = default(string);
        ///使用权（承包）面积
		protected double? syqmj = default(double?);
        ///林地使用（承包）起始时间
		protected System.DateTime? ldsyqssj = default(System.DateTime?);
        ///林地使用（承包）结束时间
		protected System.DateTime? ldsyjssj = default(System.DateTime?);
        ///林地所有权性质[字典:土地所有权性质字典表-TDSYQXZZD]
		protected string ldsyqxz = default(string);
        ///森林、林木所有权人
		protected string sllmsyqr1 = default(string);
        ///森林、林木使用权人
		protected string sllmsyqr2 = default(string);
        ///主要树种
		protected string zysz = default(string);
        ///株数
		protected long? zs = default(long?);
        ///林种[字典:林种字典表-LZZD]
		protected string lz = default(string);
        ///起源[字典:起源字典表-QYZD]
		protected string qy = default(string);
        ///造林年度
		protected long? zlnd = default(long?);
        ///林班
		protected string lb = default(string);
        ///小班
		protected string xb = default(string);
        ///小地名
		protected string xdm = default(string);
        ///不动产权证号
		protected string bdcqzh = default(string);
        ///区县代码[字典:区县字典表-VG_AREACODES]
		protected string qxdm = default(string);
        ///登记机构
		protected string djjg = default(string);
        ///登簿人
		protected string dbr = default(string);
        ///登记时间
		protected System.DateTime? djsj = default(System.DateTime?);
        ///附记
		protected string fj = default(string);
        ///权属状态[字典:权属状态字典表-QSZTZD]
		protected string qszt = default(string);
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
            get{return "Lq";}
        }
         public string LayerName
        {
            get{return "林权";}
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
                return string.Format("{0} {1} ({2})","LQ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","林权",this.id,this.ysdm);
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
		
        ///不动产单元号
        ///[Column(COL_BDCDYH, PARAM_BDCDYH )]
        public virtual string Bdcdyh 
        {
            get { return this.bdcdyh; }
			set	{ 
                  if(this.bdcdyh != value)
                    {
                        this.OnPropertyChanging("Bdcdyh"); 
                        this.bdcdyh = value;                        
                        this.OnPropertyChanged("Bdcdyh");
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
		
        ///权利类型
        ///[Column(COL_QLLX, PARAM_QLLX )]
        public virtual string Qllx 
        {
            get { return this.qllx; }
			set	{ 
                  if(this.qllx != value)
                    {
                        this.OnPropertyChanging("Qllx"); 
                        this.qllx = value;                        
                        this.OnPropertyChanged("Qllx");
                    }   
                }
        }	
		
        ///登记类型
        ///[Column(COL_DJLX, PARAM_DJLX )]
        public virtual string Djlx 
        {
            get { return this.djlx; }
			set	{ 
                  if(this.djlx != value)
                    {
                        this.OnPropertyChanging("Djlx"); 
                        this.djlx = value;                        
                        this.OnPropertyChanged("Djlx");
                    }   
                }
        }	
		
        ///登记原因
        ///[Column(COL_DJYY, PARAM_DJYY )]
        public virtual string Djyy 
        {
            get { return this.djyy; }
			set	{ 
                  if(this.djyy != value)
                    {
                        this.OnPropertyChanging("Djyy"); 
                        this.djyy = value;                        
                        this.OnPropertyChanged("Djyy");
                    }   
                }
        }	
		
        ///发包方
        ///[Column(COL_FBF, PARAM_FBF )]
        public virtual string Fbf 
        {
            get { return this.fbf; }
			set	{ 
                  if(this.fbf != value)
                    {
                        this.OnPropertyChanging("Fbf"); 
                        this.fbf = value;                        
                        this.OnPropertyChanged("Fbf");
                    }   
                }
        }	
		
        ///使用权（承包）面积
        ///[Column(COL_SYQMJ, PARAM_SYQMJ )]
        public virtual double? Syqmj 
        {
            get { return this.syqmj; }
			set	{ 
                  if(this.syqmj != value)
                    {
                        this.OnPropertyChanging("Syqmj"); 
                        this.syqmj = value;                        
                        this.OnPropertyChanged("Syqmj");
                    }   
                }
        }	
		
        ///林地使用（承包）起始时间
        ///[Column(COL_LDSYQSSJ, PARAM_LDSYQSSJ )]
        public virtual System.DateTime? Ldsyqssj 
        {
            get { return this.ldsyqssj; }
			set	{ 
                  if(this.ldsyqssj != value)
                    {
                        this.OnPropertyChanging("Ldsyqssj"); 
                        this.ldsyqssj = value;                        
                        this.OnPropertyChanged("Ldsyqssj");
                    }   
                }
        }	
		
        ///林地使用（承包）结束时间
        ///[Column(COL_LDSYJSSJ, PARAM_LDSYJSSJ )]
        public virtual System.DateTime? Ldsyjssj 
        {
            get { return this.ldsyjssj; }
			set	{ 
                  if(this.ldsyjssj != value)
                    {
                        this.OnPropertyChanging("Ldsyjssj"); 
                        this.ldsyjssj = value;                        
                        this.OnPropertyChanged("Ldsyjssj");
                    }   
                }
        }	
		
        ///林地所有权性质
        ///[Column(COL_LDSYQXZ, PARAM_LDSYQXZ )]
        public virtual string Ldsyqxz 
        {
            get { return this.ldsyqxz; }
			set	{ 
                  if(this.ldsyqxz != value)
                    {
                        this.OnPropertyChanging("Ldsyqxz"); 
                        this.ldsyqxz = value;                        
                        this.OnPropertyChanged("Ldsyqxz");
                    }   
                }
        }	
		
        ///森林、林木所有权人
        ///[Column(COL_SLLMSYQR1, PARAM_SLLMSYQR1 )]
        public virtual string Sllmsyqr1 
        {
            get { return this.sllmsyqr1; }
			set	{ 
                  if(this.sllmsyqr1 != value)
                    {
                        this.OnPropertyChanging("Sllmsyqr1"); 
                        this.sllmsyqr1 = value;                        
                        this.OnPropertyChanged("Sllmsyqr1");
                    }   
                }
        }	
		
        ///森林、林木使用权人
        ///[Column(COL_SLLMSYQR2, PARAM_SLLMSYQR2 )]
        public virtual string Sllmsyqr2 
        {
            get { return this.sllmsyqr2; }
			set	{ 
                  if(this.sllmsyqr2 != value)
                    {
                        this.OnPropertyChanging("Sllmsyqr2"); 
                        this.sllmsyqr2 = value;                        
                        this.OnPropertyChanged("Sllmsyqr2");
                    }   
                }
        }	
		
        ///主要树种
        ///[Column(COL_ZYSZ, PARAM_ZYSZ )]
        public virtual string Zysz 
        {
            get { return this.zysz; }
			set	{ 
                  if(this.zysz != value)
                    {
                        this.OnPropertyChanging("Zysz"); 
                        this.zysz = value;                        
                        this.OnPropertyChanged("Zysz");
                    }   
                }
        }	
		
        ///株数
        ///[Column(COL_ZS, PARAM_ZS )]
        public virtual long? Zs 
        {
            get { return this.zs; }
			set	{ 
                  if(this.zs != value)
                    {
                        this.OnPropertyChanging("Zs"); 
                        this.zs = value;                        
                        this.OnPropertyChanged("Zs");
                    }   
                }
        }	
		
        ///林种
        ///[Column(COL_LZ, PARAM_LZ )]
        public virtual string Lz 
        {
            get { return this.lz; }
			set	{ 
                  if(this.lz != value)
                    {
                        this.OnPropertyChanging("Lz"); 
                        this.lz = value;                        
                        this.OnPropertyChanged("Lz");
                    }   
                }
        }	
		
        ///起源
        ///[Column(COL_QY, PARAM_QY )]
        public virtual string Qy 
        {
            get { return this.qy; }
			set	{ 
                  if(this.qy != value)
                    {
                        this.OnPropertyChanging("Qy"); 
                        this.qy = value;                        
                        this.OnPropertyChanged("Qy");
                    }   
                }
        }	
		
        ///造林年度
        ///[Column(COL_ZLND, PARAM_ZLND )]
        public virtual long? Zlnd 
        {
            get { return this.zlnd; }
			set	{ 
                  if(this.zlnd != value)
                    {
                        this.OnPropertyChanging("Zlnd"); 
                        this.zlnd = value;                        
                        this.OnPropertyChanged("Zlnd");
                    }   
                }
        }	
		
        ///林班
        ///[Column(COL_LB, PARAM_LB )]
        public virtual string Lb 
        {
            get { return this.lb; }
			set	{ 
                  if(this.lb != value)
                    {
                        this.OnPropertyChanging("Lb"); 
                        this.lb = value;                        
                        this.OnPropertyChanged("Lb");
                    }   
                }
        }	
		
        ///小班
        ///[Column(COL_XB, PARAM_XB )]
        public virtual string Xb 
        {
            get { return this.xb; }
			set	{ 
                  if(this.xb != value)
                    {
                        this.OnPropertyChanging("Xb"); 
                        this.xb = value;                        
                        this.OnPropertyChanged("Xb");
                    }   
                }
        }	
		
        ///小地名
        ///[Column(COL_XDM, PARAM_XDM )]
        public virtual string Xdm 
        {
            get { return this.xdm; }
			set	{ 
                  if(this.xdm != value)
                    {
                        this.OnPropertyChanging("Xdm"); 
                        this.xdm = value;                        
                        this.OnPropertyChanged("Xdm");
                    }   
                }
        }	
		
        ///不动产权证号
        ///[Column(COL_BDCQZH, PARAM_BDCQZH )]
        public virtual string Bdcqzh 
        {
            get { return this.bdcqzh; }
			set	{ 
                  if(this.bdcqzh != value)
                    {
                        this.OnPropertyChanging("Bdcqzh"); 
                        this.bdcqzh = value;                        
                        this.OnPropertyChanged("Bdcqzh");
                    }   
                }
        }	
		
        ///区县代码
        ///[Column(COL_QXDM, PARAM_QXDM )]
        public virtual string Qxdm 
        {
            get { return this.qxdm; }
			set	{ 
                  if(this.qxdm != value)
                    {
                        this.OnPropertyChanging("Qxdm"); 
                        this.qxdm = value;                        
                        this.OnPropertyChanged("Qxdm");
                    }   
                }
        }	
		
        ///登记机构
        ///[Column(COL_DJJG, PARAM_DJJG )]
        public virtual string Djjg 
        {
            get { return this.djjg; }
			set	{ 
                  if(this.djjg != value)
                    {
                        this.OnPropertyChanging("Djjg"); 
                        this.djjg = value;                        
                        this.OnPropertyChanged("Djjg");
                    }   
                }
        }	
		
        ///登簿人
        ///[Column(COL_DBR, PARAM_DBR )]
        public virtual string Dbr 
        {
            get { return this.dbr; }
			set	{ 
                  if(this.dbr != value)
                    {
                        this.OnPropertyChanging("Dbr"); 
                        this.dbr = value;                        
                        this.OnPropertyChanged("Dbr");
                    }   
                }
        }	
		
        ///登记时间
        ///[Column(COL_DJSJ, PARAM_DJSJ )]
        public virtual System.DateTime? Djsj 
        {
            get { return this.djsj; }
			set	{ 
                  if(this.djsj != value)
                    {
                        this.OnPropertyChanging("Djsj"); 
                        this.djsj = value;                        
                        this.OnPropertyChanged("Djsj");
                    }   
                }
        }	
		
        ///附记
        ///[Column(COL_FJ, PARAM_FJ )]
        public virtual string Fj 
        {
            get { return this.fj; }
			set	{ 
                  if(this.fj != value)
                    {
                        this.OnPropertyChanging("Fj"); 
                        this.fj = value;                        
                        this.OnPropertyChanged("Fj");
                    }   
                }
        }	
		
        ///权属状态
        ///[Column(COL_QSZT, PARAM_QSZT )]
        public virtual string Qszt 
        {
            get { return this.qszt; }
			set	{ 
                  if(this.qszt != value)
                    {
                        this.OnPropertyChanging("Qszt"); 
                        this.qszt = value;                        
                        this.OnPropertyChanged("Qszt");
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
        public Lq()
        {
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.ywh="";
            this.qllx="";
            this.djlx="";
            this.djyy="";
            this.fbf="";
            this.syqmj=0.0;
            this.ldsyqssj=DateTime.Now;
            this.ldsyjssj=DateTime.Now;
            this.ldsyqxz="";
            this.sllmsyqr1="";
            this.sllmsyqr2="";
            this.zysz="";
            this.zs=0;
            this.lz="";
            this.qy="";
            this.zlnd=0;
            this.lb="";
            this.xb="";
            this.xdm="";
            this.bdcqzh="";
            this.qxdm="";
            this.djjg="";
            this.dbr="";
            this.djsj=DateTime.Now;
            this.fj="";
            this.qszt="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Lq record = obj as Lq;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_LQ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_FBF, this.Fbf);
				command.Parameters.AddWithValue(PARAM_SYQMJ, this.Syqmj);
				command.Parameters.AddWithValue(PARAM_LDSYQSSJ, this.Ldsyqssj);
				command.Parameters.AddWithValue(PARAM_LDSYJSSJ, this.Ldsyjssj);
				command.Parameters.AddWithValue(PARAM_LDSYQXZ, this.Ldsyqxz);
				command.Parameters.AddWithValue(PARAM_SLLMSYQR1, this.Sllmsyqr1);
				command.Parameters.AddWithValue(PARAM_SLLMSYQR2, this.Sllmsyqr2);
				command.Parameters.AddWithValue(PARAM_ZYSZ, this.Zysz);
				command.Parameters.AddWithValue(PARAM_ZS, this.Zs);
				command.Parameters.AddWithValue(PARAM_LZ, this.Lz);
				command.Parameters.AddWithValue(PARAM_QY, this.Qy);
				command.Parameters.AddWithValue(PARAM_ZLND, this.Zlnd);
				command.Parameters.AddWithValue(PARAM_LB, this.Lb);
				command.Parameters.AddWithValue(PARAM_XB, this.Xb);
				command.Parameters.AddWithValue(PARAM_XDM, this.Xdm);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_FJ, this.Fj);
				command.Parameters.AddWithValue(PARAM_QSZT, this.Qszt);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_LQ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_FBF, this.Fbf);
				command.Parameters.AddWithValue(PARAM_SYQMJ, this.Syqmj);
				command.Parameters.AddWithValue(PARAM_LDSYQSSJ, this.Ldsyqssj);
				command.Parameters.AddWithValue(PARAM_LDSYJSSJ, this.Ldsyjssj);
				command.Parameters.AddWithValue(PARAM_LDSYQXZ, this.Ldsyqxz);
				command.Parameters.AddWithValue(PARAM_SLLMSYQR1, this.Sllmsyqr1);
				command.Parameters.AddWithValue(PARAM_SLLMSYQR2, this.Sllmsyqr2);
				command.Parameters.AddWithValue(PARAM_ZYSZ, this.Zysz);
				command.Parameters.AddWithValue(PARAM_ZS, this.Zs);
				command.Parameters.AddWithValue(PARAM_LZ, this.Lz);
				command.Parameters.AddWithValue(PARAM_QY, this.Qy);
				command.Parameters.AddWithValue(PARAM_ZLND, this.Zlnd);
				command.Parameters.AddWithValue(PARAM_LB, this.Lb);
				command.Parameters.AddWithValue(PARAM_XB, this.Xb);
				command.Parameters.AddWithValue(PARAM_XDM, this.Xdm);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_FJ, this.Fj);
				command.Parameters.AddWithValue(PARAM_QSZT, this.Qszt);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_LQ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_LQ,dao.Connection))
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
			if (!reader.IsDBNull(1)) ysdm = reader.GetString(1);
			if (!reader.IsDBNull(2)) bdcdyh = reader.GetString(2);
			if (!reader.IsDBNull(3)) ywh = reader.GetString(3);
			if (!reader.IsDBNull(4)) qllx = reader.GetString(4);
			if (!reader.IsDBNull(5)) djlx = reader.GetString(5);
			if (!reader.IsDBNull(6)) djyy = reader.GetString(6);
			if (!reader.IsDBNull(7)) fbf = reader.GetString(7);
			if (!reader.IsDBNull(8)) syqmj = reader.GetDouble(8);
			if (!reader.IsDBNull(9)) ldsyqssj = reader.GetDateTime(9);
			if (!reader.IsDBNull(10)) ldsyjssj = reader.GetDateTime(10);
			if (!reader.IsDBNull(11)) ldsyqxz = reader.GetString(11);
			if (!reader.IsDBNull(12)) sllmsyqr1 = reader.GetString(12);
			if (!reader.IsDBNull(13)) sllmsyqr2 = reader.GetString(13);
			if (!reader.IsDBNull(14)) zysz = reader.GetString(14);
			if (!reader.IsDBNull(15)) zs = reader.GetInt64(15);
			if (!reader.IsDBNull(16)) lz = reader.GetString(16);
			if (!reader.IsDBNull(17)) qy = reader.GetString(17);
			if (!reader.IsDBNull(18)) zlnd = reader.GetInt64(18);
			if (!reader.IsDBNull(19)) lb = reader.GetString(19);
			if (!reader.IsDBNull(20)) xb = reader.GetString(20);
			if (!reader.IsDBNull(21)) xdm = reader.GetString(21);
			if (!reader.IsDBNull(22)) bdcqzh = reader.GetString(22);
			if (!reader.IsDBNull(23)) qxdm = reader.GetString(23);
			if (!reader.IsDBNull(24)) djjg = reader.GetString(24);
			if (!reader.IsDBNull(25)) dbr = reader.GetString(25);
			if (!reader.IsDBNull(26)) djsj = reader.GetDateTime(26);
			if (!reader.IsDBNull(27)) fj = reader.GetString(27);
			if (!reader.IsDBNull(28)) qszt = reader.GetString(28);
			if (!reader.IsDBNull(29)) databaseid = reader.GetInt64(29);
			if (!reader.IsDBNull(30)) flags = reader.GetInt16(30);
			if (!reader.IsDBNull(31)) xgr = reader.GetString(31);
			if (!reader.IsDBNull(32)) xgsj = reader.GetDateTime(32);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Lq target=new Lq();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Qllx=this.Qllx;
            target.Djlx=this.Djlx;
            target.Djyy=this.Djyy;
            target.Fbf=this.Fbf;
            target.Syqmj=this.Syqmj;
            target.Ldsyqssj=this.Ldsyqssj;
            target.Ldsyjssj=this.Ldsyjssj;
            target.Ldsyqxz=this.Ldsyqxz;
            target.Sllmsyqr1=this.Sllmsyqr1;
            target.Sllmsyqr2=this.Sllmsyqr2;
            target.Zysz=this.Zysz;
            target.Zs=this.Zs;
            target.Lz=this.Lz;
            target.Qy=this.Qy;
            target.Zlnd=this.Zlnd;
            target.Lb=this.Lb;
            target.Xb=this.Xb;
            target.Xdm=this.Xdm;
            target.Bdcqzh=this.Bdcqzh;
            target.Qxdm=this.Qxdm;
            target.Djjg=this.Djjg;
            target.Dbr=this.Dbr;
            target.Djsj=this.Djsj;
            target.Fj=this.Fj;
            target.Qszt=this.Qszt;
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
