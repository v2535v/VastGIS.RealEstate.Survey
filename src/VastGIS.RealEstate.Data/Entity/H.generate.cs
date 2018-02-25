
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
    public partial class H : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity,IGlobalEntity,ISurveyEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "H";	
        public const string LAYER_NAME = "户";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_FWBM = "FWBM";
		public const string COL_YSDM = "YSDM";
		public const string COL_ZRZH = "ZRZH";
		public const string COL_LJZH = "LJZH";
		public const string COL_CH = "CH";
		public const string COL_ZL = "ZL";
		public const string COL_MJDW = "MJDW";
		public const string COL_SJCS = "SJCS";
		public const string COL_HH = "HH";
		public const string COL_SHBW = "SHBW";
		public const string COL_HX = "HX";
		public const string COL_HXJG = "HXJG";
		public const string COL_FWYT1 = "FWYT1";
		public const string COL_FWYT2 = "FWYT2";
		public const string COL_FWYT3 = "FWYT3";
		public const string COL_YCJZMJ = "YCJZMJ";
		public const string COL_YCTNJZMJ = "YCTNJZMJ";
		public const string COL_YCFTJZMJ = "YCFTJZMJ";
		public const string COL_YCDXBFJZMJ = "YCDXBFJZMJ";
		public const string COL_YCQTJZMJ = "YCQTJZMJ";
		public const string COL_YCFTXS = "YCFTXS";
		public const string COL_SCJZMJ = "SCJZMJ";
		public const string COL_SCTNJZMJ = "SCTNJZMJ";
		public const string COL_SCFTJZMJ = "SCFTJZMJ";
		public const string COL_SCDXBFJZMJ = "SCDXBFJZMJ";
		public const string COL_SCQTJZMJ = "SCQTJZMJ";
		public const string COL_SCFTXS = "SCFTXS";
		public const string COL_GYTDMJ = "GYTDMJ";
		public const string COL_FTTDMJ = "FTTDMJ";
		public const string COL_DYTDMJ = "DYTDMJ";
		public const string COL_FWLX = "FWLX";
		public const string COL_FWXZ = "FWXZ";
		public const string COL_FCFHT = "FCFHT";
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
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_FWBM = "@FWBM";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_ZRZH = "@ZRZH";	
        public const string PARAM_LJZH = "@LJZH";	
        public const string PARAM_CH = "@CH";	
        public const string PARAM_ZL = "@ZL";	
        public const string PARAM_MJDW = "@MJDW";	
        public const string PARAM_SJCS = "@SJCS";	
        public const string PARAM_HH = "@HH";	
        public const string PARAM_SHBW = "@SHBW";	
        public const string PARAM_HX = "@HX";	
        public const string PARAM_HXJG = "@HXJG";	
        public const string PARAM_FWYT1 = "@FWYT1";	
        public const string PARAM_FWYT2 = "@FWYT2";	
        public const string PARAM_FWYT3 = "@FWYT3";	
        public const string PARAM_YCJZMJ = "@YCJZMJ";	
        public const string PARAM_YCTNJZMJ = "@YCTNJZMJ";	
        public const string PARAM_YCFTJZMJ = "@YCFTJZMJ";	
        public const string PARAM_YCDXBFJZMJ = "@YCDXBFJZMJ";	
        public const string PARAM_YCQTJZMJ = "@YCQTJZMJ";	
        public const string PARAM_YCFTXS = "@YCFTXS";	
        public const string PARAM_SCJZMJ = "@SCJZMJ";	
        public const string PARAM_SCTNJZMJ = "@SCTNJZMJ";	
        public const string PARAM_SCFTJZMJ = "@SCFTJZMJ";	
        public const string PARAM_SCDXBFJZMJ = "@SCDXBFJZMJ";	
        public const string PARAM_SCQTJZMJ = "@SCQTJZMJ";	
        public const string PARAM_SCFTXS = "@SCFTXS";	
        public const string PARAM_GYTDMJ = "@GYTDMJ";	
        public const string PARAM_FTTDMJ = "@FTTDMJ";	
        public const string PARAM_DYTDMJ = "@DYTDMJ";	
        public const string PARAM_FWLX = "@FWLX";	
        public const string PARAM_FWXZ = "@FWXZ";	
        public const string PARAM_FCFHT = "@FCFHT";	
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
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_H ="SELECT  Id,BDCDYH,FWBM,YSDM,ZRZH,LJZH,CH,ZL,MJDW,SJCS,HH,SHBW,HX,HXJG,FWYT1,FWYT2,FWYT3,YCJZMJ,YCTNJZMJ,YCFTJZMJ,YCDXBFJZMJ,YCQTJZMJ,YCFTXS,SCJZMJ,SCTNJZMJ,SCFTJZMJ,SCDXBFJZMJ,SCQTJZMJ,SCFTXS,GYTDMJ,FTTDMJ,DYTDMJ,FWLX,FWXZ,FCFHT,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM H WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_H = "INSERT INTO [H] (BDCDYH, FWBM, YSDM, ZRZH, LJZH, CH, ZL, MJDW, SJCS, HH, SHBW, HX, HXJG, FWYT1, FWYT2, FWYT3, YCJZMJ, YCTNJZMJ, YCFTJZMJ, YCDXBFJZMJ, YCQTJZMJ, YCFTXS, SCJZMJ, SCTNJZMJ, SCFTJZMJ, SCDXBFJZMJ, SCQTJZMJ, SCFTXS, GYTDMJ, FTTDMJ, DYTDMJ, FWLX, FWXZ, FCFHT, ZT, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @BDCDYH, @FWBM, @YSDM, @ZRZH, @LJZH, @CH, @ZL, @MJDW, @SJCS, @HH, @SHBW, @HX, @HXJG, @FWYT1, @FWYT2, @FWYT3, @YCJZMJ, @YCTNJZMJ, @YCFTJZMJ, @YCDXBFJZMJ, @YCQTJZMJ, @YCFTXS, @SCJZMJ, @SCTNJZMJ, @SCFTJZMJ, @SCDXBFJZMJ, @SCQTJZMJ, @SCFTXS, @GYTDMJ, @FTTDMJ, @DYTDMJ, @FWLX, @FWXZ, @FCFHT, @ZT, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_H = "UPDATE [H] SET BDCDYH = @BDCDYH, FWBM = @FWBM, YSDM = @YSDM, ZRZH = @ZRZH, LJZH = @LJZH, CH = @CH, ZL = @ZL, MJDW = @MJDW, SJCS = @SJCS, HH = @HH, SHBW = @SHBW, HX = @HX, HXJG = @HXJG, FWYT1 = @FWYT1, FWYT2 = @FWYT2, FWYT3 = @FWYT3, YCJZMJ = @YCJZMJ, YCTNJZMJ = @YCTNJZMJ, YCFTJZMJ = @YCFTJZMJ, YCDXBFJZMJ = @YCDXBFJZMJ, YCQTJZMJ = @YCQTJZMJ, YCFTXS = @YCFTXS, SCJZMJ = @SCJZMJ, SCTNJZMJ = @SCTNJZMJ, SCFTJZMJ = @SCFTJZMJ, SCDXBFJZMJ = @SCDXBFJZMJ, SCQTJZMJ = @SCQTJZMJ, SCFTXS = @SCFTXS, GYTDMJ = @GYTDMJ, FTTDMJ = @FTTDMJ, DYTDMJ = @DYTDMJ, FWLX = @FWLX, FWXZ = @FWXZ, FCFHT = @FCFHT, ZT = @ZT, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_H = "DELETE FROM [H] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_H = "UPDATE [H] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///不动产单元号
		protected string bdcdyh = default(string);
        ///房屋编码
		protected string fwbm = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///自然幢号
		protected string zrzh = default(string);
        ///逻辑幢号
		protected string ljzh = default(string);
        ///层号
		protected string ch = default(string);
        ///坐落
		protected string zl = default(string);
        ///面积单位[字典:面积单位字典表-MJDWZD]
		protected string mjdw = default(string);
        ///实际层数
		protected double? sjcs = default(double?);
        ///户号
		protected long? hh = default(long?);
        ///室号部位
		protected string shbw = default(string);
        ///户型[字典:户型字典表-HXZD]
		protected string hx = default(string);
        ///户型结构[字典:户型结构字典表-HXJGZD]
		protected string hxjg = default(string);
        ///房屋用途1[字典:房屋用途字典表-FWYTZD]
		protected string fwyt1 = default(string);
        ///房屋用途2[字典:房屋用途字典表-FWYTZD]
		protected string fwyt2 = default(string);
        ///房屋用途3[字典:房屋用途字典表-FWYTZD]
		protected string fwyt3 = default(string);
        ///预测建筑面积
		protected double? ycjzmj = default(double?);
        ///预测套内建筑面积
		protected double? yctnjzmj = default(double?);
        ///预测分摊建筑面积
		protected double? ycftjzmj = default(double?);
        ///预测地下部分建筑面积
		protected double? ycdxbfjzmj = default(double?);
        ///预测其它建筑面积
		protected double? ycqtjzmj = default(double?);
        ///预测分摊系数
		protected double? ycftxs = default(double?);
        ///实测建筑面积
		protected double? scjzmj = default(double?);
        ///实测套内建筑面积
		protected double? sctnjzmj = default(double?);
        ///实测分摊建筑面积
		protected double? scftjzmj = default(double?);
        ///实测地下部分建筑面积
		protected double? scdxbfjzmj = default(double?);
        ///实测其它建筑面积
		protected double? scqtjzmj = default(double?);
        ///实测分摊系数
		protected double? scftxs = default(double?);
        ///共有土地面积
		protected double? gytdmj = default(double?);
        ///分摊土地面积
		protected double? fttdmj = default(double?);
        ///独用土地面积
		protected double? dytdmj = default(double?);
        ///房屋类型[字典:房屋类型字典表-FWLXZD]
		protected string fwlx = default(string);
        ///房屋性质[字典:房屋性质字典表-FWXZZD]
		protected string fwxz = default(string);
        ///房产分户图
		protected byte[] fcfht = default(byte[]);
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
            get{return "H";}
        }
         public string LayerName
        {
            get{return "户";}
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
                return string.Format("{0} {1} ({2})","H",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","户",this.id,this.ysdm);
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
		
        ///房屋编码
        ///[Column(COL_FWBM, PARAM_FWBM )]
        public virtual string Fwbm 
        {
            get { return this.fwbm; }
			set	{ 
                  if(this.fwbm != value)
                    {
                        this.OnPropertyChanging("Fwbm"); 
                        this.fwbm = value;                        
                        this.OnPropertyChanged("Fwbm");
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
		
        ///逻辑幢号
        ///[Column(COL_LJZH, PARAM_LJZH )]
        public virtual string Ljzh 
        {
            get { return this.ljzh; }
			set	{ 
                  if(this.ljzh != value)
                    {
                        this.OnPropertyChanging("Ljzh"); 
                        this.ljzh = value;                        
                        this.OnPropertyChanged("Ljzh");
                    }   
                }
        }	
		
        ///层号
        ///[Column(COL_CH, PARAM_CH )]
        public virtual string Ch 
        {
            get { return this.ch; }
			set	{ 
                  if(this.ch != value)
                    {
                        this.OnPropertyChanging("Ch"); 
                        this.ch = value;                        
                        this.OnPropertyChanged("Ch");
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
		
        ///实际层数
        ///[Column(COL_SJCS, PARAM_SJCS )]
        public virtual double? Sjcs 
        {
            get { return this.sjcs; }
			set	{ 
                  if(this.sjcs != value)
                    {
                        this.OnPropertyChanging("Sjcs"); 
                        this.sjcs = value;                        
                        this.OnPropertyChanged("Sjcs");
                    }   
                }
        }	
		
        ///户号
        ///[Column(COL_HH, PARAM_HH )]
        public virtual long? Hh 
        {
            get { return this.hh; }
			set	{ 
                  if(this.hh != value)
                    {
                        this.OnPropertyChanging("Hh"); 
                        this.hh = value;                        
                        this.OnPropertyChanged("Hh");
                    }   
                }
        }	
		
        ///室号部位
        ///[Column(COL_SHBW, PARAM_SHBW )]
        public virtual string Shbw 
        {
            get { return this.shbw; }
			set	{ 
                  if(this.shbw != value)
                    {
                        this.OnPropertyChanging("Shbw"); 
                        this.shbw = value;                        
                        this.OnPropertyChanged("Shbw");
                    }   
                }
        }	
		
        ///户型
        ///[Column(COL_HX, PARAM_HX )]
        public virtual string Hx 
        {
            get { return this.hx; }
			set	{ 
                  if(this.hx != value)
                    {
                        this.OnPropertyChanging("Hx"); 
                        this.hx = value;                        
                        this.OnPropertyChanged("Hx");
                    }   
                }
        }	
		
        ///户型结构
        ///[Column(COL_HXJG, PARAM_HXJG )]
        public virtual string Hxjg 
        {
            get { return this.hxjg; }
			set	{ 
                  if(this.hxjg != value)
                    {
                        this.OnPropertyChanging("Hxjg"); 
                        this.hxjg = value;                        
                        this.OnPropertyChanged("Hxjg");
                    }   
                }
        }	
		
        ///房屋用途1
        ///[Column(COL_FWYT1, PARAM_FWYT1 )]
        public virtual string Fwyt1 
        {
            get { return this.fwyt1; }
			set	{ 
                  if(this.fwyt1 != value)
                    {
                        this.OnPropertyChanging("Fwyt1"); 
                        this.fwyt1 = value;                        
                        this.OnPropertyChanged("Fwyt1");
                    }   
                }
        }	
		
        ///房屋用途2
        ///[Column(COL_FWYT2, PARAM_FWYT2 )]
        public virtual string Fwyt2 
        {
            get { return this.fwyt2; }
			set	{ 
                  if(this.fwyt2 != value)
                    {
                        this.OnPropertyChanging("Fwyt2"); 
                        this.fwyt2 = value;                        
                        this.OnPropertyChanged("Fwyt2");
                    }   
                }
        }	
		
        ///房屋用途3
        ///[Column(COL_FWYT3, PARAM_FWYT3 )]
        public virtual string Fwyt3 
        {
            get { return this.fwyt3; }
			set	{ 
                  if(this.fwyt3 != value)
                    {
                        this.OnPropertyChanging("Fwyt3"); 
                        this.fwyt3 = value;                        
                        this.OnPropertyChanged("Fwyt3");
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
		
        ///预测套内建筑面积
        ///[Column(COL_YCTNJZMJ, PARAM_YCTNJZMJ )]
        public virtual double? Yctnjzmj 
        {
            get { return this.yctnjzmj; }
			set	{ 
                  if(this.yctnjzmj != value)
                    {
                        this.OnPropertyChanging("Yctnjzmj"); 
                        this.yctnjzmj = value;                        
                        this.OnPropertyChanged("Yctnjzmj");
                    }   
                }
        }	
		
        ///预测分摊建筑面积
        ///[Column(COL_YCFTJZMJ, PARAM_YCFTJZMJ )]
        public virtual double? Ycftjzmj 
        {
            get { return this.ycftjzmj; }
			set	{ 
                  if(this.ycftjzmj != value)
                    {
                        this.OnPropertyChanging("Ycftjzmj"); 
                        this.ycftjzmj = value;                        
                        this.OnPropertyChanged("Ycftjzmj");
                    }   
                }
        }	
		
        ///预测地下部分建筑面积
        ///[Column(COL_YCDXBFJZMJ, PARAM_YCDXBFJZMJ )]
        public virtual double? Ycdxbfjzmj 
        {
            get { return this.ycdxbfjzmj; }
			set	{ 
                  if(this.ycdxbfjzmj != value)
                    {
                        this.OnPropertyChanging("Ycdxbfjzmj"); 
                        this.ycdxbfjzmj = value;                        
                        this.OnPropertyChanged("Ycdxbfjzmj");
                    }   
                }
        }	
		
        ///预测其它建筑面积
        ///[Column(COL_YCQTJZMJ, PARAM_YCQTJZMJ )]
        public virtual double? Ycqtjzmj 
        {
            get { return this.ycqtjzmj; }
			set	{ 
                  if(this.ycqtjzmj != value)
                    {
                        this.OnPropertyChanging("Ycqtjzmj"); 
                        this.ycqtjzmj = value;                        
                        this.OnPropertyChanged("Ycqtjzmj");
                    }   
                }
        }	
		
        ///预测分摊系数
        ///[Column(COL_YCFTXS, PARAM_YCFTXS )]
        public virtual double? Ycftxs 
        {
            get { return this.ycftxs; }
			set	{ 
                  if(this.ycftxs != value)
                    {
                        this.OnPropertyChanging("Ycftxs"); 
                        this.ycftxs = value;                        
                        this.OnPropertyChanged("Ycftxs");
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
		
        ///实测套内建筑面积
        ///[Column(COL_SCTNJZMJ, PARAM_SCTNJZMJ )]
        public virtual double? Sctnjzmj 
        {
            get { return this.sctnjzmj; }
			set	{ 
                  if(this.sctnjzmj != value)
                    {
                        this.OnPropertyChanging("Sctnjzmj"); 
                        this.sctnjzmj = value;                        
                        this.OnPropertyChanged("Sctnjzmj");
                    }   
                }
        }	
		
        ///实测分摊建筑面积
        ///[Column(COL_SCFTJZMJ, PARAM_SCFTJZMJ )]
        public virtual double? Scftjzmj 
        {
            get { return this.scftjzmj; }
			set	{ 
                  if(this.scftjzmj != value)
                    {
                        this.OnPropertyChanging("Scftjzmj"); 
                        this.scftjzmj = value;                        
                        this.OnPropertyChanged("Scftjzmj");
                    }   
                }
        }	
		
        ///实测地下部分建筑面积
        ///[Column(COL_SCDXBFJZMJ, PARAM_SCDXBFJZMJ )]
        public virtual double? Scdxbfjzmj 
        {
            get { return this.scdxbfjzmj; }
			set	{ 
                  if(this.scdxbfjzmj != value)
                    {
                        this.OnPropertyChanging("Scdxbfjzmj"); 
                        this.scdxbfjzmj = value;                        
                        this.OnPropertyChanged("Scdxbfjzmj");
                    }   
                }
        }	
		
        ///实测其它建筑面积
        ///[Column(COL_SCQTJZMJ, PARAM_SCQTJZMJ )]
        public virtual double? Scqtjzmj 
        {
            get { return this.scqtjzmj; }
			set	{ 
                  if(this.scqtjzmj != value)
                    {
                        this.OnPropertyChanging("Scqtjzmj"); 
                        this.scqtjzmj = value;                        
                        this.OnPropertyChanged("Scqtjzmj");
                    }   
                }
        }	
		
        ///实测分摊系数
        ///[Column(COL_SCFTXS, PARAM_SCFTXS )]
        public virtual double? Scftxs 
        {
            get { return this.scftxs; }
			set	{ 
                  if(this.scftxs != value)
                    {
                        this.OnPropertyChanging("Scftxs"); 
                        this.scftxs = value;                        
                        this.OnPropertyChanged("Scftxs");
                    }   
                }
        }	
		
        ///共有土地面积
        ///[Column(COL_GYTDMJ, PARAM_GYTDMJ )]
        public virtual double? Gytdmj 
        {
            get { return this.gytdmj; }
			set	{ 
                  if(this.gytdmj != value)
                    {
                        this.OnPropertyChanging("Gytdmj"); 
                        this.gytdmj = value;                        
                        this.OnPropertyChanged("Gytdmj");
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
		
        ///房屋类型
        ///[Column(COL_FWLX, PARAM_FWLX )]
        public virtual string Fwlx 
        {
            get { return this.fwlx; }
			set	{ 
                  if(this.fwlx != value)
                    {
                        this.OnPropertyChanging("Fwlx"); 
                        this.fwlx = value;                        
                        this.OnPropertyChanged("Fwlx");
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
		
        ///房产分户图
        ///[Column(COL_FCFHT, PARAM_FCFHT )]
        public virtual byte[] Fcfht 
        {
            get { return this.fcfht; }
			set	{ 
                  if(this.fcfht != value)
                    {
                        this.OnPropertyChanging("Fcfht"); 
                        this.fcfht = value;                        
                        this.OnPropertyChanged("Fcfht");
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
        #endregion        
        
        #region 创建方法
        public H()
        {
            this.id=0;
            this.bdcdyh="";
            this.fwbm="";
            this.ysdm="";
            this.zrzh="";
            this.ljzh="";
            this.ch="";
            this.zl="";
            this.mjdw="";
            this.sjcs=0.0;
            this.hh=0;
            this.shbw="";
            this.hx="";
            this.hxjg="";
            this.fwyt1="";
            this.fwyt2="";
            this.fwyt3="";
            this.ycjzmj=0.0;
            this.yctnjzmj=0.0;
            this.ycftjzmj=0.0;
            this.ycdxbfjzmj=0.0;
            this.ycqtjzmj=0.0;
            this.ycftxs=0.0;
            this.scjzmj=0.0;
            this.sctnjzmj=0.0;
            this.scftjzmj=0.0;
            this.scdxbfjzmj=0.0;
            this.scqtjzmj=0.0;
            this.scftxs=0.0;
            this.gytdmj=0.0;
            this.fttdmj=0.0;
            this.dytdmj=0.0;
            this.fwlx="";
            this.fwxz="";
            
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
            H record = obj as H;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_H,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_FWBM, this.Fwbm);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZRZH, this.Zrzh);
				command.Parameters.AddWithValue(PARAM_LJZH, this.Ljzh);
				command.Parameters.AddWithValue(PARAM_CH, this.Ch);
				command.Parameters.AddWithValue(PARAM_ZL, this.Zl);
				command.Parameters.AddWithValue(PARAM_MJDW, this.Mjdw);
				command.Parameters.AddWithValue(PARAM_SJCS, this.Sjcs);
				command.Parameters.AddWithValue(PARAM_HH, this.Hh);
				command.Parameters.AddWithValue(PARAM_SHBW, this.Shbw);
				command.Parameters.AddWithValue(PARAM_HX, this.Hx);
				command.Parameters.AddWithValue(PARAM_HXJG, this.Hxjg);
				command.Parameters.AddWithValue(PARAM_FWYT1, this.Fwyt1);
				command.Parameters.AddWithValue(PARAM_FWYT2, this.Fwyt2);
				command.Parameters.AddWithValue(PARAM_FWYT3, this.Fwyt3);
				command.Parameters.AddWithValue(PARAM_YCJZMJ, this.Ycjzmj);
				command.Parameters.AddWithValue(PARAM_YCTNJZMJ, this.Yctnjzmj);
				command.Parameters.AddWithValue(PARAM_YCFTJZMJ, this.Ycftjzmj);
				command.Parameters.AddWithValue(PARAM_YCDXBFJZMJ, this.Ycdxbfjzmj);
				command.Parameters.AddWithValue(PARAM_YCQTJZMJ, this.Ycqtjzmj);
				command.Parameters.AddWithValue(PARAM_YCFTXS, this.Ycftxs);
				command.Parameters.AddWithValue(PARAM_SCJZMJ, this.Scjzmj);
				command.Parameters.AddWithValue(PARAM_SCTNJZMJ, this.Sctnjzmj);
				command.Parameters.AddWithValue(PARAM_SCFTJZMJ, this.Scftjzmj);
				command.Parameters.AddWithValue(PARAM_SCDXBFJZMJ, this.Scdxbfjzmj);
				command.Parameters.AddWithValue(PARAM_SCQTJZMJ, this.Scqtjzmj);
				command.Parameters.AddWithValue(PARAM_SCFTXS, this.Scftxs);
				command.Parameters.AddWithValue(PARAM_GYTDMJ, this.Gytdmj);
				command.Parameters.AddWithValue(PARAM_FTTDMJ, this.Fttdmj);
				command.Parameters.AddWithValue(PARAM_DYTDMJ, this.Dytdmj);
				command.Parameters.AddWithValue(PARAM_FWLX, this.Fwlx);
				command.Parameters.AddWithValue(PARAM_FWXZ, this.Fwxz);
				command.Parameters.AddWithValue(PARAM_FCFHT, this.Fcfht);
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
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_H,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_FWBM, this.Fwbm);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZRZH, this.Zrzh);
				command.Parameters.AddWithValue(PARAM_LJZH, this.Ljzh);
				command.Parameters.AddWithValue(PARAM_CH, this.Ch);
				command.Parameters.AddWithValue(PARAM_ZL, this.Zl);
				command.Parameters.AddWithValue(PARAM_MJDW, this.Mjdw);
				command.Parameters.AddWithValue(PARAM_SJCS, this.Sjcs);
				command.Parameters.AddWithValue(PARAM_HH, this.Hh);
				command.Parameters.AddWithValue(PARAM_SHBW, this.Shbw);
				command.Parameters.AddWithValue(PARAM_HX, this.Hx);
				command.Parameters.AddWithValue(PARAM_HXJG, this.Hxjg);
				command.Parameters.AddWithValue(PARAM_FWYT1, this.Fwyt1);
				command.Parameters.AddWithValue(PARAM_FWYT2, this.Fwyt2);
				command.Parameters.AddWithValue(PARAM_FWYT3, this.Fwyt3);
				command.Parameters.AddWithValue(PARAM_YCJZMJ, this.Ycjzmj);
				command.Parameters.AddWithValue(PARAM_YCTNJZMJ, this.Yctnjzmj);
				command.Parameters.AddWithValue(PARAM_YCFTJZMJ, this.Ycftjzmj);
				command.Parameters.AddWithValue(PARAM_YCDXBFJZMJ, this.Ycdxbfjzmj);
				command.Parameters.AddWithValue(PARAM_YCQTJZMJ, this.Ycqtjzmj);
				command.Parameters.AddWithValue(PARAM_YCFTXS, this.Ycftxs);
				command.Parameters.AddWithValue(PARAM_SCJZMJ, this.Scjzmj);
				command.Parameters.AddWithValue(PARAM_SCTNJZMJ, this.Sctnjzmj);
				command.Parameters.AddWithValue(PARAM_SCFTJZMJ, this.Scftjzmj);
				command.Parameters.AddWithValue(PARAM_SCDXBFJZMJ, this.Scdxbfjzmj);
				command.Parameters.AddWithValue(PARAM_SCQTJZMJ, this.Scqtjzmj);
				command.Parameters.AddWithValue(PARAM_SCFTXS, this.Scftxs);
				command.Parameters.AddWithValue(PARAM_GYTDMJ, this.Gytdmj);
				command.Parameters.AddWithValue(PARAM_FTTDMJ, this.Fttdmj);
				command.Parameters.AddWithValue(PARAM_DYTDMJ, this.Dytdmj);
				command.Parameters.AddWithValue(PARAM_FWLX, this.Fwlx);
				command.Parameters.AddWithValue(PARAM_FWXZ, this.Fwxz);
				command.Parameters.AddWithValue(PARAM_FCFHT, this.Fcfht);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_H,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_H,dao.Connection))
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
			if (!reader.IsDBNull(1)) bdcdyh = reader.GetString(1);
			if (!reader.IsDBNull(2)) fwbm = reader.GetString(2);
			if (!reader.IsDBNull(3)) ysdm = reader.GetString(3);
			if (!reader.IsDBNull(4)) zrzh = reader.GetString(4);
			if (!reader.IsDBNull(5)) ljzh = reader.GetString(5);
			if (!reader.IsDBNull(6)) ch = reader.GetString(6);
			if (!reader.IsDBNull(7)) zl = reader.GetString(7);
			if (!reader.IsDBNull(8)) mjdw = reader.GetString(8);
			if (!reader.IsDBNull(9)) sjcs = reader.GetDouble(9);
			if (!reader.IsDBNull(10)) hh = reader.GetInt64(10);
			if (!reader.IsDBNull(11)) shbw = reader.GetString(11);
			if (!reader.IsDBNull(12)) hx = reader.GetString(12);
			if (!reader.IsDBNull(13)) hxjg = reader.GetString(13);
			if (!reader.IsDBNull(14)) fwyt1 = reader.GetString(14);
			if (!reader.IsDBNull(15)) fwyt2 = reader.GetString(15);
			if (!reader.IsDBNull(16)) fwyt3 = reader.GetString(16);
			if (!reader.IsDBNull(17)) ycjzmj = reader.GetDouble(17);
			if (!reader.IsDBNull(18)) yctnjzmj = reader.GetDouble(18);
			if (!reader.IsDBNull(19)) ycftjzmj = reader.GetDouble(19);
			if (!reader.IsDBNull(20)) ycdxbfjzmj = reader.GetDouble(20);
			if (!reader.IsDBNull(21)) ycqtjzmj = reader.GetDouble(21);
			if (!reader.IsDBNull(22)) ycftxs = reader.GetDouble(22);
			if (!reader.IsDBNull(23)) scjzmj = reader.GetDouble(23);
			if (!reader.IsDBNull(24)) sctnjzmj = reader.GetDouble(24);
			if (!reader.IsDBNull(25)) scftjzmj = reader.GetDouble(25);
			if (!reader.IsDBNull(26)) scdxbfjzmj = reader.GetDouble(26);
			if (!reader.IsDBNull(27)) scqtjzmj = reader.GetDouble(27);
			if (!reader.IsDBNull(28)) scftxs = reader.GetDouble(28);
			if (!reader.IsDBNull(29)) gytdmj = reader.GetDouble(29);
			if (!reader.IsDBNull(30)) fttdmj = reader.GetDouble(30);
			if (!reader.IsDBNull(31)) dytdmj = reader.GetDouble(31);
			if (!reader.IsDBNull(32)) fwlx = reader.GetString(32);
			if (!reader.IsDBNull(33)) fwxz = reader.GetString(33);
			if (!reader.IsDBNull(34)) fcfht = SQLiteHelper.GetBytes(reader,"FCFHT");
			if (!reader.IsDBNull(35)) zt = reader.GetString(35);
			if (!reader.IsDBNull(36)) wxDcy = reader.GetString(36);
			if (!reader.IsDBNull(37)) wxDcsj = reader.GetDateTime(37);
			if (!reader.IsDBNull(38)) wxCly = reader.GetString(38);
			if (!reader.IsDBNull(39)) wxClsj = reader.GetDateTime(39);
			if (!reader.IsDBNull(40)) wxZty = reader.GetString(40);
			if (!reader.IsDBNull(41)) wxZtsj = reader.GetDateTime(41);
			if (!reader.IsDBNull(42)) wxZjy = reader.GetString(42);
			if (!reader.IsDBNull(43)) wxZjsj = reader.GetDateTime(43);
			if (!reader.IsDBNull(44)) wxWydm = reader.GetString(44);
			if (!reader.IsDBNull(45)) databaseid = reader.GetInt64(45);
			if (!reader.IsDBNull(46)) flags = reader.GetInt16(46);
			if (!reader.IsDBNull(47)) xgr = reader.GetString(47);
			if (!reader.IsDBNull(48)) xgsj = reader.GetDateTime(48);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            H target=new H();
            target.ID=0;
            target.Bdcdyh=this.Bdcdyh;
            target.Fwbm=this.Fwbm;
            target.Ysdm=this.Ysdm;
            target.Zrzh=this.Zrzh;
            target.Ljzh=this.Ljzh;
            target.Ch=this.Ch;
            target.Zl=this.Zl;
            target.Mjdw=this.Mjdw;
            target.Sjcs=this.Sjcs;
            target.Hh=this.Hh;
            target.Shbw=this.Shbw;
            target.Hx=this.Hx;
            target.Hxjg=this.Hxjg;
            target.Fwyt1=this.Fwyt1;
            target.Fwyt2=this.Fwyt2;
            target.Fwyt3=this.Fwyt3;
            target.Ycjzmj=this.Ycjzmj;
            target.Yctnjzmj=this.Yctnjzmj;
            target.Ycftjzmj=this.Ycftjzmj;
            target.Ycdxbfjzmj=this.Ycdxbfjzmj;
            target.Ycqtjzmj=this.Ycqtjzmj;
            target.Ycftxs=this.Ycftxs;
            target.Scjzmj=this.Scjzmj;
            target.Sctnjzmj=this.Sctnjzmj;
            target.Scftjzmj=this.Scftjzmj;
            target.Scdxbfjzmj=this.Scdxbfjzmj;
            target.Scqtjzmj=this.Scqtjzmj;
            target.Scftxs=this.Scftxs;
            target.Gytdmj=this.Gytdmj;
            target.Fttdmj=this.Fttdmj;
            target.Dytdmj=this.Dytdmj;
            target.Fwlx=this.Fwlx;
            target.Fwxz=this.Fwxz;
            target.Fcfht=this.Fcfht;
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
