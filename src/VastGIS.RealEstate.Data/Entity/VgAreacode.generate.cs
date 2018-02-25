
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
    public partial class VgAreacode : INotifyPropertyChanging, INotifyPropertyChanged,IEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_areacode";	
        public const string LAYER_NAME = "行政区划代码";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_XZQHMC = "XZQHMC";
		public const string COL_XZQHDM = "XZQHDM";
		public const string COL_XZQHJB = "XZQHJB";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_XZQHMC = "@XZQHMC";	
        public const string PARAM_XZQHDM = "@XZQHDM";	
        public const string PARAM_XZQHJB = "@XZQHJB";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_VG_AREACODE ="SELECT  Id,XZQHMC,XZQHDM,XZQHJB FROM vg_areacode ";
        
		private const string SQL_INSERT_VG_AREACODE = "INSERT INTO [vg_areacode] (XZQHMC, XZQHDM, XZQHJB) VALUES ( @XZQHMC, @XZQHDM, @XZQHJB);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_AREACODE = "UPDATE [vg_areacode] SET XZQHMC = @XZQHMC, XZQHDM = @XZQHDM, XZQHJB = @XZQHJB WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_AREACODE = "DELETE FROM [vg_areacode] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///行政区划名称
		protected string xzqhmc = default(string);
        ///行政区划代码
		protected string xzqhdm = default(string);
        ///行政区划级别
		protected long? xzqhjb = default(long?);
        
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
            get{return "VgAreacode";}
        }
         public string LayerName
        {
            get{return "行政区划代码";}
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
                return string.Format("{0} {1} ","vg_areacode",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","行政代码",this.id);
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
		
        ///行政区划名称
        ///[Column(COL_XZQHMC, PARAM_XZQHMC )]
        public virtual string Xzqhmc 
        {
            get { return this.xzqhmc; }
			set	{ 
                  if(this.xzqhmc != value)
                    {
                        this.OnPropertyChanging("Xzqhmc"); 
                        this.xzqhmc = value;                        
                        this.OnPropertyChanged("Xzqhmc");
                    }   
                }
        }	
		
        ///行政区划代码
        ///[Column(COL_XZQHDM, PARAM_XZQHDM )]
        public virtual string Xzqhdm 
        {
            get { return this.xzqhdm; }
			set	{ 
                  if(this.xzqhdm != value)
                    {
                        this.OnPropertyChanging("Xzqhdm"); 
                        this.xzqhdm = value;                        
                        this.OnPropertyChanged("Xzqhdm");
                    }   
                }
        }	
		
        ///行政区划级别
        ///[Column(COL_XZQHJB, PARAM_XZQHJB )]
        public virtual long? Xzqhjb 
        {
            get { return this.xzqhjb; }
			set	{ 
                  if(this.xzqhjb != value)
                    {
                        this.OnPropertyChanging("Xzqhjb"); 
                        this.xzqhjb = value;                        
                        this.OnPropertyChanged("Xzqhjb");
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
        public VgAreacode()
        {
            this.id=0;
            this.xzqhmc="";
            this.xzqhdm="";
            this.xzqhjb=0;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            VgAreacode record = obj as VgAreacode;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_AREACODE,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_XZQHMC, this.Xzqhmc);
				command.Parameters.AddWithValue(PARAM_XZQHDM, this.Xzqhdm);
				command.Parameters.AddWithValue(PARAM_XZQHJB, this.Xzqhjb);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_AREACODE,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_XZQHMC, this.Xzqhmc);
				command.Parameters.AddWithValue(PARAM_XZQHDM, this.Xzqhdm);
				command.Parameters.AddWithValue(PARAM_XZQHJB, this.Xzqhjb);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_AREACODE,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) xzqhmc = reader.GetString(1);
			if (!reader.IsDBNull(2)) xzqhdm = reader.GetString(2);
			if (!reader.IsDBNull(3)) xzqhjb = reader.GetInt64(3);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgAreacode target=new VgAreacode();
            target.ID=0;
            target.Xzqhmc=this.Xzqhmc;
            target.Xzqhdm=this.Xzqhdm;
            target.Xzqhjb=this.Xzqhjb;
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
