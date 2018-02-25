
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
    public partial class Jzxzj : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseFeature,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "JZXZJ";	
        public const string LAYER_NAME = "界址线注记";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.Point;
     
		public const string COL_ID = "Id";
		public const string COL_GLYSBH = "GLYSBH";
		public const string COL_YSDM = "YSDM";
		public const string COL_ZJNR = "ZJNR";
		public const string COL_ZT = "ZT";
		public const string COL_YS = "YS";
		public const string COL_BS = "BS";
		public const string COL_XZ = "XZ";
		public const string COL_XHX = "XHX";
		public const string COL_KD = "KD";
		public const string COL_GD = "GD";
		public const string COL_ZJDZXJXZB = "ZJDZXJXZB";
		public const string COL_ZJDZXJYZB = "ZJDZXJYZB";
		public const string COL_ZJFX = "ZJFX";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		public const string COL_GEOMETRY = "geometry";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_GLYSBH = "@GLYSBH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_ZJNR = "@ZJNR";	
        public const string PARAM_ZT = "@ZT";	
        public const string PARAM_YS = "@YS";	
        public const string PARAM_BS = "@BS";	
        public const string PARAM_XZ = "@XZ";	
        public const string PARAM_XHX = "@XHX";	
        public const string PARAM_KD = "@KD";	
        public const string PARAM_GD = "@GD";	
        public const string PARAM_ZJDZXJXZB = "@ZJDZXJXZB";	
        public const string PARAM_ZJDZXJYZB = "@ZJDZXJYZB";	
        public const string PARAM_ZJFX = "@ZJFX";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
        public const string PARAM_GEOMETRY = "@geometry";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_JZXZJ ="SELECT  Id,GLYSBH,YSDM,ZJNR,ZT,YS,BS,XZ,XHX,KD,GD,ZJDZXJXZB,ZJDZXJYZB,ZJFX,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM JZXZJ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_JZXZJ = "INSERT INTO [JZXZJ] (GLYSBH, YSDM, ZJNR, ZT, YS, BS, XZ, XHX, KD, GD, ZJDZXJXZB, ZJDZXJYZB, ZJFX, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @GLYSBH, @YSDM, @ZJNR, @ZT, @YS, @BS, @XZ, @XHX, @KD, @GD, @ZJDZXJXZB, @ZJDZXJYZB, @ZJFX, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_JZXZJ = "UPDATE [JZXZJ] SET GLYSBH = @GLYSBH, YSDM = @YSDM, ZJNR = @ZJNR, ZT = @ZT, YS = @YS, BS = @BS, XZ = @XZ, XHX = @XHX, KD = @KD, GD = @GD, ZJDZXJXZB = @ZJDZXJXZB, ZJDZXJYZB = @ZJDZXJYZB, ZJFX = @ZJFX, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ,  geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
		
		private const string SQL_DELETE_JZXZJ = "DELETE FROM [JZXZJ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_JZXZJ = "UPDATE [JZXZJ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///内部要素编号
		protected string glysbh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///注记内容
		protected string zjnr = default(string);
        ///字体
		protected string zt = default(string);
        ///颜色
		protected string ys = default(string);
        ///磅数
		protected long? bs = default(long?);
        ///形状
		protected string xz = default(string);
        ///下划线
		protected string xhx = default(string);
        ///宽度
		protected double? kd = default(double?);
        ///高度
		protected double? gd = default(double?);
        ///注记点左下角X坐标
		protected double? zjdzxjxzb = default(double?);
        ///注记点左下角Y坐标
		protected double? zjdzxjyzb = default(double?);
        ///注记方向
		protected double? zjfx = default(double?);
        ///原数据库内序号
		protected long? databaseid = default(long?);
        ///修改标记
		protected short? flags = default(short?);
        ///修改人
		protected string xgr = default(string);
        ///修改时间
		protected System.DateTime? xgsj = default(System.DateTime?);
        ///图形对象
        protected IGeometry _geometry;
        ///WKT字段
        protected string _wkt=default(string);
        
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
            get{return "Jzxzj";}
        }
         public string LayerName
        {
            get{return "界址线注记";}
        }
        public string EntityName{
            get{return "IDatabaseFeature,IYsdmEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return true;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","JZXZJ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","界址线注记",this.id,this.ysdm);
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
		
        ///内部要素编号
        ///[Column(COL_GLYSBH, PARAM_GLYSBH )]
        public virtual string Glysbh 
        {
            get { return this.glysbh; }
			set	{ 
                  if(this.glysbh != value)
                    {
                        this.OnPropertyChanging("Glysbh"); 
                        this.glysbh = value;                        
                        this.OnPropertyChanged("Glysbh");
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
		
        ///注记内容
        ///[Column(COL_ZJNR, PARAM_ZJNR )]
        public virtual string Zjnr 
        {
            get { return this.zjnr; }
			set	{ 
                  if(this.zjnr != value)
                    {
                        this.OnPropertyChanging("Zjnr"); 
                        this.zjnr = value;                        
                        this.OnPropertyChanged("Zjnr");
                    }   
                }
        }	
		
        ///字体
        ///[Column(COL_ZT, PARAM_ZT )]
        public virtual string Zt 
        {
            get { return this.zt; }
			set	{ 
                  if(this.zt != value)
                    {
                        this.OnPropertyChanging("Zt"); 
                        this.zt = value;                        
                        this.OnPropertyChanged("Zt");
                    }   
                }
        }	
		
        ///颜色
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
		
        ///磅数
        ///[Column(COL_BS, PARAM_BS )]
        public virtual long? Bs 
        {
            get { return this.bs; }
			set	{ 
                  if(this.bs != value)
                    {
                        this.OnPropertyChanging("Bs"); 
                        this.bs = value;                        
                        this.OnPropertyChanged("Bs");
                    }   
                }
        }	
		
        ///形状
        ///[Column(COL_XZ, PARAM_XZ )]
        public virtual string Xz 
        {
            get { return this.xz; }
			set	{ 
                  if(this.xz != value)
                    {
                        this.OnPropertyChanging("Xz"); 
                        this.xz = value;                        
                        this.OnPropertyChanged("Xz");
                    }   
                }
        }	
		
        ///下划线
        ///[Column(COL_XHX, PARAM_XHX )]
        public virtual string Xhx 
        {
            get { return this.xhx; }
			set	{ 
                  if(this.xhx != value)
                    {
                        this.OnPropertyChanging("Xhx"); 
                        this.xhx = value;                        
                        this.OnPropertyChanged("Xhx");
                    }   
                }
        }	
		
        ///宽度
        ///[Column(COL_KD, PARAM_KD )]
        public virtual double? Kd 
        {
            get { return this.kd; }
			set	{ 
                  if(this.kd != value)
                    {
                        this.OnPropertyChanging("Kd"); 
                        this.kd = value;                        
                        this.OnPropertyChanged("Kd");
                    }   
                }
        }	
		
        ///高度
        ///[Column(COL_GD, PARAM_GD )]
        public virtual double? Gd 
        {
            get { return this.gd; }
			set	{ 
                  if(this.gd != value)
                    {
                        this.OnPropertyChanging("Gd"); 
                        this.gd = value;                        
                        this.OnPropertyChanged("Gd");
                    }   
                }
        }	
		
        ///注记点左下角X坐标
        ///[Column(COL_ZJDZXJXZB, PARAM_ZJDZXJXZB )]
        public virtual double? Zjdzxjxzb 
        {
            get { return this.zjdzxjxzb; }
			set	{ 
                  if(this.zjdzxjxzb != value)
                    {
                        this.OnPropertyChanging("Zjdzxjxzb"); 
                        this.zjdzxjxzb = value;                        
                        this.OnPropertyChanged("Zjdzxjxzb");
                    }   
                }
        }	
		
        ///注记点左下角Y坐标
        ///[Column(COL_ZJDZXJYZB, PARAM_ZJDZXJYZB )]
        public virtual double? Zjdzxjyzb 
        {
            get { return this.zjdzxjyzb; }
			set	{ 
                  if(this.zjdzxjyzb != value)
                    {
                        this.OnPropertyChanging("Zjdzxjyzb"); 
                        this.zjdzxjyzb = value;                        
                        this.OnPropertyChanged("Zjdzxjyzb");
                    }   
                }
        }	
		
        ///注记方向
        ///[Column(COL_ZJFX, PARAM_ZJFX )]
        public virtual double? Zjfx 
        {
            get { return this.zjfx; }
			set	{ 
                  if(this.zjfx != value)
                    {
                        this.OnPropertyChanging("Zjfx"); 
                        this.zjfx = value;                        
                        this.OnPropertyChanged("Zjfx");
                    }   
                }
        }	
		
        ///原数据库内序号
        ///[Column(COL_DATABASEID, PARAM_DATABASEID )]
        public virtual long? DatabaseID 
        {
            get { return this.databaseid; }
			set	{ 
                  if(this.databaseid != value)
                    {
                        this.OnPropertyChanging("DatabaseID"); 
                        this.databaseid = value;                        
                        this.OnPropertyChanged("DatabaseID");
                    }   
                }
        }	
		
        ///修改标记
        ///[Column(COL_FLAGS, PARAM_FLAGS )]
        public virtual short? Flags 
        {
            get { return this.flags; }
			set	{ 
                  if(this.flags != value)
                    {
                        this.OnPropertyChanging("Flags"); 
                        this.flags = value;                        
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
		
        ///修改人
        ///[Column(COL_XGR, PARAM_XGR )]
        public virtual string Xgr 
        {
            get { return this.xgr; }
			set	{ 
                  if(this.xgr != value)
                    {
                        this.OnPropertyChanging("Xgr"); 
                        this.xgr = value;                        
                        this.OnPropertyChanged("Xgr");
                    }   
                }
        }	
		
        ///修改时间
        ///[Column(COL_XGSJ, PARAM_XGSJ )]
        public virtual System.DateTime? Xgsj 
        {
            get { return this.xgsj; }
			set	{ 
                  if(this.xgsj != value)
                    {
                        this.OnPropertyChanging("Xgsj"); 
                        this.xgsj = value;                        
                        this.OnPropertyChanged("Xgsj");
                    }   
                }
        }	
		
      
       ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
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
        public Jzxzj()
        {
            _geometry=new Geometry(GEOMETRY_TYPE,ZValueType.None);
            this.id=0;
            this.glysbh="";
            this.ysdm="";
            this.zjnr="";
            this.zt="";
            this.ys="";
            this.bs=0;
            this.xz="";
            this.xhx="";
            this.kd=0.0;
            this.gd=0.0;
            this.zjdzxjxzb=0.0;
            this.zjdzxjyzb=0.0;
            this.zjfx=0.0;
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
            
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Jzxzj record = obj as Jzxzj;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_JZXZJ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_GLYSBH, this.Glysbh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZJNR, this.Zjnr);
				command.Parameters.AddWithValue(PARAM_ZT, this.Zt);
				command.Parameters.AddWithValue(PARAM_YS, this.Ys);
				command.Parameters.AddWithValue(PARAM_BS, this.Bs);
				command.Parameters.AddWithValue(PARAM_XZ, this.Xz);
				command.Parameters.AddWithValue(PARAM_XHX, this.Xhx);
				command.Parameters.AddWithValue(PARAM_KD, this.Kd);
				command.Parameters.AddWithValue(PARAM_GD, this.Gd);
				command.Parameters.AddWithValue(PARAM_ZJDZXJXZB, this.Zjdzxjxzb);
				command.Parameters.AddWithValue(PARAM_ZJDZXJYZB, this.Zjdzxjyzb);
				command.Parameters.AddWithValue(PARAM_ZJFX, this.Zjfx);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
                command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_JZXZJ,dao.Connection))
            {
                if(this.databaseid>0)
                {
                    this.flags=2;
                }
                else
                {
                    this.flags=1;
                }
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now; 
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_GLYSBH, this.Glysbh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZJNR, this.Zjnr);
				command.Parameters.AddWithValue(PARAM_ZT, this.Zt);
				command.Parameters.AddWithValue(PARAM_YS, this.Ys);
				command.Parameters.AddWithValue(PARAM_BS, this.Bs);
				command.Parameters.AddWithValue(PARAM_XZ, this.Xz);
				command.Parameters.AddWithValue(PARAM_XHX, this.Xhx);
				command.Parameters.AddWithValue(PARAM_KD, this.Kd);
				command.Parameters.AddWithValue(PARAM_GD, this.Gd);
				command.Parameters.AddWithValue(PARAM_ZJDZXJXZB, this.Zjdzxjxzb);
				command.Parameters.AddWithValue(PARAM_ZJDZXJYZB, this.Zjdzxjyzb);
				command.Parameters.AddWithValue(PARAM_ZJFX, this.Zjfx);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
                command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
			   
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
            if(this.databaseid==0)
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_JZXZJ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_JZXZJ,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);  
                    command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);  
                    return (command.ExecuteNonQuery() == 1);
                }
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) glysbh = reader.GetString(1);
			if (!reader.IsDBNull(2)) ysdm = reader.GetString(2);
			if (!reader.IsDBNull(3)) zjnr = reader.GetString(3);
			if (!reader.IsDBNull(4)) zt = reader.GetString(4);
			if (!reader.IsDBNull(5)) ys = reader.GetString(5);
			if (!reader.IsDBNull(6)) bs = reader.GetInt64(6);
			if (!reader.IsDBNull(7)) xz = reader.GetString(7);
			if (!reader.IsDBNull(8)) xhx = reader.GetString(8);
			if (!reader.IsDBNull(9)) kd = reader.GetDouble(9);
			if (!reader.IsDBNull(10)) gd = reader.GetDouble(10);
			if (!reader.IsDBNull(11)) zjdzxjxzb = reader.GetDouble(11);
			if (!reader.IsDBNull(12)) zjdzxjyzb = reader.GetDouble(12);
			if (!reader.IsDBNull(13)) zjfx = reader.GetDouble(13);
			if (!reader.IsDBNull(14)) databaseid = reader.GetInt64(14);
			if (!reader.IsDBNull(15)) flags = reader.GetInt16(15);
			if (!reader.IsDBNull(16)) xgr = reader.GetString(16);
			if (!reader.IsDBNull(17)) xgsj = reader.GetDateTime(17);
			if (!reader.IsDBNull(18)) this.Wkt=reader.GetString(18);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Jzxzj target=new Jzxzj();
            target.ID=0;
            target.Glysbh=this.Glysbh;
            target.Ysdm=this.Ysdm;
            target.Zjnr=this.Zjnr;
            target.Zt=this.Zt;
            target.Ys=this.Ys;
            target.Bs=this.Bs;
            target.Xz=this.Xz;
            target.Xhx=this.Xhx;
            target.Kd=this.Kd;
            target.Gd=this.Gd;
            target.Zjdzxjxzb=this.Zjdzxjxzb;
            target.Zjdzxjyzb=this.Zjdzxjyzb;
            target.Zjfx=this.Zjfx;
            target.DatabaseID=0;
            target.Flags=1;
            target.Xgr=Environment.UserName;
            target.Xgsj=DateTime.Now;
            target.Wkt=this._wkt;
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
