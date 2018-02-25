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
using VastGIS.RealEstate.Data.Interface;
using VastGIS.Shared;

namespace VastGIS.RealEstate.Data.Entity
{
    public partial class TmpCadx:INotifyPropertyChanging,INotifyPropertyChanged,IReFeature
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"EntityType",false},{"Handle",false},{"FileName",true},{"geometry",false}};
        public const string TABLE_NAME = "TmpCadx";
        public const string LAYER_NAME="";
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
	    public const string COL_ID = "Id";
	    public const string COL_ENTITYTYPE = "EntityType";
	    public const string COL_HANDLE = "Handle";
	    public const string COL_FILENAME = "FileName";
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ENTITYTYPE = "@EntityType";
        public const string PARAM_HANDLE = "@Handle";
        public const string PARAM_FILENAME = "@FileName";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_TMPCADX = "INSERT INTO TmpCadx (EntityType, Handle, FileName, geometry) VALUES ( @EntityType, @Handle, @FileName, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_TMPCADX = "UPDATE TmpCadx SET EntityType = @EntityType, Handle = @Handle, FileName = @FileName, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";	
	    private const string SQL_DELETE_TMPCADX = "DELETE FROM TmpCadx WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// ID
		protected long id = default(long);
        /// ENTITYTYPE
		protected string entitytype = default(string);
        /// HANDLE
		protected string handle = default(string);
        /// FILENAME
		protected string filename = default(string);
        protected IGeometry _geometry;
        ///WKT字段
        protected string _wkt=default(string);
        ///图形对象字段
        protected GeometryType _geometryType=GeometryType.Polyline;
        
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
        
        #region IEntity属性
        //对应数据库内表名称
        public string ObjectName
        {
            get{return "TmpCadx";}
        }
        public string EntityName{
            get{return "ReFeature";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","TmpCadx",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","TmpCadx",this.id);
            }
        }        
        #endregion
        #region 字段属性信息
        /// ID
        public long ID 
        {
            get { return this.id; }
			set	{ 
                  if(this.id != value)
                    {
                        this.OnPropertyChanging("ID");  
                        this.id= value;                                              
                        this.OnPropertyChanged("ID");
                    }   
                }
        }	
        /// ENTITYTYPE
        public string EntityType 
        {
            get { return this.entitytype; }
			set	{ 
                  if(this.entitytype != value)
                    {
                        this.OnPropertyChanging("EntityType");  
                        this.entitytype= value;                                              
                        this.OnPropertyChanged("EntityType");
                    }   
                }
        }	
        /// HANDLE
        public string Handle 
        {
            get { return this.handle; }
			set	{ 
                  if(this.handle != value)
                    {
                        this.OnPropertyChanging("Handle");  
                        this.handle= value;                                              
                        this.OnPropertyChanged("Handle");
                    }   
                }
        }	
        /// FILENAME
        public string FileName 
        {
            get { return this.filename; }
			set	{ 
                  if(this.filename != value)
                    {
                        this.OnPropertyChanging("FileName");  
                        this.filename= value;                                              
                        this.OnPropertyChanged("FileName");
                    }   
                }
        }	
        ///图形对象
        public IGeometry Geometry
        {
            get{return _geometry;}
            set{
                this.OnPropertyChanging("Geometry");  
                _geometry=value;
                _wkt = _geometry.ExportToWkt();
                this.OnPropertyChanged("Geometry");
                }
        }
        ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
        }
        ///WKT字段
        public string Wkt
        {
            get{return _wkt;}
            set{
               this.OnPropertyChanging("Geometry");  
                _wkt=value;               
                _geometry.ImportFromWkt(_wkt);
                this.OnPropertyChanged("Geometry"); 
            }
        }
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  TmpCadx()
        {
            _geometry=new Geometry(_geometryType,ZValueType.None);
            this.id=0;
            this.entitytype="";
            this.handle="";
            this.filename="";
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            TmpCadx record = obj as TmpCadx;           
            
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
        
        
        public long Create(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_TMPCADX,dao.Connection))
            {
                command.Parameters.AddWithValue(PARAM_ENTITYTYPE,this.EntityType);
                command.Parameters.AddWithValue(PARAM_HANDLE,this.Handle);
                command.Parameters.AddWithValue(PARAM_FILENAME,this.FileName);
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_TMPCADX,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_ENTITYTYPE,this.EntityType);
				command.Parameters.AddWithValue(PARAM_HANDLE,this.Handle);
				command.Parameters.AddWithValue(PARAM_FILENAME,EncodingHelper.String2Unicode(this.FileName));
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
			
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(ISQLiteDao dao)
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
        

		public bool Delete(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_TMPCADX,dao.Connection))
            {
               
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
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