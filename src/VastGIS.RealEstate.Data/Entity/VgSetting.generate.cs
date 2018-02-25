
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
    public partial class VgSetting : INotifyPropertyChanging, INotifyPropertyChanged,IEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_setting";	
        public const string LAYER_NAME = "设计";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_CSMC = "CSMC";
		public const string COL_CSZ = "CSZ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_CSMC = "@CSMC";	
        public const string PARAM_CSZ = "@CSZ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_VG_SETTING ="SELECT  Id,CSMC,CSZ FROM vg_setting ";
        
		private const string SQL_INSERT_VG_SETTING = "INSERT INTO [vg_setting] (CSMC, CSZ) VALUES ( @CSMC, @CSZ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_SETTING = "UPDATE [vg_setting] SET CSMC = @CSMC, CSZ = @CSZ WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_SETTING = "DELETE FROM [vg_setting] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///参数名称
		protected string csmc = default(string);
        ///参数值
		protected string csz = default(string);
        
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
            get{return "VgSetting";}
        }
         public string LayerName
        {
            get{return "设计";}
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
                return string.Format("{0} {1} ","vg_setting",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","设计",this.id);
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
		
        ///参数名称
        ///[Column(COL_CSMC, PARAM_CSMC )]
        public virtual string Csmc 
        {
            get { return this.csmc; }
			set	{ 
                  if(this.csmc != value)
                    {
                        this.OnPropertyChanging("Csmc"); 
                        this.csmc = value;                        
                        this.OnPropertyChanged("Csmc");
                    }   
                }
        }	
		
        ///参数值
        ///[Column(COL_CSZ, PARAM_CSZ )]
        public virtual string Csz 
        {
            get { return this.csz; }
			set	{ 
                  if(this.csz != value)
                    {
                        this.OnPropertyChanging("Csz"); 
                        this.csz = value;                        
                        this.OnPropertyChanged("Csz");
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
        public VgSetting()
        {
            this.id=0;
            this.csmc="";
            this.csz="";
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            VgSetting record = obj as VgSetting;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_SETTING,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_CSMC, this.Csmc);
				command.Parameters.AddWithValue(PARAM_CSZ, this.Csz);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_SETTING,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_CSMC, this.Csmc);
				command.Parameters.AddWithValue(PARAM_CSZ, this.Csz);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_SETTING,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) csmc = reader.GetString(1);
			if (!reader.IsDBNull(2)) csz = reader.GetString(2);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgSetting target=new VgSetting();
            target.ID=0;
            target.Csmc=this.Csmc;
            target.Csz=this.Csz;
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
