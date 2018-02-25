
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
    public partial class VgCadcode : INotifyPropertyChanging, INotifyPropertyChanged,IEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_cadcode";	
        public const string LAYER_NAME = "要素代码";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_XH = "XH";
		public const string COL_SFCY = "SFCY";
		public const string COL_TC = "TC";
		public const string COL_CASSDM = "CASSDM";
		public const string COL_TXLX = "TXLX";
		public const string COL_XTC = "XTC";
		public const string COL_YSDM = "YSDM";
		public const string COL_YSLX = "YSLX";
		public const string COL_YSZL = "YSZL";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_XH = "@XH";	
        public const string PARAM_SFCY = "@SFCY";	
        public const string PARAM_TC = "@TC";	
        public const string PARAM_CASSDM = "@CASSDM";	
        public const string PARAM_TXLX = "@TXLX";	
        public const string PARAM_XTC = "@XTC";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_YSLX = "@YSLX";	
        public const string PARAM_YSZL = "@YSZL";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_VG_CADCODE ="SELECT  Id,XH,SFCY,TC,CASSDM,TXLX,XTC,YSDM,YSLX,YSZL FROM vg_cadcode ";
        
		private const string SQL_INSERT_VG_CADCODE = "INSERT INTO [vg_cadcode] (XH, SFCY, TC, CASSDM, TXLX, XTC, YSDM, YSLX, YSZL) VALUES ( @XH, @SFCY, @TC, @CASSDM, @TXLX, @XTC, @YSDM, @YSLX, @YSZL);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_CADCODE = "UPDATE [vg_cadcode] SET XH = @XH, SFCY = @SFCY, TC = @TC, CASSDM = @CASSDM, TXLX = @TXLX, XTC = @XTC, YSDM = @YSDM, YSLX = @YSLX, YSZL = @YSZL WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_CADCODE = "DELETE FROM [vg_cadcode] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///内部序号
		protected string xh = default(string);
        ///是否采用
		protected long? sfcy = default(long?);
        ///图层
		protected string tc = default(string);
        ///CASS代码
		protected string cassdm = default(string);
        ///图形类型
		protected string txlx = default(string);
        ///新图层
		protected string xtc = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///要素类型
		protected string yslx = default(string);
        ///要素种类
		protected long? yszl = default(long?);
        
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
            get{return "VgCadcode";}
        }
         public string LayerName
        {
            get{return "要素代码";}
        }
        public string EntityName{
            get{return "IEntity,IYsdmEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return false;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","vg_cadcode",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","CASS代码表",this.id,this.ysdm);
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
		
        ///内部序号
        ///[Column(COL_XH, PARAM_XH )]
        public virtual string Xh 
        {
            get { return this.xh; }
			set	{ 
                  if(this.xh != value)
                    {
                        this.OnPropertyChanging("Xh"); 
                        this.xh = value;                        
                        this.OnPropertyChanged("Xh");
                    }   
                }
        }	
		
        ///是否采用
        ///[Column(COL_SFCY, PARAM_SFCY )]
        public virtual long? Sfcy 
        {
            get { return this.sfcy; }
			set	{ 
                  if(this.sfcy != value)
                    {
                        this.OnPropertyChanging("Sfcy"); 
                        this.sfcy = value;                        
                        this.OnPropertyChanged("Sfcy");
                    }   
                }
        }	
		
        ///图层
        ///[Column(COL_TC, PARAM_TC )]
        public virtual string Tc 
        {
            get { return this.tc; }
			set	{ 
                  if(this.tc != value)
                    {
                        this.OnPropertyChanging("Tc"); 
                        this.tc = value;                        
                        this.OnPropertyChanged("Tc");
                    }   
                }
        }	
		
        ///CASS代码
        ///[Column(COL_CASSDM, PARAM_CASSDM )]
        public virtual string Cassdm 
        {
            get { return this.cassdm; }
			set	{ 
                  if(this.cassdm != value)
                    {
                        this.OnPropertyChanging("Cassdm"); 
                        this.cassdm = value;                        
                        this.OnPropertyChanged("Cassdm");
                    }   
                }
        }	
		
        ///图形类型
        ///[Column(COL_TXLX, PARAM_TXLX )]
        public virtual string Txlx 
        {
            get { return this.txlx; }
			set	{ 
                  if(this.txlx != value)
                    {
                        this.OnPropertyChanging("Txlx"); 
                        this.txlx = value;                        
                        this.OnPropertyChanged("Txlx");
                    }   
                }
        }	
		
        ///新图层
        ///[Column(COL_XTC, PARAM_XTC )]
        public virtual string Xtc 
        {
            get { return this.xtc; }
			set	{ 
                  if(this.xtc != value)
                    {
                        this.OnPropertyChanging("Xtc"); 
                        this.xtc = value;                        
                        this.OnPropertyChanged("Xtc");
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
		
        ///要素类型
        ///[Column(COL_YSLX, PARAM_YSLX )]
        public virtual string Yslx 
        {
            get { return this.yslx; }
			set	{ 
                  if(this.yslx != value)
                    {
                        this.OnPropertyChanging("Yslx"); 
                        this.yslx = value;                        
                        this.OnPropertyChanged("Yslx");
                    }   
                }
        }	
		
        ///要素种类
        ///[Column(COL_YSZL, PARAM_YSZL )]
        public virtual long? Yszl 
        {
            get { return this.yszl; }
			set	{ 
                  if(this.yszl != value)
                    {
                        this.OnPropertyChanging("Yszl"); 
                        this.yszl = value;                        
                        this.OnPropertyChanged("Yszl");
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
        public VgCadcode()
        {
            this.id=0;
            this.xh="";
            this.sfcy=0;
            this.tc="";
            this.cassdm="";
            this.txlx="";
            this.xtc="";
            this.ysdm="";
            this.yslx="";
            this.yszl=0;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            VgCadcode record = obj as VgCadcode;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_CADCODE,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_XH, this.Xh);
				command.Parameters.AddWithValue(PARAM_SFCY, this.Sfcy);
				command.Parameters.AddWithValue(PARAM_TC, this.Tc);
				command.Parameters.AddWithValue(PARAM_CASSDM, this.Cassdm);
				command.Parameters.AddWithValue(PARAM_TXLX, this.Txlx);
				command.Parameters.AddWithValue(PARAM_XTC, this.Xtc);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YSLX, this.Yslx);
				command.Parameters.AddWithValue(PARAM_YSZL, this.Yszl);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_CADCODE,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_XH, this.Xh);
				command.Parameters.AddWithValue(PARAM_SFCY, this.Sfcy);
				command.Parameters.AddWithValue(PARAM_TC, this.Tc);
				command.Parameters.AddWithValue(PARAM_CASSDM, this.Cassdm);
				command.Parameters.AddWithValue(PARAM_TXLX, this.Txlx);
				command.Parameters.AddWithValue(PARAM_XTC, this.Xtc);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YSLX, this.Yslx);
				command.Parameters.AddWithValue(PARAM_YSZL, this.Yszl);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_CADCODE,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) xh = reader.GetString(1);
			if (!reader.IsDBNull(2)) sfcy = reader.GetInt64(2);
			if (!reader.IsDBNull(3)) tc = reader.GetString(3);
			if (!reader.IsDBNull(4)) cassdm = reader.GetString(4);
			if (!reader.IsDBNull(5)) txlx = reader.GetString(5);
			if (!reader.IsDBNull(6)) xtc = reader.GetString(6);
			if (!reader.IsDBNull(7)) ysdm = reader.GetString(7);
			if (!reader.IsDBNull(8)) yslx = reader.GetString(8);
			if (!reader.IsDBNull(9)) yszl = reader.GetInt64(9);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgCadcode target=new VgCadcode();
            target.ID=0;
            target.Xh=this.Xh;
            target.Sfcy=this.Sfcy;
            target.Tc=this.Tc;
            target.Cassdm=this.Cassdm;
            target.Txlx=this.Txlx;
            target.Xtc=this.Xtc;
            target.Ysdm=this.Ysdm;
            target.Yslx=this.Yslx;
            target.Yszl=this.Yszl;
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
