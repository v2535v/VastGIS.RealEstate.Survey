
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
    public partial class Dyiq : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "DYIQ";	
        public const string LAYER_NAME = "地役权";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_YWH = "YWH";
		public const string COL_GYDBDCDYH = "GYDBDCDYH";
		public const string COL_GYDQLR = "GYDQLR";
		public const string COL_GYDQLRZJZL = "GYDQLRZJZL";
		public const string COL_GYDQLRZJH = "GYDQLRZJH";
		public const string COL_XYDBDCDYH = "XYDBDCDYH";
		public const string COL_XYDZL = "XYDZL";
		public const string COL_XYDQLR = "XYDQLR";
		public const string COL_XYDQLRZJZL = "XYDQLRZJZL";
		public const string COL_XYDQLRZJH = "XYDQLRZJH";
		public const string COL_DJLX = "DJLX";
		public const string COL_DJYY = "DJYY";
		public const string COL_DYQNR = "DYQNR";
		public const string COL_BDCDJZMH = "BDCDJZMH";
		public const string COL_QLQSSJ = "QLQSSJ";
		public const string COL_QLJSSJ = "QLJSSJ";
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
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_GYDBDCDYH = "@GYDBDCDYH";	
        public const string PARAM_GYDQLR = "@GYDQLR";	
        public const string PARAM_GYDQLRZJZL = "@GYDQLRZJZL";	
        public const string PARAM_GYDQLRZJH = "@GYDQLRZJH";	
        public const string PARAM_XYDBDCDYH = "@XYDBDCDYH";	
        public const string PARAM_XYDZL = "@XYDZL";	
        public const string PARAM_XYDQLR = "@XYDQLR";	
        public const string PARAM_XYDQLRZJZL = "@XYDQLRZJZL";	
        public const string PARAM_XYDQLRZJH = "@XYDQLRZJH";	
        public const string PARAM_DJLX = "@DJLX";	
        public const string PARAM_DJYY = "@DJYY";	
        public const string PARAM_DYQNR = "@DYQNR";	
        public const string PARAM_BDCDJZMH = "@BDCDJZMH";	
        public const string PARAM_QLQSSJ = "@QLQSSJ";	
        public const string PARAM_QLJSSJ = "@QLJSSJ";	
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
		private const string SQL_QUERY_DYIQ ="SELECT  Id,YSDM,YWH,GYDBDCDYH,GYDQLR,GYDQLRZJZL,GYDQLRZJH,XYDBDCDYH,XYDZL,XYDQLR,XYDQLRZJZL,XYDQLRZJH,DJLX,DJYY,DYQNR,BDCDJZMH,QLQSSJ,QLJSSJ,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM DYIQ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_DYIQ = "INSERT INTO [DYIQ] (YSDM, YWH, GYDBDCDYH, GYDQLR, GYDQLRZJZL, GYDQLRZJH, XYDBDCDYH, XYDZL, XYDQLR, XYDQLRZJZL, XYDQLRZJH, DJLX, DJYY, DYQNR, BDCDJZMH, QLQSSJ, QLJSSJ, QXDM, DJJG, DBR, DJSJ, FJ, QSZT, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @YWH, @GYDBDCDYH, @GYDQLR, @GYDQLRZJZL, @GYDQLRZJH, @XYDBDCDYH, @XYDZL, @XYDQLR, @XYDQLRZJZL, @XYDQLRZJH, @DJLX, @DJYY, @DYQNR, @BDCDJZMH, @QLQSSJ, @QLJSSJ, @QXDM, @DJJG, @DBR, @DJSJ, @FJ, @QSZT, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_DYIQ = "UPDATE [DYIQ] SET YSDM = @YSDM, YWH = @YWH, GYDBDCDYH = @GYDBDCDYH, GYDQLR = @GYDQLR, GYDQLRZJZL = @GYDQLRZJZL, GYDQLRZJH = @GYDQLRZJH, XYDBDCDYH = @XYDBDCDYH, XYDZL = @XYDZL, XYDQLR = @XYDQLR, XYDQLRZJZL = @XYDQLRZJZL, XYDQLRZJH = @XYDQLRZJH, DJLX = @DJLX, DJYY = @DJYY, DYQNR = @DYQNR, BDCDJZMH = @BDCDJZMH, QLQSSJ = @QLQSSJ, QLJSSJ = @QLJSSJ, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, FJ = @FJ, QSZT = @QSZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_DYIQ = "DELETE FROM [DYIQ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_DYIQ = "UPDATE [DYIQ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///业务号
		protected string ywh = default(string);
        ///供役地不动产单元号
		protected string gydbdcdyh = default(string);
        ///供役地权利人
		protected string gydqlr = default(string);
        ///供役地权利人证件种类[字典:证件种类字典表-ZJZLZD]
		protected string gydqlrzjzl = default(string);
        ///供役地权利人证件号
		protected string gydqlrzjh = default(string);
        ///需役地不动产单元号
		protected string xydbdcdyh = default(string);
        ///需役地坐落
		protected string xydzl = default(string);
        ///需役地权利人
		protected string xydqlr = default(string);
        ///需役地权利人证件种类[字典:证件种类字典表-ZJZLZD]
		protected string xydqlrzjzl = default(string);
        ///需役地权利人证件号
		protected string xydqlrzjh = default(string);
        ///登记类型[字典:登记类型字典表-DJLXZD]
		protected string djlx = default(string);
        ///登记原因
		protected string djyy = default(string);
        ///地役权内容
		protected string dyqnr = default(string);
        ///不动产登记证明号
		protected string bdcdjzmh = default(string);
        ///权利起始时间
		protected System.DateTime? qlqssj = default(System.DateTime?);
        ///权利结束时间
		protected System.DateTime? qljssj = default(System.DateTime?);
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
            get{return "Dyiq";}
        }
         public string LayerName
        {
            get{return "地役权";}
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
                return string.Format("{0} {1} ({2})","DYIQ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","地役权",this.id,this.ysdm);
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
		
        ///供役地不动产单元号
        ///[Column(COL_GYDBDCDYH, PARAM_GYDBDCDYH )]
        public virtual string Gydbdcdyh 
        {
            get { return this.gydbdcdyh; }
			set	{ 
                  if(this.gydbdcdyh != value)
                    {
                        this.OnPropertyChanging("Gydbdcdyh"); 
                        this.gydbdcdyh = value;                        
                        this.OnPropertyChanged("Gydbdcdyh");
                    }   
                }
        }	
		
        ///供役地权利人
        ///[Column(COL_GYDQLR, PARAM_GYDQLR )]
        public virtual string Gydqlr 
        {
            get { return this.gydqlr; }
			set	{ 
                  if(this.gydqlr != value)
                    {
                        this.OnPropertyChanging("Gydqlr"); 
                        this.gydqlr = value;                        
                        this.OnPropertyChanged("Gydqlr");
                    }   
                }
        }	
		
        ///供役地权利人证件种类
        ///[Column(COL_GYDQLRZJZL, PARAM_GYDQLRZJZL )]
        public virtual string Gydqlrzjzl 
        {
            get { return this.gydqlrzjzl; }
			set	{ 
                  if(this.gydqlrzjzl != value)
                    {
                        this.OnPropertyChanging("Gydqlrzjzl"); 
                        this.gydqlrzjzl = value;                        
                        this.OnPropertyChanged("Gydqlrzjzl");
                    }   
                }
        }	
		
        ///供役地权利人证件号
        ///[Column(COL_GYDQLRZJH, PARAM_GYDQLRZJH )]
        public virtual string Gydqlrzjh 
        {
            get { return this.gydqlrzjh; }
			set	{ 
                  if(this.gydqlrzjh != value)
                    {
                        this.OnPropertyChanging("Gydqlrzjh"); 
                        this.gydqlrzjh = value;                        
                        this.OnPropertyChanged("Gydqlrzjh");
                    }   
                }
        }	
		
        ///需役地不动产单元号
        ///[Column(COL_XYDBDCDYH, PARAM_XYDBDCDYH )]
        public virtual string Xydbdcdyh 
        {
            get { return this.xydbdcdyh; }
			set	{ 
                  if(this.xydbdcdyh != value)
                    {
                        this.OnPropertyChanging("Xydbdcdyh"); 
                        this.xydbdcdyh = value;                        
                        this.OnPropertyChanged("Xydbdcdyh");
                    }   
                }
        }	
		
        ///需役地坐落
        ///[Column(COL_XYDZL, PARAM_XYDZL )]
        public virtual string Xydzl 
        {
            get { return this.xydzl; }
			set	{ 
                  if(this.xydzl != value)
                    {
                        this.OnPropertyChanging("Xydzl"); 
                        this.xydzl = value;                        
                        this.OnPropertyChanged("Xydzl");
                    }   
                }
        }	
		
        ///需役地权利人
        ///[Column(COL_XYDQLR, PARAM_XYDQLR )]
        public virtual string Xydqlr 
        {
            get { return this.xydqlr; }
			set	{ 
                  if(this.xydqlr != value)
                    {
                        this.OnPropertyChanging("Xydqlr"); 
                        this.xydqlr = value;                        
                        this.OnPropertyChanged("Xydqlr");
                    }   
                }
        }	
		
        ///需役地权利人证件种类
        ///[Column(COL_XYDQLRZJZL, PARAM_XYDQLRZJZL )]
        public virtual string Xydqlrzjzl 
        {
            get { return this.xydqlrzjzl; }
			set	{ 
                  if(this.xydqlrzjzl != value)
                    {
                        this.OnPropertyChanging("Xydqlrzjzl"); 
                        this.xydqlrzjzl = value;                        
                        this.OnPropertyChanged("Xydqlrzjzl");
                    }   
                }
        }	
		
        ///需役地权利人证件号
        ///[Column(COL_XYDQLRZJH, PARAM_XYDQLRZJH )]
        public virtual string Xydqlrzjh 
        {
            get { return this.xydqlrzjh; }
			set	{ 
                  if(this.xydqlrzjh != value)
                    {
                        this.OnPropertyChanging("Xydqlrzjh"); 
                        this.xydqlrzjh = value;                        
                        this.OnPropertyChanged("Xydqlrzjh");
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
		
        ///地役权内容
        ///[Column(COL_DYQNR, PARAM_DYQNR )]
        public virtual string Dyqnr 
        {
            get { return this.dyqnr; }
			set	{ 
                  if(this.dyqnr != value)
                    {
                        this.OnPropertyChanging("Dyqnr"); 
                        this.dyqnr = value;                        
                        this.OnPropertyChanged("Dyqnr");
                    }   
                }
        }	
		
        ///不动产登记证明号
        ///[Column(COL_BDCDJZMH, PARAM_BDCDJZMH )]
        public virtual string Bdcdjzmh 
        {
            get { return this.bdcdjzmh; }
			set	{ 
                  if(this.bdcdjzmh != value)
                    {
                        this.OnPropertyChanging("Bdcdjzmh"); 
                        this.bdcdjzmh = value;                        
                        this.OnPropertyChanged("Bdcdjzmh");
                    }   
                }
        }	
		
        ///权利起始时间
        ///[Column(COL_QLQSSJ, PARAM_QLQSSJ )]
        public virtual System.DateTime? Qlqssj 
        {
            get { return this.qlqssj; }
			set	{ 
                  if(this.qlqssj != value)
                    {
                        this.OnPropertyChanging("Qlqssj"); 
                        this.qlqssj = value;                        
                        this.OnPropertyChanged("Qlqssj");
                    }   
                }
        }	
		
        ///权利结束时间
        ///[Column(COL_QLJSSJ, PARAM_QLJSSJ )]
        public virtual System.DateTime? Qljssj 
        {
            get { return this.qljssj; }
			set	{ 
                  if(this.qljssj != value)
                    {
                        this.OnPropertyChanging("Qljssj"); 
                        this.qljssj = value;                        
                        this.OnPropertyChanged("Qljssj");
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
        public Dyiq()
        {
            this.id=0;
            this.ysdm="";
            this.ywh="";
            this.gydbdcdyh="";
            this.gydqlr="";
            this.gydqlrzjzl="";
            this.gydqlrzjh="";
            this.xydbdcdyh="";
            this.xydzl="";
            this.xydqlr="";
            this.xydqlrzjzl="";
            this.xydqlrzjh="";
            this.djlx="";
            this.djyy="";
            this.dyqnr="";
            this.bdcdjzmh="";
            this.qlqssj=DateTime.Now;
            this.qljssj=DateTime.Now;
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
            Dyiq record = obj as Dyiq;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_DYIQ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_GYDBDCDYH, this.Gydbdcdyh);
				command.Parameters.AddWithValue(PARAM_GYDQLR, this.Gydqlr);
				command.Parameters.AddWithValue(PARAM_GYDQLRZJZL, this.Gydqlrzjzl);
				command.Parameters.AddWithValue(PARAM_GYDQLRZJH, this.Gydqlrzjh);
				command.Parameters.AddWithValue(PARAM_XYDBDCDYH, this.Xydbdcdyh);
				command.Parameters.AddWithValue(PARAM_XYDZL, this.Xydzl);
				command.Parameters.AddWithValue(PARAM_XYDQLR, this.Xydqlr);
				command.Parameters.AddWithValue(PARAM_XYDQLRZJZL, this.Xydqlrzjzl);
				command.Parameters.AddWithValue(PARAM_XYDQLRZJH, this.Xydqlrzjh);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_DYQNR, this.Dyqnr);
				command.Parameters.AddWithValue(PARAM_BDCDJZMH, this.Bdcdjzmh);
				command.Parameters.AddWithValue(PARAM_QLQSSJ, this.Qlqssj);
				command.Parameters.AddWithValue(PARAM_QLJSSJ, this.Qljssj);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_DYIQ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_GYDBDCDYH, this.Gydbdcdyh);
				command.Parameters.AddWithValue(PARAM_GYDQLR, this.Gydqlr);
				command.Parameters.AddWithValue(PARAM_GYDQLRZJZL, this.Gydqlrzjzl);
				command.Parameters.AddWithValue(PARAM_GYDQLRZJH, this.Gydqlrzjh);
				command.Parameters.AddWithValue(PARAM_XYDBDCDYH, this.Xydbdcdyh);
				command.Parameters.AddWithValue(PARAM_XYDZL, this.Xydzl);
				command.Parameters.AddWithValue(PARAM_XYDQLR, this.Xydqlr);
				command.Parameters.AddWithValue(PARAM_XYDQLRZJZL, this.Xydqlrzjzl);
				command.Parameters.AddWithValue(PARAM_XYDQLRZJH, this.Xydqlrzjh);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_DYQNR, this.Dyqnr);
				command.Parameters.AddWithValue(PARAM_BDCDJZMH, this.Bdcdjzmh);
				command.Parameters.AddWithValue(PARAM_QLQSSJ, this.Qlqssj);
				command.Parameters.AddWithValue(PARAM_QLJSSJ, this.Qljssj);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_DYIQ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_DYIQ,dao.Connection))
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
			if (!reader.IsDBNull(2)) ywh = reader.GetString(2);
			if (!reader.IsDBNull(3)) gydbdcdyh = reader.GetString(3);
			if (!reader.IsDBNull(4)) gydqlr = reader.GetString(4);
			if (!reader.IsDBNull(5)) gydqlrzjzl = reader.GetString(5);
			if (!reader.IsDBNull(6)) gydqlrzjh = reader.GetString(6);
			if (!reader.IsDBNull(7)) xydbdcdyh = reader.GetString(7);
			if (!reader.IsDBNull(8)) xydzl = reader.GetString(8);
			if (!reader.IsDBNull(9)) xydqlr = reader.GetString(9);
			if (!reader.IsDBNull(10)) xydqlrzjzl = reader.GetString(10);
			if (!reader.IsDBNull(11)) xydqlrzjh = reader.GetString(11);
			if (!reader.IsDBNull(12)) djlx = reader.GetString(12);
			if (!reader.IsDBNull(13)) djyy = reader.GetString(13);
			if (!reader.IsDBNull(14)) dyqnr = reader.GetString(14);
			if (!reader.IsDBNull(15)) bdcdjzmh = reader.GetString(15);
			if (!reader.IsDBNull(16)) qlqssj = reader.GetDateTime(16);
			if (!reader.IsDBNull(17)) qljssj = reader.GetDateTime(17);
			if (!reader.IsDBNull(18)) qxdm = reader.GetString(18);
			if (!reader.IsDBNull(19)) djjg = reader.GetString(19);
			if (!reader.IsDBNull(20)) dbr = reader.GetString(20);
			if (!reader.IsDBNull(21)) djsj = reader.GetDateTime(21);
			if (!reader.IsDBNull(22)) fj = reader.GetString(22);
			if (!reader.IsDBNull(23)) qszt = reader.GetString(23);
			if (!reader.IsDBNull(24)) databaseid = reader.GetInt64(24);
			if (!reader.IsDBNull(25)) flags = reader.GetInt16(25);
			if (!reader.IsDBNull(26)) xgr = reader.GetString(26);
			if (!reader.IsDBNull(27)) xgsj = reader.GetDateTime(27);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Dyiq target=new Dyiq();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Ywh=this.Ywh;
            target.Gydbdcdyh=this.Gydbdcdyh;
            target.Gydqlr=this.Gydqlr;
            target.Gydqlrzjzl=this.Gydqlrzjzl;
            target.Gydqlrzjh=this.Gydqlrzjh;
            target.Xydbdcdyh=this.Xydbdcdyh;
            target.Xydzl=this.Xydzl;
            target.Xydqlr=this.Xydqlr;
            target.Xydqlrzjzl=this.Xydqlrzjzl;
            target.Xydqlrzjh=this.Xydqlrzjh;
            target.Djlx=this.Djlx;
            target.Djyy=this.Djyy;
            target.Dyqnr=this.Dyqnr;
            target.Bdcdjzmh=this.Bdcdjzmh;
            target.Qlqssj=this.Qlqssj;
            target.Qljssj=this.Qljssj;
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
