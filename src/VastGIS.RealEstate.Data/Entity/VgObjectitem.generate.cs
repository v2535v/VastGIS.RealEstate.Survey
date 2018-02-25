
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
    public partial class VgObjectitem : INotifyPropertyChanging, INotifyPropertyChanged,IEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_objectitem";	
        public const string LAYER_NAME = "要素表";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_YSMC = "YSMC";
		public const string COL_YSBM = "YSBM";
		public const string COL_SFKJ = "SFKJ";
		public const string COL_YSLX = "YSLX";
		public const string COL_SM = "SM";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_YSMC = "@YSMC";	
        public const string PARAM_YSBM = "@YSBM";	
        public const string PARAM_SFKJ = "@SFKJ";	
        public const string PARAM_YSLX = "@YSLX";	
        public const string PARAM_SM = "@SM";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_VG_OBJECTITEM ="SELECT  Id,YSDM,YSMC,YSBM,SFKJ,YSLX,SM FROM vg_objectitem ";
        
		private const string SQL_INSERT_VG_OBJECTITEM = "INSERT INTO [vg_objectitem] (YSDM, YSMC, YSBM, SFKJ, YSLX, SM) VALUES ( @YSDM, @YSMC, @YSBM, @SFKJ, @YSLX, @SM);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_OBJECTITEM = "UPDATE [vg_objectitem] SET YSDM = @YSDM, YSMC = @YSMC, YSBM = @YSBM, SFKJ = @SFKJ, YSLX = @YSLX, SM = @SM WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_OBJECTITEM = "DELETE FROM [vg_objectitem] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///要素名称
		protected string ysmc = default(string);
        ///要素编码
		protected string ysbm = default(string);
        ///是否空间要素
		protected long? sfkj = default(long?);
        ///要素类型
		protected string yslx = default(string);
        ///说明
		protected string sm = default(string);
        
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
            get{return "VgObjectitem";}
        }
         public string LayerName
        {
            get{return "要素表";}
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
                return string.Format("{0} {1} ({2})","vg_objectitem",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","要素表",this.id,this.ysdm);
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
		
        ///要素名称
        ///[Column(COL_YSMC, PARAM_YSMC )]
        public virtual string Ysmc 
        {
            get { return this.ysmc; }
			set	{ 
                  if(this.ysmc != value)
                    {
                        this.OnPropertyChanging("Ysmc"); 
                        this.ysmc = value;                        
                        this.OnPropertyChanged("Ysmc");
                    }   
                }
        }	
		
        ///要素编码
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
		
        ///是否空间要素
        ///[Column(COL_SFKJ, PARAM_SFKJ )]
        public virtual long? Sfkj 
        {
            get { return this.sfkj; }
			set	{ 
                  if(this.sfkj != value)
                    {
                        this.OnPropertyChanging("Sfkj"); 
                        this.sfkj = value;                        
                        this.OnPropertyChanged("Sfkj");
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
		
        ///说明
        ///[Column(COL_SM, PARAM_SM )]
        public virtual string Sm 
        {
            get { return this.sm; }
			set	{ 
                  if(this.sm != value)
                    {
                        this.OnPropertyChanging("Sm"); 
                        this.sm = value;                        
                        this.OnPropertyChanged("Sm");
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
        public VgObjectitem()
        {
            this.id=0;
            this.ysdm="";
            this.ysmc="";
            this.ysbm="";
            this.sfkj=0;
            this.yslx="";
            this.sm="";
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            VgObjectitem record = obj as VgObjectitem;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_OBJECTITEM,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YSMC, this.Ysmc);
				command.Parameters.AddWithValue(PARAM_YSBM, this.Ysbm);
				command.Parameters.AddWithValue(PARAM_SFKJ, this.Sfkj);
				command.Parameters.AddWithValue(PARAM_YSLX, this.Yslx);
				command.Parameters.AddWithValue(PARAM_SM, this.Sm);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_OBJECTITEM,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YSMC, this.Ysmc);
				command.Parameters.AddWithValue(PARAM_YSBM, this.Ysbm);
				command.Parameters.AddWithValue(PARAM_SFKJ, this.Sfkj);
				command.Parameters.AddWithValue(PARAM_YSLX, this.Yslx);
				command.Parameters.AddWithValue(PARAM_SM, this.Sm);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_OBJECTITEM,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) ysdm = reader.GetString(1);
			if (!reader.IsDBNull(2)) ysmc = reader.GetString(2);
			if (!reader.IsDBNull(3)) ysbm = reader.GetString(3);
			if (!reader.IsDBNull(4)) sfkj = reader.GetInt64(4);
			if (!reader.IsDBNull(5)) yslx = reader.GetString(5);
			if (!reader.IsDBNull(6)) sm = reader.GetString(6);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgObjectitem target=new VgObjectitem();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Ysmc=this.Ysmc;
            target.Ysbm=this.Ysbm;
            target.Sfkj=this.Sfkj;
            target.Yslx=this.Yslx;
            target.Sm=this.Sm;
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
