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

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class TmpCadm:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "TmpCadm";
        public const string LAYER_NAME="";
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
	
	    private const string SQL_INSERT_TMPCADM = "INSERT INTO TmpCadm (EntityType, Handle, FileName, geometry) VALUES ( @EntityType, @Handle, @FileName, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_TMPCADM = "UPDATE TmpCadm SET EntityType = @EntityType, Handle = @Handle, FileName = @FileName, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
	
	    private const string SQL_DELETE_TMPCADM = "DELETE FROM TmpCadm WHERE  Id = @Id ";
        
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string entitytype = default(string);
		protected string handle = default(string);
		protected string filename = default(string);
        protected IGeometry _geometry;
        protected string _wkt=default(string);
        protected GeometryType _geometryType=GeometryType.Polygon;
        
        private event PropertyChangingEventHandler propertyChanging;            
        private event PropertyChangedEventHandler propertyChanged;
        #endregion
        
        #region 属性
    
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
        
        public long ID 
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
        public string EntityType 
        {
            get { return this.entitytype; }
			set	{ 
                  if(this.entitytype != value)
                    {
                        this.OnPropertyChanging("EntityType");  
                        this.entitytype = value;                        
                        this.OnPropertyChanged("EntityType");
                    }   
                }
        }	
        public string Handle 
        {
            get { return this.handle; }
			set	{ 
                  if(this.handle != value)
                    {
                        this.OnPropertyChanging("Handle");  
                        this.handle = value;                        
                        this.OnPropertyChanged("Handle");
                    }   
                }
        }	
        public string FileName 
        {
            get { return this.filename; }
			set	{ 
                  if(this.filename != value)
                    {
                        this.OnPropertyChanging("FileName");  
                        this.filename = value;                        
                        this.OnPropertyChanged("FileName");
                    }   
                }
        }	
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
        public GeometryType GeometryType
        {
            get{return _geometryType;}
            set{_geometryType=value;}
        }
        public string Wkt
        {
            get{return _wkt;}
            set{
               this.OnPropertyChanging("Geometry");  
                _wkt=value;
                //_geometry=DbGeometry.FromText(_wkt);
                _geometry.ImportFromWkt(_wkt);
                this.OnPropertyChanged("Geometry"); 
            }
        }
        
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","TmpCadm",this.id);
            }
        }
        
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","TmpCadm",this.id);
            }
        }
        
        
        
        #endregion     
        
        #region 创建方法
        public  TmpCadm()
        {
            _geometry=new Geometry(_geometryType,ZValueType.None);
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            TmpCadm record = obj as TmpCadm;           
            
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
        
        
        
        public bool Create(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_TMPCADM,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_ENTITYTYPE,this.EntityType);    				
                 command.Parameters.AddWithValue(PARAM_HANDLE,this.Handle);    				
                 command.Parameters.AddWithValue(PARAM_FILENAME,this.FileName);    				
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",srid);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_TMPCADM,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_ENTITYTYPE,this.EntityType);  
				command.Parameters.AddWithValue(PARAM_HANDLE,this.Handle);  
				command.Parameters.AddWithValue(PARAM_FILENAME,this.FileName);  
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",srid);
			
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(SQLiteConnection connection,int srid)
        {
            if(this.id == default(long))
            {
                return Create(connection,srid);
            }
            else
            {
                return Update(connection,srid);
            }
            
        }

		public bool Delete(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_TMPCADM,connection))
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