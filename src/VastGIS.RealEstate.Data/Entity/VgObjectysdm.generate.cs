
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
    public partial class VgObjectysdm : INotifyPropertyChanging, INotifyPropertyChanged,IEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_objectysdm";	
        public const string LAYER_NAME = "图形要素代码";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_YSMC = "YSMC";
		public const string COL_XSSX = "XSSX";
		public const string COL_QSBG = "QSBG";
		public const string COL_QSFH = "QSFH";
		public const string COL_SFKJ = "SFKJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_YSMC = "@YSMC";	
        public const string PARAM_XSSX = "@XSSX";	
        public const string PARAM_QSBG = "@QSBG";	
        public const string PARAM_QSFH = "@QSFH";	
        public const string PARAM_SFKJ = "@SFKJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_VG_OBJECTYSDM ="SELECT  Id,YSDM,YSMC,XSSX,QSBG,QSFH,SFKJ FROM vg_objectysdm ";
        
		private const string SQL_INSERT_VG_OBJECTYSDM = "INSERT INTO [vg_objectysdm] (YSDM, YSMC, XSSX, QSBG, QSFH, SFKJ) VALUES ( @YSDM, @YSMC, @XSSX, @QSBG, @QSFH, @SFKJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_OBJECTYSDM = "UPDATE [vg_objectysdm] SET YSDM = @YSDM, YSMC = @YSMC, XSSX = @XSSX, QSBG = @QSBG, QSFH = @QSFH, SFKJ = @SFKJ WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_OBJECTYSDM = "DELETE FROM [vg_objectysdm] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///要素名称
		protected string ysmc = default(string);
        ///显示顺序
		protected long? xssx = default(long?);
        ///缺省表格
		protected string qsbg = default(string);
        ///缺省符号
		protected string qsfh = default(string);
        ///是否空间要素
		protected bool sfkj = default(bool);
        
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
            get{return "VgObjectysdm";}
        }
         public string LayerName
        {
            get{return "图形要素代码";}
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
                return string.Format("{0} {1} ({2})","vg_objectysdm",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","要素代码",this.id,this.ysdm);
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
		
        ///显示顺序
        ///[Column(COL_XSSX, PARAM_XSSX )]
        public virtual long? Xssx 
        {
            get { return this.xssx; }
			set	{ 
                  if(this.xssx != value)
                    {
                        this.OnPropertyChanging("Xssx"); 
                        this.xssx = value;                        
                        this.OnPropertyChanged("Xssx");
                    }   
                }
        }	
		
        ///缺省表格
        ///[Column(COL_QSBG, PARAM_QSBG )]
        public virtual string Qsbg 
        {
            get { return this.qsbg; }
			set	{ 
                  if(this.qsbg != value)
                    {
                        this.OnPropertyChanging("Qsbg"); 
                        this.qsbg = value;                        
                        this.OnPropertyChanged("Qsbg");
                    }   
                }
        }	
		
        ///缺省符号
        ///[Column(COL_QSFH, PARAM_QSFH )]
        public virtual string Qsfh 
        {
            get { return this.qsfh; }
			set	{ 
                  if(this.qsfh != value)
                    {
                        this.OnPropertyChanging("Qsfh"); 
                        this.qsfh = value;                        
                        this.OnPropertyChanged("Qsfh");
                    }   
                }
        }	
		
        ///是否空间要素
        ///[Column(COL_SFKJ, PARAM_SFKJ, default(bool))]
        public virtual bool Sfkj 
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
		
      
       ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
        }
        #endregion        
        
        #region 创建方法
        public VgObjectysdm()
        {
            this.id=0;
            this.ysdm="";
            this.ysmc="";
            this.xssx=0;
            this.qsbg="";
            this.qsfh="";
            this.sfkj=true;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            VgObjectysdm record = obj as VgObjectysdm;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_OBJECTYSDM,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YSMC, this.Ysmc);
				command.Parameters.AddWithValue(PARAM_XSSX, this.Xssx);
				command.Parameters.AddWithValue(PARAM_QSBG, this.Qsbg);
				command.Parameters.AddWithValue(PARAM_QSFH, this.Qsfh);
				command.Parameters.AddWithValue(PARAM_SFKJ, this.Sfkj);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_OBJECTYSDM,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YSMC, this.Ysmc);
				command.Parameters.AddWithValue(PARAM_XSSX, this.Xssx);
				command.Parameters.AddWithValue(PARAM_QSBG, this.Qsbg);
				command.Parameters.AddWithValue(PARAM_QSFH, this.Qsfh);
				command.Parameters.AddWithValue(PARAM_SFKJ, this.Sfkj);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_OBJECTYSDM,dao.Connection))
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
			if (!reader.IsDBNull(3)) xssx = reader.GetInt64(3);
			if (!reader.IsDBNull(4)) qsbg = reader.GetString(4);
			if (!reader.IsDBNull(5)) qsfh = reader.GetString(5);
			if (!reader.IsDBNull(6)) sfkj = reader.GetBoolean(6);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgObjectysdm target=new VgObjectysdm();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Ysmc=this.Ysmc;
            target.Xssx=this.Xssx;
            target.Qsbg=this.Qsbg;
            target.Qsfh=this.Qsfh;
            target.Sfkj=this.Sfkj;
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
