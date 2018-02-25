
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
    public partial class Ljz : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "LJZ";	
        public const string LAYER_NAME = "逻辑幢";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_LJZH = "LJZH";
		public const string COL_ZRZH = "ZRZH";
		public const string COL_YSDM = "YSDM";
		public const string COL_MPH = "MPH";
		public const string COL_YCJZMJ = "YCJZMJ";
		public const string COL_YCDXMJ = "YCDXMJ";
		public const string COL_YCQTMJ = "YCQTMJ";
		public const string COL_SCJZMJ = "SCJZMJ";
		public const string COL_SCDXMJ = "SCDXMJ";
		public const string COL_SCQTMJ = "SCQTMJ";
		public const string COL_JGRQ = "JGRQ";
		public const string COL_FWJG1 = "FWJG1";
		public const string COL_FWJG2 = "FWJG2";
		public const string COL_FWJG3 = "FWJG3";
		public const string COL_JZWZT = "JZWZT";
		public const string COL_FWYT1 = "FWYT1";
		public const string COL_FWYT2 = "FWYT2";
		public const string COL_FWYT3 = "FWYT3";
		public const string COL_ZCS = "ZCS";
		public const string COL_DSCS = "DSCS";
		public const string COL_DXCS = "DXCS";
		public const string COL_BZ = "BZ";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_LJZH = "@LJZH";	
        public const string PARAM_ZRZH = "@ZRZH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_MPH = "@MPH";	
        public const string PARAM_YCJZMJ = "@YCJZMJ";	
        public const string PARAM_YCDXMJ = "@YCDXMJ";	
        public const string PARAM_YCQTMJ = "@YCQTMJ";	
        public const string PARAM_SCJZMJ = "@SCJZMJ";	
        public const string PARAM_SCDXMJ = "@SCDXMJ";	
        public const string PARAM_SCQTMJ = "@SCQTMJ";	
        public const string PARAM_JGRQ = "@JGRQ";	
        public const string PARAM_FWJG1 = "@FWJG1";	
        public const string PARAM_FWJG2 = "@FWJG2";	
        public const string PARAM_FWJG3 = "@FWJG3";	
        public const string PARAM_JZWZT = "@JZWZT";	
        public const string PARAM_FWYT1 = "@FWYT1";	
        public const string PARAM_FWYT2 = "@FWYT2";	
        public const string PARAM_FWYT3 = "@FWYT3";	
        public const string PARAM_ZCS = "@ZCS";	
        public const string PARAM_DSCS = "@DSCS";	
        public const string PARAM_DXCS = "@DXCS";	
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_LJZ ="SELECT  Id,LJZH,ZRZH,YSDM,MPH,YCJZMJ,YCDXMJ,YCQTMJ,SCJZMJ,SCDXMJ,SCQTMJ,JGRQ,FWJG1,FWJG2,FWJG3,JZWZT,FWYT1,FWYT2,FWYT3,ZCS,DSCS,DXCS,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM LJZ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_LJZ = "INSERT INTO [LJZ] (LJZH, ZRZH, YSDM, MPH, YCJZMJ, YCDXMJ, YCQTMJ, SCJZMJ, SCDXMJ, SCQTMJ, JGRQ, FWJG1, FWJG2, FWJG3, JZWZT, FWYT1, FWYT2, FWYT3, ZCS, DSCS, DXCS, BZ, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @LJZH, @ZRZH, @YSDM, @MPH, @YCJZMJ, @YCDXMJ, @YCQTMJ, @SCJZMJ, @SCDXMJ, @SCQTMJ, @JGRQ, @FWJG1, @FWJG2, @FWJG3, @JZWZT, @FWYT1, @FWYT2, @FWYT3, @ZCS, @DSCS, @DXCS, @BZ, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_LJZ = "UPDATE [LJZ] SET LJZH = @LJZH, ZRZH = @ZRZH, YSDM = @YSDM, MPH = @MPH, YCJZMJ = @YCJZMJ, YCDXMJ = @YCDXMJ, YCQTMJ = @YCQTMJ, SCJZMJ = @SCJZMJ, SCDXMJ = @SCDXMJ, SCQTMJ = @SCQTMJ, JGRQ = @JGRQ, FWJG1 = @FWJG1, FWJG2 = @FWJG2, FWJG3 = @FWJG3, JZWZT = @JZWZT, FWYT1 = @FWYT1, FWYT2 = @FWYT2, FWYT3 = @FWYT3, ZCS = @ZCS, DSCS = @DSCS, DXCS = @DXCS, BZ = @BZ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_LJZ = "DELETE FROM [LJZ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_LJZ = "UPDATE [LJZ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///逻辑幢号
		protected string ljzh = default(string);
        ///自然幢号
		protected string zrzh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///门牌号
		protected string mph = default(string);
        ///预测建筑面积
		protected double? ycjzmj = default(double?);
        ///预测地下面积
		protected double? ycdxmj = default(double?);
        ///预测其它面积
		protected double? ycqtmj = default(double?);
        ///实测建筑面积
		protected double? scjzmj = default(double?);
        ///实测地下面积
		protected double? scdxmj = default(double?);
        ///实测其它面积
		protected double? scqtmj = default(double?);
        ///竣工日期
		protected System.DateTime? jgrq = default(System.DateTime?);
        ///房屋结构1[字典:房屋结构字典表-FWJGZD]
		protected string fwjg1 = default(string);
        ///房屋结构2[字典:房屋结构字典表-FWJGZD]
		protected string fwjg2 = default(string);
        ///房屋结构3[字典:房屋结构字典表-FWJGZD]
		protected string fwjg3 = default(string);
        ///建筑物状态[字典:建筑物状态字典表-JZWZTZD]
		protected string jzwzt = default(string);
        ///房屋用途1[字典:房屋用途字典表-FWYTZD]
		protected string fwyt1 = default(string);
        ///房屋用途2[字典:房屋用途字典表-FWYTZD]
		protected string fwyt2 = default(string);
        ///房屋用途3[字典:房屋用途字典表-FWYTZD]
		protected string fwyt3 = default(string);
        ///总层数
		protected long? zcs = default(long?);
        ///地上层数
		protected long? dscs = default(long?);
        ///地下层数
		protected long? dxcs = default(long?);
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
            get{return "Ljz";}
        }
         public string LayerName
        {
            get{return "逻辑幢";}
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
                return string.Format("{0} {1} ({2})","LJZ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","逻辑幢",this.id,this.ysdm);
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
		
        ///门牌号
        ///[Column(COL_MPH, PARAM_MPH )]
        public virtual string Mph 
        {
            get { return this.mph; }
			set	{ 
                  if(this.mph != value)
                    {
                        this.OnPropertyChanging("Mph"); 
                        this.mph = value;                        
                        this.OnPropertyChanged("Mph");
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
		
        ///预测地下面积
        ///[Column(COL_YCDXMJ, PARAM_YCDXMJ )]
        public virtual double? Ycdxmj 
        {
            get { return this.ycdxmj; }
			set	{ 
                  if(this.ycdxmj != value)
                    {
                        this.OnPropertyChanging("Ycdxmj"); 
                        this.ycdxmj = value;                        
                        this.OnPropertyChanged("Ycdxmj");
                    }   
                }
        }	
		
        ///预测其它面积
        ///[Column(COL_YCQTMJ, PARAM_YCQTMJ )]
        public virtual double? Ycqtmj 
        {
            get { return this.ycqtmj; }
			set	{ 
                  if(this.ycqtmj != value)
                    {
                        this.OnPropertyChanging("Ycqtmj"); 
                        this.ycqtmj = value;                        
                        this.OnPropertyChanged("Ycqtmj");
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
		
        ///实测地下面积
        ///[Column(COL_SCDXMJ, PARAM_SCDXMJ )]
        public virtual double? Scdxmj 
        {
            get { return this.scdxmj; }
			set	{ 
                  if(this.scdxmj != value)
                    {
                        this.OnPropertyChanging("Scdxmj"); 
                        this.scdxmj = value;                        
                        this.OnPropertyChanged("Scdxmj");
                    }   
                }
        }	
		
        ///实测其它面积
        ///[Column(COL_SCQTMJ, PARAM_SCQTMJ )]
        public virtual double? Scqtmj 
        {
            get { return this.scqtmj; }
			set	{ 
                  if(this.scqtmj != value)
                    {
                        this.OnPropertyChanging("Scqtmj"); 
                        this.scqtmj = value;                        
                        this.OnPropertyChanged("Scqtmj");
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
		
        ///房屋结构1
        ///[Column(COL_FWJG1, PARAM_FWJG1 )]
        public virtual string Fwjg1 
        {
            get { return this.fwjg1; }
			set	{ 
                  if(this.fwjg1 != value)
                    {
                        this.OnPropertyChanging("Fwjg1"); 
                        this.fwjg1 = value;                        
                        this.OnPropertyChanged("Fwjg1");
                    }   
                }
        }	
		
        ///房屋结构2
        ///[Column(COL_FWJG2, PARAM_FWJG2 )]
        public virtual string Fwjg2 
        {
            get { return this.fwjg2; }
			set	{ 
                  if(this.fwjg2 != value)
                    {
                        this.OnPropertyChanging("Fwjg2"); 
                        this.fwjg2 = value;                        
                        this.OnPropertyChanged("Fwjg2");
                    }   
                }
        }	
		
        ///房屋结构3
        ///[Column(COL_FWJG3, PARAM_FWJG3 )]
        public virtual string Fwjg3 
        {
            get { return this.fwjg3; }
			set	{ 
                  if(this.fwjg3 != value)
                    {
                        this.OnPropertyChanging("Fwjg3"); 
                        this.fwjg3 = value;                        
                        this.OnPropertyChanged("Fwjg3");
                    }   
                }
        }	
		
        ///建筑物状态
        ///[Column(COL_JZWZT, PARAM_JZWZT )]
        public virtual string Jzwzt 
        {
            get { return this.jzwzt; }
			set	{ 
                  if(this.jzwzt != value)
                    {
                        this.OnPropertyChanging("Jzwzt"); 
                        this.jzwzt = value;                        
                        this.OnPropertyChanged("Jzwzt");
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
        public Ljz()
        {
            this.id=0;
            this.ljzh="";
            this.zrzh="";
            this.ysdm="";
            this.mph="";
            this.ycjzmj=0.0;
            this.ycdxmj=0.0;
            this.ycqtmj=0.0;
            this.scjzmj=0.0;
            this.scdxmj=0.0;
            this.scqtmj=0.0;
            this.jgrq=DateTime.Now;
            this.fwjg1="";
            this.fwjg2="";
            this.fwjg3="";
            this.jzwzt="";
            this.fwyt1="";
            this.fwyt2="";
            this.fwyt3="";
            this.zcs=0;
            this.dscs=0;
            this.dxcs=0;
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
            Ljz record = obj as Ljz;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_LJZ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_LJZH, this.Ljzh);
				command.Parameters.AddWithValue(PARAM_ZRZH, this.Zrzh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_MPH, this.Mph);
				command.Parameters.AddWithValue(PARAM_YCJZMJ, this.Ycjzmj);
				command.Parameters.AddWithValue(PARAM_YCDXMJ, this.Ycdxmj);
				command.Parameters.AddWithValue(PARAM_YCQTMJ, this.Ycqtmj);
				command.Parameters.AddWithValue(PARAM_SCJZMJ, this.Scjzmj);
				command.Parameters.AddWithValue(PARAM_SCDXMJ, this.Scdxmj);
				command.Parameters.AddWithValue(PARAM_SCQTMJ, this.Scqtmj);
				command.Parameters.AddWithValue(PARAM_JGRQ, this.Jgrq);
				command.Parameters.AddWithValue(PARAM_FWJG1, this.Fwjg1);
				command.Parameters.AddWithValue(PARAM_FWJG2, this.Fwjg2);
				command.Parameters.AddWithValue(PARAM_FWJG3, this.Fwjg3);
				command.Parameters.AddWithValue(PARAM_JZWZT, this.Jzwzt);
				command.Parameters.AddWithValue(PARAM_FWYT1, this.Fwyt1);
				command.Parameters.AddWithValue(PARAM_FWYT2, this.Fwyt2);
				command.Parameters.AddWithValue(PARAM_FWYT3, this.Fwyt3);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_DSCS, this.Dscs);
				command.Parameters.AddWithValue(PARAM_DXCS, this.Dxcs);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_LJZ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_LJZH, this.Ljzh);
				command.Parameters.AddWithValue(PARAM_ZRZH, this.Zrzh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_MPH, this.Mph);
				command.Parameters.AddWithValue(PARAM_YCJZMJ, this.Ycjzmj);
				command.Parameters.AddWithValue(PARAM_YCDXMJ, this.Ycdxmj);
				command.Parameters.AddWithValue(PARAM_YCQTMJ, this.Ycqtmj);
				command.Parameters.AddWithValue(PARAM_SCJZMJ, this.Scjzmj);
				command.Parameters.AddWithValue(PARAM_SCDXMJ, this.Scdxmj);
				command.Parameters.AddWithValue(PARAM_SCQTMJ, this.Scqtmj);
				command.Parameters.AddWithValue(PARAM_JGRQ, this.Jgrq);
				command.Parameters.AddWithValue(PARAM_FWJG1, this.Fwjg1);
				command.Parameters.AddWithValue(PARAM_FWJG2, this.Fwjg2);
				command.Parameters.AddWithValue(PARAM_FWJG3, this.Fwjg3);
				command.Parameters.AddWithValue(PARAM_JZWZT, this.Jzwzt);
				command.Parameters.AddWithValue(PARAM_FWYT1, this.Fwyt1);
				command.Parameters.AddWithValue(PARAM_FWYT2, this.Fwyt2);
				command.Parameters.AddWithValue(PARAM_FWYT3, this.Fwyt3);
				command.Parameters.AddWithValue(PARAM_ZCS, this.Zcs);
				command.Parameters.AddWithValue(PARAM_DSCS, this.Dscs);
				command.Parameters.AddWithValue(PARAM_DXCS, this.Dxcs);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_LJZ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_LJZ,dao.Connection))
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
			if (!reader.IsDBNull(1)) ljzh = reader.GetString(1);
			if (!reader.IsDBNull(2)) zrzh = reader.GetString(2);
			if (!reader.IsDBNull(3)) ysdm = reader.GetString(3);
			if (!reader.IsDBNull(4)) mph = reader.GetString(4);
			if (!reader.IsDBNull(5)) ycjzmj = reader.GetDouble(5);
			if (!reader.IsDBNull(6)) ycdxmj = reader.GetDouble(6);
			if (!reader.IsDBNull(7)) ycqtmj = reader.GetDouble(7);
			if (!reader.IsDBNull(8)) scjzmj = reader.GetDouble(8);
			if (!reader.IsDBNull(9)) scdxmj = reader.GetDouble(9);
			if (!reader.IsDBNull(10)) scqtmj = reader.GetDouble(10);
			if (!reader.IsDBNull(11)) jgrq = reader.GetDateTime(11);
			if (!reader.IsDBNull(12)) fwjg1 = reader.GetString(12);
			if (!reader.IsDBNull(13)) fwjg2 = reader.GetString(13);
			if (!reader.IsDBNull(14)) fwjg3 = reader.GetString(14);
			if (!reader.IsDBNull(15)) jzwzt = reader.GetString(15);
			if (!reader.IsDBNull(16)) fwyt1 = reader.GetString(16);
			if (!reader.IsDBNull(17)) fwyt2 = reader.GetString(17);
			if (!reader.IsDBNull(18)) fwyt3 = reader.GetString(18);
			if (!reader.IsDBNull(19)) zcs = reader.GetInt64(19);
			if (!reader.IsDBNull(20)) dscs = reader.GetInt64(20);
			if (!reader.IsDBNull(21)) dxcs = reader.GetInt64(21);
			if (!reader.IsDBNull(22)) bz = reader.GetString(22);
			if (!reader.IsDBNull(23)) databaseid = reader.GetInt64(23);
			if (!reader.IsDBNull(24)) flags = reader.GetInt16(24);
			if (!reader.IsDBNull(25)) xgr = reader.GetString(25);
			if (!reader.IsDBNull(26)) xgsj = reader.GetDateTime(26);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Ljz target=new Ljz();
            target.ID=0;
            target.Ljzh=this.Ljzh;
            target.Zrzh=this.Zrzh;
            target.Ysdm=this.Ysdm;
            target.Mph=this.Mph;
            target.Ycjzmj=this.Ycjzmj;
            target.Ycdxmj=this.Ycdxmj;
            target.Ycqtmj=this.Ycqtmj;
            target.Scjzmj=this.Scjzmj;
            target.Scdxmj=this.Scdxmj;
            target.Scqtmj=this.Scqtmj;
            target.Jgrq=this.Jgrq;
            target.Fwjg1=this.Fwjg1;
            target.Fwjg2=this.Fwjg2;
            target.Fwjg3=this.Fwjg3;
            target.Jzwzt=this.Jzwzt;
            target.Fwyt1=this.Fwyt1;
            target.Fwyt2=this.Fwyt2;
            target.Fwyt3=this.Fwyt3;
            target.Zcs=this.Zcs;
            target.Dscs=this.Dscs;
            target.Dxcs=this.Dxcs;
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
