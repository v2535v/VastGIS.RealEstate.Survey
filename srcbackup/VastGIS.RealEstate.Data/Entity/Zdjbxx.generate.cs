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
using VastGIS.RealEstate.Data.Interface;
using VastGIS.Shared;

namespace VastGIS.RealEstate.Data.Entity
{
    public partial class Zdjbxx:INotifyPropertyChanging,INotifyPropertyChanged,ISurveyFeature
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"YSDM",false},{"ZDDM",false},{"BDCDYH",false},{"ZDTZM",false},{"ZL",true},{"ZDMJ",false},{"MJDW",false},{"YT",false},{"DJ",false},{"JG",false},{"QLLX",false},{"QLXZ",false},{"QLSDFS",false},{"RJL",false},{"JZMD",false},{"JZXG",false},{"ZDSZD",true},{"ZDSZN",true},{"ZDSZX",true},{"ZDSZB",true},{"ZDT",false},{"TFH",false},{"DJH",false},{"DAH",false},{"BZ",false},{"ZT",false},{"WX_DCY",true},{"WX_DCSJ",false},{"WX_CLY",true},{"WX_CLSJ",false},{"WX_ZTY",true},{"WX_ZTSJ",false},{"WX_ZJY",true},{"WX_ZJSJ",false},{"WX_WYDM",false},{"DatabaseId",false},{"FLAGS",false},{"XGR",false},{"XGSJ",false},{"geometry",false}};
        public const string TABLE_NAME = "ZDJBXX";
        public const string LAYER_NAME="宗地";
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
        
        #region 查询	
	    private const string SQL_INSERT_ZDJBXX = "INSERT INTO ZDJBXX (YSDM, ZDDM, BDCDYH, ZDTZM, ZL, ZDMJ, MJDW, YT, DJ, JG, QLLX, QLXZ, QLSDFS, RJL, JZMD, JZXG, ZDSZD, ZDSZN, ZDSZX, ZDSZB, ZDT, TFH, DJH, DAH, BZ, ZT, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @YSDM, @ZDDM, @BDCDYH, @ZDTZM, @ZL, @ZDMJ, @MJDW, @YT, @DJ, @JG, @QLLX, @QLXZ, @QLSDFS, @RJL, @JZMD, @JZXG, @ZDSZD, @ZDSZN, @ZDSZX, @ZDSZB, @ZDT, @TFH, @DJH, @DAH, @BZ, @ZT, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_ZDJBXX = "UPDATE ZDJBXX SET YSDM = @YSDM, ZDDM = @ZDDM, BDCDYH = @BDCDYH, ZDTZM = @ZDTZM, ZL = @ZL, ZDMJ = @ZDMJ, MJDW = @MJDW, YT = @YT, DJ = @DJ, JG = @JG, QLLX = @QLLX, QLXZ = @QLXZ, QLSDFS = @QLSDFS, RJL = @RJL, JZMD = @JZMD, JZXG = @JZXG, ZDSZD = @ZDSZD, ZDSZN = @ZDSZN, ZDSZX = @ZDSZX, ZDSZB = @ZDSZB, ZDT = @ZDT, TFH = @TFH, DJH = @DJH, DAH = @DAH, BZ = @BZ, ZT = @ZT, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";	
	    private const string SQL_DELETE_ZDJBXX = "DELETE FROM ZDJBXX WHERE  Id = @Id ";        
        private const string SQL_DELETE_FLAG_ZDJBXX = "UPDATE ZDJBXX Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE  Id = @Id ";
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 要素代码
		protected string ysdm = default(string);
        /// 宗地代码
		protected string zddm = default(string);
        /// 不动产单元号
		protected string bdcdyh = default(string);
        /// 宗地特征码 - 使用字典信息(宗地（宗海）特征码字典表--ZDZHTZMZD)
		protected string zdtzm = default(string);
        /// 坐落
		protected string zl = default(string);
        /// 宗地面积
		protected double? zdmj = default(double?);
        /// 面积单位 - 使用字典信息(面积单位字典表--MJDWZD)
		protected string mjdw = default(string);
        /// 用途
		protected string yt = default(string);
        /// 等级 - 使用字典信息(土地等级字典表--TDDJZD)
		protected string dj = default(string);
        /// 价格
		protected double? jg = default(double?);
        /// 权利类型 - 使用字典信息(权利类型字典表--QLLXZD)
		protected string qllx = default(string);
        /// 权利性质 - 使用字典信息(权利性质字典表--QLXZZD)
		protected string qlxz = default(string);
        /// 权利设定方式 - 使用字典信息(权利设定方式字典表--QLSDFSZD)
		protected string qlsdf = default(string);
        /// 容积率
		protected double? rjl = default(double?);
        /// 建筑密度
		protected double? jzmd = default(double?);
        /// 建筑限高
		protected double? jzxg = default(double?);
        /// 宗地四至-东
		protected string zdszd = default(string);
        /// 宗地四至-南
		protected string zdszn = default(string);
        /// 宗地四至-西
		protected string zdszx = default(string);
        /// 宗地四至-北
		protected string zdszb = default(string);
        /// 宗地图
		protected byte[] zdt = default(byte[]);
        /// 图幅号
		protected string tfh = default(string);
        /// 地籍号
		protected string djh = default(string);
        /// 档案号
		protected string dah = default(string);
        /// 备注
		protected string bz = default(string);
        /// 状态 - 使用字典信息(不动产单元状态字典表--BDCDYZTZD)
		protected string zt = default(string);
        /// 调查员
		protected string wxDcy = default(string);
        /// 调查时间
		protected System.DateTime? wxDcsj = default(System.DateTime?);
        /// 测量员
		protected string wxCly = default(string);
        /// 测量时间
		protected System.DateTime? wxClsj = default(System.DateTime?);
        /// 制图员
		protected string wxZty = default(string);
        /// 制图时间
		protected System.DateTime? wxZtsj = default(System.DateTime?);
        /// 质检员
		protected string wxZjy = default(string);
        /// 质检时间
		protected System.DateTime? wxZjsj = default(System.DateTime?);
        /// 唯一代码
		protected System.Guid? wxWydm = default(System.Guid?);
        /// 源数据库内序号
		protected long? databaseid = default(long?);
        /// 修改标记
		protected short? flag = default(short?);
        /// XGR
		protected string xgr = default(string);
        /// XGSJ
		protected System.DateTime? xgsj = default(System.DateTime?);
        protected IGeometry _geometry;
        ///WKT字段
        protected string _wkt=default(string);
        ///图形对象字段
        protected GeometryType _geometryType=GeometryType.Polygon;
        
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
        
        #region IEntity属性
        //对应数据库内表名称
        public string ObjectName
        {
            get{return "Zdjbxx";}
        }
        public string EntityName{
            get{return "SurveyFeature";}
        }       
        public string TableName{get{return TABLE_NAME;}}
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
                return string.Format("{0} {1} ({2})","ZDJBXX",this.id,this.ysdm);
            }
        }        
        #endregion
        #region 字段属性信息
        /// 标识码
        public long ID 
        {
            get { return this.id; }
			set	{ 
                  if(this.id != value)
                    {
                        this.OnPropertyChanging("ID");  
                        this.id= value;                                              
                        this.OnPropertyChanged("ID");
                    }   
                }
        }	
        /// 要素代码
        public string Ysdm 
        {
            get { return this.ysdm; }
			set	{ 
                  if(this.ysdm != value)
                    {
                        this.OnPropertyChanging("Ysdm");  
                        this.ysdm= value;                                              
                        this.OnPropertyChanged("Ysdm");
                    }   
                }
        }	
        /// 宗地代码
        public string Zddm 
        {
            get { return this.zddm; }
			set	{ 
                  if(this.zddm != value)
                    {
                        this.OnPropertyChanging("Zddm");  
                        this.zddm= value;                                              
                        this.OnPropertyChanged("Zddm");
                    }   
                }
        }	
        /// 不动产单元号
        public string Bdcdyh 
        {
            get { return this.bdcdyh; }
			set	{ 
                  if(this.bdcdyh != value)
                    {
                        this.OnPropertyChanging("Bdcdyh");  
                        this.bdcdyh= value;                                              
                        this.OnPropertyChanged("Bdcdyh");
                    }   
                }
        }	
        /// 宗地特征码 - 使用字典信息(宗地（宗海）特征码字典表--ZDZHTZMZD)
        public string Zdtzm 
        {
            get { return this.zdtzm; }
			set	{ 
                  if(this.zdtzm != value)
                    {
                        this.OnPropertyChanging("Zdtzm");  
                        this.zdtzm= value;                                              
                        this.OnPropertyChanged("Zdtzm");
                    }   
                }
        }	
        /// 坐落
        public string Zl 
        {
            get { return this.zl; }
			set	{ 
                  if(this.zl != value)
                    {
                        this.OnPropertyChanging("Zl");  
                        this.zl= value;                                              
                        this.OnPropertyChanged("Zl");
                    }   
                }
        }	
        /// 宗地面积
        public double? Zdmj 
        {
            get { return this.zdmj; }
			set	{ 
                  if(this.zdmj != value)
                    {
                        this.OnPropertyChanging("Zdmj");  
                        this.zdmj= value;                                              
                        this.OnPropertyChanged("Zdmj");
                    }   
                }
        }	
        /// 面积单位 - 使用字典信息(面积单位字典表--MJDWZD)
        public string Mjdw 
        {
            get { return this.mjdw; }
			set	{ 
                  if(this.mjdw != value)
                    {
                        this.OnPropertyChanging("Mjdw");  
                        this.mjdw= value;                                              
                        this.OnPropertyChanged("Mjdw");
                    }   
                }
        }	
        /// 用途
        public string Yt 
        {
            get { return this.yt; }
			set	{ 
                  if(this.yt != value)
                    {
                        this.OnPropertyChanging("Yt");  
                        this.yt= value;                                              
                        this.OnPropertyChanged("Yt");
                    }   
                }
        }	
        /// 等级 - 使用字典信息(土地等级字典表--TDDJZD)
        public string Dj 
        {
            get { return this.dj; }
			set	{ 
                  if(this.dj != value)
                    {
                        this.OnPropertyChanging("Dj");  
                        this.dj= value;                                              
                        this.OnPropertyChanged("Dj");
                    }   
                }
        }	
        /// 价格
        public double? Jg 
        {
            get { return this.jg; }
			set	{ 
                  if(this.jg != value)
                    {
                        this.OnPropertyChanging("Jg");  
                        this.jg= value;                                              
                        this.OnPropertyChanged("Jg");
                    }   
                }
        }	
        /// 权利类型 - 使用字典信息(权利类型字典表--QLLXZD)
        public string Qllx 
        {
            get { return this.qllx; }
			set	{ 
                  if(this.qllx != value)
                    {
                        this.OnPropertyChanging("Qllx");  
                        this.qllx= value;                                              
                        this.OnPropertyChanged("Qllx");
                    }   
                }
        }	
        /// 权利性质 - 使用字典信息(权利性质字典表--QLXZZD)
        public string Qlxz 
        {
            get { return this.qlxz; }
			set	{ 
                  if(this.qlxz != value)
                    {
                        this.OnPropertyChanging("Qlxz");  
                        this.qlxz= value;                                              
                        this.OnPropertyChanged("Qlxz");
                    }   
                }
        }	
        /// 权利设定方式 - 使用字典信息(权利设定方式字典表--QLSDFSZD)
        public string Qlsdfs 
        {
            get { return this.qlsdf; }
			set	{ 
                  if(this.qlsdf != value)
                    {
                        this.OnPropertyChanging("Qlsdfs");  
                        this.qlsdf= value;                                              
                        this.OnPropertyChanged("Qlsdfs");
                    }   
                }
        }	
        /// 容积率
        public double? Rjl 
        {
            get { return this.rjl; }
			set	{ 
                  if(this.rjl != value)
                    {
                        this.OnPropertyChanging("Rjl");  
                        this.rjl= value;                                              
                        this.OnPropertyChanged("Rjl");
                    }   
                }
        }	
        /// 建筑密度
        public double? Jzmd 
        {
            get { return this.jzmd; }
			set	{ 
                  if(this.jzmd != value)
                    {
                        this.OnPropertyChanging("Jzmd");  
                        this.jzmd= value;                                              
                        this.OnPropertyChanged("Jzmd");
                    }   
                }
        }	
        /// 建筑限高
        public double? Jzxg 
        {
            get { return this.jzxg; }
			set	{ 
                  if(this.jzxg != value)
                    {
                        this.OnPropertyChanging("Jzxg");  
                        this.jzxg= value;                                              
                        this.OnPropertyChanged("Jzxg");
                    }   
                }
        }	
        /// 宗地四至-东
        public string Zdszd 
        {
            get { return this.zdszd; }
			set	{ 
                  if(this.zdszd != value)
                    {
                        this.OnPropertyChanging("Zdszd");  
                        this.zdszd= value;                                              
                        this.OnPropertyChanged("Zdszd");
                    }   
                }
        }	
        /// 宗地四至-南
        public string Zdszn 
        {
            get { return this.zdszn; }
			set	{ 
                  if(this.zdszn != value)
                    {
                        this.OnPropertyChanging("Zdszn");  
                        this.zdszn= value;                                              
                        this.OnPropertyChanged("Zdszn");
                    }   
                }
        }	
        /// 宗地四至-西
        public string Zdszx 
        {
            get { return this.zdszx; }
			set	{ 
                  if(this.zdszx != value)
                    {
                        this.OnPropertyChanging("Zdszx");  
                        this.zdszx= value;                                              
                        this.OnPropertyChanged("Zdszx");
                    }   
                }
        }	
        /// 宗地四至-北
        public string Zdszb 
        {
            get { return this.zdszb; }
			set	{ 
                  if(this.zdszb != value)
                    {
                        this.OnPropertyChanging("Zdszb");  
                        this.zdszb= value;                                              
                        this.OnPropertyChanged("Zdszb");
                    }   
                }
        }	
        /// 宗地图
        public byte[] Zdt 
        {
            get { return this.zdt; }
			set	{ 
                  if(this.zdt != value)
                    {
                        this.OnPropertyChanging("Zdt");  
                        this.zdt= value;                                              
                        this.OnPropertyChanged("Zdt");
                    }   
                }
        }	
        /// 图幅号
        public string Tfh 
        {
            get { return this.tfh; }
			set	{ 
                  if(this.tfh != value)
                    {
                        this.OnPropertyChanging("Tfh");  
                        this.tfh= value;                                              
                        this.OnPropertyChanged("Tfh");
                    }   
                }
        }	
        /// 地籍号
        public string Djh 
        {
            get { return this.djh; }
			set	{ 
                  if(this.djh != value)
                    {
                        this.OnPropertyChanging("Djh");  
                        this.djh= value;                                              
                        this.OnPropertyChanged("Djh");
                    }   
                }
        }	
        /// 档案号
        public string Dah 
        {
            get { return this.dah; }
			set	{ 
                  if(this.dah != value)
                    {
                        this.OnPropertyChanging("Dah");  
                        this.dah= value;                                              
                        this.OnPropertyChanged("Dah");
                    }   
                }
        }	
        /// 备注
        public string Bz 
        {
            get { return this.bz; }
			set	{ 
                  if(this.bz != value)
                    {
                        this.OnPropertyChanging("Bz");  
                        this.bz= value;                                              
                        this.OnPropertyChanged("Bz");
                    }   
                }
        }	
        /// 状态 - 使用字典信息(不动产单元状态字典表--BDCDYZTZD)
        public string Zt 
        {
            get { return this.zt; }
			set	{ 
                  if(this.zt != value)
                    {
                        this.OnPropertyChanging("Zt");  
                        this.zt= value;                                              
                        this.OnPropertyChanged("Zt");
                    }   
                }
        }	
        /// 调查员
        public string WxDcy 
        {
            get { return this.wxDcy; }
			set	{ 
                  if(this.wxDcy != value)
                    {
                        this.OnPropertyChanging("WxDcy");  
                        this.wxDcy= value;                                              
                        this.OnPropertyChanged("WxDcy");
                    }   
                }
        }	
        /// 调查时间
        public System.DateTime? WxDcsj 
        {
            get { return this.wxDcsj; }
			set	{ 
                  if(this.wxDcsj != value)
                    {
                        this.OnPropertyChanging("WxDcsj");  
                        this.wxDcsj= value;                                              
                        this.OnPropertyChanged("WxDcsj");
                    }   
                }
        }	
        /// 测量员
        public string WxCly 
        {
            get { return this.wxCly; }
			set	{ 
                  if(this.wxCly != value)
                    {
                        this.OnPropertyChanging("WxCly");  
                        this.wxCly= value;                                              
                        this.OnPropertyChanged("WxCly");
                    }   
                }
        }	
        /// 测量时间
        public System.DateTime? WxClsj 
        {
            get { return this.wxClsj; }
			set	{ 
                  if(this.wxClsj != value)
                    {
                        this.OnPropertyChanging("WxClsj");  
                        this.wxClsj= value;                                              
                        this.OnPropertyChanged("WxClsj");
                    }   
                }
        }	
        /// 制图员
        public string WxZty 
        {
            get { return this.wxZty; }
			set	{ 
                  if(this.wxZty != value)
                    {
                        this.OnPropertyChanging("WxZty");  
                        this.wxZty= value;                                              
                        this.OnPropertyChanged("WxZty");
                    }   
                }
        }	
        /// 制图时间
        public System.DateTime? WxZtsj 
        {
            get { return this.wxZtsj; }
			set	{ 
                  if(this.wxZtsj != value)
                    {
                        this.OnPropertyChanging("WxZtsj");  
                        this.wxZtsj= value;                                              
                        this.OnPropertyChanged("WxZtsj");
                    }   
                }
        }	
        /// 质检员
        public string WxZjy 
        {
            get { return this.wxZjy; }
			set	{ 
                  if(this.wxZjy != value)
                    {
                        this.OnPropertyChanging("WxZjy");  
                        this.wxZjy= value;                                              
                        this.OnPropertyChanged("WxZjy");
                    }   
                }
        }	
        /// 质检时间
        public System.DateTime? WxZjsj 
        {
            get { return this.wxZjsj; }
			set	{ 
                  if(this.wxZjsj != value)
                    {
                        this.OnPropertyChanging("WxZjsj");  
                        this.wxZjsj= value;                                              
                        this.OnPropertyChanged("WxZjsj");
                    }   
                }
        }	
        /// 唯一代码
        public System.Guid? WxWydm 
        {
            get { return this.wxWydm; }
			set	{ 
                  if(this.wxWydm != value)
                    {
                        this.OnPropertyChanging("WxWydm");  
                        this.wxWydm= value;                                              
                        this.OnPropertyChanged("WxWydm");
                    }   
                }
        }	
        /// 源数据库内序号
        public long? DatabaseID 
        {
            get { return this.databaseid; }
			set	{ 
                  if(this.databaseid != value)
                    {
                        this.OnPropertyChanging("DatabaseID");  
                        this.databaseid= value;                                              
                        this.OnPropertyChanged("DatabaseID");
                    }   
                }
        }	
        /// 修改标记
        public short? Flags 
        {
            get { return this.flag; }
			set	{ 
                  if(this.flag != value)
                    {
                        this.OnPropertyChanging("Flags");  
                        this.flag= value;                                              
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
        /// XGR
        public string Xgr 
        {
            get { return this.xgr; }
			set	{ 
                  if(this.xgr != value)
                    {
                        this.OnPropertyChanging("Xgr");  
                        this.xgr= value;                                              
                        this.OnPropertyChanged("Xgr");
                    }   
                }
        }	
        /// XGSJ
        public System.DateTime? Xgsj 
        {
            get { return this.xgsj; }
			set	{ 
                  if(this.xgsj != value)
                    {
                        this.OnPropertyChanging("Xgsj");  
                        this.xgsj= value;                                              
                        this.OnPropertyChanged("Xgsj");
                    }   
                }
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
        ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
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
        public  Zdjbxx()
        {
            _geometry=new Geometry(_geometryType,ZValueType.None);
            this.id=0;
            this.ysdm="6001010000";
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
            this.qlsdf="";
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
            this.wxWydm=Guid.NewGuid();
            this.databaseid=0;
            this.flag=1;
            this.xgr="";
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
        
        
        public long Create(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZDJBXX,dao.Connection))
            {
                this.databaseid=0;
                this.flag=1;
                command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
                command.Parameters.AddWithValue(PARAM_ZDDM,this.Zddm);
                command.Parameters.AddWithValue(PARAM_BDCDYH,this.Bdcdyh);
                command.Parameters.AddWithValue(PARAM_ZDTZM,this.Zdtzm);
                command.Parameters.AddWithValue(PARAM_ZL,this.Zl);
                command.Parameters.AddWithValue(PARAM_ZDMJ,this.Zdmj);
                command.Parameters.AddWithValue(PARAM_MJDW,this.Mjdw);
                command.Parameters.AddWithValue(PARAM_YT,this.Yt);
                command.Parameters.AddWithValue(PARAM_DJ,this.Dj);
                command.Parameters.AddWithValue(PARAM_JG,this.Jg);
                command.Parameters.AddWithValue(PARAM_QLLX,this.Qllx);
                command.Parameters.AddWithValue(PARAM_QLXZ,this.Qlxz);
                command.Parameters.AddWithValue(PARAM_QLSDFS,this.Qlsdfs);
                command.Parameters.AddWithValue(PARAM_RJL,this.Rjl);
                command.Parameters.AddWithValue(PARAM_JZMD,this.Jzmd);
                command.Parameters.AddWithValue(PARAM_JZXG,this.Jzxg);
                command.Parameters.AddWithValue(PARAM_ZDSZD,this.Zdszd);
                command.Parameters.AddWithValue(PARAM_ZDSZN,this.Zdszn);
                command.Parameters.AddWithValue(PARAM_ZDSZX,this.Zdszx);
                command.Parameters.AddWithValue(PARAM_ZDSZB,this.Zdszb);
                command.Parameters.AddWithValue(PARAM_ZDT,this.Zdt);
                command.Parameters.AddWithValue(PARAM_TFH,this.Tfh);
                command.Parameters.AddWithValue(PARAM_DJH,this.Djh);
                command.Parameters.AddWithValue(PARAM_DAH,this.Dah);
                command.Parameters.AddWithValue(PARAM_BZ,this.Bz);
                command.Parameters.AddWithValue(PARAM_ZT,this.Zt);
                command.Parameters.AddWithValue(PARAM_WX_DCY,this.WxDcy);
                command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);
                command.Parameters.AddWithValue(PARAM_WX_CLY,this.WxCly);
                command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);
                command.Parameters.AddWithValue(PARAM_WX_ZTY,this.WxZty);
                command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);
                command.Parameters.AddWithValue(PARAM_WX_ZJY,this.WxZjy);
                command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);
                command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);
                command.Parameters.AddWithValue(PARAM_DATABASEID,0);
                this.flag=1;command.Parameters.AddWithValue(PARAM_FLAGS,1);
                command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);
                command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZDJBXX,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZDDM,this.Zddm);
				command.Parameters.AddWithValue(PARAM_BDCDYH,this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_ZDTZM,this.Zdtzm);
				command.Parameters.AddWithValue(PARAM_ZL,EncodingHelper.String2Unicode(this.Zl));
				command.Parameters.AddWithValue(PARAM_ZDMJ,this.Zdmj);
				command.Parameters.AddWithValue(PARAM_MJDW,this.Mjdw);
				command.Parameters.AddWithValue(PARAM_YT,this.Yt);
				command.Parameters.AddWithValue(PARAM_DJ,this.Dj);
				command.Parameters.AddWithValue(PARAM_JG,this.Jg);
				command.Parameters.AddWithValue(PARAM_QLLX,this.Qllx);
				command.Parameters.AddWithValue(PARAM_QLXZ,this.Qlxz);
				command.Parameters.AddWithValue(PARAM_QLSDFS,this.Qlsdfs);
				command.Parameters.AddWithValue(PARAM_RJL,this.Rjl);
				command.Parameters.AddWithValue(PARAM_JZMD,this.Jzmd);
				command.Parameters.AddWithValue(PARAM_JZXG,this.Jzxg);
				command.Parameters.AddWithValue(PARAM_ZDSZD,EncodingHelper.String2Unicode(this.Zdszd));
				command.Parameters.AddWithValue(PARAM_ZDSZN,EncodingHelper.String2Unicode(this.Zdszn));
				command.Parameters.AddWithValue(PARAM_ZDSZX,EncodingHelper.String2Unicode(this.Zdszx));
				command.Parameters.AddWithValue(PARAM_ZDSZB,EncodingHelper.String2Unicode(this.Zdszb));
				command.Parameters.AddWithValue(PARAM_ZDT,this.Zdt);
				command.Parameters.AddWithValue(PARAM_TFH,this.Tfh);
				command.Parameters.AddWithValue(PARAM_DJH,this.Djh);
				command.Parameters.AddWithValue(PARAM_DAH,this.Dah);
				command.Parameters.AddWithValue(PARAM_BZ,this.Bz);
				command.Parameters.AddWithValue(PARAM_ZT,this.Zt);
				command.Parameters.AddWithValue(PARAM_WX_DCY,EncodingHelper.String2Unicode(this.WxDcy));
				command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);
				command.Parameters.AddWithValue(PARAM_WX_CLY,EncodingHelper.String2Unicode(this.WxCly));
				command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);
				command.Parameters.AddWithValue(PARAM_WX_ZTY,EncodingHelper.String2Unicode(this.WxZty));
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);
				command.Parameters.AddWithValue(PARAM_WX_ZJY,EncodingHelper.String2Unicode(this.WxZjy));
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);
				command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);
				command.Parameters.AddWithValue(PARAM_DATABASEID,this.DatabaseID);
				this.flag = (short?)(this.databaseid > 0 ? 2 :1);command.Parameters.AddWithValue(PARAM_FLAGS,this.flag);
				command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);
				command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
			
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(ISQLiteDao dao)
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
        

		public bool Delete(ISQLiteDao dao)
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