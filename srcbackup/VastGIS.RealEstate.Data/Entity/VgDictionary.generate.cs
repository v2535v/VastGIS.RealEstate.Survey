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
    public partial class VgDictionary:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"ZDMC",false},{"ZDZ",false},{"ZDSM",false},{"SFQS",false},{"PX",false}};
        public const string TABLE_NAME = "vg_dictionary";
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_ZDMC = "ZDMC";
	    public const string COL_ZDZ = "ZDZ";
	    public const string COL_ZDSM = "ZDSM";
	    public const string COL_SFQS = "SFQS";
	    public const string COL_PX = "PX";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ZDMC = "@ZDMC";
        public const string PARAM_ZDZ = "@ZDZ";
        public const string PARAM_ZDSM = "@ZDSM";
        public const string PARAM_SFQS = "@SFQS";
        public const string PARAM_PX = "@PX";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_VG_DICTIONARY = "INSERT INTO vg_dictionary (ZDMC, ZDZ, ZDSM, SFQS, PX) VALUES ( @ZDMC, @ZDZ, @ZDSM, @SFQS, @PX);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_VG_DICTIONARY = "UPDATE vg_dictionary SET ZDMC = @ZDMC, ZDZ = @ZDZ, ZDSM = @ZDSM, SFQS = @SFQS, PX = @PX WHERE Id = @Id";	
	    private const string SQL_DELETE_VG_DICTIONARY = "DELETE FROM vg_dictionary WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 字典名称
		protected string zdmc = default(string);
        /// 字典值
		protected string zdz = default(string);
        /// 字典值说明
		protected string zdsm = default(string);
        /// 是否缺省
		protected bool? sfq = default(bool?);
        /// 排序
		protected int? px = default(int?);
		protected VgDictoryname vgDictorynameRef;	
        
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
            get{return "VgDictionary";}
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
                return string.Format("{0} {1} ","vg_dictionary",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_dictionary",this.id);
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
        /// 字典值
        public string Zdz 
        {
            get { return this.zdz; }
			set	{ 
                  if(this.zdz != value)
                    {
                        this.OnPropertyChanging("Zdz");  
                        this.zdz= value;                                              
                        this.OnPropertyChanged("Zdz");
                    }   
                }
        }	
        /// 字典值说明
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
        /// 是否缺省
        public bool? Sfqs 
        {
            get { return this.sfq; }
			set	{ 
                  if(this.sfq != value)
                    {
                        this.OnPropertyChanging("Sfqs");  
                        this.sfq= value;                                              
                        this.OnPropertyChanged("Sfqs");
                    }   
                }
        }	
        /// 排序
        public int? Px 
        {
            get { return this.px; }
			set	{ 
                  if(this.px != value)
                    {
                        this.OnPropertyChanging("Px");  
                        this.px= value;                                              
                        this.OnPropertyChanged("Px");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgDictionary()
        {
            
            this.id=0;
            this.zdmc="";
            this.zdz="";
            this.zdsm="";
            this.sfq=false;
            this.px=0;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgDictionary record = obj as VgDictionary;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_DICTIONARY,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_ZDMC,this.Zdmc);  
                command.Parameters.AddWithValue(PARAM_ZDZ,this.Zdz);  
                command.Parameters.AddWithValue(PARAM_ZDSM,this.Zdsm);  
                command.Parameters.AddWithValue(PARAM_SFQS,this.Sfqs);  
                command.Parameters.AddWithValue(PARAM_PX,this.Px);  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_DICTIONARY,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_ZDMC,this.Zdmc);
				command.Parameters.AddWithValue(PARAM_ZDZ,this.Zdz);
				command.Parameters.AddWithValue(PARAM_ZDSM,this.Zdsm);
				command.Parameters.AddWithValue(PARAM_SFQS,this.Sfqs);
				command.Parameters.AddWithValue(PARAM_PX,this.Px);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_DICTIONARY,dao.Connection))
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