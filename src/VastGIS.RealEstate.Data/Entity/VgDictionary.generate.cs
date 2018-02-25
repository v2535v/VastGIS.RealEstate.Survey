
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
    public partial class VgDictionary : INotifyPropertyChanging, INotifyPropertyChanged,IEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_dictionary";	
        public const string LAYER_NAME = "数据字典";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
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
		
		#region SQL语句
		private const string SQL_QUERY_VG_DICTIONARY ="SELECT  Id,ZDMC,ZDZ,ZDSM,SFQS,PX FROM vg_dictionary ";
        
		private const string SQL_INSERT_VG_DICTIONARY = "INSERT INTO [vg_dictionary] (ZDMC, ZDZ, ZDSM, SFQS, PX) VALUES ( @ZDMC, @ZDZ, @ZDSM, @SFQS, @PX);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_DICTIONARY = "UPDATE [vg_dictionary] SET ZDMC = @ZDMC, ZDZ = @ZDZ, ZDSM = @ZDSM, SFQS = @SFQS, PX = @PX WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_DICTIONARY = "DELETE FROM [vg_dictionary] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///字典名称
		protected string zdmc = default(string);
        ///字典值
		protected string zdz = default(string);
        ///字典值说明
		protected string zdsm = default(string);
        ///是否缺省
		protected bool? sfqs = default(bool?);
        ///排序
		protected int? px = default(int?);
        
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
            get{return "VgDictionary";}
        }
         public string LayerName
        {
            get{return "数据字典";}
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
                return string.Format("{0} {1} ","vg_dictionary",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","字典内容",this.id);
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
		
        ///字典名称
        ///[Column(COL_ZDMC, PARAM_ZDMC )]
        public virtual string Zdmc 
        {
            get { return this.zdmc; }
			set	{ 
                  if(this.zdmc != value)
                    {
                        this.OnPropertyChanging("Zdmc"); 
                        this.zdmc = value;                        
                        this.OnPropertyChanged("Zdmc");
                    }   
                }
        }	
		
        ///字典值
        ///[Column(COL_ZDZ, PARAM_ZDZ )]
        public virtual string Zdz 
        {
            get { return this.zdz; }
			set	{ 
                  if(this.zdz != value)
                    {
                        this.OnPropertyChanging("Zdz"); 
                        this.zdz = value;                        
                        this.OnPropertyChanged("Zdz");
                    }   
                }
        }	
		
        ///字典值说明
        ///[Column(COL_ZDSM, PARAM_ZDSM )]
        public virtual string Zdsm 
        {
            get { return this.zdsm; }
			set	{ 
                  if(this.zdsm != value)
                    {
                        this.OnPropertyChanging("Zdsm"); 
                        this.zdsm = value;                        
                        this.OnPropertyChanged("Zdsm");
                    }   
                }
        }	
		
        ///是否缺省
        ///[Column(COL_SFQS, PARAM_SFQS )]
        public virtual bool? Sfqs 
        {
            get { return this.sfqs; }
			set	{ 
                  if(this.sfqs != value)
                    {
                        this.OnPropertyChanging("Sfqs"); 
                        this.sfqs = value;                        
                        this.OnPropertyChanged("Sfqs");
                    }   
                }
        }	
		
        ///排序
        ///[Column(COL_PX, PARAM_PX )]
        public virtual int? Px 
        {
            get { return this.px; }
			set	{ 
                  if(this.px != value)
                    {
                        this.OnPropertyChanging("Px"); 
                        this.px = value;                        
                        this.OnPropertyChanged("Px");
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
        public VgDictionary()
        {
            this.id=0;
            this.zdmc="";
            this.zdz="";
            this.zdsm="";
            this.sfqs=true;
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
        
		
		
		public long Create(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_DICTIONARY,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_ZDMC, this.Zdmc);
				command.Parameters.AddWithValue(PARAM_ZDZ, this.Zdz);
				command.Parameters.AddWithValue(PARAM_ZDSM, this.Zdsm);
				command.Parameters.AddWithValue(PARAM_SFQS, this.Sfqs);
				command.Parameters.AddWithValue(PARAM_PX, this.Px);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_DICTIONARY,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_ZDMC, this.Zdmc);
				command.Parameters.AddWithValue(PARAM_ZDZ, this.Zdz);
				command.Parameters.AddWithValue(PARAM_ZDSM, this.Zdsm);
				command.Parameters.AddWithValue(PARAM_SFQS, this.Sfqs);
				command.Parameters.AddWithValue(PARAM_PX, this.Px);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_DICTIONARY,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) zdmc = reader.GetString(1);
			if (!reader.IsDBNull(2)) zdz = reader.GetString(2);
			if (!reader.IsDBNull(3)) zdsm = reader.GetString(3);
			if (!reader.IsDBNull(4)) sfqs = reader.GetBoolean(4);
			if (!reader.IsDBNull(5)) px = reader.GetInt32(5);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgDictionary target=new VgDictionary();
            target.ID=0;
            target.Zdmc=this.Zdmc;
            target.Zdz=this.Zdz;
            target.Zdsm=this.Zdsm;
            target.Sfqs=this.Sfqs;
            target.Px=this.Px;
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
