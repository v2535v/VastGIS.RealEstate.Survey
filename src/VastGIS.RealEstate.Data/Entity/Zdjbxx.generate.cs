
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
    public partial class Zdjbxx : INotifyPropertyChanging, INotifyPropertyChanged,ISurveyFeature,IYsdmEntity,IGlobalEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "ZDJBXX";	
        public const string LAYER_NAME = "宗地";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.Polygon;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_ZDDM = "ZDDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_ZDTZM = "ZDTZM";
		public const string COL_ZL = "ZL";
		public const string COL_ZDMJ = "ZDMJ";
		public const string COL_MJDW = "MJDW";
		public const string COL_YT = "YT";
		public const string COL_DJ = "DJ";
		public const string COL_JG = "JG";
		public const string COL_QLLX = "QLLX";
		public const string COL_QLXZ = "QLXZ";
		public const string COL_QLSDFS = "QLSDFS";
		public const string COL_RJL = "RJL";
		public const string COL_JZMD = "JZMD";
		public const string COL_JZXG = "JZXG";
		public const string COL_ZDSZD = "ZDSZD";
		public const string COL_ZDSZN = "ZDSZN";
		public const string COL_ZDSZX = "ZDSZX";
		public const string COL_ZDSZB = "ZDSZB";
		public const string COL_ZDT = "ZDT";
		public const string COL_TFH = "TFH";
		public const string COL_DJH = "DJH";
		public const string COL_DAH = "DAH";
		public const string COL_BZ = "BZ";
		public const string COL_ZT = "ZT";
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
		public const string COL_GEOMETRY = "geometry";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_ZDDM = "@ZDDM";	
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_ZDTZM = "@ZDTZM";	
        public const string PARAM_ZL = "@ZL";	
        public const string PARAM_ZDMJ = "@ZDMJ";	
        public const string PARAM_MJDW = "@MJDW";	
        public const string PARAM_YT = "@YT";	
        public const string PARAM_DJ = "@DJ";	
        public const string PARAM_JG = "@JG";	
        public const string PARAM_QLLX = "@QLLX";	
        public const string PARAM_QLXZ = "@QLXZ";	
        public const string PARAM_QLSDFS = "@QLSDFS";	
        public const string PARAM_RJL = "@RJL";	
        public const string PARAM_JZMD = "@JZMD";	
        public const string PARAM_JZXG = "@JZXG";	
        public const string PARAM_ZDSZD = "@ZDSZD";	
        public const string PARAM_ZDSZN = "@ZDSZN";	
        public const string PARAM_ZDSZX = "@ZDSZX";	
        public const string PARAM_ZDSZB = "@ZDSZB";	
        public const string PARAM_ZDT = "@ZDT";	
        public const string PARAM_TFH = "@TFH";	
        public const string PARAM_DJH = "@DJH";	
        public const string PARAM_DAH = "@DAH";	
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_ZT = "@ZT";	
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
        public const string PARAM_GEOMETRY = "@geometry";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_ZDJBXX ="SELECT  Id,YSDM,ZDDM,BDCDYH,ZDTZM,ZL,ZDMJ,MJDW,YT,DJ,JG,QLLX,QLXZ,QLSDFS,RJL,JZMD,JZXG,ZDSZD,ZDSZN,ZDSZX,ZDSZB,ZDT,TFH,DJH,DAH,BZ,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM ZDJBXX WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_ZDJBXX = "INSERT INTO [ZDJBXX] (YSDM, ZDDM, BDCDYH, ZDTZM, ZL, ZDMJ, MJDW, YT, DJ, JG, QLLX, QLXZ, QLSDFS, RJL, JZMD, JZXG, ZDSZD, ZDSZN, ZDSZX, ZDSZB, ZDT, TFH, DJH, DAH, BZ, ZT, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @YSDM, @ZDDM, @BDCDYH, @ZDTZM, @ZL, @ZDMJ, @MJDW, @YT, @DJ, @JG, @QLLX, @QLXZ, @QLSDFS, @RJL, @JZMD, @JZXG, @ZDSZD, @ZDSZN, @ZDSZX, @ZDSZB, @ZDT, @TFH, @DJH, @DAH, @BZ, @ZT, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_ZDJBXX = "UPDATE [ZDJBXX] SET YSDM = @YSDM, ZDDM = @ZDDM, BDCDYH = @BDCDYH, ZDTZM = @ZDTZM, ZL = @ZL, ZDMJ = @ZDMJ, MJDW = @MJDW, YT = @YT, DJ = @DJ, JG = @JG, QLLX = @QLLX, QLXZ = @QLXZ, QLSDFS = @QLSDFS, RJL = @RJL, JZMD = @JZMD, JZXG = @JZXG, ZDSZD = @ZDSZD, ZDSZN = @ZDSZN, ZDSZX = @ZDSZX, ZDSZB = @ZDSZB, ZDT = @ZDT, TFH = @TFH, DJH = @DJH, DAH = @DAH, BZ = @BZ, ZT = @ZT, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ,  geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
		
		private const string SQL_DELETE_ZDJBXX = "DELETE FROM [ZDJBXX] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_ZDJBXX = "UPDATE [ZDJBXX] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
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
        ///宗地特征码[字典:宗地（宗海）特征码字典表-ZDZHTZMZD]
		protected string zdtzm = default(string);
        ///坐落
		protected string zl = default(string);
        ///宗地面积
		protected double? zdmj = default(double?);
        ///面积单位[字典:面积单位字典表-MJDWZD]
		protected string mjdw = default(string);
        ///用途
		protected string yt = default(string);
        ///等级[字典:土地等级字典表-TDDJZD]
		protected string dj = default(string);
        ///价格
		protected double? jg = default(double?);
        ///权利类型[字典:权利类型字典表-QLLXZD]
		protected string qllx = default(string);
        ///权利性质[字典:权利性质字典表-QLXZZD]
		protected string qlxz = default(string);
        ///权利设定方式[字典:权利设定方式字典表-QLSDFSZD]
		protected string qlsdfs = default(string);
        ///容积率
		protected double? rjl = default(double?);
        ///建筑密度
		protected double? jzmd = default(double?);
        ///建筑限高
		protected double? jzxg = default(double?);
        ///宗地四至-东
		protected string zdszd = default(string);
        ///宗地四至-南
		protected string zdszn = default(string);
        ///宗地四至-西
		protected string zdszx = default(string);
        ///宗地四至-北
		protected string zdszb = default(string);
        ///宗地图
		protected byte[] zdt = default(byte[]);
        ///图幅号
		protected string tfh = default(string);
        ///地籍号
		protected string djh = default(string);
        ///档案号
		protected string dah = default(string);
        ///备注
		protected string bz = default(string);
        ///状态[字典:不动产单元状态字典表-BDCDYZTZD]
		protected string zt = default(string);
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
            get{return "Zdjbxx";}
        }
         public string LayerName
        {
            get{return "宗地";}
        }
        public string EntityName{
            get{return "ISurveyFeature,IYsdmEntity,IGlobalEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return true;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return true;}}
        public bool HasSurvey{get{return true;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","ZDJBXX",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","宗地",this.id,this.ysdm);
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
		
        ///宗地特征码
        ///[Column(COL_ZDTZM, PARAM_ZDTZM )]
        public virtual string Zdtzm 
        {
            get { return this.zdtzm; }
			set	{ 
                  if(this.zdtzm != value)
                    {
                        this.OnPropertyChanging("Zdtzm"); 
                        this.zdtzm = value;                        
                        this.OnPropertyChanged("Zdtzm");
                    }   
                }
        }	
		
        ///坐落
        ///[Column(COL_ZL, PARAM_ZL )]
        public virtual string Zl 
        {
            get { return this.zl; }
			set	{ 
                  if(this.zl != value)
                    {
                        this.OnPropertyChanging("Zl"); 
                        this.zl = value;                        
                        this.OnPropertyChanged("Zl");
                    }   
                }
        }	
		
        ///宗地面积
        ///[Column(COL_ZDMJ, PARAM_ZDMJ )]
        public virtual double? Zdmj 
        {
            get { return this.zdmj; }
			set	{ 
                  if(this.zdmj != value)
                    {
                        this.OnPropertyChanging("Zdmj"); 
                        this.zdmj = value;                        
                        this.OnPropertyChanged("Zdmj");
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
		
        ///用途
        ///[Column(COL_YT, PARAM_YT )]
        public virtual string Yt 
        {
            get { return this.yt; }
			set	{ 
                  if(this.yt != value)
                    {
                        this.OnPropertyChanging("Yt"); 
                        this.yt = value;                        
                        this.OnPropertyChanged("Yt");
                    }   
                }
        }	
		
        ///等级
        ///[Column(COL_DJ, PARAM_DJ )]
        public virtual string Dj 
        {
            get { return this.dj; }
			set	{ 
                  if(this.dj != value)
                    {
                        this.OnPropertyChanging("Dj"); 
                        this.dj = value;                        
                        this.OnPropertyChanged("Dj");
                    }   
                }
        }	
		
        ///价格
        ///[Column(COL_JG, PARAM_JG )]
        public virtual double? Jg 
        {
            get { return this.jg; }
			set	{ 
                  if(this.jg != value)
                    {
                        this.OnPropertyChanging("Jg"); 
                        this.jg = value;                        
                        this.OnPropertyChanged("Jg");
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
		
        ///权利性质
        ///[Column(COL_QLXZ, PARAM_QLXZ )]
        public virtual string Qlxz 
        {
            get { return this.qlxz; }
			set	{ 
                  if(this.qlxz != value)
                    {
                        this.OnPropertyChanging("Qlxz"); 
                        this.qlxz = value;                        
                        this.OnPropertyChanged("Qlxz");
                    }   
                }
        }	
		
        ///权利设定方式
        ///[Column(COL_QLSDFS, PARAM_QLSDFS )]
        public virtual string Qlsdfs 
        {
            get { return this.qlsdfs; }
			set	{ 
                  if(this.qlsdfs != value)
                    {
                        this.OnPropertyChanging("Qlsdfs"); 
                        this.qlsdfs = value;                        
                        this.OnPropertyChanged("Qlsdfs");
                    }   
                }
        }	
		
        ///容积率
        ///[Column(COL_RJL, PARAM_RJL )]
        public virtual double? Rjl 
        {
            get { return this.rjl; }
			set	{ 
                  if(this.rjl != value)
                    {
                        this.OnPropertyChanging("Rjl"); 
                        this.rjl = value;                        
                        this.OnPropertyChanged("Rjl");
                    }   
                }
        }	
		
        ///建筑密度
        ///[Column(COL_JZMD, PARAM_JZMD )]
        public virtual double? Jzmd 
        {
            get { return this.jzmd; }
			set	{ 
                  if(this.jzmd != value)
                    {
                        this.OnPropertyChanging("Jzmd"); 
                        this.jzmd = value;                        
                        this.OnPropertyChanged("Jzmd");
                    }   
                }
        }	
		
        ///建筑限高
        ///[Column(COL_JZXG, PARAM_JZXG )]
        public virtual double? Jzxg 
        {
            get { return this.jzxg; }
			set	{ 
                  if(this.jzxg != value)
                    {
                        this.OnPropertyChanging("Jzxg"); 
                        this.jzxg = value;                        
                        this.OnPropertyChanged("Jzxg");
                    }   
                }
        }	
		
        ///宗地四至-东
        ///[Column(COL_ZDSZD, PARAM_ZDSZD )]
        public virtual string Zdszd 
        {
            get { return this.zdszd; }
			set	{ 
                  if(this.zdszd != value)
                    {
                        this.OnPropertyChanging("Zdszd"); 
                        this.zdszd = value;                        
                        this.OnPropertyChanged("Zdszd");
                    }   
                }
        }	
		
        ///宗地四至-南
        ///[Column(COL_ZDSZN, PARAM_ZDSZN )]
        public virtual string Zdszn 
        {
            get { return this.zdszn; }
			set	{ 
                  if(this.zdszn != value)
                    {
                        this.OnPropertyChanging("Zdszn"); 
                        this.zdszn = value;                        
                        this.OnPropertyChanged("Zdszn");
                    }   
                }
        }	
		
        ///宗地四至-西
        ///[Column(COL_ZDSZX, PARAM_ZDSZX )]
        public virtual string Zdszx 
        {
            get { return this.zdszx; }
			set	{ 
                  if(this.zdszx != value)
                    {
                        this.OnPropertyChanging("Zdszx"); 
                        this.zdszx = value;                        
                        this.OnPropertyChanged("Zdszx");
                    }   
                }
        }	
		
        ///宗地四至-北
        ///[Column(COL_ZDSZB, PARAM_ZDSZB )]
        public virtual string Zdszb 
        {
            get { return this.zdszb; }
			set	{ 
                  if(this.zdszb != value)
                    {
                        this.OnPropertyChanging("Zdszb"); 
                        this.zdszb = value;                        
                        this.OnPropertyChanged("Zdszb");
                    }   
                }
        }	
		
        ///宗地图
        ///[Column(COL_ZDT, PARAM_ZDT )]
        public virtual byte[] Zdt 
        {
            get { return this.zdt; }
			set	{ 
                  if(this.zdt != value)
                    {
                        this.OnPropertyChanging("Zdt"); 
                        this.zdt = value;                        
                        this.OnPropertyChanged("Zdt");
                    }   
                }
        }	
		
        ///图幅号
        ///[Column(COL_TFH, PARAM_TFH )]
        public virtual string Tfh 
        {
            get { return this.tfh; }
			set	{ 
                  if(this.tfh != value)
                    {
                        this.OnPropertyChanging("Tfh"); 
                        this.tfh = value;                        
                        this.OnPropertyChanged("Tfh");
                    }   
                }
        }	
		
        ///地籍号
        ///[Column(COL_DJH, PARAM_DJH )]
        public virtual string Djh 
        {
            get { return this.djh; }
			set	{ 
                  if(this.djh != value)
                    {
                        this.OnPropertyChanging("Djh"); 
                        this.djh = value;                        
                        this.OnPropertyChanged("Djh");
                    }   
                }
        }	
		
        ///档案号
        ///[Column(COL_DAH, PARAM_DAH )]
        public virtual string Dah 
        {
            get { return this.dah; }
			set	{ 
                  if(this.dah != value)
                    {
                        this.OnPropertyChanging("Dah"); 
                        this.dah = value;                        
                        this.OnPropertyChanged("Dah");
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
		
        ///状态
        ///[Column(COL_ZT, PARAM_ZT )]
        public virtual string Zt 
        {
            get { return this.zt; }
			set	{ 
                  if(this.zt != value)
                    {
                        this.OnPropertyChanging("Zt"); 
                        this.zt = value;                        
                        this.OnPropertyChanged("Zt");
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
        public Zdjbxx()
        {
            _geometry=new Geometry(GEOMETRY_TYPE,ZValueType.None);
            this.id=0;
            this.ysdm="";
            this.zddm="";
            this.bdcdyh="";
            this.zdtzm="";
            this.zl="";
            this.zdmj=0.0;
            this.mjdw="";
            this.yt="";
            this.dj="";
            this.jg=0.0;
            this.qllx="";
            this.qlxz="";
            this.qlsdfs="";
            this.rjl=0.0;
            this.jzmd=0.0;
            this.jzxg=0.0;
            this.zdszd="";
            this.zdszn="";
            this.zdszx="";
            this.zdszb="";
            
            this.tfh="";
            this.djh="";
            this.dah="";
            this.bz="";
            this.zt="";
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
            Zdjbxx record = obj as Zdjbxx;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZDJBXX,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZDDM, this.Zddm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_ZDTZM, this.Zdtzm);
				command.Parameters.AddWithValue(PARAM_ZL, this.Zl);
				command.Parameters.AddWithValue(PARAM_ZDMJ, this.Zdmj);
				command.Parameters.AddWithValue(PARAM_MJDW, this.Mjdw);
				command.Parameters.AddWithValue(PARAM_YT, this.Yt);
				command.Parameters.AddWithValue(PARAM_DJ, this.Dj);
				command.Parameters.AddWithValue(PARAM_JG, this.Jg);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_QLXZ, this.Qlxz);
				command.Parameters.AddWithValue(PARAM_QLSDFS, this.Qlsdfs);
				command.Parameters.AddWithValue(PARAM_RJL, this.Rjl);
				command.Parameters.AddWithValue(PARAM_JZMD, this.Jzmd);
				command.Parameters.AddWithValue(PARAM_JZXG, this.Jzxg);
				command.Parameters.AddWithValue(PARAM_ZDSZD, this.Zdszd);
				command.Parameters.AddWithValue(PARAM_ZDSZN, this.Zdszn);
				command.Parameters.AddWithValue(PARAM_ZDSZX, this.Zdszx);
				command.Parameters.AddWithValue(PARAM_ZDSZB, this.Zdszb);
				command.Parameters.AddWithValue(PARAM_ZDT, this.Zdt);
				command.Parameters.AddWithValue(PARAM_TFH, this.Tfh);
				command.Parameters.AddWithValue(PARAM_DJH, this.Djh);
				command.Parameters.AddWithValue(PARAM_DAH, this.Dah);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
				command.Parameters.AddWithValue(PARAM_ZT, this.Zt);
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
                command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZDJBXX,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_ZDTZM, this.Zdtzm);
				command.Parameters.AddWithValue(PARAM_ZL, this.Zl);
				command.Parameters.AddWithValue(PARAM_ZDMJ, this.Zdmj);
				command.Parameters.AddWithValue(PARAM_MJDW, this.Mjdw);
				command.Parameters.AddWithValue(PARAM_YT, this.Yt);
				command.Parameters.AddWithValue(PARAM_DJ, this.Dj);
				command.Parameters.AddWithValue(PARAM_JG, this.Jg);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_QLXZ, this.Qlxz);
				command.Parameters.AddWithValue(PARAM_QLSDFS, this.Qlsdfs);
				command.Parameters.AddWithValue(PARAM_RJL, this.Rjl);
				command.Parameters.AddWithValue(PARAM_JZMD, this.Jzmd);
				command.Parameters.AddWithValue(PARAM_JZXG, this.Jzxg);
				command.Parameters.AddWithValue(PARAM_ZDSZD, this.Zdszd);
				command.Parameters.AddWithValue(PARAM_ZDSZN, this.Zdszn);
				command.Parameters.AddWithValue(PARAM_ZDSZX, this.Zdszx);
				command.Parameters.AddWithValue(PARAM_ZDSZB, this.Zdszb);
				command.Parameters.AddWithValue(PARAM_ZDT, this.Zdt);
				command.Parameters.AddWithValue(PARAM_TFH, this.Tfh);
				command.Parameters.AddWithValue(PARAM_DJH, this.Djh);
				command.Parameters.AddWithValue(PARAM_DAH, this.Dah);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
				command.Parameters.AddWithValue(PARAM_ZT, this.Zt);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZDJBXX,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_ZDJBXX,dao.Connection))
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
			if (!reader.IsDBNull(4)) zdtzm = reader.GetString(4);
			if (!reader.IsDBNull(5)) zl = reader.GetString(5);
			if (!reader.IsDBNull(6)) zdmj = reader.GetDouble(6);
			if (!reader.IsDBNull(7)) mjdw = reader.GetString(7);
			if (!reader.IsDBNull(8)) yt = reader.GetString(8);
			if (!reader.IsDBNull(9)) dj = reader.GetString(9);
			if (!reader.IsDBNull(10)) jg = reader.GetDouble(10);
			if (!reader.IsDBNull(11)) qllx = reader.GetString(11);
			if (!reader.IsDBNull(12)) qlxz = reader.GetString(12);
			if (!reader.IsDBNull(13)) qlsdfs = reader.GetString(13);
			if (!reader.IsDBNull(14)) rjl = reader.GetDouble(14);
			if (!reader.IsDBNull(15)) jzmd = reader.GetDouble(15);
			if (!reader.IsDBNull(16)) jzxg = reader.GetDouble(16);
			if (!reader.IsDBNull(17)) zdszd = reader.GetString(17);
			if (!reader.IsDBNull(18)) zdszn = reader.GetString(18);
			if (!reader.IsDBNull(19)) zdszx = reader.GetString(19);
			if (!reader.IsDBNull(20)) zdszb = reader.GetString(20);
			if (!reader.IsDBNull(21)) zdt = SQLiteHelper.GetBytes(reader,"ZDT");
			if (!reader.IsDBNull(22)) tfh = reader.GetString(22);
			if (!reader.IsDBNull(23)) djh = reader.GetString(23);
			if (!reader.IsDBNull(24)) dah = reader.GetString(24);
			if (!reader.IsDBNull(25)) bz = reader.GetString(25);
			if (!reader.IsDBNull(26)) zt = reader.GetString(26);
			if (!reader.IsDBNull(27)) wxDcy = reader.GetString(27);
			if (!reader.IsDBNull(28)) wxDcsj = reader.GetDateTime(28);
			if (!reader.IsDBNull(29)) wxCly = reader.GetString(29);
			if (!reader.IsDBNull(30)) wxClsj = reader.GetDateTime(30);
			if (!reader.IsDBNull(31)) wxZty = reader.GetString(31);
			if (!reader.IsDBNull(32)) wxZtsj = reader.GetDateTime(32);
			if (!reader.IsDBNull(33)) wxZjy = reader.GetString(33);
			if (!reader.IsDBNull(34)) wxZjsj = reader.GetDateTime(34);
			if (!reader.IsDBNull(35)) wxWydm = reader.GetString(35);
			if (!reader.IsDBNull(36)) databaseid = reader.GetInt64(36);
			if (!reader.IsDBNull(37)) flags = reader.GetInt16(37);
			if (!reader.IsDBNull(38)) xgr = reader.GetString(38);
			if (!reader.IsDBNull(39)) xgsj = reader.GetDateTime(39);
			if (!reader.IsDBNull(40)) this.Wkt=reader.GetString(40);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Zdjbxx target=new Zdjbxx();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Zddm=this.Zddm;
            target.Bdcdyh=this.Bdcdyh;
            target.Zdtzm=this.Zdtzm;
            target.Zl=this.Zl;
            target.Zdmj=this.Zdmj;
            target.Mjdw=this.Mjdw;
            target.Yt=this.Yt;
            target.Dj=this.Dj;
            target.Jg=this.Jg;
            target.Qllx=this.Qllx;
            target.Qlxz=this.Qlxz;
            target.Qlsdfs=this.Qlsdfs;
            target.Rjl=this.Rjl;
            target.Jzmd=this.Jzmd;
            target.Jzxg=this.Jzxg;
            target.Zdszd=this.Zdszd;
            target.Zdszn=this.Zdszn;
            target.Zdszx=this.Zdszx;
            target.Zdszb=this.Zdszb;
            target.Zdt=this.Zdt;
            target.Tfh=this.Tfh;
            target.Djh=this.Djh;
            target.Dah=this.Dah;
            target.Bz=this.Bz;
            target.Zt=this.Zt;
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
