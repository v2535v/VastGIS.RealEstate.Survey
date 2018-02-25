
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
    public partial class VgFieldinfo : INotifyPropertyChanging, INotifyPropertyChanged,IEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_fieldinfo";	
        public const string LAYER_NAME = "字段信息";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_BM = "BM";
		public const string COL_BNSX = "BNSX";
		public const string COL_ZDZWMC = "ZDZWMC";
		public const string COL_ZDMC = "ZDMC";
		public const string COL_ZDLX = "ZDLX";
		public const string COL_ZDCD = "ZDCD";
		public const string COL_ZDXSWS = "ZDXSWS";
		public const string COL_SYZD = "SYZD";
		public const string COL_YS = "YS";
		public const string COL_SYZDYW = "SYZDYW";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_BM = "@BM";	
        public const string PARAM_BNSX = "@BNSX";	
        public const string PARAM_ZDZWMC = "@ZDZWMC";	
        public const string PARAM_ZDMC = "@ZDMC";	
        public const string PARAM_ZDLX = "@ZDLX";	
        public const string PARAM_ZDCD = "@ZDCD";	
        public const string PARAM_ZDXSWS = "@ZDXSWS";	
        public const string PARAM_SYZD = "@SYZD";	
        public const string PARAM_YS = "@YS";	
        public const string PARAM_SYZDYW = "@SYZDYW";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_VG_FIELDINFO ="SELECT  Id,BM,BNSX,ZDZWMC,ZDMC,ZDLX,ZDCD,ZDXSWS,SYZD,YS,SYZDYW FROM vg_fieldinfo ";
        
		private const string SQL_INSERT_VG_FIELDINFO = "INSERT INTO [vg_fieldinfo] (BM, BNSX, ZDZWMC, ZDMC, ZDLX, ZDCD, ZDXSWS, SYZD, YS, SYZDYW) VALUES ( @BM, @BNSX, @ZDZWMC, @ZDMC, @ZDLX, @ZDCD, @ZDXSWS, @SYZD, @YS, @SYZDYW);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_FIELDINFO = "UPDATE [vg_fieldinfo] SET BM = @BM, BNSX = @BNSX, ZDZWMC = @ZDZWMC, ZDMC = @ZDMC, ZDLX = @ZDLX, ZDCD = @ZDCD, ZDXSWS = @ZDXSWS, SYZD = @SYZD, YS = @YS, SYZDYW = @SYZDYW WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_FIELDINFO = "DELETE FROM [vg_fieldinfo] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///表名
		protected string bm = default(string);
        ///表内顺序
		protected long? bnsx = default(long?);
        ///字段中文名称
		protected string zdzwmc = default(string);
        ///字段名称
		protected string zdmc = default(string);
        ///字段类型
		protected string zdlx = default(string);
        ///字段长度
		protected long? zdcd = default(long?);
        ///字段显示顺序
		protected long? zdxsws = default(long?);
        ///使用字典
		protected string syzd = default(string);
        ///可选
		protected string ys = default(string);
        ///使用字典英文
		protected string syzdyw = default(string);
        
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
            get{return "VgFieldinfo";}
        }
         public string LayerName
        {
            get{return "字段信息";}
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
                return string.Format("{0} {1} ","vg_fieldinfo",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","字段信息",this.id);
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
		
        ///表名
        ///[Column(COL_BM, PARAM_BM )]
        public virtual string Bm 
        {
            get { return this.bm; }
			set	{ 
                  if(this.bm != value)
                    {
                        this.OnPropertyChanging("Bm"); 
                        this.bm = value;                        
                        this.OnPropertyChanged("Bm");
                    }   
                }
        }	
		
        ///表内顺序
        ///[Column(COL_BNSX, PARAM_BNSX )]
        public virtual long? Bnsx 
        {
            get { return this.bnsx; }
			set	{ 
                  if(this.bnsx != value)
                    {
                        this.OnPropertyChanging("Bnsx"); 
                        this.bnsx = value;                        
                        this.OnPropertyChanged("Bnsx");
                    }   
                }
        }	
		
        ///字段中文名称
        ///[Column(COL_ZDZWMC, PARAM_ZDZWMC )]
        public virtual string Zdzwmc 
        {
            get { return this.zdzwmc; }
			set	{ 
                  if(this.zdzwmc != value)
                    {
                        this.OnPropertyChanging("Zdzwmc"); 
                        this.zdzwmc = value;                        
                        this.OnPropertyChanged("Zdzwmc");
                    }   
                }
        }	
		
        ///字段名称
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
		
        ///字段类型
        ///[Column(COL_ZDLX, PARAM_ZDLX )]
        public virtual string Zdlx 
        {
            get { return this.zdlx; }
			set	{ 
                  if(this.zdlx != value)
                    {
                        this.OnPropertyChanging("Zdlx"); 
                        this.zdlx = value;                        
                        this.OnPropertyChanged("Zdlx");
                    }   
                }
        }	
		
        ///字段长度
        ///[Column(COL_ZDCD, PARAM_ZDCD )]
        public virtual long? Zdcd 
        {
            get { return this.zdcd; }
			set	{ 
                  if(this.zdcd != value)
                    {
                        this.OnPropertyChanging("Zdcd"); 
                        this.zdcd = value;                        
                        this.OnPropertyChanged("Zdcd");
                    }   
                }
        }	
		
        ///字段显示顺序
        ///[Column(COL_ZDXSWS, PARAM_ZDXSWS )]
        public virtual long? Zdxsws 
        {
            get { return this.zdxsws; }
			set	{ 
                  if(this.zdxsws != value)
                    {
                        this.OnPropertyChanging("Zdxsws"); 
                        this.zdxsws = value;                        
                        this.OnPropertyChanged("Zdxsws");
                    }   
                }
        }	
		
        ///使用字典
        ///[Column(COL_SYZD, PARAM_SYZD )]
        public virtual string Syzd 
        {
            get { return this.syzd; }
			set	{ 
                  if(this.syzd != value)
                    {
                        this.OnPropertyChanging("Syzd"); 
                        this.syzd = value;                        
                        this.OnPropertyChanged("Syzd");
                    }   
                }
        }	
		
        ///可选
        ///[Column(COL_YS, PARAM_YS )]
        public virtual string Ys 
        {
            get { return this.ys; }
			set	{ 
                  if(this.ys != value)
                    {
                        this.OnPropertyChanging("Ys"); 
                        this.ys = value;                        
                        this.OnPropertyChanged("Ys");
                    }   
                }
        }	
		
        ///使用字典英文
        ///[Column(COL_SYZDYW, PARAM_SYZDYW )]
        public virtual string Syzdyw 
        {
            get { return this.syzdyw; }
			set	{ 
                  if(this.syzdyw != value)
                    {
                        this.OnPropertyChanging("Syzdyw"); 
                        this.syzdyw = value;                        
                        this.OnPropertyChanged("Syzdyw");
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
        public VgFieldinfo()
        {
            this.id=0;
            this.bm="";
            this.bnsx=0;
            this.zdzwmc="";
            this.zdmc="";
            this.zdlx="";
            this.zdcd=0;
            this.zdxsws=0;
            this.syzd="";
            this.ys="";
            this.syzdyw="";
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            VgFieldinfo record = obj as VgFieldinfo;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_FIELDINFO,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_BM, this.Bm);
				command.Parameters.AddWithValue(PARAM_BNSX, this.Bnsx);
				command.Parameters.AddWithValue(PARAM_ZDZWMC, this.Zdzwmc);
				command.Parameters.AddWithValue(PARAM_ZDMC, this.Zdmc);
				command.Parameters.AddWithValue(PARAM_ZDLX, this.Zdlx);
				command.Parameters.AddWithValue(PARAM_ZDCD, this.Zdcd);
				command.Parameters.AddWithValue(PARAM_ZDXSWS, this.Zdxsws);
				command.Parameters.AddWithValue(PARAM_SYZD, this.Syzd);
				command.Parameters.AddWithValue(PARAM_YS, this.Ys);
				command.Parameters.AddWithValue(PARAM_SYZDYW, this.Syzdyw);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_FIELDINFO,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_BM, this.Bm);
				command.Parameters.AddWithValue(PARAM_BNSX, this.Bnsx);
				command.Parameters.AddWithValue(PARAM_ZDZWMC, this.Zdzwmc);
				command.Parameters.AddWithValue(PARAM_ZDMC, this.Zdmc);
				command.Parameters.AddWithValue(PARAM_ZDLX, this.Zdlx);
				command.Parameters.AddWithValue(PARAM_ZDCD, this.Zdcd);
				command.Parameters.AddWithValue(PARAM_ZDXSWS, this.Zdxsws);
				command.Parameters.AddWithValue(PARAM_SYZD, this.Syzd);
				command.Parameters.AddWithValue(PARAM_YS, this.Ys);
				command.Parameters.AddWithValue(PARAM_SYZDYW, this.Syzdyw);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_FIELDINFO,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) bm = reader.GetString(1);
			if (!reader.IsDBNull(2)) bnsx = reader.GetInt64(2);
			if (!reader.IsDBNull(3)) zdzwmc = reader.GetString(3);
			if (!reader.IsDBNull(4)) zdmc = reader.GetString(4);
			if (!reader.IsDBNull(5)) zdlx = reader.GetString(5);
			if (!reader.IsDBNull(6)) zdcd = reader.GetInt64(6);
			if (!reader.IsDBNull(7)) zdxsws = reader.GetInt64(7);
			if (!reader.IsDBNull(8)) syzd = reader.GetString(8);
			if (!reader.IsDBNull(9)) ys = reader.GetString(9);
			if (!reader.IsDBNull(10)) syzdyw = reader.GetString(10);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgFieldinfo target=new VgFieldinfo();
            target.ID=0;
            target.Bm=this.Bm;
            target.Bnsx=this.Bnsx;
            target.Zdzwmc=this.Zdzwmc;
            target.Zdmc=this.Zdmc;
            target.Zdlx=this.Zdlx;
            target.Zdcd=this.Zdcd;
            target.Zdxsws=this.Zdxsws;
            target.Syzd=this.Syzd;
            target.Ys=this.Ys;
            target.Syzdyw=this.Syzdyw;
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
