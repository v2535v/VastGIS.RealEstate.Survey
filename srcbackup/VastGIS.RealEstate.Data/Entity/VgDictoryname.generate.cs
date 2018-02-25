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
    public partial class VgDictoryname:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"ZDMC",false},{"ZDSM",false}};
        public const string TABLE_NAME = "vg_dictoryname";
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_ZDMC = "ZDMC";
	    public const string COL_ZDSM = "ZDSM";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ZDMC = "@ZDMC";
        public const string PARAM_ZDSM = "@ZDSM";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_VG_DICTORYNAME = "INSERT INTO vg_dictoryname (ZDMC, ZDSM) VALUES ( @ZDMC, @ZDSM);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_VG_DICTORYNAME = "UPDATE vg_dictoryname SET ZDMC = @ZDMC, ZDSM = @ZDSM WHERE Id = @Id";	
	    private const string SQL_DELETE_VG_DICTORYNAME = "DELETE FROM vg_dictoryname WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 字典名称
		protected string zdmc = default(string);
        /// ZDSM
		protected string zdsm = default(string);
        
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
            get{return "VgDictoryname";}
        }
        public string EntityName{
            get{return "Entity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_dictoryname",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_dictoryname",this.id);
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
        /// 字典名称
        public string Zdmc 
        {
            get { return this.zdmc; }
			set	{ 
                  if(this.zdmc != value)
                    {
                        this.OnPropertyChanging("Zdmc");  
                        this.zdmc= value;                                              
                        this.OnPropertyChanged("Zdmc");
                    }   
                }
        }	
        /// ZDSM
        public string Zdsm 
        {
            get { return this.zdsm; }
			set	{ 
                  if(this.zdsm != value)
                    {
                        this.OnPropertyChanging("Zdsm");  
                        this.zdsm= value;                                              
                        this.OnPropertyChanged("Zdsm");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgDictoryname()
        {
            
            this.id=0;
            this.zdmc="";
            this.zdsm="";
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgDictoryname record = obj as VgDictoryname;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_DICTORYNAME,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_ZDMC,this.Zdmc);  
                command.Parameters.AddWithValue(PARAM_ZDSM,this.Zdsm);  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_DICTORYNAME,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_ZDMC,this.Zdmc);
				command.Parameters.AddWithValue(PARAM_ZDSM,this.Zdsm);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(ISQLiteDao dao)
        {
            if(this.id == default(long))
            {
                return Create(dao) >0;
            }
            else
            {
                return Update(dao);
            }            
        }

		public bool Delete(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_DICTORYNAME,dao.Connection))
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