
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
    public partial class Sqr : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "SQR";	
        public const string LAYER_NAME = "申请人";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YWH = "YWH";
		public const string COL_YSDM = "YSDM";
		public const string COL_QLRMC = "QLRMC";
		public const string COL_QLRZJZL = "QLRZJZL";
		public const string COL_QLRZJH = "QLRZJH";
		public const string COL_QLRTXDZ = "QLRTXDZ";
		public const string COL_QLRYB = "QLRYB";
		public const string COL_QLRFRMC = "QLRFRMC";
		public const string COL_QLRFRDH = "QLRFRDH";
		public const string COL_QLRDLRMC = "QLRDLRMC";
		public const string COL_QLRDLRDH = "QLRDLRDH";
		public const string COL_QLRDLJG = "QLRDLJG";
		public const string COL_YWRMC = "YWRMC";
		public const string COL_YWRZJZL = "YWRZJZL";
		public const string COL_YWRZJH = "YWRZJH";
		public const string COL_YWRTXDZ = "YWRTXDZ";
		public const string COL_YWRYB = "YWRYB";
		public const string COL_YWRFRMC = "YWRFRMC";
		public const string COL_YWRFRDH = "YWRFRDH";
		public const string COL_YWRDLRMC = "YWRDLRMC";
		public const string COL_YWRDLRDH = "YWRDLRDH";
		public const string COL_YWRDLJG = "YWRDLJG";
		public const string COL_BZ = "BZ";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_QLRMC = "@QLRMC";	
        public const string PARAM_QLRZJZL = "@QLRZJZL";	
        public const string PARAM_QLRZJH = "@QLRZJH";	
        public const string PARAM_QLRTXDZ = "@QLRTXDZ";	
        public const string PARAM_QLRYB = "@QLRYB";	
        public const string PARAM_QLRFRMC = "@QLRFRMC";	
        public const string PARAM_QLRFRDH = "@QLRFRDH";	
        public const string PARAM_QLRDLRMC = "@QLRDLRMC";	
        public const string PARAM_QLRDLRDH = "@QLRDLRDH";	
        public const string PARAM_QLRDLJG = "@QLRDLJG";	
        public const string PARAM_YWRMC = "@YWRMC";	
        public const string PARAM_YWRZJZL = "@YWRZJZL";	
        public const string PARAM_YWRZJH = "@YWRZJH";	
        public const string PARAM_YWRTXDZ = "@YWRTXDZ";	
        public const string PARAM_YWRYB = "@YWRYB";	
        public const string PARAM_YWRFRMC = "@YWRFRMC";	
        public const string PARAM_YWRFRDH = "@YWRFRDH";	
        public const string PARAM_YWRDLRMC = "@YWRDLRMC";	
        public const string PARAM_YWRDLRDH = "@YWRDLRDH";	
        public const string PARAM_YWRDLJG = "@YWRDLJG";	
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_SQR ="SELECT  Id,YWH,YSDM,QLRMC,QLRZJZL,QLRZJH,QLRTXDZ,QLRYB,QLRFRMC,QLRFRDH,QLRDLRMC,QLRDLRDH,QLRDLJG,YWRMC,YWRZJZL,YWRZJH,YWRTXDZ,YWRYB,YWRFRMC,YWRFRDH,YWRDLRMC,YWRDLRDH,YWRDLJG,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM SQR WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_SQR = "INSERT INTO [SQR] (YWH, YSDM, QLRMC, QLRZJZL, QLRZJH, QLRTXDZ, QLRYB, QLRFRMC, QLRFRDH, QLRDLRMC, QLRDLRDH, QLRDLJG, YWRMC, YWRZJZL, YWRZJH, YWRTXDZ, YWRYB, YWRFRMC, YWRFRDH, YWRDLRMC, YWRDLRDH, YWRDLJG, BZ, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YWH, @YSDM, @QLRMC, @QLRZJZL, @QLRZJH, @QLRTXDZ, @QLRYB, @QLRFRMC, @QLRFRDH, @QLRDLRMC, @QLRDLRDH, @QLRDLJG, @YWRMC, @YWRZJZL, @YWRZJH, @YWRTXDZ, @YWRYB, @YWRFRMC, @YWRFRDH, @YWRDLRMC, @YWRDLRDH, @YWRDLJG, @BZ, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_SQR = "UPDATE [SQR] SET YWH = @YWH, YSDM = @YSDM, QLRMC = @QLRMC, QLRZJZL = @QLRZJZL, QLRZJH = @QLRZJH, QLRTXDZ = @QLRTXDZ, QLRYB = @QLRYB, QLRFRMC = @QLRFRMC, QLRFRDH = @QLRFRDH, QLRDLRMC = @QLRDLRMC, QLRDLRDH = @QLRDLRDH, QLRDLJG = @QLRDLJG, YWRMC = @YWRMC, YWRZJZL = @YWRZJZL, YWRZJH = @YWRZJH, YWRTXDZ = @YWRTXDZ, YWRYB = @YWRYB, YWRFRMC = @YWRFRMC, YWRFRDH = @YWRFRDH, YWRDLRMC = @YWRDLRMC, YWRDLRDH = @YWRDLRDH, YWRDLJG = @YWRDLJG, BZ = @BZ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_SQR = "DELETE FROM [SQR] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_SQR = "UPDATE [SQR] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///业务号
		protected string ywh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///权利人名称
		protected string qlrmc = default(string);
        ///权利人证件种类[字典:证件种类字典表-ZJZLZD]
		protected string qlrzjzl = default(string);
        ///权利人证件号
		protected string qlrzjh = default(string);
        ///权利人通讯地址
		protected string qlrtxdz = default(string);
        ///权利人邮编
		protected string qlryb = default(string);
        ///权利人法人名称
		protected string qlrfrmc = default(string);
        ///权利人法人电话
		protected string qlrfrdh = default(string);
        ///权利人代理人名称
		protected string qlrdlrmc = default(string);
        ///权利人代理人电话
		protected string qlrdlrdh = default(string);
        ///权利人代理机构
		protected string qlrdljg = default(string);
        ///义务人名称
		protected string ywrmc = default(string);
        ///义务人证件种类[字典:证件种类字典表-ZJZLZD]
		protected string ywrzjzl = default(string);
        ///义务人证件号
		protected string ywrzjh = default(string);
        ///义务人通讯地址
		protected string ywrtxdz = default(string);
        ///义务人邮编
		protected string ywryb = default(string);
        ///义务人法人名称
		protected string ywrfrmc = default(string);
        ///义务人法人电话
		protected string ywrfrdh = default(string);
        ///义务人代理人名称
		protected string ywrdlrmc = default(string);
        ///义务人代理人电话
		protected string ywrdlrdh = default(string);
        ///义务人代理机构
		protected string ywrdljg = default(string);
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
            get{return "Sqr";}
        }
         public string LayerName
        {
            get{return "申请人";}
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
                return string.Format("{0} {1} ({2})","SQR",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","申请人",this.id,this.ysdm);
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
		
        ///权利人证件种类
        ///[Column(COL_QLRZJZL, PARAM_QLRZJZL )]
        public virtual string Qlrzjzl 
        {
            get { return this.qlrzjzl; }
			set	{ 
                  if(this.qlrzjzl != value)
                    {
                        this.OnPropertyChanging("Qlrzjzl"); 
                        this.qlrzjzl = value;                        
                        this.OnPropertyChanged("Qlrzjzl");
                    }   
                }
        }	
		
        ///权利人证件号
        ///[Column(COL_QLRZJH, PARAM_QLRZJH )]
        public virtual string Qlrzjh 
        {
            get { return this.qlrzjh; }
			set	{ 
                  if(this.qlrzjh != value)
                    {
                        this.OnPropertyChanging("Qlrzjh"); 
                        this.qlrzjh = value;                        
                        this.OnPropertyChanged("Qlrzjh");
                    }   
                }
        }	
		
        ///权利人通讯地址
        ///[Column(COL_QLRTXDZ, PARAM_QLRTXDZ )]
        public virtual string Qlrtxdz 
        {
            get { return this.qlrtxdz; }
			set	{ 
                  if(this.qlrtxdz != value)
                    {
                        this.OnPropertyChanging("Qlrtxdz"); 
                        this.qlrtxdz = value;                        
                        this.OnPropertyChanged("Qlrtxdz");
                    }   
                }
        }	
		
        ///权利人邮编
        ///[Column(COL_QLRYB, PARAM_QLRYB )]
        public virtual string Qlryb 
        {
            get { return this.qlryb; }
			set	{ 
                  if(this.qlryb != value)
                    {
                        this.OnPropertyChanging("Qlryb"); 
                        this.qlryb = value;                        
                        this.OnPropertyChanged("Qlryb");
                    }   
                }
        }	
		
        ///权利人法人名称
        ///[Column(COL_QLRFRMC, PARAM_QLRFRMC )]
        public virtual string Qlrfrmc 
        {
            get { return this.qlrfrmc; }
			set	{ 
                  if(this.qlrfrmc != value)
                    {
                        this.OnPropertyChanging("Qlrfrmc"); 
                        this.qlrfrmc = value;                        
                        this.OnPropertyChanged("Qlrfrmc");
                    }   
                }
        }	
		
        ///权利人法人电话
        ///[Column(COL_QLRFRDH, PARAM_QLRFRDH )]
        public virtual string Qlrfrdh 
        {
            get { return this.qlrfrdh; }
			set	{ 
                  if(this.qlrfrdh != value)
                    {
                        this.OnPropertyChanging("Qlrfrdh"); 
                        this.qlrfrdh = value;                        
                        this.OnPropertyChanged("Qlrfrdh");
                    }   
                }
        }	
		
        ///权利人代理人名称
        ///[Column(COL_QLRDLRMC, PARAM_QLRDLRMC )]
        public virtual string Qlrdlrmc 
        {
            get { return this.qlrdlrmc; }
			set	{ 
                  if(this.qlrdlrmc != value)
                    {
                        this.OnPropertyChanging("Qlrdlrmc"); 
                        this.qlrdlrmc = value;                        
                        this.OnPropertyChanged("Qlrdlrmc");
                    }   
                }
        }	
		
        ///权利人代理人电话
        ///[Column(COL_QLRDLRDH, PARAM_QLRDLRDH )]
        public virtual string Qlrdlrdh 
        {
            get { return this.qlrdlrdh; }
			set	{ 
                  if(this.qlrdlrdh != value)
                    {
                        this.OnPropertyChanging("Qlrdlrdh"); 
                        this.qlrdlrdh = value;                        
                        this.OnPropertyChanged("Qlrdlrdh");
                    }   
                }
        }	
		
        ///权利人代理机构
        ///[Column(COL_QLRDLJG, PARAM_QLRDLJG )]
        public virtual string Qlrdljg 
        {
            get { return this.qlrdljg; }
			set	{ 
                  if(this.qlrdljg != value)
                    {
                        this.OnPropertyChanging("Qlrdljg"); 
                        this.qlrdljg = value;                        
                        this.OnPropertyChanged("Qlrdljg");
                    }   
                }
        }	
		
        ///义务人名称
        ///[Column(COL_YWRMC, PARAM_YWRMC )]
        public virtual string Ywrmc 
        {
            get { return this.ywrmc; }
			set	{ 
                  if(this.ywrmc != value)
                    {
                        this.OnPropertyChanging("Ywrmc"); 
                        this.ywrmc = value;                        
                        this.OnPropertyChanged("Ywrmc");
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
		
        ///义务人通讯地址
        ///[Column(COL_YWRTXDZ, PARAM_YWRTXDZ )]
        public virtual string Ywrtxdz 
        {
            get { return this.ywrtxdz; }
			set	{ 
                  if(this.ywrtxdz != value)
                    {
                        this.OnPropertyChanging("Ywrtxdz"); 
                        this.ywrtxdz = value;                        
                        this.OnPropertyChanged("Ywrtxdz");
                    }   
                }
        }	
		
        ///义务人邮编
        ///[Column(COL_YWRYB, PARAM_YWRYB )]
        public virtual string Ywryb 
        {
            get { return this.ywryb; }
			set	{ 
                  if(this.ywryb != value)
                    {
                        this.OnPropertyChanging("Ywryb"); 
                        this.ywryb = value;                        
                        this.OnPropertyChanged("Ywryb");
                    }   
                }
        }	
		
        ///义务人法人名称
        ///[Column(COL_YWRFRMC, PARAM_YWRFRMC )]
        public virtual string Ywrfrmc 
        {
            get { return this.ywrfrmc; }
			set	{ 
                  if(this.ywrfrmc != value)
                    {
                        this.OnPropertyChanging("Ywrfrmc"); 
                        this.ywrfrmc = value;                        
                        this.OnPropertyChanged("Ywrfrmc");
                    }   
                }
        }	
		
        ///义务人法人电话
        ///[Column(COL_YWRFRDH, PARAM_YWRFRDH )]
        public virtual string Ywrfrdh 
        {
            get { return this.ywrfrdh; }
			set	{ 
                  if(this.ywrfrdh != value)
                    {
                        this.OnPropertyChanging("Ywrfrdh"); 
                        this.ywrfrdh = value;                        
                        this.OnPropertyChanged("Ywrfrdh");
                    }   
                }
        }	
		
        ///义务人代理人名称
        ///[Column(COL_YWRDLRMC, PARAM_YWRDLRMC )]
        public virtual string Ywrdlrmc 
        {
            get { return this.ywrdlrmc; }
			set	{ 
                  if(this.ywrdlrmc != value)
                    {
                        this.OnPropertyChanging("Ywrdlrmc"); 
                        this.ywrdlrmc = value;                        
                        this.OnPropertyChanged("Ywrdlrmc");
                    }   
                }
        }	
		
        ///义务人代理人电话
        ///[Column(COL_YWRDLRDH, PARAM_YWRDLRDH )]
        public virtual string Ywrdlrdh 
        {
            get { return this.ywrdlrdh; }
			set	{ 
                  if(this.ywrdlrdh != value)
                    {
                        this.OnPropertyChanging("Ywrdlrdh"); 
                        this.ywrdlrdh = value;                        
                        this.OnPropertyChanged("Ywrdlrdh");
                    }   
                }
        }	
		
        ///义务人代理机构
        ///[Column(COL_YWRDLJG, PARAM_YWRDLJG )]
        public virtual string Ywrdljg 
        {
            get { return this.ywrdljg; }
			set	{ 
                  if(this.ywrdljg != value)
                    {
                        this.OnPropertyChanging("Ywrdljg"); 
                        this.ywrdljg = value;                        
                        this.OnPropertyChanged("Ywrdljg");
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
		
      
       ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
        }
        #endregion        
        
        #region 创建方法
        public Sqr()
        {
            this.id=0;
            this.ywh="";
            this.ysdm="";
            this.qlrmc="";
            this.qlrzjzl="";
            this.qlrzjh="";
            this.qlrtxdz="";
            this.qlryb="";
            this.qlrfrmc="";
            this.qlrfrdh="";
            this.qlrdlrmc="";
            this.qlrdlrdh="";
            this.qlrdljg="";
            this.ywrmc="";
            this.ywrzjzl="";
            this.ywrzjh="";
            this.ywrtxdz="";
            this.ywryb="";
            this.ywrfrmc="";
            this.ywrfrdh="";
            this.ywrdlrmc="";
            this.ywrdlrdh="";
            this.ywrdljg="";
            this.bz="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Sqr record = obj as Sqr;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_SQR,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_QLRMC, this.Qlrmc);
				command.Parameters.AddWithValue(PARAM_QLRZJZL, this.Qlrzjzl);
				command.Parameters.AddWithValue(PARAM_QLRZJH, this.Qlrzjh);
				command.Parameters.AddWithValue(PARAM_QLRTXDZ, this.Qlrtxdz);
				command.Parameters.AddWithValue(PARAM_QLRYB, this.Qlryb);
				command.Parameters.AddWithValue(PARAM_QLRFRMC, this.Qlrfrmc);
				command.Parameters.AddWithValue(PARAM_QLRFRDH, this.Qlrfrdh);
				command.Parameters.AddWithValue(PARAM_QLRDLRMC, this.Qlrdlrmc);
				command.Parameters.AddWithValue(PARAM_QLRDLRDH, this.Qlrdlrdh);
				command.Parameters.AddWithValue(PARAM_QLRDLJG, this.Qlrdljg);
				command.Parameters.AddWithValue(PARAM_YWRMC, this.Ywrmc);
				command.Parameters.AddWithValue(PARAM_YWRZJZL, this.Ywrzjzl);
				command.Parameters.AddWithValue(PARAM_YWRZJH, this.Ywrzjh);
				command.Parameters.AddWithValue(PARAM_YWRTXDZ, this.Ywrtxdz);
				command.Parameters.AddWithValue(PARAM_YWRYB, this.Ywryb);
				command.Parameters.AddWithValue(PARAM_YWRFRMC, this.Ywrfrmc);
				command.Parameters.AddWithValue(PARAM_YWRFRDH, this.Ywrfrdh);
				command.Parameters.AddWithValue(PARAM_YWRDLRMC, this.Ywrdlrmc);
				command.Parameters.AddWithValue(PARAM_YWRDLRDH, this.Ywrdlrdh);
				command.Parameters.AddWithValue(PARAM_YWRDLJG, this.Ywrdljg);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_SQR,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_QLRMC, this.Qlrmc);
				command.Parameters.AddWithValue(PARAM_QLRZJZL, this.Qlrzjzl);
				command.Parameters.AddWithValue(PARAM_QLRZJH, this.Qlrzjh);
				command.Parameters.AddWithValue(PARAM_QLRTXDZ, this.Qlrtxdz);
				command.Parameters.AddWithValue(PARAM_QLRYB, this.Qlryb);
				command.Parameters.AddWithValue(PARAM_QLRFRMC, this.Qlrfrmc);
				command.Parameters.AddWithValue(PARAM_QLRFRDH, this.Qlrfrdh);
				command.Parameters.AddWithValue(PARAM_QLRDLRMC, this.Qlrdlrmc);
				command.Parameters.AddWithValue(PARAM_QLRDLRDH, this.Qlrdlrdh);
				command.Parameters.AddWithValue(PARAM_QLRDLJG, this.Qlrdljg);
				command.Parameters.AddWithValue(PARAM_YWRMC, this.Ywrmc);
				command.Parameters.AddWithValue(PARAM_YWRZJZL, this.Ywrzjzl);
				command.Parameters.AddWithValue(PARAM_YWRZJH, this.Ywrzjh);
				command.Parameters.AddWithValue(PARAM_YWRTXDZ, this.Ywrtxdz);
				command.Parameters.AddWithValue(PARAM_YWRYB, this.Ywryb);
				command.Parameters.AddWithValue(PARAM_YWRFRMC, this.Ywrfrmc);
				command.Parameters.AddWithValue(PARAM_YWRFRDH, this.Ywrfrdh);
				command.Parameters.AddWithValue(PARAM_YWRDLRMC, this.Ywrdlrmc);
				command.Parameters.AddWithValue(PARAM_YWRDLRDH, this.Ywrdlrdh);
				command.Parameters.AddWithValue(PARAM_YWRDLJG, this.Ywrdljg);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_SQR,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_SQR,dao.Connection))
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
			if (!reader.IsDBNull(1)) ywh = reader.GetString(1);
			if (!reader.IsDBNull(2)) ysdm = reader.GetString(2);
			if (!reader.IsDBNull(3)) qlrmc = reader.GetString(3);
			if (!reader.IsDBNull(4)) qlrzjzl = reader.GetString(4);
			if (!reader.IsDBNull(5)) qlrzjh = reader.GetString(5);
			if (!reader.IsDBNull(6)) qlrtxdz = reader.GetString(6);
			if (!reader.IsDBNull(7)) qlryb = reader.GetString(7);
			if (!reader.IsDBNull(8)) qlrfrmc = reader.GetString(8);
			if (!reader.IsDBNull(9)) qlrfrdh = reader.GetString(9);
			if (!reader.IsDBNull(10)) qlrdlrmc = reader.GetString(10);
			if (!reader.IsDBNull(11)) qlrdlrdh = reader.GetString(11);
			if (!reader.IsDBNull(12)) qlrdljg = reader.GetString(12);
			if (!reader.IsDBNull(13)) ywrmc = reader.GetString(13);
			if (!reader.IsDBNull(14)) ywrzjzl = reader.GetString(14);
			if (!reader.IsDBNull(15)) ywrzjh = reader.GetString(15);
			if (!reader.IsDBNull(16)) ywrtxdz = reader.GetString(16);
			if (!reader.IsDBNull(17)) ywryb = reader.GetString(17);
			if (!reader.IsDBNull(18)) ywrfrmc = reader.GetString(18);
			if (!reader.IsDBNull(19)) ywrfrdh = reader.GetString(19);
			if (!reader.IsDBNull(20)) ywrdlrmc = reader.GetString(20);
			if (!reader.IsDBNull(21)) ywrdlrdh = reader.GetString(21);
			if (!reader.IsDBNull(22)) ywrdljg = reader.GetString(22);
			if (!reader.IsDBNull(23)) bz = reader.GetString(23);
			if (!reader.IsDBNull(24)) databaseid = reader.GetInt64(24);
			if (!reader.IsDBNull(25)) flags = reader.GetInt16(25);
			if (!reader.IsDBNull(26)) xgr = reader.GetString(26);
			if (!reader.IsDBNull(27)) xgsj = reader.GetDateTime(27);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Sqr target=new Sqr();
            target.ID=0;
            target.Ywh=this.Ywh;
            target.Ysdm=this.Ysdm;
            target.Qlrmc=this.Qlrmc;
            target.Qlrzjzl=this.Qlrzjzl;
            target.Qlrzjh=this.Qlrzjh;
            target.Qlrtxdz=this.Qlrtxdz;
            target.Qlryb=this.Qlryb;
            target.Qlrfrmc=this.Qlrfrmc;
            target.Qlrfrdh=this.Qlrfrdh;
            target.Qlrdlrmc=this.Qlrdlrmc;
            target.Qlrdlrdh=this.Qlrdlrdh;
            target.Qlrdljg=this.Qlrdljg;
            target.Ywrmc=this.Ywrmc;
            target.Ywrzjzl=this.Ywrzjzl;
            target.Ywrzjh=this.Ywrzjh;
            target.Ywrtxdz=this.Ywrtxdz;
            target.Ywryb=this.Ywryb;
            target.Ywrfrmc=this.Ywrfrmc;
            target.Ywrfrdh=this.Ywrfrdh;
            target.Ywrdlrmc=this.Ywrdlrmc;
            target.Ywrdlrdh=this.Ywrdlrdh;
            target.Ywrdljg=this.Ywrdljg;
            target.Bz=this.Bz;
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
