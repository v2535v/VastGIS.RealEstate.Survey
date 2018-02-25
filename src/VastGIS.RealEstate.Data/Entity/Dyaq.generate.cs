
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
    public partial class Dyaq : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "DYAQ";	
        public const string LAYER_NAME = "抵押权";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_DYBDCLX = "DYBDCLX";
		public const string COL_DYR = "DYR";
		public const string COL_DYFS = "DYFS";
		public const string COL_DJLX = "DJLX";
		public const string COL_DJYY = "DJYY";
		public const string COL_ZJJZWZL = "ZJJZWZL";
		public const string COL_ZJJZWDYFW = "ZJJZWDYFW";
		public const string COL_BDBZZQSE = "BDBZZQSE";
		public const string COL_ZWLXQSSJ = "ZWLXQSSJ";
		public const string COL_ZWLXJSSJ = "ZWLXJSSJ";
		public const string COL_ZGZQQDSS = "ZGZQQDSS";
		public const string COL_ZGZQSE = "ZGZQSE";
		public const string COL_ZXDYYWH = "ZXDYYWH";
		public const string COL_ZXDYYY = "ZXDYYY";
		public const string COL_ZXSJ = "ZXSJ";
		public const string COL_BDCDJZMH = "BDCDJZMH";
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
        public const string PARAM_DYBDCLX = "@DYBDCLX";	
        public const string PARAM_DYR = "@DYR";	
        public const string PARAM_DYFS = "@DYFS";	
        public const string PARAM_DJLX = "@DJLX";	
        public const string PARAM_DJYY = "@DJYY";	
        public const string PARAM_ZJJZWZL = "@ZJJZWZL";	
        public const string PARAM_ZJJZWDYFW = "@ZJJZWDYFW";	
        public const string PARAM_BDBZZQSE = "@BDBZZQSE";	
        public const string PARAM_ZWLXQSSJ = "@ZWLXQSSJ";	
        public const string PARAM_ZWLXJSSJ = "@ZWLXJSSJ";	
        public const string PARAM_ZGZQQDSS = "@ZGZQQDSS";	
        public const string PARAM_ZGZQSE = "@ZGZQSE";	
        public const string PARAM_ZXDYYWH = "@ZXDYYWH";	
        public const string PARAM_ZXDYYY = "@ZXDYYY";	
        public const string PARAM_ZXSJ = "@ZXSJ";	
        public const string PARAM_BDCDJZMH = "@BDCDJZMH";	
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
		private const string SQL_QUERY_DYAQ ="SELECT  Id,YSDM,BDCDYH,YWH,DYBDCLX,DYR,DYFS,DJLX,DJYY,ZJJZWZL,ZJJZWDYFW,BDBZZQSE,ZWLXQSSJ,ZWLXJSSJ,ZGZQQDSS,ZGZQSE,ZXDYYWH,ZXDYYY,ZXSJ,BDCDJZMH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM DYAQ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_DYAQ = "INSERT INTO [DYAQ] (YSDM, BDCDYH, YWH, DYBDCLX, DYR, DYFS, DJLX, DJYY, ZJJZWZL, ZJJZWDYFW, BDBZZQSE, ZWLXQSSJ, ZWLXJSSJ, ZGZQQDSS, ZGZQSE, ZXDYYWH, ZXDYYY, ZXSJ, BDCDJZMH, QXDM, DJJG, DBR, DJSJ, FJ, QSZT, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @BDCDYH, @YWH, @DYBDCLX, @DYR, @DYFS, @DJLX, @DJYY, @ZJJZWZL, @ZJJZWDYFW, @BDBZZQSE, @ZWLXQSSJ, @ZWLXJSSJ, @ZGZQQDSS, @ZGZQSE, @ZXDYYWH, @ZXDYYY, @ZXSJ, @BDCDJZMH, @QXDM, @DJJG, @DBR, @DJSJ, @FJ, @QSZT, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_DYAQ = "UPDATE [DYAQ] SET YSDM = @YSDM, BDCDYH = @BDCDYH, YWH = @YWH, DYBDCLX = @DYBDCLX, DYR = @DYR, DYFS = @DYFS, DJLX = @DJLX, DJYY = @DJYY, ZJJZWZL = @ZJJZWZL, ZJJZWDYFW = @ZJJZWDYFW, BDBZZQSE = @BDBZZQSE, ZWLXQSSJ = @ZWLXQSSJ, ZWLXJSSJ = @ZWLXJSSJ, ZGZQQDSS = @ZGZQQDSS, ZGZQSE = @ZGZQSE, ZXDYYWH = @ZXDYYWH, ZXDYYY = @ZXDYYY, ZXSJ = @ZXSJ, BDCDJZMH = @BDCDJZMH, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, FJ = @FJ, QSZT = @QSZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_DYAQ = "DELETE FROM [DYAQ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_DYAQ = "UPDATE [DYAQ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
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
        ///抵押不动产类型[字典:抵押不动产类型字典表-DYBDCLXZD]
		protected string dybdclx = default(string);
        ///抵押人
		protected string dyr = default(string);
        ///抵押方式[字典:抵押方式字典表-DYFSZD]
		protected string dyfs = default(string);
        ///登记类型[字典:登记类型字典表-DJLXZD]
		protected string djlx = default(string);
        ///登记原因
		protected string djyy = default(string);
        ///在建建筑物坐落
		protected string zjjzwzl = default(string);
        ///在建建筑物抵押范围
		protected string zjjzwdyfw = default(string);
        ///被担保主债权数额
		protected double? bdbzzqse = default(double?);
        ///债务履行起始时间
		protected System.DateTime? zwlxqssj = default(System.DateTime?);
        ///债务履行结束时间
		protected System.DateTime? zwlxjssj = default(System.DateTime?);
        ///最高债权确定事实
		protected string zgzqqdss = default(string);
        ///最高债权数额
		protected double? zgzqse = default(double?);
        ///注销抵押业务号
		protected string zxdyywh = default(string);
        ///注销抵押原因
		protected string zxdyyy = default(string);
        ///注销时间
		protected System.DateTime? zxsj = default(System.DateTime?);
        ///不动产登记证明号
		protected string bdcdjzmh = default(string);
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
            get{return "Dyaq";}
        }
         public string LayerName
        {
            get{return "抵押权";}
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
                return string.Format("{0} {1} ({2})","DYAQ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","抵押权",this.id,this.ysdm);
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
		
        ///抵押不动产类型
        ///[Column(COL_DYBDCLX, PARAM_DYBDCLX )]
        public virtual string Dybdclx 
        {
            get { return this.dybdclx; }
			set	{ 
                  if(this.dybdclx != value)
                    {
                        this.OnPropertyChanging("Dybdclx"); 
                        this.dybdclx = value;                        
                        this.OnPropertyChanged("Dybdclx");
                    }   
                }
        }	
		
        ///抵押人
        ///[Column(COL_DYR, PARAM_DYR )]
        public virtual string Dyr 
        {
            get { return this.dyr; }
			set	{ 
                  if(this.dyr != value)
                    {
                        this.OnPropertyChanging("Dyr"); 
                        this.dyr = value;                        
                        this.OnPropertyChanged("Dyr");
                    }   
                }
        }	
		
        ///抵押方式
        ///[Column(COL_DYFS, PARAM_DYFS )]
        public virtual string Dyfs 
        {
            get { return this.dyfs; }
			set	{ 
                  if(this.dyfs != value)
                    {
                        this.OnPropertyChanging("Dyfs"); 
                        this.dyfs = value;                        
                        this.OnPropertyChanged("Dyfs");
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
		
        ///在建建筑物坐落
        ///[Column(COL_ZJJZWZL, PARAM_ZJJZWZL )]
        public virtual string Zjjzwzl 
        {
            get { return this.zjjzwzl; }
			set	{ 
                  if(this.zjjzwzl != value)
                    {
                        this.OnPropertyChanging("Zjjzwzl"); 
                        this.zjjzwzl = value;                        
                        this.OnPropertyChanged("Zjjzwzl");
                    }   
                }
        }	
		
        ///在建建筑物抵押范围
        ///[Column(COL_ZJJZWDYFW, PARAM_ZJJZWDYFW )]
        public virtual string Zjjzwdyfw 
        {
            get { return this.zjjzwdyfw; }
			set	{ 
                  if(this.zjjzwdyfw != value)
                    {
                        this.OnPropertyChanging("Zjjzwdyfw"); 
                        this.zjjzwdyfw = value;                        
                        this.OnPropertyChanged("Zjjzwdyfw");
                    }   
                }
        }	
		
        ///被担保主债权数额
        ///[Column(COL_BDBZZQSE, PARAM_BDBZZQSE )]
        public virtual double? Bdbzzqse 
        {
            get { return this.bdbzzqse; }
			set	{ 
                  if(this.bdbzzqse != value)
                    {
                        this.OnPropertyChanging("Bdbzzqse"); 
                        this.bdbzzqse = value;                        
                        this.OnPropertyChanged("Bdbzzqse");
                    }   
                }
        }	
		
        ///债务履行起始时间
        ///[Column(COL_ZWLXQSSJ, PARAM_ZWLXQSSJ )]
        public virtual System.DateTime? Zwlxqssj 
        {
            get { return this.zwlxqssj; }
			set	{ 
                  if(this.zwlxqssj != value)
                    {
                        this.OnPropertyChanging("Zwlxqssj"); 
                        this.zwlxqssj = value;                        
                        this.OnPropertyChanged("Zwlxqssj");
                    }   
                }
        }	
		
        ///债务履行结束时间
        ///[Column(COL_ZWLXJSSJ, PARAM_ZWLXJSSJ )]
        public virtual System.DateTime? Zwlxjssj 
        {
            get { return this.zwlxjssj; }
			set	{ 
                  if(this.zwlxjssj != value)
                    {
                        this.OnPropertyChanging("Zwlxjssj"); 
                        this.zwlxjssj = value;                        
                        this.OnPropertyChanged("Zwlxjssj");
                    }   
                }
        }	
		
        ///最高债权确定事实
        ///[Column(COL_ZGZQQDSS, PARAM_ZGZQQDSS )]
        public virtual string Zgzqqdss 
        {
            get { return this.zgzqqdss; }
			set	{ 
                  if(this.zgzqqdss != value)
                    {
                        this.OnPropertyChanging("Zgzqqdss"); 
                        this.zgzqqdss = value;                        
                        this.OnPropertyChanged("Zgzqqdss");
                    }   
                }
        }	
		
        ///最高债权数额
        ///[Column(COL_ZGZQSE, PARAM_ZGZQSE )]
        public virtual double? Zgzqse 
        {
            get { return this.zgzqse; }
			set	{ 
                  if(this.zgzqse != value)
                    {
                        this.OnPropertyChanging("Zgzqse"); 
                        this.zgzqse = value;                        
                        this.OnPropertyChanged("Zgzqse");
                    }   
                }
        }	
		
        ///注销抵押业务号
        ///[Column(COL_ZXDYYWH, PARAM_ZXDYYWH )]
        public virtual string Zxdyywh 
        {
            get { return this.zxdyywh; }
			set	{ 
                  if(this.zxdyywh != value)
                    {
                        this.OnPropertyChanging("Zxdyywh"); 
                        this.zxdyywh = value;                        
                        this.OnPropertyChanged("Zxdyywh");
                    }   
                }
        }	
		
        ///注销抵押原因
        ///[Column(COL_ZXDYYY, PARAM_ZXDYYY )]
        public virtual string Zxdyyy 
        {
            get { return this.zxdyyy; }
			set	{ 
                  if(this.zxdyyy != value)
                    {
                        this.OnPropertyChanging("Zxdyyy"); 
                        this.zxdyyy = value;                        
                        this.OnPropertyChanged("Zxdyyy");
                    }   
                }
        }	
		
        ///注销时间
        ///[Column(COL_ZXSJ, PARAM_ZXSJ )]
        public virtual System.DateTime? Zxsj 
        {
            get { return this.zxsj; }
			set	{ 
                  if(this.zxsj != value)
                    {
                        this.OnPropertyChanging("Zxsj"); 
                        this.zxsj = value;                        
                        this.OnPropertyChanged("Zxsj");
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
        public Dyaq()
        {
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.ywh="";
            this.dybdclx="";
            this.dyr="";
            this.dyfs="";
            this.djlx="";
            this.djyy="";
            this.zjjzwzl="";
            this.zjjzwdyfw="";
            this.bdbzzqse=0.0;
            this.zwlxqssj=DateTime.Now;
            this.zwlxjssj=DateTime.Now;
            this.zgzqqdss="";
            this.zgzqse=0.0;
            this.zxdyywh="";
            this.zxdyyy="";
            this.zxsj=DateTime.Now;
            this.bdcdjzmh="";
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
            Dyaq record = obj as Dyaq;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_DYAQ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_DYBDCLX, this.Dybdclx);
				command.Parameters.AddWithValue(PARAM_DYR, this.Dyr);
				command.Parameters.AddWithValue(PARAM_DYFS, this.Dyfs);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_ZJJZWZL, this.Zjjzwzl);
				command.Parameters.AddWithValue(PARAM_ZJJZWDYFW, this.Zjjzwdyfw);
				command.Parameters.AddWithValue(PARAM_BDBZZQSE, this.Bdbzzqse);
				command.Parameters.AddWithValue(PARAM_ZWLXQSSJ, this.Zwlxqssj);
				command.Parameters.AddWithValue(PARAM_ZWLXJSSJ, this.Zwlxjssj);
				command.Parameters.AddWithValue(PARAM_ZGZQQDSS, this.Zgzqqdss);
				command.Parameters.AddWithValue(PARAM_ZGZQSE, this.Zgzqse);
				command.Parameters.AddWithValue(PARAM_ZXDYYWH, this.Zxdyywh);
				command.Parameters.AddWithValue(PARAM_ZXDYYY, this.Zxdyyy);
				command.Parameters.AddWithValue(PARAM_ZXSJ, this.Zxsj);
				command.Parameters.AddWithValue(PARAM_BDCDJZMH, this.Bdcdjzmh);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_DYAQ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_DYBDCLX, this.Dybdclx);
				command.Parameters.AddWithValue(PARAM_DYR, this.Dyr);
				command.Parameters.AddWithValue(PARAM_DYFS, this.Dyfs);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_ZJJZWZL, this.Zjjzwzl);
				command.Parameters.AddWithValue(PARAM_ZJJZWDYFW, this.Zjjzwdyfw);
				command.Parameters.AddWithValue(PARAM_BDBZZQSE, this.Bdbzzqse);
				command.Parameters.AddWithValue(PARAM_ZWLXQSSJ, this.Zwlxqssj);
				command.Parameters.AddWithValue(PARAM_ZWLXJSSJ, this.Zwlxjssj);
				command.Parameters.AddWithValue(PARAM_ZGZQQDSS, this.Zgzqqdss);
				command.Parameters.AddWithValue(PARAM_ZGZQSE, this.Zgzqse);
				command.Parameters.AddWithValue(PARAM_ZXDYYWH, this.Zxdyywh);
				command.Parameters.AddWithValue(PARAM_ZXDYYY, this.Zxdyyy);
				command.Parameters.AddWithValue(PARAM_ZXSJ, this.Zxsj);
				command.Parameters.AddWithValue(PARAM_BDCDJZMH, this.Bdcdjzmh);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_DYAQ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_DYAQ,dao.Connection))
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
			if (!reader.IsDBNull(4)) dybdclx = reader.GetString(4);
			if (!reader.IsDBNull(5)) dyr = reader.GetString(5);
			if (!reader.IsDBNull(6)) dyfs = reader.GetString(6);
			if (!reader.IsDBNull(7)) djlx = reader.GetString(7);
			if (!reader.IsDBNull(8)) djyy = reader.GetString(8);
			if (!reader.IsDBNull(9)) zjjzwzl = reader.GetString(9);
			if (!reader.IsDBNull(10)) zjjzwdyfw = reader.GetString(10);
			if (!reader.IsDBNull(11)) bdbzzqse = reader.GetDouble(11);
			if (!reader.IsDBNull(12)) zwlxqssj = reader.GetDateTime(12);
			if (!reader.IsDBNull(13)) zwlxjssj = reader.GetDateTime(13);
			if (!reader.IsDBNull(14)) zgzqqdss = reader.GetString(14);
			if (!reader.IsDBNull(15)) zgzqse = reader.GetDouble(15);
			if (!reader.IsDBNull(16)) zxdyywh = reader.GetString(16);
			if (!reader.IsDBNull(17)) zxdyyy = reader.GetString(17);
			if (!reader.IsDBNull(18)) zxsj = reader.GetDateTime(18);
			if (!reader.IsDBNull(19)) bdcdjzmh = reader.GetString(19);
			if (!reader.IsDBNull(20)) qxdm = reader.GetString(20);
			if (!reader.IsDBNull(21)) djjg = reader.GetString(21);
			if (!reader.IsDBNull(22)) dbr = reader.GetString(22);
			if (!reader.IsDBNull(23)) djsj = reader.GetDateTime(23);
			if (!reader.IsDBNull(24)) fj = reader.GetString(24);
			if (!reader.IsDBNull(25)) qszt = reader.GetString(25);
			if (!reader.IsDBNull(26)) databaseid = reader.GetInt64(26);
			if (!reader.IsDBNull(27)) flags = reader.GetInt16(27);
			if (!reader.IsDBNull(28)) xgr = reader.GetString(28);
			if (!reader.IsDBNull(29)) xgsj = reader.GetDateTime(29);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Dyaq target=new Dyaq();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Dybdclx=this.Dybdclx;
            target.Dyr=this.Dyr;
            target.Dyfs=this.Dyfs;
            target.Djlx=this.Djlx;
            target.Djyy=this.Djyy;
            target.Zjjzwzl=this.Zjjzwzl;
            target.Zjjzwdyfw=this.Zjjzwdyfw;
            target.Bdbzzqse=this.Bdbzzqse;
            target.Zwlxqssj=this.Zwlxqssj;
            target.Zwlxjssj=this.Zwlxjssj;
            target.Zgzqqdss=this.Zgzqqdss;
            target.Zgzqse=this.Zgzqse;
            target.Zxdyywh=this.Zxdyywh;
            target.Zxdyyy=this.Zxdyyy;
            target.Zxsj=this.Zxsj;
            target.Bdcdjzmh=this.Bdcdjzmh;
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
