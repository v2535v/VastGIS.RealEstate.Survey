
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
    public partial class R : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "R";	
        public const string LAYER_NAME = "人员信息";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_QLRMC = "QLRMC";
		public const string COL_QLRPY = "QLRPY";
		public const string COL_PYSX = "PYSX";
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
		public const string COL_BZ = "BZ";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_QLRMC = "@QLRMC";	
        public const string PARAM_QLRPY = "@QLRPY";	
        public const string PARAM_PYSX = "@PYSX";	
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
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_R ="SELECT  Id,YSDM,QLRMC,QLRPY,PYSX,ZJZL,ZJH,FZJG,SSHY,GJ,HJSZSS,XB,DH,DZ,YB,GZDW,DZYJ,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM R WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_R = "INSERT INTO [R] (YSDM, QLRMC, QLRPY, PYSX, ZJZL, ZJH, FZJG, SSHY, GJ, HJSZSS, XB, DH, DZ, YB, GZDW, DZYJ, BZ, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @QLRMC, @QLRPY, @PYSX, @ZJZL, @ZJH, @FZJG, @SSHY, @GJ, @HJSZSS, @XB, @DH, @DZ, @YB, @GZDW, @DZYJ, @BZ, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_R = "UPDATE [R] SET YSDM = @YSDM, QLRMC = @QLRMC, QLRPY = @QLRPY, PYSX = @PYSX, ZJZL = @ZJZL, ZJH = @ZJH, FZJG = @FZJG, SSHY = @SSHY, GJ = @GJ, HJSZSS = @HJSZSS, XB = @XB, DH = @DH, DZ = @DZ, YB = @YB, GZDW = @GZDW, DZYJ = @DZYJ, BZ = @BZ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_R = "DELETE FROM [R] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_R = "UPDATE [R] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///QLRMC
		protected string qlrmc = default(string);
        ///拼音
		protected string qlrpy = default(string);
        ///拼音缩写
		protected string pysx = default(string);
        ///ZJZL
		protected string zjzl = default(string);
        ///ZJH
		protected string zjh = default(string);
        ///FZJG
		protected string fzjg = default(string);
        ///SSHY
		protected string sshy = default(string);
        ///GJ
		protected string gj = default(string);
        ///HJSZSS
		protected string hjszss = default(string);
        ///XB
		protected string xb = default(string);
        ///DH
		protected string dh = default(string);
        ///DZ
		protected string dz = default(string);
        ///YB
		protected string yb = default(string);
        ///GZDW
		protected string gzdw = default(string);
        ///DZYJ
		protected string dzyj = default(string);
        ///BZ
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
            get{return "R";}
        }
         public string LayerName
        {
            get{return "人员信息";}
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
                return string.Format("{0} {1} ({2})","R",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","人员信息",this.id,this.ysdm);
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
		
        ///QLRMC
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
		
        ///拼音
        ///[Column(COL_QLRPY, PARAM_QLRPY )]
        public virtual string Qlrpy 
        {
            get { return this.qlrpy; }
			set	{ 
                  if(this.qlrpy != value)
                    {
                        this.OnPropertyChanging("Qlrpy"); 
                        this.qlrpy = value;                        
                        this.OnPropertyChanged("Qlrpy");
                    }   
                }
        }	
		
        ///拼音缩写
        ///[Column(COL_PYSX, PARAM_PYSX )]
        public virtual string Pysx 
        {
            get { return this.pysx; }
			set	{ 
                  if(this.pysx != value)
                    {
                        this.OnPropertyChanging("Pysx"); 
                        this.pysx = value;                        
                        this.OnPropertyChanged("Pysx");
                    }   
                }
        }	
		
        ///ZJZL
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
		
        ///ZJH
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
		
        ///FZJG
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
		
        ///SSHY
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
		
        ///GJ
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
		
        ///HJSZSS
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
		
        ///XB
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
		
        ///DH
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
		
        ///DZ
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
		
        ///YB
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
		
        ///GZDW
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
		
        ///DZYJ
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
		
        ///BZ
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
        public R()
        {
            this.id=0;
            this.ysdm="";
            this.qlrmc="";
            this.qlrpy="";
            this.pysx="";
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
            R record = obj as R;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_R,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_QLRMC, this.Qlrmc);
				command.Parameters.AddWithValue(PARAM_QLRPY, this.Qlrpy);
				command.Parameters.AddWithValue(PARAM_PYSX, this.Pysx);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_R,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_QLRMC, this.Qlrmc);
				command.Parameters.AddWithValue(PARAM_QLRPY, this.Qlrpy);
				command.Parameters.AddWithValue(PARAM_PYSX, this.Pysx);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_R,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_R,dao.Connection))
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
			if (!reader.IsDBNull(2)) qlrmc = reader.GetString(2);
			if (!reader.IsDBNull(3)) qlrpy = reader.GetString(3);
			if (!reader.IsDBNull(4)) pysx = reader.GetString(4);
			if (!reader.IsDBNull(5)) zjzl = reader.GetString(5);
			if (!reader.IsDBNull(6)) zjh = reader.GetString(6);
			if (!reader.IsDBNull(7)) fzjg = reader.GetString(7);
			if (!reader.IsDBNull(8)) sshy = reader.GetString(8);
			if (!reader.IsDBNull(9)) gj = reader.GetString(9);
			if (!reader.IsDBNull(10)) hjszss = reader.GetString(10);
			if (!reader.IsDBNull(11)) xb = reader.GetString(11);
			if (!reader.IsDBNull(12)) dh = reader.GetString(12);
			if (!reader.IsDBNull(13)) dz = reader.GetString(13);
			if (!reader.IsDBNull(14)) yb = reader.GetString(14);
			if (!reader.IsDBNull(15)) gzdw = reader.GetString(15);
			if (!reader.IsDBNull(16)) dzyj = reader.GetString(16);
			if (!reader.IsDBNull(17)) bz = reader.GetString(17);
			if (!reader.IsDBNull(18)) databaseid = reader.GetInt64(18);
			if (!reader.IsDBNull(19)) flags = reader.GetInt16(19);
			if (!reader.IsDBNull(20)) xgr = reader.GetString(20);
			if (!reader.IsDBNull(21)) xgsj = reader.GetDateTime(21);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            R target=new R();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Qlrmc=this.Qlrmc;
            target.Qlrpy=this.Qlrpy;
            target.Pysx=this.Pysx;
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
