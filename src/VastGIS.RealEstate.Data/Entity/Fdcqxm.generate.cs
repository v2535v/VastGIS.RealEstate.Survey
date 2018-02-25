
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
    public partial class Fdcqxm : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IGlobalEntity,ISurveyEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "FDCQXM";	
        public const string LAYER_NAME = "房地产权（项目内多幢房屋）项目";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_XMMC = "XMMC";
		public const string COL_ZH = "ZH";
		public const string COL_ZCS = "ZCS";
		public const string COL_GHYT = "GHYT";
		public const string COL_FWJG = "FWJG";
		public const string COL_JZMJ = "JZMJ";
		public const string COL_JGSJ = "JGSJ";
		public const string COL_ZTS = "ZTS";
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
        public const string PARAM_XMMC = "@XMMC";	
        public const string PARAM_ZH = "@ZH";	
        public const string PARAM_ZCS = "@ZCS";	
        public const string PARAM_GHYT = "@GHYT";	
        public const string PARAM_FWJG = "@FWJG";	
        public const string PARAM_JZMJ = "@JZMJ";	
        public const string PARAM_JGSJ = "@JGSJ";	
        public const string PARAM_ZTS = "@ZTS";	
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
		private const string SQL_QUERY_FDCQXM ="SELECT  Id,BDCDYH,XMMC,ZH,ZCS,GHYT,FWJG,JZMJ,JGSJ,ZTS,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM FDCQXM WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_FDCQXM = "INSERT INTO [FDCQXM] (BDCDYH, XMMC, ZH, ZCS, GHYT, FWJG, JZMJ, JGSJ, ZTS, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @BDCDYH, @XMMC, @ZH, @ZCS, @GHYT, @FWJG, @JZMJ, @JGSJ, @ZTS, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_FDCQXM = "UPDATE [FDCQXM] SET BDCDYH = @BDCDYH, XMMC = @XMMC, ZH = @ZH, ZCS = @ZCS, GHYT = @GHYT, FWJG = @FWJG, JZMJ = @JZMJ, JGSJ = @JGSJ, ZTS = @ZTS, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_FDCQXM = "DELETE FROM [FDCQXM] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_FDCQXM = "UPDATE [FDCQXM] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///不动产单元号
		protected string bdcdyh = default(string);
        ///项目名称
		protected string xmmc = default(string);
        ///幢号
		protected string zh = default(string);
        ///总层数
		protected long? zcs = default(long?);
        ///规划用途[字典:房屋用途字典表-FWYTZD]
		protected string ghyt = default(string);
        ///房屋结构[字典:房屋结构字典表-FWJGZD]
		protected string fwjg = default(string);
        ///建筑面积
		protected double? jzmj = default(double?);
        ///竣工时间
		protected System.DateTime? jgsj = default(System.DateTime?);
        ///总套数
		protected long? zts = default(long?);
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
            get{return "Fdcqxm";}
        }
         public string LayerName
        {
            get{return "房地产权（项目内多幢房屋）项目";}
        }
        public string EntityName{
            get{return "IDatabaseEntity,IGlobalEntity,ISurveyEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return true;}}
        public bool HasYsdm{get{return false;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return true;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","FDCQXM",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","房地产权（项目内多幢房屋）项目",this.id);
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
		
        ///幢号
        ///[Column(COL_ZH, PARAM_ZH )]
        public virtual string Zh 
        {
            get { return this.zh; }
			set	{ 
                  if(this.zh != value)
                    {
                        this.OnPropertyChanging("Zh"); 
                        this.zh = value;                        
                        this.OnPropertyChanged("Zh");
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
        public Fdcqxm()
        {
            this.id=0;
            this.bdcdyh="";
            this.xmmc="";
            this.zh="";
            this.zcs=0;
            this.ghyt="";
            this.fwjg="";
            this.jzmj=0.0;
            this.jgsj=DateTime.Now;
            this.zts=0;
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
            Fdcqxm record = obj as Fdcqxm;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_FDCQXM,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_XMMC, this.Xmmc);
				command.Parameters.AddWithValue(PARAM_ZH, this.Zh);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_GHYT, this.Ghyt);
				command.Parameters.AddWithValue(PARAM_FWJG, this.Fwjg);
				command.Parameters.AddWithValue(PARAM_JZMJ, this.Jzmj);
				command.Parameters.AddWithValue(PARAM_JGSJ, this.Jgsj);
				command.Parameters.AddWithValue(PARAM_ZTS, this.Zts);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_FDCQXM,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_XMMC, this.Xmmc);
				command.Parameters.AddWithValue(PARAM_ZH, this.Zh);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_GHYT, this.Ghyt);
				command.Parameters.AddWithValue(PARAM_FWJG, this.Fwjg);
				command.Parameters.AddWithValue(PARAM_JZMJ, this.Jzmj);
				command.Parameters.AddWithValue(PARAM_JGSJ, this.Jgsj);
				command.Parameters.AddWithValue(PARAM_ZTS, this.Zts);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FDCQXM,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_FDCQXM,dao.Connection))
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
			if (!reader.IsDBNull(2)) xmmc = reader.GetString(2);
			if (!reader.IsDBNull(3)) zh = reader.GetString(3);
			if (!reader.IsDBNull(4)) zcs = reader.GetInt64(4);
			if (!reader.IsDBNull(5)) ghyt = reader.GetString(5);
			if (!reader.IsDBNull(6)) fwjg = reader.GetString(6);
			if (!reader.IsDBNull(7)) jzmj = reader.GetDouble(7);
			if (!reader.IsDBNull(8)) jgsj = reader.GetDateTime(8);
			if (!reader.IsDBNull(9)) zts = reader.GetInt64(9);
			if (!reader.IsDBNull(10)) wxDcy = reader.GetString(10);
			if (!reader.IsDBNull(11)) wxDcsj = reader.GetDateTime(11);
			if (!reader.IsDBNull(12)) wxCly = reader.GetString(12);
			if (!reader.IsDBNull(13)) wxClsj = reader.GetDateTime(13);
			if (!reader.IsDBNull(14)) wxZty = reader.GetString(14);
			if (!reader.IsDBNull(15)) wxZtsj = reader.GetDateTime(15);
			if (!reader.IsDBNull(16)) wxZjy = reader.GetString(16);
			if (!reader.IsDBNull(17)) wxZjsj = reader.GetDateTime(17);
			if (!reader.IsDBNull(18)) wxWydm = reader.GetString(18);
			if (!reader.IsDBNull(19)) databaseid = reader.GetInt64(19);
			if (!reader.IsDBNull(20)) flags = reader.GetInt16(20);
			if (!reader.IsDBNull(21)) xgr = reader.GetString(21);
			if (!reader.IsDBNull(22)) xgsj = reader.GetDateTime(22);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Fdcqxm target=new Fdcqxm();
            target.ID=0;
            target.Bdcdyh=this.Bdcdyh;
            target.Xmmc=this.Xmmc;
            target.Zh=this.Zh;
            target.Zcs=this.Zcs;
            target.Ghyt=this.Ghyt;
            target.Fwjg=this.Fwjg;
            target.Jzmj=this.Jzmj;
            target.Jgsj=this.Jgsj;
            target.Zts=this.Zts;
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
