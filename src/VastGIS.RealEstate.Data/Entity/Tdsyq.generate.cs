
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
    public partial class Tdsyq : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity,IGlobalEntity,ISurveyEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "TDSYQ";	
        public const string LAYER_NAME = "土地所有权";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_ZDDM = "ZDDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_QLLX = "QLLX";
		public const string COL_DJLX = "DJLX";
		public const string COL_DJYY = "DJYY";
		public const string COL_MJDW = "MJDW";
		public const string COL_NYDMJ = "NYDMJ";
		public const string COL_GDMJ = "GDMJ";
		public const string COL_LDMJ = "LDMJ";
		public const string COL_CDMJ = "CDMJ";
		public const string COL_QTNYDMJ = "QTNYDMJ";
		public const string COL_JSYDMJ = "JSYDMJ";
		public const string COL_WLYDMJ = "WLYDMJ";
		public const string COL_BDCQZH = "BDCQZH";
		public const string COL_QXDM = "QXDM";
		public const string COL_DJJG = "DJJG";
		public const string COL_DBR = "DBR";
		public const string COL_DJSJ = "DJSJ";
		public const string COL_FJ = "FJ";
		public const string COL_QSZT = "QSZT";
		public const string COL_WX_DCY = "WX_DCY";
		public const string COL_WX_DCSJ = "WX_DCSJ";
		public const string COL_WX_CLY = "WX_CLY";
		public const string COL_WX_CLSJ = "WX_CLSJ";
		public const string COL_WX_ZTY = "WX_ZTY";
		public const string COL_WX_ZTSJ = "WX_ZTSJ";
		public const string COL_WX_ZJY = "WX_ZJY";
		public const string COL_WX_ZJSJ = "WX_ZJSJ";
		public const string COL_WX_WYDM = "WX_WYDM";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_ZDDM = "@ZDDM";	
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_QLLX = "@QLLX";	
        public const string PARAM_DJLX = "@DJLX";	
        public const string PARAM_DJYY = "@DJYY";	
        public const string PARAM_MJDW = "@MJDW";	
        public const string PARAM_NYDMJ = "@NYDMJ";	
        public const string PARAM_GDMJ = "@GDMJ";	
        public const string PARAM_LDMJ = "@LDMJ";	
        public const string PARAM_CDMJ = "@CDMJ";	
        public const string PARAM_QTNYDMJ = "@QTNYDMJ";	
        public const string PARAM_JSYDMJ = "@JSYDMJ";	
        public const string PARAM_WLYDMJ = "@WLYDMJ";	
        public const string PARAM_BDCQZH = "@BDCQZH";	
        public const string PARAM_QXDM = "@QXDM";	
        public const string PARAM_DJJG = "@DJJG";	
        public const string PARAM_DBR = "@DBR";	
        public const string PARAM_DJSJ = "@DJSJ";	
        public const string PARAM_FJ = "@FJ";	
        public const string PARAM_QSZT = "@QSZT";	
        public const string PARAM_WX_DCY = "@WX_DCY";	
        public const string PARAM_WX_DCSJ = "@WX_DCSJ";	
        public const string PARAM_WX_CLY = "@WX_CLY";	
        public const string PARAM_WX_CLSJ = "@WX_CLSJ";	
        public const string PARAM_WX_ZTY = "@WX_ZTY";	
        public const string PARAM_WX_ZTSJ = "@WX_ZTSJ";	
        public const string PARAM_WX_ZJY = "@WX_ZJY";	
        public const string PARAM_WX_ZJSJ = "@WX_ZJSJ";	
        public const string PARAM_WX_WYDM = "@WX_WYDM";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_TDSYQ ="SELECT  Id,YSDM,ZDDM,BDCDYH,YWH,QLLX,DJLX,DJYY,MJDW,NYDMJ,GDMJ,LDMJ,CDMJ,QTNYDMJ,JSYDMJ,WLYDMJ,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM TDSYQ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_TDSYQ = "INSERT INTO [TDSYQ] (YSDM, ZDDM, BDCDYH, YWH, QLLX, DJLX, DJYY, MJDW, NYDMJ, GDMJ, LDMJ, CDMJ, QTNYDMJ, JSYDMJ, WLYDMJ, BDCQZH, QXDM, DJJG, DBR, DJSJ, FJ, QSZT, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @ZDDM, @BDCDYH, @YWH, @QLLX, @DJLX, @DJYY, @MJDW, @NYDMJ, @GDMJ, @LDMJ, @CDMJ, @QTNYDMJ, @JSYDMJ, @WLYDMJ, @BDCQZH, @QXDM, @DJJG, @DBR, @DJSJ, @FJ, @QSZT, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_TDSYQ = "UPDATE [TDSYQ] SET YSDM = @YSDM, ZDDM = @ZDDM, BDCDYH = @BDCDYH, YWH = @YWH, QLLX = @QLLX, DJLX = @DJLX, DJYY = @DJYY, MJDW = @MJDW, NYDMJ = @NYDMJ, GDMJ = @GDMJ, LDMJ = @LDMJ, CDMJ = @CDMJ, QTNYDMJ = @QTNYDMJ, JSYDMJ = @JSYDMJ, WLYDMJ = @WLYDMJ, BDCQZH = @BDCQZH, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, FJ = @FJ, QSZT = @QSZT, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_TDSYQ = "DELETE FROM [TDSYQ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_TDSYQ = "UPDATE [TDSYQ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///宗地代码
		protected string zddm = default(string);
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
        ///面积单位[字典:面积单位字典表-MJDWZD]
		protected string mjdw = default(string);
        ///农用地面积
		protected double? nydmj = default(double?);
        ///耕地面积
		protected double? gdmj = default(double?);
        ///林地面积
		protected double? ldmj = default(double?);
        ///草地面积
		protected double? cdmj = default(double?);
        ///其它农用地面积
		protected double? qtnydmj = default(double?);
        ///建设用地面积
		protected double? jsydmj = default(double?);
        ///未利用地面积
		protected double? wlydmj = default(double?);
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
        ///调查员
		protected string wxDcy = default(string);
        ///调查时间
		protected System.DateTime? wxDcsj = default(System.DateTime?);
        ///测量员
		protected string wxCly = default(string);
        ///测量时间
		protected System.DateTime? wxClsj = default(System.DateTime?);
        ///制图员
		protected string wxZty = default(string);
        ///制图时间
		protected System.DateTime? wxZtsj = default(System.DateTime?);
        ///质检员
		protected string wxZjy = default(string);
        ///质检时间
		protected System.DateTime? wxZjsj = default(System.DateTime?);
        ///全局唯一代码
		protected string wxWydm = default(string);
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
            get{return "Tdsyq";}
        }
         public string LayerName
        {
            get{return "土地所有权";}
        }
        public string EntityName{
            get{return "IDatabaseEntity,IYsdmEntity,IGlobalEntity,ISurveyEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return true;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return true;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","TDSYQ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","土地所有权",this.id,this.ysdm);
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
		
        ///宗地代码
        ///[Column(COL_ZDDM, PARAM_ZDDM )]
        public virtual string Zddm 
        {
            get { return this.zddm; }
			set	{ 
                  if(this.zddm != value)
                    {
                        this.OnPropertyChanging("Zddm"); 
                        this.zddm = value;                        
                        this.OnPropertyChanged("Zddm");
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
		
        ///面积单位
        ///[Column(COL_MJDW, PARAM_MJDW )]
        public virtual string Mjdw 
        {
            get { return this.mjdw; }
			set	{ 
                  if(this.mjdw != value)
                    {
                        this.OnPropertyChanging("Mjdw"); 
                        this.mjdw = value;                        
                        this.OnPropertyChanged("Mjdw");
                    }   
                }
        }	
		
        ///农用地面积
        ///[Column(COL_NYDMJ, PARAM_NYDMJ )]
        public virtual double? Nydmj 
        {
            get { return this.nydmj; }
			set	{ 
                  if(this.nydmj != value)
                    {
                        this.OnPropertyChanging("Nydmj"); 
                        this.nydmj = value;                        
                        this.OnPropertyChanged("Nydmj");
                    }   
                }
        }	
		
        ///耕地面积
        ///[Column(COL_GDMJ, PARAM_GDMJ )]
        public virtual double? Gdmj 
        {
            get { return this.gdmj; }
			set	{ 
                  if(this.gdmj != value)
                    {
                        this.OnPropertyChanging("Gdmj"); 
                        this.gdmj = value;                        
                        this.OnPropertyChanged("Gdmj");
                    }   
                }
        }	
		
        ///林地面积
        ///[Column(COL_LDMJ, PARAM_LDMJ )]
        public virtual double? Ldmj 
        {
            get { return this.ldmj; }
			set	{ 
                  if(this.ldmj != value)
                    {
                        this.OnPropertyChanging("Ldmj"); 
                        this.ldmj = value;                        
                        this.OnPropertyChanged("Ldmj");
                    }   
                }
        }	
		
        ///草地面积
        ///[Column(COL_CDMJ, PARAM_CDMJ )]
        public virtual double? Cdmj 
        {
            get { return this.cdmj; }
			set	{ 
                  if(this.cdmj != value)
                    {
                        this.OnPropertyChanging("Cdmj"); 
                        this.cdmj = value;                        
                        this.OnPropertyChanged("Cdmj");
                    }   
                }
        }	
		
        ///其它农用地面积
        ///[Column(COL_QTNYDMJ, PARAM_QTNYDMJ )]
        public virtual double? Qtnydmj 
        {
            get { return this.qtnydmj; }
			set	{ 
                  if(this.qtnydmj != value)
                    {
                        this.OnPropertyChanging("Qtnydmj"); 
                        this.qtnydmj = value;                        
                        this.OnPropertyChanged("Qtnydmj");
                    }   
                }
        }	
		
        ///建设用地面积
        ///[Column(COL_JSYDMJ, PARAM_JSYDMJ )]
        public virtual double? Jsydmj 
        {
            get { return this.jsydmj; }
			set	{ 
                  if(this.jsydmj != value)
                    {
                        this.OnPropertyChanging("Jsydmj"); 
                        this.jsydmj = value;                        
                        this.OnPropertyChanged("Jsydmj");
                    }   
                }
        }	
		
        ///未利用地面积
        ///[Column(COL_WLYDMJ, PARAM_WLYDMJ )]
        public virtual double? Wlydmj 
        {
            get { return this.wlydmj; }
			set	{ 
                  if(this.wlydmj != value)
                    {
                        this.OnPropertyChanging("Wlydmj"); 
                        this.wlydmj = value;                        
                        this.OnPropertyChanged("Wlydmj");
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
		
        ///调查员
        ///[Column(COL_WX_DCY, PARAM_WX_DCY )]
        public virtual string WxDcy 
        {
            get { return this.wxDcy; }
			set	{ 
                  if(this.wxDcy != value)
                    {
                        this.OnPropertyChanging("WxDcy"); 
                        this.wxDcy = value;                        
                        this.OnPropertyChanged("WxDcy");
                    }   
                }
        }	
		
        ///调查时间
        ///[Column(COL_WX_DCSJ, PARAM_WX_DCSJ )]
        public virtual System.DateTime? WxDcsj 
        {
            get { return this.wxDcsj; }
			set	{ 
                  if(this.wxDcsj != value)
                    {
                        this.OnPropertyChanging("WxDcsj"); 
                        this.wxDcsj = value;                        
                        this.OnPropertyChanged("WxDcsj");
                    }   
                }
        }	
		
        ///测量员
        ///[Column(COL_WX_CLY, PARAM_WX_CLY )]
        public virtual string WxCly 
        {
            get { return this.wxCly; }
			set	{ 
                  if(this.wxCly != value)
                    {
                        this.OnPropertyChanging("WxCly"); 
                        this.wxCly = value;                        
                        this.OnPropertyChanged("WxCly");
                    }   
                }
        }	
		
        ///测量时间
        ///[Column(COL_WX_CLSJ, PARAM_WX_CLSJ )]
        public virtual System.DateTime? WxClsj 
        {
            get { return this.wxClsj; }
			set	{ 
                  if(this.wxClsj != value)
                    {
                        this.OnPropertyChanging("WxClsj"); 
                        this.wxClsj = value;                        
                        this.OnPropertyChanged("WxClsj");
                    }   
                }
        }	
		
        ///制图员
        ///[Column(COL_WX_ZTY, PARAM_WX_ZTY )]
        public virtual string WxZty 
        {
            get { return this.wxZty; }
			set	{ 
                  if(this.wxZty != value)
                    {
                        this.OnPropertyChanging("WxZty"); 
                        this.wxZty = value;                        
                        this.OnPropertyChanged("WxZty");
                    }   
                }
        }	
		
        ///制图时间
        ///[Column(COL_WX_ZTSJ, PARAM_WX_ZTSJ )]
        public virtual System.DateTime? WxZtsj 
        {
            get { return this.wxZtsj; }
			set	{ 
                  if(this.wxZtsj != value)
                    {
                        this.OnPropertyChanging("WxZtsj"); 
                        this.wxZtsj = value;                        
                        this.OnPropertyChanged("WxZtsj");
                    }   
                }
        }	
		
        ///质检员
        ///[Column(COL_WX_ZJY, PARAM_WX_ZJY )]
        public virtual string WxZjy 
        {
            get { return this.wxZjy; }
			set	{ 
                  if(this.wxZjy != value)
                    {
                        this.OnPropertyChanging("WxZjy"); 
                        this.wxZjy = value;                        
                        this.OnPropertyChanged("WxZjy");
                    }   
                }
        }	
		
        ///质检时间
        ///[Column(COL_WX_ZJSJ, PARAM_WX_ZJSJ )]
        public virtual System.DateTime? WxZjsj 
        {
            get { return this.wxZjsj; }
			set	{ 
                  if(this.wxZjsj != value)
                    {
                        this.OnPropertyChanging("WxZjsj"); 
                        this.wxZjsj = value;                        
                        this.OnPropertyChanged("WxZjsj");
                    }   
                }
        }	
		
        ///全局唯一代码
        ///[Column(COL_WX_WYDM, PARAM_WX_WYDM )]
        public virtual string WxWydm 
        {
            get { return this.wxWydm; }
			set	{ 
                  if(this.wxWydm != value)
                    {
                        this.OnPropertyChanging("WxWydm"); 
                        this.wxWydm = value;                        
                        this.OnPropertyChanged("WxWydm");
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
        public Tdsyq()
        {
            this.id=0;
            this.ysdm="";
            this.zddm="";
            this.bdcdyh="";
            this.ywh="";
            this.qllx="";
            this.djlx="";
            this.djyy="";
            this.mjdw="";
            this.nydmj=0.0;
            this.gdmj=0.0;
            this.ldmj=0.0;
            this.cdmj=0.0;
            this.qtnydmj=0.0;
            this.jsydmj=0.0;
            this.wlydmj=0.0;
            this.bdcqzh="";
            this.qxdm="";
            this.djjg="";
            this.dbr="";
            this.djsj=DateTime.Now;
            this.fj="";
            this.qszt="";
            this.wxDcy="";
            this.wxDcsj=DateTime.Now;
            this.wxCly="";
            this.wxClsj=DateTime.Now;
            this.wxZty="";
            this.wxZtsj=DateTime.Now;
            this.wxZjy="";
            this.wxZjsj=DateTime.Now;
            this.wxWydm=Guid.NewGuid().ToString();
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Tdsyq record = obj as Tdsyq;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_TDSYQ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZDDM, this.Zddm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_MJDW, this.Mjdw);
				command.Parameters.AddWithValue(PARAM_NYDMJ, this.Nydmj);
				command.Parameters.AddWithValue(PARAM_GDMJ, this.Gdmj);
				command.Parameters.AddWithValue(PARAM_LDMJ, this.Ldmj);
				command.Parameters.AddWithValue(PARAM_CDMJ, this.Cdmj);
				command.Parameters.AddWithValue(PARAM_QTNYDMJ, this.Qtnydmj);
				command.Parameters.AddWithValue(PARAM_JSYDMJ, this.Jsydmj);
				command.Parameters.AddWithValue(PARAM_WLYDMJ, this.Wlydmj);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_FJ, this.Fj);
				command.Parameters.AddWithValue(PARAM_QSZT, this.Qszt);
				command.Parameters.AddWithValue(PARAM_WX_DCY, this.WxDcy);
				command.Parameters.AddWithValue(PARAM_WX_DCSJ, this.WxDcsj);
				command.Parameters.AddWithValue(PARAM_WX_CLY, this.WxCly);
				command.Parameters.AddWithValue(PARAM_WX_CLSJ, this.WxClsj);
				command.Parameters.AddWithValue(PARAM_WX_ZTY, this.WxZty);
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ, this.WxZtsj);
				command.Parameters.AddWithValue(PARAM_WX_ZJY, this.WxZjy);
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ, this.WxZjsj);
				command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_TDSYQ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_ZDDM, this.Zddm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_MJDW, this.Mjdw);
				command.Parameters.AddWithValue(PARAM_NYDMJ, this.Nydmj);
				command.Parameters.AddWithValue(PARAM_GDMJ, this.Gdmj);
				command.Parameters.AddWithValue(PARAM_LDMJ, this.Ldmj);
				command.Parameters.AddWithValue(PARAM_CDMJ, this.Cdmj);
				command.Parameters.AddWithValue(PARAM_QTNYDMJ, this.Qtnydmj);
				command.Parameters.AddWithValue(PARAM_JSYDMJ, this.Jsydmj);
				command.Parameters.AddWithValue(PARAM_WLYDMJ, this.Wlydmj);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_FJ, this.Fj);
				command.Parameters.AddWithValue(PARAM_QSZT, this.Qszt);
				command.Parameters.AddWithValue(PARAM_WX_DCY, this.WxDcy);
				command.Parameters.AddWithValue(PARAM_WX_DCSJ, this.WxDcsj);
				command.Parameters.AddWithValue(PARAM_WX_CLY, this.WxCly);
				command.Parameters.AddWithValue(PARAM_WX_CLSJ, this.WxClsj);
				command.Parameters.AddWithValue(PARAM_WX_ZTY, this.WxZty);
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ, this.WxZtsj);
				command.Parameters.AddWithValue(PARAM_WX_ZJY, this.WxZjy);
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ, this.WxZjsj);
				command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_TDSYQ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_TDSYQ,dao.Connection))
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
			if (!reader.IsDBNull(2)) zddm = reader.GetString(2);
			if (!reader.IsDBNull(3)) bdcdyh = reader.GetString(3);
			if (!reader.IsDBNull(4)) ywh = reader.GetString(4);
			if (!reader.IsDBNull(5)) qllx = reader.GetString(5);
			if (!reader.IsDBNull(6)) djlx = reader.GetString(6);
			if (!reader.IsDBNull(7)) djyy = reader.GetString(7);
			if (!reader.IsDBNull(8)) mjdw = reader.GetString(8);
			if (!reader.IsDBNull(9)) nydmj = reader.GetDouble(9);
			if (!reader.IsDBNull(10)) gdmj = reader.GetDouble(10);
			if (!reader.IsDBNull(11)) ldmj = reader.GetDouble(11);
			if (!reader.IsDBNull(12)) cdmj = reader.GetDouble(12);
			if (!reader.IsDBNull(13)) qtnydmj = reader.GetDouble(13);
			if (!reader.IsDBNull(14)) jsydmj = reader.GetDouble(14);
			if (!reader.IsDBNull(15)) wlydmj = reader.GetDouble(15);
			if (!reader.IsDBNull(16)) bdcqzh = reader.GetString(16);
			if (!reader.IsDBNull(17)) qxdm = reader.GetString(17);
			if (!reader.IsDBNull(18)) djjg = reader.GetString(18);
			if (!reader.IsDBNull(19)) dbr = reader.GetString(19);
			if (!reader.IsDBNull(20)) djsj = reader.GetDateTime(20);
			if (!reader.IsDBNull(21)) fj = reader.GetString(21);
			if (!reader.IsDBNull(22)) qszt = reader.GetString(22);
			if (!reader.IsDBNull(23)) wxDcy = reader.GetString(23);
			if (!reader.IsDBNull(24)) wxDcsj = reader.GetDateTime(24);
			if (!reader.IsDBNull(25)) wxCly = reader.GetString(25);
			if (!reader.IsDBNull(26)) wxClsj = reader.GetDateTime(26);
			if (!reader.IsDBNull(27)) wxZty = reader.GetString(27);
			if (!reader.IsDBNull(28)) wxZtsj = reader.GetDateTime(28);
			if (!reader.IsDBNull(29)) wxZjy = reader.GetString(29);
			if (!reader.IsDBNull(30)) wxZjsj = reader.GetDateTime(30);
			if (!reader.IsDBNull(31)) wxWydm = reader.GetString(31);
			if (!reader.IsDBNull(32)) databaseid = reader.GetInt64(32);
			if (!reader.IsDBNull(33)) flags = reader.GetInt16(33);
			if (!reader.IsDBNull(34)) xgr = reader.GetString(34);
			if (!reader.IsDBNull(35)) xgsj = reader.GetDateTime(35);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Tdsyq target=new Tdsyq();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Zddm=this.Zddm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Qllx=this.Qllx;
            target.Djlx=this.Djlx;
            target.Djyy=this.Djyy;
            target.Mjdw=this.Mjdw;
            target.Nydmj=this.Nydmj;
            target.Gdmj=this.Gdmj;
            target.Ldmj=this.Ldmj;
            target.Cdmj=this.Cdmj;
            target.Qtnydmj=this.Qtnydmj;
            target.Jsydmj=this.Jsydmj;
            target.Wlydmj=this.Wlydmj;
            target.Bdcqzh=this.Bdcqzh;
            target.Qxdm=this.Qxdm;
            target.Djjg=this.Djjg;
            target.Dbr=this.Dbr;
            target.Djsj=this.Djsj;
            target.Fj=this.Fj;
            target.Qszt=this.Qszt;
            target.WxDcy=this.WxDcy;
            target.WxDcsj=this.WxDcsj;
            target.WxCly=this.WxCly;
            target.WxClsj=this.WxClsj;
            target.WxZty=this.WxZty;
            target.WxZtsj=this.WxZtsj;
            target.WxZjy=this.WxZjy;
            target.WxZjsj=this.WxZjsj;
            target.WxWydm=Guid.NewGuid().ToString();
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
