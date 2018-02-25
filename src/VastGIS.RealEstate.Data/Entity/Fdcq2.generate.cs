
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
    public partial class Fdcq2 : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity,IGlobalEntity,ISurveyEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "FDCQ2";	
        public const string LAYER_NAME = "房地产权（独幢、层、套、间房屋）";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_QLLX = "QLLX";
		public const string COL_DJLX = "DJLX";
		public const string COL_DJYY = "DJYY";
		public const string COL_FDZL = "FDZL";
		public const string COL_TDSYQR = "TDSYQR";
		public const string COL_DYTDMJ = "DYTDMJ";
		public const string COL_FTTDMJ = "FTTDMJ";
		public const string COL_TDSYQSSJ = "TDSYQSSJ";
		public const string COL_TDSYJSSJ = "TDSYJSSJ";
		public const string COL_FDCJYJG = "FDCJYJG";
		public const string COL_GHYT = "GHYT";
		public const string COL_FWXZ = "FWXZ";
		public const string COL_FWJG = "FWJG";
		public const string COL_SZC = "SZC";
		public const string COL_ZCS = "ZCS";
		public const string COL_JZMJ = "JZMJ";
		public const string COL_ZYJZMJ = "ZYJZMJ";
		public const string COL_FTJZMJ = "FTJZMJ";
		public const string COL_JGSJ = "JGSJ";
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
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_QLLX = "@QLLX";	
        public const string PARAM_DJLX = "@DJLX";	
        public const string PARAM_DJYY = "@DJYY";	
        public const string PARAM_FDZL = "@FDZL";	
        public const string PARAM_TDSYQR = "@TDSYQR";	
        public const string PARAM_DYTDMJ = "@DYTDMJ";	
        public const string PARAM_FTTDMJ = "@FTTDMJ";	
        public const string PARAM_TDSYQSSJ = "@TDSYQSSJ";	
        public const string PARAM_TDSYJSSJ = "@TDSYJSSJ";	
        public const string PARAM_FDCJYJG = "@FDCJYJG";	
        public const string PARAM_GHYT = "@GHYT";	
        public const string PARAM_FWXZ = "@FWXZ";	
        public const string PARAM_FWJG = "@FWJG";	
        public const string PARAM_SZC = "@SZC";	
        public const string PARAM_ZCS = "@ZCS";	
        public const string PARAM_JZMJ = "@JZMJ";	
        public const string PARAM_ZYJZMJ = "@ZYJZMJ";	
        public const string PARAM_FTJZMJ = "@FTJZMJ";	
        public const string PARAM_JGSJ = "@JGSJ";	
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
		private const string SQL_QUERY_FDCQ2 ="SELECT  Id,YSDM,BDCDYH,YWH,QLLX,DJLX,DJYY,FDZL,TDSYQR,DYTDMJ,FTTDMJ,TDSYQSSJ,TDSYJSSJ,FDCJYJG,GHYT,FWXZ,FWJG,SZC,ZCS,JZMJ,ZYJZMJ,FTJZMJ,JGSJ,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM FDCQ2 WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_FDCQ2 = "INSERT INTO [FDCQ2] (YSDM, BDCDYH, YWH, QLLX, DJLX, DJYY, FDZL, TDSYQR, DYTDMJ, FTTDMJ, TDSYQSSJ, TDSYJSSJ, FDCJYJG, GHYT, FWXZ, FWJG, SZC, ZCS, JZMJ, ZYJZMJ, FTJZMJ, JGSJ, BDCQZH, QXDM, DJJG, DBR, DJSJ, FJ, QSZT, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @BDCDYH, @YWH, @QLLX, @DJLX, @DJYY, @FDZL, @TDSYQR, @DYTDMJ, @FTTDMJ, @TDSYQSSJ, @TDSYJSSJ, @FDCJYJG, @GHYT, @FWXZ, @FWJG, @SZC, @ZCS, @JZMJ, @ZYJZMJ, @FTJZMJ, @JGSJ, @BDCQZH, @QXDM, @DJJG, @DBR, @DJSJ, @FJ, @QSZT, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_FDCQ2 = "UPDATE [FDCQ2] SET YSDM = @YSDM, BDCDYH = @BDCDYH, YWH = @YWH, QLLX = @QLLX, DJLX = @DJLX, DJYY = @DJYY, FDZL = @FDZL, TDSYQR = @TDSYQR, DYTDMJ = @DYTDMJ, FTTDMJ = @FTTDMJ, TDSYQSSJ = @TDSYQSSJ, TDSYJSSJ = @TDSYJSSJ, FDCJYJG = @FDCJYJG, GHYT = @GHYT, FWXZ = @FWXZ, FWJG = @FWJG, SZC = @SZC, ZCS = @ZCS, JZMJ = @JZMJ, ZYJZMJ = @ZYJZMJ, FTJZMJ = @FTJZMJ, JGSJ = @JGSJ, BDCQZH = @BDCQZH, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, FJ = @FJ, QSZT = @QSZT, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_FDCQ2 = "DELETE FROM [FDCQ2] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_FDCQ2 = "UPDATE [FDCQ2] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
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
        ///房地坐落
		protected string fdzl = default(string);
        ///土地使用权人
		protected string tdsyqr = default(string);
        ///独用土地面积
		protected double? dytdmj = default(double?);
        ///分摊土地面积
		protected double? fttdmj = default(double?);
        ///土地使用起始时间
		protected System.DateTime? tdsyqssj = default(System.DateTime?);
        ///土地使用结束时间
		protected System.DateTime? tdsyjssj = default(System.DateTime?);
        ///房地产交易价格
		protected double? fdcjyjg = default(double?);
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
        ///专有建筑面积
		protected double? zyjzmj = default(double?);
        ///分摊建筑面积
		protected double? ftjzmj = default(double?);
        ///竣工时间
		protected System.DateTime? jgsj = default(System.DateTime?);
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
            get{return "Fdcq2";}
        }
         public string LayerName
        {
            get{return "房地产权（独幢、层、套、间房屋）";}
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
                return string.Format("{0} {1} ({2})","FDCQ2",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","房地产权（独幢、层、套、间房屋）",this.id,this.ysdm);
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
		
        ///房地坐落
        ///[Column(COL_FDZL, PARAM_FDZL )]
        public virtual string Fdzl 
        {
            get { return this.fdzl; }
			set	{ 
                  if(this.fdzl != value)
                    {
                        this.OnPropertyChanging("Fdzl"); 
                        this.fdzl = value;                        
                        this.OnPropertyChanged("Fdzl");
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
		
        ///独用土地面积
        ///[Column(COL_DYTDMJ, PARAM_DYTDMJ )]
        public virtual double? Dytdmj 
        {
            get { return this.dytdmj; }
			set	{ 
                  if(this.dytdmj != value)
                    {
                        this.OnPropertyChanging("Dytdmj"); 
                        this.dytdmj = value;                        
                        this.OnPropertyChanged("Dytdmj");
                    }   
                }
        }	
		
        ///分摊土地面积
        ///[Column(COL_FTTDMJ, PARAM_FTTDMJ )]
        public virtual double? Fttdmj 
        {
            get { return this.fttdmj; }
			set	{ 
                  if(this.fttdmj != value)
                    {
                        this.OnPropertyChanging("Fttdmj"); 
                        this.fttdmj = value;                        
                        this.OnPropertyChanged("Fttdmj");
                    }   
                }
        }	
		
        ///土地使用起始时间
        ///[Column(COL_TDSYQSSJ, PARAM_TDSYQSSJ )]
        public virtual System.DateTime? Tdsyqssj 
        {
            get { return this.tdsyqssj; }
			set	{ 
                  if(this.tdsyqssj != value)
                    {
                        this.OnPropertyChanging("Tdsyqssj"); 
                        this.tdsyqssj = value;                        
                        this.OnPropertyChanged("Tdsyqssj");
                    }   
                }
        }	
		
        ///土地使用结束时间
        ///[Column(COL_TDSYJSSJ, PARAM_TDSYJSSJ )]
        public virtual System.DateTime? Tdsyjssj 
        {
            get { return this.tdsyjssj; }
			set	{ 
                  if(this.tdsyjssj != value)
                    {
                        this.OnPropertyChanging("Tdsyjssj"); 
                        this.tdsyjssj = value;                        
                        this.OnPropertyChanged("Tdsyjssj");
                    }   
                }
        }	
		
        ///房地产交易价格
        ///[Column(COL_FDCJYJG, PARAM_FDCJYJG )]
        public virtual double? Fdcjyjg 
        {
            get { return this.fdcjyjg; }
			set	{ 
                  if(this.fdcjyjg != value)
                    {
                        this.OnPropertyChanging("Fdcjyjg"); 
                        this.fdcjyjg = value;                        
                        this.OnPropertyChanged("Fdcjyjg");
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
		
        ///专有建筑面积
        ///[Column(COL_ZYJZMJ, PARAM_ZYJZMJ )]
        public virtual double? Zyjzmj 
        {
            get { return this.zyjzmj; }
			set	{ 
                  if(this.zyjzmj != value)
                    {
                        this.OnPropertyChanging("Zyjzmj"); 
                        this.zyjzmj = value;                        
                        this.OnPropertyChanged("Zyjzmj");
                    }   
                }
        }	
		
        ///分摊建筑面积
        ///[Column(COL_FTJZMJ, PARAM_FTJZMJ )]
        public virtual double? Ftjzmj 
        {
            get { return this.ftjzmj; }
			set	{ 
                  if(this.ftjzmj != value)
                    {
                        this.OnPropertyChanging("Ftjzmj"); 
                        this.ftjzmj = value;                        
                        this.OnPropertyChanged("Ftjzmj");
                    }   
                }
        }	
		
        ///竣工时间
        ///[Column(COL_JGSJ, PARAM_JGSJ )]
        public virtual System.DateTime? Jgsj 
        {
            get { return this.jgsj; }
			set	{ 
                  if(this.jgsj != value)
                    {
                        this.OnPropertyChanging("Jgsj"); 
                        this.jgsj = value;                        
                        this.OnPropertyChanged("Jgsj");
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
        public Fdcq2()
        {
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.ywh="";
            this.qllx="";
            this.djlx="";
            this.djyy="";
            this.fdzl="";
            this.tdsyqr="";
            this.dytdmj=0.0;
            this.fttdmj=0.0;
            this.tdsyqssj=DateTime.Now;
            this.tdsyjssj=DateTime.Now;
            this.fdcjyjg=0.0;
            this.ghyt="";
            this.fwxz="";
            this.fwjg="";
            this.szc=0;
            this.zcs=0;
            this.jzmj=0.0;
            this.zyjzmj=0.0;
            this.ftjzmj=0.0;
            this.jgsj=DateTime.Now;
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
            Fdcq2 record = obj as Fdcq2;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_FDCQ2,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_FDZL, this.Fdzl);
				command.Parameters.AddWithValue(PARAM_TDSYQR, this.Tdsyqr);
				command.Parameters.AddWithValue(PARAM_DYTDMJ, this.Dytdmj);
				command.Parameters.AddWithValue(PARAM_FTTDMJ, this.Fttdmj);
				command.Parameters.AddWithValue(PARAM_TDSYQSSJ, this.Tdsyqssj);
				command.Parameters.AddWithValue(PARAM_TDSYJSSJ, this.Tdsyjssj);
				command.Parameters.AddWithValue(PARAM_FDCJYJG, this.Fdcjyjg);
				command.Parameters.AddWithValue(PARAM_GHYT, this.Ghyt);
				command.Parameters.AddWithValue(PARAM_FWXZ, this.Fwxz);
				command.Parameters.AddWithValue(PARAM_FWJG, this.Fwjg);
				command.Parameters.AddWithValue(PARAM_SZC, this.Szc);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_JZMJ, this.Jzmj);
				command.Parameters.AddWithValue(PARAM_ZYJZMJ, this.Zyjzmj);
				command.Parameters.AddWithValue(PARAM_FTJZMJ, this.Ftjzmj);
				command.Parameters.AddWithValue(PARAM_JGSJ, this.Jgsj);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_FDCQ2,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_FDZL, this.Fdzl);
				command.Parameters.AddWithValue(PARAM_TDSYQR, this.Tdsyqr);
				command.Parameters.AddWithValue(PARAM_DYTDMJ, this.Dytdmj);
				command.Parameters.AddWithValue(PARAM_FTTDMJ, this.Fttdmj);
				command.Parameters.AddWithValue(PARAM_TDSYQSSJ, this.Tdsyqssj);
				command.Parameters.AddWithValue(PARAM_TDSYJSSJ, this.Tdsyjssj);
				command.Parameters.AddWithValue(PARAM_FDCJYJG, this.Fdcjyjg);
				command.Parameters.AddWithValue(PARAM_GHYT, this.Ghyt);
				command.Parameters.AddWithValue(PARAM_FWXZ, this.Fwxz);
				command.Parameters.AddWithValue(PARAM_FWJG, this.Fwjg);
				command.Parameters.AddWithValue(PARAM_SZC, this.Szc);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_JZMJ, this.Jzmj);
				command.Parameters.AddWithValue(PARAM_ZYJZMJ, this.Zyjzmj);
				command.Parameters.AddWithValue(PARAM_FTJZMJ, this.Ftjzmj);
				command.Parameters.AddWithValue(PARAM_JGSJ, this.Jgsj);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FDCQ2,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_FDCQ2,dao.Connection))
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
			if (!reader.IsDBNull(7)) fdzl = reader.GetString(7);
			if (!reader.IsDBNull(8)) tdsyqr = reader.GetString(8);
			if (!reader.IsDBNull(9)) dytdmj = reader.GetDouble(9);
			if (!reader.IsDBNull(10)) fttdmj = reader.GetDouble(10);
			if (!reader.IsDBNull(11)) tdsyqssj = reader.GetDateTime(11);
			if (!reader.IsDBNull(12)) tdsyjssj = reader.GetDateTime(12);
			if (!reader.IsDBNull(13)) fdcjyjg = reader.GetDouble(13);
			if (!reader.IsDBNull(14)) ghyt = reader.GetString(14);
			if (!reader.IsDBNull(15)) fwxz = reader.GetString(15);
			if (!reader.IsDBNull(16)) fwjg = reader.GetString(16);
			if (!reader.IsDBNull(17)) szc = reader.GetInt64(17);
			if (!reader.IsDBNull(18)) zcs = reader.GetInt64(18);
			if (!reader.IsDBNull(19)) jzmj = reader.GetDouble(19);
			if (!reader.IsDBNull(20)) zyjzmj = reader.GetDouble(20);
			if (!reader.IsDBNull(21)) ftjzmj = reader.GetDouble(21);
			if (!reader.IsDBNull(22)) jgsj = reader.GetDateTime(22);
			if (!reader.IsDBNull(23)) bdcqzh = reader.GetString(23);
			if (!reader.IsDBNull(24)) qxdm = reader.GetString(24);
			if (!reader.IsDBNull(25)) djjg = reader.GetString(25);
			if (!reader.IsDBNull(26)) dbr = reader.GetString(26);
			if (!reader.IsDBNull(27)) djsj = reader.GetDateTime(27);
			if (!reader.IsDBNull(28)) fj = reader.GetString(28);
			if (!reader.IsDBNull(29)) qszt = reader.GetString(29);
			if (!reader.IsDBNull(30)) wxDcy = reader.GetString(30);
			if (!reader.IsDBNull(31)) wxDcsj = reader.GetDateTime(31);
			if (!reader.IsDBNull(32)) wxCly = reader.GetString(32);
			if (!reader.IsDBNull(33)) wxClsj = reader.GetDateTime(33);
			if (!reader.IsDBNull(34)) wxZty = reader.GetString(34);
			if (!reader.IsDBNull(35)) wxZtsj = reader.GetDateTime(35);
			if (!reader.IsDBNull(36)) wxZjy = reader.GetString(36);
			if (!reader.IsDBNull(37)) wxZjsj = reader.GetDateTime(37);
			if (!reader.IsDBNull(38)) wxWydm = reader.GetString(38);
			if (!reader.IsDBNull(39)) databaseid = reader.GetInt64(39);
			if (!reader.IsDBNull(40)) flags = reader.GetInt16(40);
			if (!reader.IsDBNull(41)) xgr = reader.GetString(41);
			if (!reader.IsDBNull(42)) xgsj = reader.GetDateTime(42);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Fdcq2 target=new Fdcq2();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Qllx=this.Qllx;
            target.Djlx=this.Djlx;
            target.Djyy=this.Djyy;
            target.Fdzl=this.Fdzl;
            target.Tdsyqr=this.Tdsyqr;
            target.Dytdmj=this.Dytdmj;
            target.Fttdmj=this.Fttdmj;
            target.Tdsyqssj=this.Tdsyqssj;
            target.Tdsyjssj=this.Tdsyjssj;
            target.Fdcjyjg=this.Fdcjyjg;
            target.Ghyt=this.Ghyt;
            target.Fwxz=this.Fwxz;
            target.Fwjg=this.Fwjg;
            target.Szc=this.Szc;
            target.Zcs=this.Zcs;
            target.Jzmj=this.Jzmj;
            target.Zyjzmj=this.Zyjzmj;
            target.Ftjzmj=this.Ftjzmj;
            target.Jgsj=this.Jgsj;
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
