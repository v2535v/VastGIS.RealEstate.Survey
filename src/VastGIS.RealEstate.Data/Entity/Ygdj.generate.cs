
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
    public partial class Ygdj : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "YGDJ";	
        public const string LAYER_NAME = "预告登记";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_BDCZL = "BDCZL";
		public const string COL_YWR = "YWR";
		public const string COL_YWRZJZL = "YWRZJZL";
		public const string COL_YWRZJH = "YWRZJH";
		public const string COL_YGDJZL = "YGDJZL";
		public const string COL_DJLX = "DJLX";
		public const string COL_DJYY = "DJYY";
		public const string COL_TDSYQR = "TDSYQR";
		public const string COL_GHYT = "GHYT";
		public const string COL_FWXZ = "FWXZ";
		public const string COL_FWJG = "FWJG";
		public const string COL_SZC = "SZC";
		public const string COL_ZCS = "ZCS";
		public const string COL_JZMJ = "JZMJ";
		public const string COL_QDJG = "QDJG";
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
        public const string PARAM_BDCZL = "@BDCZL";	
        public const string PARAM_YWR = "@YWR";	
        public const string PARAM_YWRZJZL = "@YWRZJZL";	
        public const string PARAM_YWRZJH = "@YWRZJH";	
        public const string PARAM_YGDJZL = "@YGDJZL";	
        public const string PARAM_DJLX = "@DJLX";	
        public const string PARAM_DJYY = "@DJYY";	
        public const string PARAM_TDSYQR = "@TDSYQR";	
        public const string PARAM_GHYT = "@GHYT";	
        public const string PARAM_FWXZ = "@FWXZ";	
        public const string PARAM_FWJG = "@FWJG";	
        public const string PARAM_SZC = "@SZC";	
        public const string PARAM_ZCS = "@ZCS";	
        public const string PARAM_JZMJ = "@JZMJ";	
        public const string PARAM_QDJG = "@QDJG";	
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
		private const string SQL_QUERY_YGDJ ="SELECT  Id,YSDM,BDCDYH,YWH,BDCZL,YWR,YWRZJZL,YWRZJH,YGDJZL,DJLX,DJYY,TDSYQR,GHYT,FWXZ,FWJG,SZC,ZCS,JZMJ,QDJG,BDCDJZMH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM YGDJ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_YGDJ = "INSERT INTO [YGDJ] (YSDM, BDCDYH, YWH, BDCZL, YWR, YWRZJZL, YWRZJH, YGDJZL, DJLX, DJYY, TDSYQR, GHYT, FWXZ, FWJG, SZC, ZCS, JZMJ, QDJG, BDCDJZMH, QXDM, DJJG, DBR, DJSJ, FJ, QSZT, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @BDCDYH, @YWH, @BDCZL, @YWR, @YWRZJZL, @YWRZJH, @YGDJZL, @DJLX, @DJYY, @TDSYQR, @GHYT, @FWXZ, @FWJG, @SZC, @ZCS, @JZMJ, @QDJG, @BDCDJZMH, @QXDM, @DJJG, @DBR, @DJSJ, @FJ, @QSZT, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_YGDJ = "UPDATE [YGDJ] SET YSDM = @YSDM, BDCDYH = @BDCDYH, YWH = @YWH, BDCZL = @BDCZL, YWR = @YWR, YWRZJZL = @YWRZJZL, YWRZJH = @YWRZJH, YGDJZL = @YGDJZL, DJLX = @DJLX, DJYY = @DJYY, TDSYQR = @TDSYQR, GHYT = @GHYT, FWXZ = @FWXZ, FWJG = @FWJG, SZC = @SZC, ZCS = @ZCS, JZMJ = @JZMJ, QDJG = @QDJG, BDCDJZMH = @BDCDJZMH, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, FJ = @FJ, QSZT = @QSZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_YGDJ = "DELETE FROM [YGDJ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_YGDJ = "UPDATE [YGDJ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
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
        ///不动产坐落
		protected string bdczl = default(string);
        ///义务人
		protected string ywr = default(string);
        ///义务人证件种类[字典:证件种类字典表-ZJZLZD]
		protected string ywrzjzl = default(string);
        ///义务人证件号
		protected string ywrzjh = default(string);
        ///预告登记种类[字典:预告登记种类字典表-YGDJZLZD]
		protected string ygdjzl = default(string);
        ///登记类型[字典:登记类型字典表-DJLXZD]
		protected string djlx = default(string);
        ///登记原因
		protected string djyy = default(string);
        ///土地使用权人
		protected string tdsyqr = default(string);
        ///规划用途[字典:房屋用途字典表-FWYTZD]
		protected string ghyt = default(string);
        ///房屋性质[字典:房屋性质字典表-FWXZZD]
		protected string fwxz = default(string);
        ///房屋结构[字典:房屋结构字典表-FWJGZD]
		protected string fwjg = default(string);
        ///所在层
		protected long? szc = default(long?);
        ///总层数
		protected long? zcs = default(long?);
        ///建筑面积
		protected double? jzmj = default(double?);
        ///取得价格/被担保主债权数额
		protected double? qdjg = default(double?);
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
            get{return "Ygdj";}
        }
         public string LayerName
        {
            get{return "预告登记";}
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
                return string.Format("{0} {1} ({2})","YGDJ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","预告登记",this.id,this.ysdm);
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
		
        ///不动产坐落
        ///[Column(COL_BDCZL, PARAM_BDCZL )]
        public virtual string Bdczl 
        {
            get { return this.bdczl; }
			set	{ 
                  if(this.bdczl != value)
                    {
                        this.OnPropertyChanging("Bdczl"); 
                        this.bdczl = value;                        
                        this.OnPropertyChanged("Bdczl");
                    }   
                }
        }	
		
        ///义务人
        ///[Column(COL_YWR, PARAM_YWR )]
        public virtual string Ywr 
        {
            get { return this.ywr; }
			set	{ 
                  if(this.ywr != value)
                    {
                        this.OnPropertyChanging("Ywr"); 
                        this.ywr = value;                        
                        this.OnPropertyChanged("Ywr");
                    }   
                }
        }	
		
        ///义务人证件种类
        ///[Column(COL_YWRZJZL, PARAM_YWRZJZL )]
        public virtual string Ywrzjzl 
        {
            get { return this.ywrzjzl; }
			set	{ 
                  if(this.ywrzjzl != value)
                    {
                        this.OnPropertyChanging("Ywrzjzl"); 
                        this.ywrzjzl = value;                        
                        this.OnPropertyChanged("Ywrzjzl");
                    }   
                }
        }	
		
        ///义务人证件号
        ///[Column(COL_YWRZJH, PARAM_YWRZJH )]
        public virtual string Ywrzjh 
        {
            get { return this.ywrzjh; }
			set	{ 
                  if(this.ywrzjh != value)
                    {
                        this.OnPropertyChanging("Ywrzjh"); 
                        this.ywrzjh = value;                        
                        this.OnPropertyChanged("Ywrzjh");
                    }   
                }
        }	
		
        ///预告登记种类
        ///[Column(COL_YGDJZL, PARAM_YGDJZL )]
        public virtual string Ygdjzl 
        {
            get { return this.ygdjzl; }
			set	{ 
                  if(this.ygdjzl != value)
                    {
                        this.OnPropertyChanging("Ygdjzl"); 
                        this.ygdjzl = value;                        
                        this.OnPropertyChanged("Ygdjzl");
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
		
        ///土地使用权人
        ///[Column(COL_TDSYQR, PARAM_TDSYQR )]
        public virtual string Tdsyqr 
        {
            get { return this.tdsyqr; }
			set	{ 
                  if(this.tdsyqr != value)
                    {
                        this.OnPropertyChanging("Tdsyqr"); 
                        this.tdsyqr = value;                        
                        this.OnPropertyChanged("Tdsyqr");
                    }   
                }
        }	
		
        ///规划用途
        ///[Column(COL_GHYT, PARAM_GHYT )]
        public virtual string Ghyt 
        {
            get { return this.ghyt; }
			set	{ 
                  if(this.ghyt != value)
                    {
                        this.OnPropertyChanging("Ghyt"); 
                        this.ghyt = value;                        
                        this.OnPropertyChanged("Ghyt");
                    }   
                }
        }	
		
        ///房屋性质
        ///[Column(COL_FWXZ, PARAM_FWXZ )]
        public virtual string Fwxz 
        {
            get { return this.fwxz; }
			set	{ 
                  if(this.fwxz != value)
                    {
                        this.OnPropertyChanging("Fwxz"); 
                        this.fwxz = value;                        
                        this.OnPropertyChanged("Fwxz");
                    }   
                }
        }	
		
        ///房屋结构
        ///[Column(COL_FWJG, PARAM_FWJG )]
        public virtual string Fwjg 
        {
            get { return this.fwjg; }
			set	{ 
                  if(this.fwjg != value)
                    {
                        this.OnPropertyChanging("Fwjg"); 
                        this.fwjg = value;                        
                        this.OnPropertyChanged("Fwjg");
                    }   
                }
        }	
		
        ///所在层
        ///[Column(COL_SZC, PARAM_SZC )]
        public virtual long? Szc 
        {
            get { return this.szc; }
			set	{ 
                  if(this.szc != value)
                    {
                        this.OnPropertyChanging("Szc"); 
                        this.szc = value;                        
                        this.OnPropertyChanged("Szc");
                    }   
                }
        }	
		
        ///总层数
        ///[Column(COL_ZCS, PARAM_ZCS )]
        public virtual long? Zcs 
        {
            get { return this.zcs; }
			set	{ 
                  if(this.zcs != value)
                    {
                        this.OnPropertyChanging("Zcs"); 
                        this.zcs = value;                        
                        this.OnPropertyChanged("Zcs");
                    }   
                }
        }	
		
        ///建筑面积
        ///[Column(COL_JZMJ, PARAM_JZMJ )]
        public virtual double? Jzmj 
        {
            get { return this.jzmj; }
			set	{ 
                  if(this.jzmj != value)
                    {
                        this.OnPropertyChanging("Jzmj"); 
                        this.jzmj = value;                        
                        this.OnPropertyChanged("Jzmj");
                    }   
                }
        }	
		
        ///取得价格/被担保主债权数额
        ///[Column(COL_QDJG, PARAM_QDJG )]
        public virtual double? Qdjg 
        {
            get { return this.qdjg; }
			set	{ 
                  if(this.qdjg != value)
                    {
                        this.OnPropertyChanging("Qdjg"); 
                        this.qdjg = value;                        
                        this.OnPropertyChanged("Qdjg");
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
        public Ygdj()
        {
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.ywh="";
            this.bdczl="";
            this.ywr="";
            this.ywrzjzl="";
            this.ywrzjh="";
            this.ygdjzl="";
            this.djlx="";
            this.djyy="";
            this.tdsyqr="";
            this.ghyt="";
            this.fwxz="";
            this.fwjg="";
            this.szc=0;
            this.zcs=0;
            this.jzmj=0.0;
            this.qdjg=0.0;
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
            Ygdj record = obj as Ygdj;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_YGDJ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_BDCZL, this.Bdczl);
				command.Parameters.AddWithValue(PARAM_YWR, this.Ywr);
				command.Parameters.AddWithValue(PARAM_YWRZJZL, this.Ywrzjzl);
				command.Parameters.AddWithValue(PARAM_YWRZJH, this.Ywrzjh);
				command.Parameters.AddWithValue(PARAM_YGDJZL, this.Ygdjzl);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_TDSYQR, this.Tdsyqr);
				command.Parameters.AddWithValue(PARAM_GHYT, this.Ghyt);
				command.Parameters.AddWithValue(PARAM_FWXZ, this.Fwxz);
				command.Parameters.AddWithValue(PARAM_FWJG, this.Fwjg);
				command.Parameters.AddWithValue(PARAM_SZC, this.Szc);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_JZMJ, this.Jzmj);
				command.Parameters.AddWithValue(PARAM_QDJG, this.Qdjg);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_YGDJ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_BDCZL, this.Bdczl);
				command.Parameters.AddWithValue(PARAM_YWR, this.Ywr);
				command.Parameters.AddWithValue(PARAM_YWRZJZL, this.Ywrzjzl);
				command.Parameters.AddWithValue(PARAM_YWRZJH, this.Ywrzjh);
				command.Parameters.AddWithValue(PARAM_YGDJZL, this.Ygdjzl);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_TDSYQR, this.Tdsyqr);
				command.Parameters.AddWithValue(PARAM_GHYT, this.Ghyt);
				command.Parameters.AddWithValue(PARAM_FWXZ, this.Fwxz);
				command.Parameters.AddWithValue(PARAM_FWJG, this.Fwjg);
				command.Parameters.AddWithValue(PARAM_SZC, this.Szc);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_JZMJ, this.Jzmj);
				command.Parameters.AddWithValue(PARAM_QDJG, this.Qdjg);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_YGDJ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_YGDJ,dao.Connection))
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
			if (!reader.IsDBNull(4)) bdczl = reader.GetString(4);
			if (!reader.IsDBNull(5)) ywr = reader.GetString(5);
			if (!reader.IsDBNull(6)) ywrzjzl = reader.GetString(6);
			if (!reader.IsDBNull(7)) ywrzjh = reader.GetString(7);
			if (!reader.IsDBNull(8)) ygdjzl = reader.GetString(8);
			if (!reader.IsDBNull(9)) djlx = reader.GetString(9);
			if (!reader.IsDBNull(10)) djyy = reader.GetString(10);
			if (!reader.IsDBNull(11)) tdsyqr = reader.GetString(11);
			if (!reader.IsDBNull(12)) ghyt = reader.GetString(12);
			if (!reader.IsDBNull(13)) fwxz = reader.GetString(13);
			if (!reader.IsDBNull(14)) fwjg = reader.GetString(14);
			if (!reader.IsDBNull(15)) szc = reader.GetInt64(15);
			if (!reader.IsDBNull(16)) zcs = reader.GetInt64(16);
			if (!reader.IsDBNull(17)) jzmj = reader.GetDouble(17);
			if (!reader.IsDBNull(18)) qdjg = reader.GetDouble(18);
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
            Ygdj target=new Ygdj();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Bdczl=this.Bdczl;
            target.Ywr=this.Ywr;
            target.Ywrzjzl=this.Ywrzjzl;
            target.Ywrzjh=this.Ywrzjh;
            target.Ygdjzl=this.Ygdjzl;
            target.Djlx=this.Djlx;
            target.Djyy=this.Djyy;
            target.Tdsyqr=this.Tdsyqr;
            target.Ghyt=this.Ghyt;
            target.Fwxz=this.Fwxz;
            target.Fwjg=this.Fwjg;
            target.Szc=this.Szc;
            target.Zcs=this.Zcs;
            target.Jzmj=this.Jzmj;
            target.Qdjg=this.Qdjg;
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
