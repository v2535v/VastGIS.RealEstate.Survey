
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
    public partial class Zrz : INotifyPropertyChanging, INotifyPropertyChanged,ISurveyFeature,IYsdmEntity,IGlobalEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "ZRZ";	
        public const string LAYER_NAME = "自然幢";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.Polygon;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_ZDDM = "ZDDM";
		public const string COL_ZRZH = "ZRZH";
		public const string COL_XMMC = "XMMC";
		public const string COL_JZWMC = "JZWMC";
		public const string COL_JGRQ = "JGRQ";
		public const string COL_JZWGD = "JZWGD";
		public const string COL_ZZDMJ = "ZZDMJ";
		public const string COL_ZYDMJ = "ZYDMJ";
		public const string COL_YCJZMJ = "YCJZMJ";
		public const string COL_SCJZMJ = "SCJZMJ";
		public const string COL_ZCS = "ZCS";
		public const string COL_DSCS = "DSCS";
		public const string COL_DXCS = "DXCS";
		public const string COL_DXSD = "DXSD";
		public const string COL_GHYT = "GHYT";
		public const string COL_FWJG = "FWJG";
		public const string COL_ZTS = "ZTS";
		public const string COL_JZWJBYT = "JZWJBYT";
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
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_ZDDM = "@ZDDM";	
        public const string PARAM_ZRZH = "@ZRZH";	
        public const string PARAM_XMMC = "@XMMC";	
        public const string PARAM_JZWMC = "@JZWMC";	
        public const string PARAM_JGRQ = "@JGRQ";	
        public const string PARAM_JZWGD = "@JZWGD";	
        public const string PARAM_ZZDMJ = "@ZZDMJ";	
        public const string PARAM_ZYDMJ = "@ZYDMJ";	
        public const string PARAM_YCJZMJ = "@YCJZMJ";	
        public const string PARAM_SCJZMJ = "@SCJZMJ";	
        public const string PARAM_ZCS = "@ZCS";	
        public const string PARAM_DSCS = "@DSCS";	
        public const string PARAM_DXCS = "@DXCS";	
        public const string PARAM_DXSD = "@DXSD";	
        public const string PARAM_GHYT = "@GHYT";	
        public const string PARAM_FWJG = "@FWJG";	
        public const string PARAM_ZTS = "@ZTS";	
        public const string PARAM_JZWJBYT = "@JZWJBYT";	
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
		private const string SQL_QUERY_ZRZ ="SELECT  Id,YSDM,BDCDYH,ZDDM,ZRZH,XMMC,JZWMC,JGRQ,JZWGD,ZZDMJ,ZYDMJ,YCJZMJ,SCJZMJ,ZCS,DSCS,DXCS,DXSD,GHYT,FWJG,ZTS,JZWJBYT,DAH,BZ,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM ZRZ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_ZRZ = "INSERT INTO [ZRZ] (YSDM, BDCDYH, ZDDM, ZRZH, XMMC, JZWMC, JGRQ, JZWGD, ZZDMJ, ZYDMJ, YCJZMJ, SCJZMJ, ZCS, DSCS, DXCS, DXSD, GHYT, FWJG, ZTS, JZWJBYT, DAH, BZ, ZT, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @YSDM, @BDCDYH, @ZDDM, @ZRZH, @XMMC, @JZWMC, @JGRQ, @JZWGD, @ZZDMJ, @ZYDMJ, @YCJZMJ, @SCJZMJ, @ZCS, @DSCS, @DXCS, @DXSD, @GHYT, @FWJG, @ZTS, @JZWJBYT, @DAH, @BZ, @ZT, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_ZRZ = "UPDATE [ZRZ] SET YSDM = @YSDM, BDCDYH = @BDCDYH, ZDDM = @ZDDM, ZRZH = @ZRZH, XMMC = @XMMC, JZWMC = @JZWMC, JGRQ = @JGRQ, JZWGD = @JZWGD, ZZDMJ = @ZZDMJ, ZYDMJ = @ZYDMJ, YCJZMJ = @YCJZMJ, SCJZMJ = @SCJZMJ, ZCS = @ZCS, DSCS = @DSCS, DXCS = @DXCS, DXSD = @DXSD, GHYT = @GHYT, FWJG = @FWJG, ZTS = @ZTS, JZWJBYT = @JZWJBYT, DAH = @DAH, BZ = @BZ, ZT = @ZT, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ,  geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
		
		private const string SQL_DELETE_ZRZ = "DELETE FROM [ZRZ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_ZRZ = "UPDATE [ZRZ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///不动产单元号
		protected string bdcdyh = default(string);
        ///宗地代码
		protected string zddm = default(string);
        ///自然幢号
		protected string zrzh = default(string);
        ///项目名称
		protected string xmmc = default(string);
        ///建筑物名称
		protected string jzwmc = default(string);
        ///竣工日期
		protected System.DateTime? jgrq = default(System.DateTime?);
        ///建筑物高度
		protected double? jzwgd = default(double?);
        ///幢占地面积
		protected double? zzdmj = default(double?);
        ///幢用地面积
		protected double? zydmj = default(double?);
        ///预测建筑面积
		protected double? ycjzmj = default(double?);
        ///实测建筑面积
		protected double? scjzmj = default(double?);
        ///总层数
		protected long? zcs = default(long?);
        ///地上层数
		protected long? dscs = default(long?);
        ///地下层数
		protected long? dxcs = default(long?);
        ///地下深度
		protected double? dxsd = default(double?);
        ///规划用途[字典:房屋用途字典表-FWYTZD]
		protected string ghyt = default(string);
        ///房屋结构[字典:房屋结构字典表-FWJGZD]
		protected string fwjg = default(string);
        ///总套数
		protected long? zts = default(long?);
        ///建筑物基本用途
		protected string jzwjbyt = default(string);
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
            get{return "Zrz";}
        }
         public string LayerName
        {
            get{return "自然幢";}
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
                return string.Format("{0} {1} ({2})","ZRZ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","自然幢",this.id,this.ysdm);
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
		
        ///自然幢号
        ///[Column(COL_ZRZH, PARAM_ZRZH )]
        public virtual string Zrzh 
        {
            get { return this.zrzh; }
			set	{ 
                  if(this.zrzh != value)
                    {
                        this.OnPropertyChanging("Zrzh"); 
                        this.zrzh = value;                        
                        this.OnPropertyChanged("Zrzh");
                    }   
                }
        }	
		
        ///项目名称
        ///[Column(COL_XMMC, PARAM_XMMC )]
        public virtual string Xmmc 
        {
            get { return this.xmmc; }
			set	{ 
                  if(this.xmmc != value)
                    {
                        this.OnPropertyChanging("Xmmc"); 
                        this.xmmc = value;                        
                        this.OnPropertyChanged("Xmmc");
                    }   
                }
        }	
		
        ///建筑物名称
        ///[Column(COL_JZWMC, PARAM_JZWMC )]
        public virtual string Jzwmc 
        {
            get { return this.jzwmc; }
			set	{ 
                  if(this.jzwmc != value)
                    {
                        this.OnPropertyChanging("Jzwmc"); 
                        this.jzwmc = value;                        
                        this.OnPropertyChanged("Jzwmc");
                    }   
                }
        }	
		
        ///竣工日期
        ///[Column(COL_JGRQ, PARAM_JGRQ )]
        public virtual System.DateTime? Jgrq 
        {
            get { return this.jgrq; }
			set	{ 
                  if(this.jgrq != value)
                    {
                        this.OnPropertyChanging("Jgrq"); 
                        this.jgrq = value;                        
                        this.OnPropertyChanged("Jgrq");
                    }   
                }
        }	
		
        ///建筑物高度
        ///[Column(COL_JZWGD, PARAM_JZWGD )]
        public virtual double? Jzwgd 
        {
            get { return this.jzwgd; }
			set	{ 
                  if(this.jzwgd != value)
                    {
                        this.OnPropertyChanging("Jzwgd"); 
                        this.jzwgd = value;                        
                        this.OnPropertyChanged("Jzwgd");
                    }   
                }
        }	
		
        ///幢占地面积
        ///[Column(COL_ZZDMJ, PARAM_ZZDMJ )]
        public virtual double? Zzdmj 
        {
            get { return this.zzdmj; }
			set	{ 
                  if(this.zzdmj != value)
                    {
                        this.OnPropertyChanging("Zzdmj"); 
                        this.zzdmj = value;                        
                        this.OnPropertyChanged("Zzdmj");
                    }   
                }
        }	
		
        ///幢用地面积
        ///[Column(COL_ZYDMJ, PARAM_ZYDMJ )]
        public virtual double? Zydmj 
        {
            get { return this.zydmj; }
			set	{ 
                  if(this.zydmj != value)
                    {
                        this.OnPropertyChanging("Zydmj"); 
                        this.zydmj = value;                        
                        this.OnPropertyChanged("Zydmj");
                    }   
                }
        }	
		
        ///预测建筑面积
        ///[Column(COL_YCJZMJ, PARAM_YCJZMJ )]
        public virtual double? Ycjzmj 
        {
            get { return this.ycjzmj; }
			set	{ 
                  if(this.ycjzmj != value)
                    {
                        this.OnPropertyChanging("Ycjzmj"); 
                        this.ycjzmj = value;                        
                        this.OnPropertyChanged("Ycjzmj");
                    }   
                }
        }	
		
        ///实测建筑面积
        ///[Column(COL_SCJZMJ, PARAM_SCJZMJ )]
        public virtual double? Scjzmj 
        {
            get { return this.scjzmj; }
			set	{ 
                  if(this.scjzmj != value)
                    {
                        this.OnPropertyChanging("Scjzmj"); 
                        this.scjzmj = value;                        
                        this.OnPropertyChanged("Scjzmj");
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
		
        ///地上层数
        ///[Column(COL_DSCS, PARAM_DSCS )]
        public virtual long? Dscs 
        {
            get { return this.dscs; }
			set	{ 
                  if(this.dscs != value)
                    {
                        this.OnPropertyChanging("Dscs"); 
                        this.dscs = value;                        
                        this.OnPropertyChanged("Dscs");
                    }   
                }
        }	
		
        ///地下层数
        ///[Column(COL_DXCS, PARAM_DXCS )]
        public virtual long? Dxcs 
        {
            get { return this.dxcs; }
			set	{ 
                  if(this.dxcs != value)
                    {
                        this.OnPropertyChanging("Dxcs"); 
                        this.dxcs = value;                        
                        this.OnPropertyChanged("Dxcs");
                    }   
                }
        }	
		
        ///地下深度
        ///[Column(COL_DXSD, PARAM_DXSD )]
        public virtual double? Dxsd 
        {
            get { return this.dxsd; }
			set	{ 
                  if(this.dxsd != value)
                    {
                        this.OnPropertyChanging("Dxsd"); 
                        this.dxsd = value;                        
                        this.OnPropertyChanged("Dxsd");
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
		
        ///总套数
        ///[Column(COL_ZTS, PARAM_ZTS )]
        public virtual long? Zts 
        {
            get { return this.zts; }
			set	{ 
                  if(this.zts != value)
                    {
                        this.OnPropertyChanging("Zts"); 
                        this.zts = value;                        
                        this.OnPropertyChanged("Zts");
                    }   
                }
        }	
		
        ///建筑物基本用途
        ///[Column(COL_JZWJBYT, PARAM_JZWJBYT )]
        public virtual string Jzwjbyt 
        {
            get { return this.jzwjbyt; }
			set	{ 
                  if(this.jzwjbyt != value)
                    {
                        this.OnPropertyChanging("Jzwjbyt"); 
                        this.jzwjbyt = value;                        
                        this.OnPropertyChanged("Jzwjbyt");
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
        public Zrz()
        {
            _geometry=new Geometry(GEOMETRY_TYPE,ZValueType.None);
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.zddm="";
            this.zrzh="";
            this.xmmc="";
            this.jzwmc="";
            this.jgrq=DateTime.Now;
            this.jzwgd=0.0;
            this.zzdmj=0.0;
            this.zydmj=0.0;
            this.ycjzmj=0.0;
            this.scjzmj=0.0;
            this.zcs=0;
            this.dscs=0;
            this.dxcs=0;
            this.dxsd=0.0;
            this.ghyt="";
            this.fwjg="";
            this.zts=0;
            this.jzwjbyt="";
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
            Zrz record = obj as Zrz;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZRZ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_ZDDM, this.Zddm);
				command.Parameters.AddWithValue(PARAM_ZRZH, this.Zrzh);
				command.Parameters.AddWithValue(PARAM_XMMC, this.Xmmc);
				command.Parameters.AddWithValue(PARAM_JZWMC, this.Jzwmc);
				command.Parameters.AddWithValue(PARAM_JGRQ, this.Jgrq);
				command.Parameters.AddWithValue(PARAM_JZWGD, this.Jzwgd);
				command.Parameters.AddWithValue(PARAM_ZZDMJ, this.Zzdmj);
				command.Parameters.AddWithValue(PARAM_ZYDMJ, this.Zydmj);
				command.Parameters.AddWithValue(PARAM_YCJZMJ, this.Ycjzmj);
				command.Parameters.AddWithValue(PARAM_SCJZMJ, this.Scjzmj);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_DSCS, this.Dscs);
				command.Parameters.AddWithValue(PARAM_DXCS, this.Dxcs);
				command.Parameters.AddWithValue(PARAM_DXSD, this.Dxsd);
				command.Parameters.AddWithValue(PARAM_GHYT, this.Ghyt);
				command.Parameters.AddWithValue(PARAM_FWJG, this.Fwjg);
				command.Parameters.AddWithValue(PARAM_ZTS, this.Zts);
				command.Parameters.AddWithValue(PARAM_JZWJBYT, this.Jzwjbyt);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZRZ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_ZDDM, this.Zddm);
				command.Parameters.AddWithValue(PARAM_ZRZH, this.Zrzh);
				command.Parameters.AddWithValue(PARAM_XMMC, this.Xmmc);
				command.Parameters.AddWithValue(PARAM_JZWMC, this.Jzwmc);
				command.Parameters.AddWithValue(PARAM_JGRQ, this.Jgrq);
				command.Parameters.AddWithValue(PARAM_JZWGD, this.Jzwgd);
				command.Parameters.AddWithValue(PARAM_ZZDMJ, this.Zzdmj);
				command.Parameters.AddWithValue(PARAM_ZYDMJ, this.Zydmj);
				command.Parameters.AddWithValue(PARAM_YCJZMJ, this.Ycjzmj);
				command.Parameters.AddWithValue(PARAM_SCJZMJ, this.Scjzmj);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_DSCS, this.Dscs);
				command.Parameters.AddWithValue(PARAM_DXCS, this.Dxcs);
				command.Parameters.AddWithValue(PARAM_DXSD, this.Dxsd);
				command.Parameters.AddWithValue(PARAM_GHYT, this.Ghyt);
				command.Parameters.AddWithValue(PARAM_FWJG, this.Fwjg);
				command.Parameters.AddWithValue(PARAM_ZTS, this.Zts);
				command.Parameters.AddWithValue(PARAM_JZWJBYT, this.Jzwjbyt);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZRZ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_ZRZ,dao.Connection))
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
			if (!reader.IsDBNull(3)) zddm = reader.GetString(3);
			if (!reader.IsDBNull(4)) zrzh = reader.GetString(4);
			if (!reader.IsDBNull(5)) xmmc = reader.GetString(5);
			if (!reader.IsDBNull(6)) jzwmc = reader.GetString(6);
			if (!reader.IsDBNull(7)) jgrq = reader.GetDateTime(7);
			if (!reader.IsDBNull(8)) jzwgd = reader.GetDouble(8);
			if (!reader.IsDBNull(9)) zzdmj = reader.GetDouble(9);
			if (!reader.IsDBNull(10)) zydmj = reader.GetDouble(10);
			if (!reader.IsDBNull(11)) ycjzmj = reader.GetDouble(11);
			if (!reader.IsDBNull(12)) scjzmj = reader.GetDouble(12);
			if (!reader.IsDBNull(13)) zcs = reader.GetInt64(13);
			if (!reader.IsDBNull(14)) dscs = reader.GetInt64(14);
			if (!reader.IsDBNull(15)) dxcs = reader.GetInt64(15);
			if (!reader.IsDBNull(16)) dxsd = reader.GetDouble(16);
			if (!reader.IsDBNull(17)) ghyt = reader.GetString(17);
			if (!reader.IsDBNull(18)) fwjg = reader.GetString(18);
			if (!reader.IsDBNull(19)) zts = reader.GetInt64(19);
			if (!reader.IsDBNull(20)) jzwjbyt = reader.GetString(20);
			if (!reader.IsDBNull(21)) dah = reader.GetString(21);
			if (!reader.IsDBNull(22)) bz = reader.GetString(22);
			if (!reader.IsDBNull(23)) zt = reader.GetString(23);
			if (!reader.IsDBNull(24)) wxDcy = reader.GetString(24);
			if (!reader.IsDBNull(25)) wxDcsj = reader.GetDateTime(25);
			if (!reader.IsDBNull(26)) wxCly = reader.GetString(26);
			if (!reader.IsDBNull(27)) wxClsj = reader.GetDateTime(27);
			if (!reader.IsDBNull(28)) wxZty = reader.GetString(28);
			if (!reader.IsDBNull(29)) wxZtsj = reader.GetDateTime(29);
			if (!reader.IsDBNull(30)) wxZjy = reader.GetString(30);
			if (!reader.IsDBNull(31)) wxZjsj = reader.GetDateTime(31);
			if (!reader.IsDBNull(32)) wxWydm = reader.GetString(32);
			if (!reader.IsDBNull(33)) databaseid = reader.GetInt64(33);
			if (!reader.IsDBNull(34)) flags = reader.GetInt16(34);
			if (!reader.IsDBNull(35)) xgr = reader.GetString(35);
			if (!reader.IsDBNull(36)) xgsj = reader.GetDateTime(36);
			if (!reader.IsDBNull(37)) this.Wkt=reader.GetString(37);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Zrz target=new Zrz();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Zddm=this.Zddm;
            target.Zrzh=this.Zrzh;
            target.Xmmc=this.Xmmc;
            target.Jzwmc=this.Jzwmc;
            target.Jgrq=this.Jgrq;
            target.Jzwgd=this.Jzwgd;
            target.Zzdmj=this.Zzdmj;
            target.Zydmj=this.Zydmj;
            target.Ycjzmj=this.Ycjzmj;
            target.Scjzmj=this.Scjzmj;
            target.Zcs=this.Zcs;
            target.Dscs=this.Dscs;
            target.Dxcs=this.Dxcs;
            target.Dxsd=this.Dxsd;
            target.Ghyt=this.Ghyt;
            target.Fwjg=this.Fwjg;
            target.Zts=this.Zts;
            target.Jzwjbyt=this.Jzwjbyt;
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
