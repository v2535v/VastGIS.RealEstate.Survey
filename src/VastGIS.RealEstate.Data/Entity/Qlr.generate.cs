
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
    public partial class Qlr : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity,IGlobalEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "QLR";	
        public const string LAYER_NAME = "权利人";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_SXH = "SXH";
		public const string COL_QLRMC = "QLRMC";
		public const string COL_BDCQZH = "BDCQZH";
		public const string COL_QZYSXLH = "QZYSXLH";
		public const string COL_SFCZR = "SFCZR";
		public const string COL_ZJZL = "ZJZL";
		public const string COL_ZJH = "ZJH";
		public const string COL_FZJG = "FZJG";
		public const string COL_SSHY = "SSHY";
		public const string COL_GJ = "GJ";
		public const string COL_HJSZSS = "HJSZSS";
		public const string COL_XB = "XB";
		public const string COL_DH = "DH";
		public const string COL_DZ = "DZ";
		public const string COL_YB = "YB";
		public const string COL_GZDW = "GZDW";
		public const string COL_DZYJ = "DZYJ";
		public const string COL_QLRLX = "QLRLX";
		public const string COL_QLBL = "QLBL";
		public const string COL_GYFS = "GYFS";
		public const string COL_GYQK = "GYQK";
		public const string COL_BZ = "BZ";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		public const string COL_WX_WYDM = "WX_WYDM";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_SXH = "@SXH";	
        public const string PARAM_QLRMC = "@QLRMC";	
        public const string PARAM_BDCQZH = "@BDCQZH";	
        public const string PARAM_QZYSXLH = "@QZYSXLH";	
        public const string PARAM_SFCZR = "@SFCZR";	
        public const string PARAM_ZJZL = "@ZJZL";	
        public const string PARAM_ZJH = "@ZJH";	
        public const string PARAM_FZJG = "@FZJG";	
        public const string PARAM_SSHY = "@SSHY";	
        public const string PARAM_GJ = "@GJ";	
        public const string PARAM_HJSZSS = "@HJSZSS";	
        public const string PARAM_XB = "@XB";	
        public const string PARAM_DH = "@DH";	
        public const string PARAM_DZ = "@DZ";	
        public const string PARAM_YB = "@YB";	
        public const string PARAM_GZDW = "@GZDW";	
        public const string PARAM_DZYJ = "@DZYJ";	
        public const string PARAM_QLRLX = "@QLRLX";	
        public const string PARAM_QLBL = "@QLBL";	
        public const string PARAM_GYFS = "@GYFS";	
        public const string PARAM_GYQK = "@GYQK";	
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
        public const string PARAM_WX_WYDM = "@WX_WYDM";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_QLR ="SELECT  Id,YSDM,BDCDYH,SXH,QLRMC,BDCQZH,QZYSXLH,SFCZR,ZJZL,ZJH,FZJG,SSHY,GJ,HJSZSS,XB,DH,DZ,YB,GZDW,DZYJ,QLRLX,QLBL,GYFS,GYQK,BZ,DatabaseId,FLAGS,XGR,XGSJ,WX_WYDM FROM QLR WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_QLR = "INSERT INTO [QLR] (YSDM, BDCDYH, SXH, QLRMC, BDCQZH, QZYSXLH, SFCZR, ZJZL, ZJH, FZJG, SSHY, GJ, HJSZSS, XB, DH, DZ, YB, GZDW, DZYJ, QLRLX, QLBL, GYFS, GYQK, BZ, DatabaseId, FLAGS, XGR, XGSJ, WX_WYDM) VALUES ( @YSDM, @BDCDYH, @SXH, @QLRMC, @BDCQZH, @QZYSXLH, @SFCZR, @ZJZL, @ZJH, @FZJG, @SSHY, @GJ, @HJSZSS, @XB, @DH, @DZ, @YB, @GZDW, @DZYJ, @QLRLX, @QLBL, @GYFS, @GYQK, @BZ, @DatabaseId, @FLAGS, @XGR, @XGSJ, @WX_WYDM);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_QLR = "UPDATE [QLR] SET YSDM = @YSDM, BDCDYH = @BDCDYH, SXH = @SXH, QLRMC = @QLRMC, BDCQZH = @BDCQZH, QZYSXLH = @QZYSXLH, SFCZR = @SFCZR, ZJZL = @ZJZL, ZJH = @ZJH, FZJG = @FZJG, SSHY = @SSHY, GJ = @GJ, HJSZSS = @HJSZSS, XB = @XB, DH = @DH, DZ = @DZ, YB = @YB, GZDW = @GZDW, DZYJ = @DZYJ, QLRLX = @QLRLX, QLBL = @QLBL, GYFS = @GYFS, GYQK = @GYQK, BZ = @BZ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ, WX_WYDM = @WX_WYDM WHERE Id = @Id";
		
		private const string SQL_DELETE_QLR = "DELETE FROM [QLR] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_QLR = "UPDATE [QLR] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///不动产单元号
		protected string bdcdyh = default(string);
        ///顺序号
		protected long? sxh = default(long?);
        ///权利人名称
		protected string qlrmc = default(string);
        ///不动产权证号
		protected string bdcqzh = default(string);
        ///权证印刷序列号
		protected string qzysxlh = default(string);
        ///是否持证人[字典:是否字典表-SFZD]
		protected string sfczr = default(string);
        ///证件种类[字典:证件种类字典表-ZJZLZD]
		protected string zjzl = default(string);
        ///证件号
		protected string zjh = default(string);
        ///发证机关
		protected string fzjg = default(string);
        ///所属行业
		protected string sshy = default(string);
        ///国家/地区[字典:国家和地区字典表-GJHDQZD]
		protected string gj = default(string);
        ///户籍所在省市[字典:省市字典表-SSZD]
		protected string hjszss = default(string);
        ///性别[字典:性别字典表-XBZD]
		protected string xb = default(string);
        ///电话
		protected string dh = default(string);
        ///地址
		protected string dz = default(string);
        ///邮编
		protected string yb = default(string);
        ///工作单位
		protected string gzdw = default(string);
        ///电子邮件
		protected string dzyj = default(string);
        ///权利人类型[字典:权利人类型字典表-QLRLXZD]
		protected string qlrlx = default(string);
        ///权利比例
		protected string qlbl = default(string);
        ///共有方式[字典:共有方式字典表-GYFSZD]
		protected string gyfs = default(string);
        ///共有情况
		protected string gyqk = default(string);
        ///备注
		protected string bz = default(string);
        ///原数据库内序号
		protected long? databaseid = default(long?);
        ///修改标记
		protected short? flags = default(short?);
        ///修改人
		protected string xgr = default(string);
        ///修改时间
		protected System.DateTime? xgsj = default(System.DateTime?);
        ///全局唯一代码
		protected string wxWydm = default(string);
        
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
            get{return "Qlr";}
        }
         public string LayerName
        {
            get{return "权利人";}
        }
        public string EntityName{
            get{return "IDatabaseEntity,IYsdmEntity,IGlobalEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return true;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","QLR",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","权利人",this.id,this.ysdm);
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
		
        ///顺序号
        ///[Column(COL_SXH, PARAM_SXH )]
        public virtual long? Sxh 
        {
            get { return this.sxh; }
			set	{ 
                  if(this.sxh != value)
                    {
                        this.OnPropertyChanging("Sxh"); 
                        this.sxh = value;                        
                        this.OnPropertyChanged("Sxh");
                    }   
                }
        }	
		
        ///权利人名称
        ///[Column(COL_QLRMC, PARAM_QLRMC )]
        public virtual string Qlrmc 
        {
            get { return this.qlrmc; }
			set	{ 
                  if(this.qlrmc != value)
                    {
                        this.OnPropertyChanging("Qlrmc"); 
                        this.qlrmc = value;                        
                        this.OnPropertyChanged("Qlrmc");
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
		
        ///权证印刷序列号
        ///[Column(COL_QZYSXLH, PARAM_QZYSXLH )]
        public virtual string Qzysxlh 
        {
            get { return this.qzysxlh; }
			set	{ 
                  if(this.qzysxlh != value)
                    {
                        this.OnPropertyChanging("Qzysxlh"); 
                        this.qzysxlh = value;                        
                        this.OnPropertyChanged("Qzysxlh");
                    }   
                }
        }	
		
        ///是否持证人
        ///[Column(COL_SFCZR, PARAM_SFCZR )]
        public virtual string Sfczr 
        {
            get { return this.sfczr; }
			set	{ 
                  if(this.sfczr != value)
                    {
                        this.OnPropertyChanging("Sfczr"); 
                        this.sfczr = value;                        
                        this.OnPropertyChanged("Sfczr");
                    }   
                }
        }	
		
        ///证件种类
        ///[Column(COL_ZJZL, PARAM_ZJZL )]
        public virtual string Zjzl 
        {
            get { return this.zjzl; }
			set	{ 
                  if(this.zjzl != value)
                    {
                        this.OnPropertyChanging("Zjzl"); 
                        this.zjzl = value;                        
                        this.OnPropertyChanged("Zjzl");
                    }   
                }
        }	
		
        ///证件号
        ///[Column(COL_ZJH, PARAM_ZJH )]
        public virtual string Zjh 
        {
            get { return this.zjh; }
			set	{ 
                  if(this.zjh != value)
                    {
                        this.OnPropertyChanging("Zjh"); 
                        this.zjh = value;                        
                        this.OnPropertyChanged("Zjh");
                    }   
                }
        }	
		
        ///发证机关
        ///[Column(COL_FZJG, PARAM_FZJG )]
        public virtual string Fzjg 
        {
            get { return this.fzjg; }
			set	{ 
                  if(this.fzjg != value)
                    {
                        this.OnPropertyChanging("Fzjg"); 
                        this.fzjg = value;                        
                        this.OnPropertyChanged("Fzjg");
                    }   
                }
        }	
		
        ///所属行业
        ///[Column(COL_SSHY, PARAM_SSHY )]
        public virtual string Sshy 
        {
            get { return this.sshy; }
			set	{ 
                  if(this.sshy != value)
                    {
                        this.OnPropertyChanging("Sshy"); 
                        this.sshy = value;                        
                        this.OnPropertyChanged("Sshy");
                    }   
                }
        }	
		
        ///国家/地区
        ///[Column(COL_GJ, PARAM_GJ )]
        public virtual string Gj 
        {
            get { return this.gj; }
			set	{ 
                  if(this.gj != value)
                    {
                        this.OnPropertyChanging("Gj"); 
                        this.gj = value;                        
                        this.OnPropertyChanged("Gj");
                    }   
                }
        }	
		
        ///户籍所在省市
        ///[Column(COL_HJSZSS, PARAM_HJSZSS )]
        public virtual string Hjszss 
        {
            get { return this.hjszss; }
			set	{ 
                  if(this.hjszss != value)
                    {
                        this.OnPropertyChanging("Hjszss"); 
                        this.hjszss = value;                        
                        this.OnPropertyChanged("Hjszss");
                    }   
                }
        }	
		
        ///性别
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
		
        ///电话
        ///[Column(COL_DH, PARAM_DH )]
        public virtual string Dh 
        {
            get { return this.dh; }
			set	{ 
                  if(this.dh != value)
                    {
                        this.OnPropertyChanging("Dh"); 
                        this.dh = value;                        
                        this.OnPropertyChanged("Dh");
                    }   
                }
        }	
		
        ///地址
        ///[Column(COL_DZ, PARAM_DZ )]
        public virtual string Dz 
        {
            get { return this.dz; }
			set	{ 
                  if(this.dz != value)
                    {
                        this.OnPropertyChanging("Dz"); 
                        this.dz = value;                        
                        this.OnPropertyChanged("Dz");
                    }   
                }
        }	
		
        ///邮编
        ///[Column(COL_YB, PARAM_YB )]
        public virtual string Yb 
        {
            get { return this.yb; }
			set	{ 
                  if(this.yb != value)
                    {
                        this.OnPropertyChanging("Yb"); 
                        this.yb = value;                        
                        this.OnPropertyChanged("Yb");
                    }   
                }
        }	
		
        ///工作单位
        ///[Column(COL_GZDW, PARAM_GZDW )]
        public virtual string Gzdw 
        {
            get { return this.gzdw; }
			set	{ 
                  if(this.gzdw != value)
                    {
                        this.OnPropertyChanging("Gzdw"); 
                        this.gzdw = value;                        
                        this.OnPropertyChanged("Gzdw");
                    }   
                }
        }	
		
        ///电子邮件
        ///[Column(COL_DZYJ, PARAM_DZYJ )]
        public virtual string Dzyj 
        {
            get { return this.dzyj; }
			set	{ 
                  if(this.dzyj != value)
                    {
                        this.OnPropertyChanging("Dzyj"); 
                        this.dzyj = value;                        
                        this.OnPropertyChanged("Dzyj");
                    }   
                }
        }	
		
        ///权利人类型
        ///[Column(COL_QLRLX, PARAM_QLRLX )]
        public virtual string Qlrlx 
        {
            get { return this.qlrlx; }
			set	{ 
                  if(this.qlrlx != value)
                    {
                        this.OnPropertyChanging("Qlrlx"); 
                        this.qlrlx = value;                        
                        this.OnPropertyChanged("Qlrlx");
                    }   
                }
        }	
		
        ///权利比例
        ///[Column(COL_QLBL, PARAM_QLBL )]
        public virtual string Qlbl 
        {
            get { return this.qlbl; }
			set	{ 
                  if(this.qlbl != value)
                    {
                        this.OnPropertyChanging("Qlbl"); 
                        this.qlbl = value;                        
                        this.OnPropertyChanged("Qlbl");
                    }   
                }
        }	
		
        ///共有方式
        ///[Column(COL_GYFS, PARAM_GYFS )]
        public virtual string Gyfs 
        {
            get { return this.gyfs; }
			set	{ 
                  if(this.gyfs != value)
                    {
                        this.OnPropertyChanging("Gyfs"); 
                        this.gyfs = value;                        
                        this.OnPropertyChanged("Gyfs");
                    }   
                }
        }	
		
        ///共有情况
        ///[Column(COL_GYQK, PARAM_GYQK )]
        public virtual string Gyqk 
        {
            get { return this.gyqk; }
			set	{ 
                  if(this.gyqk != value)
                    {
                        this.OnPropertyChanging("Gyqk"); 
                        this.gyqk = value;                        
                        this.OnPropertyChanged("Gyqk");
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
		
      
       ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
        }
        #endregion        
        
        #region 创建方法
        public Qlr()
        {
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.sxh=0;
            this.qlrmc="";
            this.bdcqzh="";
            this.qzysxlh="";
            this.sfczr="";
            this.zjzl="";
            this.zjh="";
            this.fzjg="";
            this.sshy="";
            this.gj="";
            this.hjszss="";
            this.xb="";
            this.dh="";
            this.dz="";
            this.yb="";
            this.gzdw="";
            this.dzyj="";
            this.qlrlx="";
            this.qlbl="";
            this.gyfs="";
            this.gyqk="";
            this.bz="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
            this.wxWydm=Guid.NewGuid().ToString();
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Qlr record = obj as Qlr;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_QLR,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_SXH, this.Sxh);
				command.Parameters.AddWithValue(PARAM_QLRMC, this.Qlrmc);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QZYSXLH, this.Qzysxlh);
				command.Parameters.AddWithValue(PARAM_SFCZR, this.Sfczr);
				command.Parameters.AddWithValue(PARAM_ZJZL, this.Zjzl);
				command.Parameters.AddWithValue(PARAM_ZJH, this.Zjh);
				command.Parameters.AddWithValue(PARAM_FZJG, this.Fzjg);
				command.Parameters.AddWithValue(PARAM_SSHY, this.Sshy);
				command.Parameters.AddWithValue(PARAM_GJ, this.Gj);
				command.Parameters.AddWithValue(PARAM_HJSZSS, this.Hjszss);
				command.Parameters.AddWithValue(PARAM_XB, this.Xb);
				command.Parameters.AddWithValue(PARAM_DH, this.Dh);
				command.Parameters.AddWithValue(PARAM_DZ, this.Dz);
				command.Parameters.AddWithValue(PARAM_YB, this.Yb);
				command.Parameters.AddWithValue(PARAM_GZDW, this.Gzdw);
				command.Parameters.AddWithValue(PARAM_DZYJ, this.Dzyj);
				command.Parameters.AddWithValue(PARAM_QLRLX, this.Qlrlx);
				command.Parameters.AddWithValue(PARAM_QLBL, this.Qlbl);
				command.Parameters.AddWithValue(PARAM_GYFS, this.Gyfs);
				command.Parameters.AddWithValue(PARAM_GYQK, this.Gyqk);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
				command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_QLR,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_SXH, this.Sxh);
				command.Parameters.AddWithValue(PARAM_QLRMC, this.Qlrmc);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QZYSXLH, this.Qzysxlh);
				command.Parameters.AddWithValue(PARAM_SFCZR, this.Sfczr);
				command.Parameters.AddWithValue(PARAM_ZJZL, this.Zjzl);
				command.Parameters.AddWithValue(PARAM_ZJH, this.Zjh);
				command.Parameters.AddWithValue(PARAM_FZJG, this.Fzjg);
				command.Parameters.AddWithValue(PARAM_SSHY, this.Sshy);
				command.Parameters.AddWithValue(PARAM_GJ, this.Gj);
				command.Parameters.AddWithValue(PARAM_HJSZSS, this.Hjszss);
				command.Parameters.AddWithValue(PARAM_XB, this.Xb);
				command.Parameters.AddWithValue(PARAM_DH, this.Dh);
				command.Parameters.AddWithValue(PARAM_DZ, this.Dz);
				command.Parameters.AddWithValue(PARAM_YB, this.Yb);
				command.Parameters.AddWithValue(PARAM_GZDW, this.Gzdw);
				command.Parameters.AddWithValue(PARAM_DZYJ, this.Dzyj);
				command.Parameters.AddWithValue(PARAM_QLRLX, this.Qlrlx);
				command.Parameters.AddWithValue(PARAM_QLBL, this.Qlbl);
				command.Parameters.AddWithValue(PARAM_GYFS, this.Gyfs);
				command.Parameters.AddWithValue(PARAM_GYQK, this.Gyqk);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
				command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
			   
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_QLR,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_QLR,dao.Connection))
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
			if (!reader.IsDBNull(3)) sxh = reader.GetInt64(3);
			if (!reader.IsDBNull(4)) qlrmc = reader.GetString(4);
			if (!reader.IsDBNull(5)) bdcqzh = reader.GetString(5);
			if (!reader.IsDBNull(6)) qzysxlh = reader.GetString(6);
			if (!reader.IsDBNull(7)) sfczr = reader.GetString(7);
			if (!reader.IsDBNull(8)) zjzl = reader.GetString(8);
			if (!reader.IsDBNull(9)) zjh = reader.GetString(9);
			if (!reader.IsDBNull(10)) fzjg = reader.GetString(10);
			if (!reader.IsDBNull(11)) sshy = reader.GetString(11);
			if (!reader.IsDBNull(12)) gj = reader.GetString(12);
			if (!reader.IsDBNull(13)) hjszss = reader.GetString(13);
			if (!reader.IsDBNull(14)) xb = reader.GetString(14);
			if (!reader.IsDBNull(15)) dh = reader.GetString(15);
			if (!reader.IsDBNull(16)) dz = reader.GetString(16);
			if (!reader.IsDBNull(17)) yb = reader.GetString(17);
			if (!reader.IsDBNull(18)) gzdw = reader.GetString(18);
			if (!reader.IsDBNull(19)) dzyj = reader.GetString(19);
			if (!reader.IsDBNull(20)) qlrlx = reader.GetString(20);
			if (!reader.IsDBNull(21)) qlbl = reader.GetString(21);
			if (!reader.IsDBNull(22)) gyfs = reader.GetString(22);
			if (!reader.IsDBNull(23)) gyqk = reader.GetString(23);
			if (!reader.IsDBNull(24)) bz = reader.GetString(24);
			if (!reader.IsDBNull(25)) databaseid = reader.GetInt64(25);
			if (!reader.IsDBNull(26)) flags = reader.GetInt16(26);
			if (!reader.IsDBNull(27)) xgr = reader.GetString(27);
			if (!reader.IsDBNull(28)) xgsj = reader.GetDateTime(28);
			if (!reader.IsDBNull(29)) wxWydm = reader.GetString(29);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Qlr target=new Qlr();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Sxh=this.Sxh;
            target.Qlrmc=this.Qlrmc;
            target.Bdcqzh=this.Bdcqzh;
            target.Qzysxlh=this.Qzysxlh;
            target.Sfczr=this.Sfczr;
            target.Zjzl=this.Zjzl;
            target.Zjh=this.Zjh;
            target.Fzjg=this.Fzjg;
            target.Sshy=this.Sshy;
            target.Gj=this.Gj;
            target.Hjszss=this.Hjszss;
            target.Xb=this.Xb;
            target.Dh=this.Dh;
            target.Dz=this.Dz;
            target.Yb=this.Yb;
            target.Gzdw=this.Gzdw;
            target.Dzyj=this.Dzyj;
            target.Qlrlx=this.Qlrlx;
            target.Qlbl=this.Qlbl;
            target.Gyfs=this.Gyfs;
            target.Gyqk=this.Gyqk;
            target.Bz=this.Bz;
            target.DatabaseID=0;
            target.Flags=1;
            target.Xgr=Environment.UserName;
            target.Xgsj=DateTime.Now;
            target.WxWydm=Guid.NewGuid().ToString();
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
