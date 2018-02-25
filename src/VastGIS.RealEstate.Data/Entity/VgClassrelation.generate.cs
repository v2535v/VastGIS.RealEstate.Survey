
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
    public partial class VgClassrelation : INotifyPropertyChanging, INotifyPropertyChanged,IEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_classrelation";	
        public const string LAYER_NAME = "关联关系表";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSBM = "YSBM";
		public const string COL_GLBM = "GLBM";
		public const string COL_YSZD = "YSZD";
		public const string COL_GLZD = "GLZD";
		public const string COL_GLLX = "GLLX";
		public const string COL_GXB = "GXB";
		public const string COL_YSGX = "YSGX";
		public const string COL_GLGX = "GLGX";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSBM = "@YSBM";	
        public const string PARAM_GLBM = "@GLBM";	
        public const string PARAM_YSZD = "@YSZD";	
        public const string PARAM_GLZD = "@GLZD";	
        public const string PARAM_GLLX = "@GLLX";	
        public const string PARAM_GXB = "@GXB";	
        public const string PARAM_YSGX = "@YSGX";	
        public const string PARAM_GLGX = "@GLGX";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_VG_CLASSRELATION ="SELECT  Id,YSBM,GLBM,YSZD,GLZD,GLLX,GXB,YSGX,GLGX FROM vg_classrelation ";
        
		private const string SQL_INSERT_VG_CLASSRELATION = "INSERT INTO [vg_classrelation] (YSBM, GLBM, YSZD, GLZD, GLLX, GXB, YSGX, GLGX) VALUES ( @YSBM, @GLBM, @YSZD, @GLZD, @GLLX, @GXB, @YSGX, @GLGX);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_CLASSRELATION = "UPDATE [vg_classrelation] SET YSBM = @YSBM, GLBM = @GLBM, YSZD = @YSZD, GLZD = @GLZD, GLLX = @GLLX, GXB = @GXB, YSGX = @YSGX, GLGX = @GLGX WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_CLASSRELATION = "DELETE FROM [vg_classrelation] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///原始表名
		protected string ysbm = default(string);
        ///关联表名
		protected string glbm = default(string);
        ///原始字段
		protected string yszd = default(string);
        ///关联字段
		protected string glzd = default(string);
        ///关联类型
		protected short? gllx = default(short?);
        ///关系表名
		protected string gxb = default(string);
        ///原始关系
		protected string ysgx = default(string);
        ///关联关系
		protected string glgx = default(string);
        
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
            get{return "VgClassrelation";}
        }
         public string LayerName
        {
            get{return "关联关系表";}
        }
        public string EntityName{
            get{return "IEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return false;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return false;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_classrelation",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","关联关系表",this.id);
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
		
        ///原始表名
        ///[Column(COL_YSBM, PARAM_YSBM )]
        public virtual string Ysbm 
        {
            get { return this.ysbm; }
			set	{ 
                  if(this.ysbm != value)
                    {
                        this.OnPropertyChanging("Ysbm"); 
                        this.ysbm = value;                        
                        this.OnPropertyChanged("Ysbm");
                    }   
                }
        }	
		
        ///关联表名
        ///[Column(COL_GLBM, PARAM_GLBM )]
        public virtual string Glbm 
        {
            get { return this.glbm; }
			set	{ 
                  if(this.glbm != value)
                    {
                        this.OnPropertyChanging("Glbm"); 
                        this.glbm = value;                        
                        this.OnPropertyChanged("Glbm");
                    }   
                }
        }	
		
        ///原始字段
        ///[Column(COL_YSZD, PARAM_YSZD )]
        public virtual string Yszd 
        {
            get { return this.yszd; }
			set	{ 
                  if(this.yszd != value)
                    {
                        this.OnPropertyChanging("Yszd"); 
                        this.yszd = value;                        
                        this.OnPropertyChanged("Yszd");
                    }   
                }
        }	
		
        ///关联字段
        ///[Column(COL_GLZD, PARAM_GLZD )]
        public virtual string Glzd 
        {
            get { return this.glzd; }
			set	{ 
                  if(this.glzd != value)
                    {
                        this.OnPropertyChanging("Glzd"); 
                        this.glzd = value;                        
                        this.OnPropertyChanged("Glzd");
                    }   
                }
        }	
		
        ///关联类型
        ///[Column(COL_GLLX, PARAM_GLLX )]
        public virtual short? Gllx 
        {
            get { return this.gllx; }
			set	{ 
                  if(this.gllx != value)
                    {
                        this.OnPropertyChanging("Gllx"); 
                        this.gllx = value;                        
                        this.OnPropertyChanged("Gllx");
                    }   
                }
        }	
		
        ///关系表名
        ///[Column(COL_GXB, PARAM_GXB )]
        public virtual string Gxb 
        {
            get { return this.gxb; }
			set	{ 
                  if(this.gxb != value)
                    {
                        this.OnPropertyChanging("Gxb"); 
                        this.gxb = value;                        
                        this.OnPropertyChanged("Gxb");
                    }   
                }
        }	
		
        ///原始关系
        ///[Column(COL_YSGX, PARAM_YSGX )]
        public virtual string Ysgx 
        {
            get { return this.ysgx; }
			set	{ 
                  if(this.ysgx != value)
                    {
                        this.OnPropertyChanging("Ysgx"); 
                        this.ysgx = value;                        
                        this.OnPropertyChanged("Ysgx");
                    }   
                }
        }	
		
        ///关联关系
        ///[Column(COL_GLGX, PARAM_GLGX )]
        public virtual string Glgx 
        {
            get { return this.glgx; }
			set	{ 
                  if(this.glgx != value)
                    {
                        this.OnPropertyChanging("Glgx"); 
                        this.glgx = value;                        
                        this.OnPropertyChanged("Glgx");
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
        public VgClassrelation()
        {
            this.id=0;
            this.ysbm="";
            this.glbm="";
            this.yszd="";
            this.glzd="";
            
            this.gxb="";
            this.ysgx="";
            this.glgx="";
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            VgClassrelation record = obj as VgClassrelation;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_CLASSRELATION,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_YSBM, this.Ysbm);
				command.Parameters.AddWithValue(PARAM_GLBM, this.Glbm);
				command.Parameters.AddWithValue(PARAM_YSZD, this.Yszd);
				command.Parameters.AddWithValue(PARAM_GLZD, this.Glzd);
				command.Parameters.AddWithValue(PARAM_GLLX, this.Gllx);
				command.Parameters.AddWithValue(PARAM_GXB, this.Gxb);
				command.Parameters.AddWithValue(PARAM_YSGX, this.Ysgx);
				command.Parameters.AddWithValue(PARAM_GLGX, this.Glgx);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_CLASSRELATION,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_YSBM, this.Ysbm);
				command.Parameters.AddWithValue(PARAM_GLBM, this.Glbm);
				command.Parameters.AddWithValue(PARAM_YSZD, this.Yszd);
				command.Parameters.AddWithValue(PARAM_GLZD, this.Glzd);
				command.Parameters.AddWithValue(PARAM_GLLX, this.Gllx);
				command.Parameters.AddWithValue(PARAM_GXB, this.Gxb);
				command.Parameters.AddWithValue(PARAM_YSGX, this.Ysgx);
				command.Parameters.AddWithValue(PARAM_GLGX, this.Glgx);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_CLASSRELATION,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) ysbm = reader.GetString(1);
			if (!reader.IsDBNull(2)) glbm = reader.GetString(2);
			if (!reader.IsDBNull(3)) yszd = reader.GetString(3);
			if (!reader.IsDBNull(4)) glzd = reader.GetString(4);
			if (!reader.IsDBNull(5)) gllx = reader.GetInt16(5);
			if (!reader.IsDBNull(6)) gxb = reader.GetString(6);
			if (!reader.IsDBNull(7)) ysgx = reader.GetString(7);
			if (!reader.IsDBNull(8)) glgx = reader.GetString(8);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgClassrelation target=new VgClassrelation();
            target.ID=0;
            target.Ysbm=this.Ysbm;
            target.Glbm=this.Glbm;
            target.Yszd=this.Yszd;
            target.Glzd=this.Glzd;
            target.Gllx=this.Gllx;
            target.Gxb=this.Gxb;
            target.Ysgx=this.Ysgx;
            target.Glgx=this.Glgx;
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
