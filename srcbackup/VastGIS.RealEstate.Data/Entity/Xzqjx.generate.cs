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
    public partial class Xzqjx:INotifyPropertyChanging,INotifyPropertyChanged,IDatabaseFeature
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"YSDM",false},{"JXLX",false},{"JXXZ",false},{"JXSM",true},{"DatabaseId",false},{"FLAGS",false},{"XGR",false},{"XGSJ",false},{"geometry",false}};
        public const string TABLE_NAME = "XZQJX";
        public const string LAYER_NAME="";
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
	    public const string COL_ID = "Id";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_JXLX = "JXLX";
	    public const string COL_JXXZ = "JXXZ";
	    public const string COL_JXSM = "JXSM";
	    public const string COL_DATABASEID = "DatabaseId";
	    public const string COL_FLAGS = "FLAGS";
	    public const string COL_XGR = "XGR";
	    public const string COL_XGSJ = "XGSJ";
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_JXLX = "@JXLX";
        public const string PARAM_JXXZ = "@JXXZ";
        public const string PARAM_JXSM = "@JXSM";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_XGR = "@XGR";
        public const string PARAM_XGSJ = "@XGSJ";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_XZQJX = "INSERT INTO XZQJX (YSDM, JXLX, JXXZ, JXSM, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @YSDM, @JXLX, @JXXZ, @JXSM, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_XZQJX = "UPDATE XZQJX SET YSDM = @YSDM, JXLX = @JXLX, JXXZ = @JXXZ, JXSM = @JXSM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";	
	    private const string SQL_DELETE_XZQJX = "DELETE FROM XZQJX WHERE  Id = @Id ";        
        private const string SQL_DELETE_FLAG_XZQJX = "UPDATE XZQJX Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE  Id = @Id ";
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 要素代码
		protected string ysdm = default(string);
        /// 界线类型 - 使用字典信息(界线类型字典表--JXLXZD)
		protected string jxlx = default(string);
        /// 界线性质 - 使用字典信息(界线性质字典表--JXXZZD)
		protected string jxxz = default(string);
        /// 界线说明
		protected string jxsm = default(string);
        /// 源数据库内序号
		protected long? databaseid = default(long?);
        /// 修改标记
		protected short? flag = default(short?);
        /// XGR
		protected string xgr = default(string);
        /// XGSJ
		protected System.DateTime? xgsj = default(System.DateTime?);
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
            get{return "Xzqjx";}
        }
        public string EntityName{
            get{return "DatabaseFeature";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","XZQJX",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","XZQJX",this.id,this.ysdm);
            }
        }        
        #endregion
        #region 字段属性信息
        /// 标识码
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
        /// 要素代码
        public string Ysdm 
        {
            get { return this.ysdm; }
			set	{ 
                  if(this.ysdm != value)
                    {
                        this.OnPropertyChanging("Ysdm");  
                        this.ysdm= value;                                              
                        this.OnPropertyChanged("Ysdm");
                    }   
                }
        }	
        /// 界线类型 - 使用字典信息(界线类型字典表--JXLXZD)
        public string Jxlx 
        {
            get { return this.jxlx; }
			set	{ 
                  if(this.jxlx != value)
                    {
                        this.OnPropertyChanging("Jxlx");  
                        this.jxlx= value;                                              
                        this.OnPropertyChanged("Jxlx");
                    }   
                }
        }	
        /// 界线性质 - 使用字典信息(界线性质字典表--JXXZZD)
        public string Jxxz 
        {
            get { return this.jxxz; }
			set	{ 
                  if(this.jxxz != value)
                    {
                        this.OnPropertyChanging("Jxxz");  
                        this.jxxz= value;                                              
                        this.OnPropertyChanged("Jxxz");
                    }   
                }
        }	
        /// 界线说明
        public string Jxsm 
        {
            get { return this.jxsm; }
			set	{ 
                  if(this.jxsm != value)
                    {
                        this.OnPropertyChanging("Jxsm");  
                        this.jxsm= value;                                              
                        this.OnPropertyChanged("Jxsm");
                    }   
                }
        }	
        /// 源数据库内序号
        public long? DatabaseID 
        {
            get { return this.databaseid; }
			set	{ 
                  if(this.databaseid != value)
                    {
                        this.OnPropertyChanging("DatabaseID");  
                        this.databaseid= value;                                              
                        this.OnPropertyChanged("DatabaseID");
                    }   
                }
        }	
        /// 修改标记
        public short? Flags 
        {
            get { return this.flag; }
			set	{ 
                  if(this.flag != value)
                    {
                        this.OnPropertyChanging("Flags");  
                        this.flag= value;                                              
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
        /// XGR
        public string Xgr 
        {
            get { return this.xgr; }
			set	{ 
                  if(this.xgr != value)
                    {
                        this.OnPropertyChanging("Xgr");  
                        this.xgr= value;                                              
                        this.OnPropertyChanged("Xgr");
                    }   
                }
        }	
        /// XGSJ
        public System.DateTime? Xgsj 
        {
            get { return this.xgsj; }
			set	{ 
                  if(this.xgsj != value)
                    {
                        this.OnPropertyChanging("Xgsj");  
                        this.xgsj= value;                                              
                        this.OnPropertyChanged("Xgsj");
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
        public  Xzqjx()
        {
            _geometry=new Geometry(_geometryType,ZValueType.None);
            this.id=0;
            this.ysdm="1001020000";
            this.jxlx="";
            this.jxxz="";
            this.jxsm="";
            this.databaseid=0;
            this.flag=1;
            this.xgr="";
            this.xgsj=DateTime.Now;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Xzqjx record = obj as Xzqjx;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_XZQJX,dao.Connection))
            {
                this.databaseid=0;
                this.flag=1;
                command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
                command.Parameters.AddWithValue(PARAM_JXLX,this.Jxlx);
                command.Parameters.AddWithValue(PARAM_JXXZ,this.Jxxz);
                command.Parameters.AddWithValue(PARAM_JXSM,this.Jxsm);
                command.Parameters.AddWithValue(PARAM_DATABASEID,0);
                this.flag=1;command.Parameters.AddWithValue(PARAM_FLAGS,1);
                command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);
                command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_XZQJX,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
				command.Parameters.AddWithValue(PARAM_JXLX,this.Jxlx);
				command.Parameters.AddWithValue(PARAM_JXXZ,this.Jxxz);
				command.Parameters.AddWithValue(PARAM_JXSM,EncodingHelper.String2Unicode(this.Jxsm));
				command.Parameters.AddWithValue(PARAM_DATABASEID,this.DatabaseID);
				this.flag = (short?)(this.databaseid > 0 ? 2 :1);command.Parameters.AddWithValue(PARAM_FLAGS,this.flag);
				command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);
				command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);
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
            if(this.databaseid==0)
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_XZQJX,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_XZQJX,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);  
                    command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);  
                    return (command.ExecuteNonQuery() == 1);
                }
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