using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class Zdjbxx:INotifyPropertyChanging, INotifyPropertyChanged,IBackEntity,IDatabaseEntity
    {
        #region 表结构
        public const string TABLE_NAME = "ZDJBXX";
	    public const string COL_ID = "Id";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_ZDDM = "ZDDM";
	    public const string COL_BDCDYH = "BDCDYH";
	    public const string COL_ZDTZM = "ZDTZM";
	    public const string COL_ZL = "ZL";
	    public const string COL_ZDMJ = "ZDMJ";
	    public const string COL_MJDW = "MJDW";
	    public const string COL_YT = "YT";
	    public const string COL_DJ = "DJ";
	    public const string COL_JG = "JG";
	    public const string COL_QLLX = "QLLX";
	    public const string COL_QLXZ = "QLXZ";
	    public const string COL_QLSDFS = "QLSDFS";
	    public const string COL_RJL = "RJL";
	    public const string COL_JZMD = "JZMD";
	    public const string COL_JZXG = "JZXG";
	    public const string COL_ZDSZD = "ZDSZD";
	    public const string COL_ZDSZN = "ZDSZN";
	    public const string COL_ZDSZX = "ZDSZX";
	    public const string COL_ZDSZB = "ZDSZB";
	    public const string COL_ZDT = "ZDT";
	    public const string COL_TFH = "TFH";
	    public const string COL_DJH = "DJH";
	    public const string COL_DAH = "DAH";
	    public const string COL_BZ = "BZ";
	    public const string COL_ZT = "ZT";
	    public const string COL_WX_DCY = "WX_DCY";
	    public const string COL_WX_DCSJ = "WX_DCSJ";
	    public const string COL_WX_CLY = "WX_CLY";
	    public const string COL_WX_CLSJ = "WX_CLSJ";
	    public const string COL_WX_ZTY = "WX_ZTY";
	    public const string COL_WX_ZTSJ = "WX_ZTSJ";
	    public const string COL_WX_ZJY = "WX_ZJY";
	    public const string COL_WX_ZJSJ = "WX_ZJSJ";
	    public const string COL_WX_WYDM = "WX_WYDM";
	    public const string COL_DATABASEID = "DatabaseId";
	    public const string COL_FLAGS = "FLAGS";
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_ZDDM = "@ZDDM";
        public const string PARAM_BDCDYH = "@BDCDYH";
        public const string PARAM_ZDTZM = "@ZDTZM";
        public const string PARAM_ZL = "@ZL";
        public const string PARAM_ZDMJ = "@ZDMJ";
        public const string PARAM_MJDW = "@MJDW";
        public const string PARAM_YT = "@YT";
        public const string PARAM_DJ = "@DJ";
        public const string PARAM_JG = "@JG";
        public const string PARAM_QLLX = "@QLLX";
        public const string PARAM_QLXZ = "@QLXZ";
        public const string PARAM_QLSDFS = "@QLSDFS";
        public const string PARAM_RJL = "@RJL";
        public const string PARAM_JZMD = "@JZMD";
        public const string PARAM_JZXG = "@JZXG";
        public const string PARAM_ZDSZD = "@ZDSZD";
        public const string PARAM_ZDSZN = "@ZDSZN";
        public const string PARAM_ZDSZX = "@ZDSZX";
        public const string PARAM_ZDSZB = "@ZDSZB";
        public const string PARAM_ZDT = "@ZDT";
        public const string PARAM_TFH = "@TFH";
        public const string PARAM_DJH = "@DJH";
        public const string PARAM_DAH = "@DAH";
        public const string PARAM_BZ = "@BZ";
        public const string PARAM_ZT = "@ZT";
        public const string PARAM_WX_DCY = "@WX_DCY";
        public const string PARAM_WX_DCSJ = "@WX_DCSJ";
        public const string PARAM_WX_CLY = "@WX_CLY";
        public const string PARAM_WX_CLSJ = "@WX_CLSJ";
        public const string PARAM_WX_ZTY = "@WX_ZTY";
        public const string PARAM_WX_ZTSJ = "@WX_ZTSJ";
        public const string PARAM_WX_ZJY = "@WX_ZJY";
        public const string PARAM_WX_ZJSJ = "@WX_ZJSJ";
        public const string PARAM_WX_WYDM = "@WX_WYDM";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_ZDJBXX = "INSERT INTO ZDJBXX (YSDM, ZDDM, BDCDYH, ZDTZM, ZL, ZDMJ, MJDW, YT, DJ, JG, QLLX, QLXZ, QLSDFS, RJL, JZMD, JZXG, ZDSZD, ZDSZN, ZDSZX, ZDSZB, ZDT, TFH, DJH, DAH, BZ, ZT, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, geometry) VALUES ( @YSDM, @ZDDM, @BDCDYH, @ZDTZM, @ZL, @ZDMJ, @MJDW, @YT, @DJ, @JG, @QLLX, @QLXZ, @QLSDFS, @RJL, @JZMD, @JZXG, @ZDSZD, @ZDSZN, @ZDSZX, @ZDSZB, @ZDT, @TFH, @DJH, @DAH, @BZ, @ZT, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_ZDJBXX = "UPDATE ZDJBXX SET YSDM = @YSDM, ZDDM = @ZDDM, BDCDYH = @BDCDYH, ZDTZM = @ZDTZM, ZL = @ZL, ZDMJ = @ZDMJ, MJDW = @MJDW, YT = @YT, DJ = @DJ, JG = @JG, QLLX = @QLLX, QLXZ = @QLXZ, QLSDFS = @QLSDFS, RJL = @RJL, JZMD = @JZMD, JZXG = @JZXG, ZDSZD = @ZDSZD, ZDSZN = @ZDSZN, ZDSZX = @ZDSZX, ZDSZB = @ZDSZB, ZDT = @ZDT, TFH = @TFH, DJH = @DJH, DAH = @DAH, BZ = @BZ, ZT = @ZT, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
	
	    private const string SQL_DELETE_ZDJBXX = "DELETE FROM ZDJBXX WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string ysdm = default(string);
		protected string zddm = default(string);
		protected string bdcdyh = default(string);
		protected string zdtzm = default(string);
		protected string zl = default(string);
		protected double? zdmj = default(double?);
		protected string mjdw = default(string);
		protected string yt = default(string);
		protected string dj = default(string);
		protected double? jg = default(double?);
		protected string qllx = default(string);
		protected string qlxz = default(string);
		protected string qlsdf = default(string);
		protected double? rjl = default(double?);
		protected double? jzmd = default(double?);
		protected double? jzxg = default(double?);
		protected string zdszd = default(string);
		protected string zdszn = default(string);
		protected string zdszx = default(string);
		protected string zdszb = default(string);
		protected byte[] zdt = default(byte[]);
		protected string tfh = default(string);
		protected string djh = default(string);
		protected string dah = default(string);
		protected string bz = default(string);
		protected string zt = default(string);
		protected string wxDcy = default(string);
		protected System.DateTime? wxDcsj = default(System.DateTime?);
		protected string wxCly = default(string);
		protected System.DateTime? wxClsj = default(System.DateTime?);
		protected string wxZty = default(string);
		protected System.DateTime? wxZtsj = default(System.DateTime?);
		protected string wxZjy = default(string);
		protected System.DateTime? wxZjsj = default(System.DateTime?);
		protected System.Guid wxWydm = default(System.Guid);
		protected long? databaseid = default(long?);
		protected short? flag = default(short?);
        protected DbGeometry _geometry;
        protected string _wkt=default(string);
        
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
        public string Ysdm 
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
        public string Zddm 
        {
            get { return this.zddm; }
			set	{ 
                  if(this.zddm != value)
                    {
                        this.OnPropertyChanging("Zddm");  
                        this.zddm = value;                        
                        this.OnPropertyChanged("Zddm");
                    }   
                }
        }	
        public string Bdcdyh 
        {
            get { return this.bdcdyh; }
			set	{ 
                  if(this.bdcdyh != value)
                    {
                        this.OnPropertyChanging("Bdcdyh");  
                        this.bdcdyh = value;                        
                        this.OnPropertyChanged("Bdcdyh");
                    }   
                }
        }	
        public string Zdtzm 
        {
            get { return this.zdtzm; }
			set	{ 
                  if(this.zdtzm != value)
                    {
                        this.OnPropertyChanging("Zdtzm");  
                        this.zdtzm = value;                        
                        this.OnPropertyChanged("Zdtzm");
                    }   
                }
        }	
        public string Zl 
        {
            get { return this.zl; }
			set	{ 
                  if(this.zl != value)
                    {
                        this.OnPropertyChanging("Zl");  
                        this.zl = value;                        
                        this.OnPropertyChanged("Zl");
                    }   
                }
        }	
        public double? Zdmj 
        {
            get { return this.zdmj; }
			set	{ 
                  if(this.zdmj != value)
                    {
                        this.OnPropertyChanging("Zdmj");  
                        this.zdmj = value;                        
                        this.OnPropertyChanged("Zdmj");
                    }   
                }
        }	
        public string Mjdw 
        {
            get { return this.mjdw; }
			set	{ 
                  if(this.mjdw != value)
                    {
                        this.OnPropertyChanging("Mjdw");  
                        this.mjdw = value;                        
                        this.OnPropertyChanged("Mjdw");
                    }   
                }
        }	
        public string Yt 
        {
            get { return this.yt; }
			set	{ 
                  if(this.yt != value)
                    {
                        this.OnPropertyChanging("Yt");  
                        this.yt = value;                        
                        this.OnPropertyChanged("Yt");
                    }   
                }
        }	
        public string Dj 
        {
            get { return this.dj; }
			set	{ 
                  if(this.dj != value)
                    {
                        this.OnPropertyChanging("Dj");  
                        this.dj = value;                        
                        this.OnPropertyChanged("Dj");
                    }   
                }
        }	
        public double? Jg 
        {
            get { return this.jg; }
			set	{ 
                  if(this.jg != value)
                    {
                        this.OnPropertyChanging("Jg");  
                        this.jg = value;                        
                        this.OnPropertyChanged("Jg");
                    }   
                }
        }	
        public string Qllx 
        {
            get { return this.qllx; }
			set	{ 
                  if(this.qllx != value)
                    {
                        this.OnPropertyChanging("Qllx");  
                        this.qllx = value;                        
                        this.OnPropertyChanged("Qllx");
                    }   
                }
        }	
        public string Qlxz 
        {
            get { return this.qlxz; }
			set	{ 
                  if(this.qlxz != value)
                    {
                        this.OnPropertyChanging("Qlxz");  
                        this.qlxz = value;                        
                        this.OnPropertyChanged("Qlxz");
                    }   
                }
        }	
        public string Qlsdfs 
        {
            get { return this.qlsdf; }
			set	{ 
                  if(this.qlsdf != value)
                    {
                        this.OnPropertyChanging("Qlsdfs");  
                        this.qlsdf = value;                        
                        this.OnPropertyChanged("Qlsdfs");
                    }   
                }
        }	
        public double? Rjl 
        {
            get { return this.rjl; }
			set	{ 
                  if(this.rjl != value)
                    {
                        this.OnPropertyChanging("Rjl");  
                        this.rjl = value;                        
                        this.OnPropertyChanged("Rjl");
                    }   
                }
        }	
        public double? Jzmd 
        {
            get { return this.jzmd; }
			set	{ 
                  if(this.jzmd != value)
                    {
                        this.OnPropertyChanging("Jzmd");  
                        this.jzmd = value;                        
                        this.OnPropertyChanged("Jzmd");
                    }   
                }
        }	
        public double? Jzxg 
        {
            get { return this.jzxg; }
			set	{ 
                  if(this.jzxg != value)
                    {
                        this.OnPropertyChanging("Jzxg");  
                        this.jzxg = value;                        
                        this.OnPropertyChanged("Jzxg");
                    }   
                }
        }	
        public string Zdszd 
        {
            get { return this.zdszd; }
			set	{ 
                  if(this.zdszd != value)
                    {
                        this.OnPropertyChanging("Zdszd");  
                        this.zdszd = value;                        
                        this.OnPropertyChanged("Zdszd");
                    }   
                }
        }	
        public string Zdszn 
        {
            get { return this.zdszn; }
			set	{ 
                  if(this.zdszn != value)
                    {
                        this.OnPropertyChanging("Zdszn");  
                        this.zdszn = value;                        
                        this.OnPropertyChanged("Zdszn");
                    }   
                }
        }	
        public string Zdszx 
        {
            get { return this.zdszx; }
			set	{ 
                  if(this.zdszx != value)
                    {
                        this.OnPropertyChanging("Zdszx");  
                        this.zdszx = value;                        
                        this.OnPropertyChanged("Zdszx");
                    }   
                }
        }	
        public string Zdszb 
        {
            get { return this.zdszb; }
			set	{ 
                  if(this.zdszb != value)
                    {
                        this.OnPropertyChanging("Zdszb");  
                        this.zdszb = value;                        
                        this.OnPropertyChanged("Zdszb");
                    }   
                }
        }	
        public byte[] Zdt 
        {
            get { return this.zdt; }
			set	{ 
                  if(this.zdt != value)
                    {
                        this.OnPropertyChanging("Zdt");  
                        this.zdt = value;                        
                        this.OnPropertyChanged("Zdt");
                    }   
                }
        }	
        public string Tfh 
        {
            get { return this.tfh; }
			set	{ 
                  if(this.tfh != value)
                    {
                        this.OnPropertyChanging("Tfh");  
                        this.tfh = value;                        
                        this.OnPropertyChanged("Tfh");
                    }   
                }
        }	
        public string Djh 
        {
            get { return this.djh; }
			set	{ 
                  if(this.djh != value)
                    {
                        this.OnPropertyChanging("Djh");  
                        this.djh = value;                        
                        this.OnPropertyChanged("Djh");
                    }   
                }
        }	
        public string Dah 
        {
            get { return this.dah; }
			set	{ 
                  if(this.dah != value)
                    {
                        this.OnPropertyChanging("Dah");  
                        this.dah = value;                        
                        this.OnPropertyChanged("Dah");
                    }   
                }
        }	
        public string Bz 
        {
            get { return this.bz; }
			set	{ 
                  if(this.bz != value)
                    {
                        this.OnPropertyChanging("Bz");  
                        this.bz = value;                        
                        this.OnPropertyChanged("Bz");
                    }   
                }
        }	
        public string Zt 
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
        public string WxDcy 
        {
            get { return this.wxDcy; }
			set	{ 
                  if(this.wxDcy != value)
                    {
                        this.OnPropertyChanging("WxDcy");  
                        this.wxDcy = value;                        
                        this.OnPropertyChanged("WxDcy");
                    }   
                }
        }	
        public System.DateTime? WxDcsj 
        {
            get { return this.wxDcsj; }
			set	{ 
                  if(this.wxDcsj != value)
                    {
                        this.OnPropertyChanging("WxDcsj");  
                        this.wxDcsj = value;                        
                        this.OnPropertyChanged("WxDcsj");
                    }   
                }
        }	
        public string WxCly 
        {
            get { return this.wxCly; }
			set	{ 
                  if(this.wxCly != value)
                    {
                        this.OnPropertyChanging("WxCly");  
                        this.wxCly = value;                        
                        this.OnPropertyChanged("WxCly");
                    }   
                }
        }	
        public System.DateTime? WxClsj 
        {
            get { return this.wxClsj; }
			set	{ 
                  if(this.wxClsj != value)
                    {
                        this.OnPropertyChanging("WxClsj");  
                        this.wxClsj = value;                        
                        this.OnPropertyChanged("WxClsj");
                    }   
                }
        }	
        public string WxZty 
        {
            get { return this.wxZty; }
			set	{ 
                  if(this.wxZty != value)
                    {
                        this.OnPropertyChanging("WxZty");  
                        this.wxZty = value;                        
                        this.OnPropertyChanged("WxZty");
                    }   
                }
        }	
        public System.DateTime? WxZtsj 
        {
            get { return this.wxZtsj; }
			set	{ 
                  if(this.wxZtsj != value)
                    {
                        this.OnPropertyChanging("WxZtsj");  
                        this.wxZtsj = value;                        
                        this.OnPropertyChanged("WxZtsj");
                    }   
                }
        }	
        public string WxZjy 
        {
            get { return this.wxZjy; }
			set	{ 
                  if(this.wxZjy != value)
                    {
                        this.OnPropertyChanging("WxZjy");  
                        this.wxZjy = value;                        
                        this.OnPropertyChanged("WxZjy");
                    }   
                }
        }	
        public System.DateTime? WxZjsj 
        {
            get { return this.wxZjsj; }
			set	{ 
                  if(this.wxZjsj != value)
                    {
                        this.OnPropertyChanging("WxZjsj");  
                        this.wxZjsj = value;                        
                        this.OnPropertyChanged("WxZjsj");
                    }   
                }
        }	
        public System.Guid WxWydm 
        {
            get { return this.wxWydm; }
			set	{ 
                  if(this.wxWydm != value)
                    {
                        this.OnPropertyChanging("WxWydm");  
                        this.wxWydm = value;                        
                        this.OnPropertyChanged("WxWydm");
                    }   
                }
        }	
        public long? DatabaseID 
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
        public short? Flags 
        {
            get { return this.flag; }
			set	{ 
                  if(this.flag != value)
                    {
                        this.OnPropertyChanging("Flags");  
                        this.flag = value;                        
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
        public DbGeometry Geometry
        {
            get{return _geometry;}
            set{
                this.OnPropertyChanging("Geometry");  
                _geometry=value;
                _wkt=_geometry.AsText();
                this.OnPropertyChanged("Geometry");
                }
        }
        public string Wkt
        {
            get{return _wkt;}
            set{
               this.OnPropertyChanging("Geometry");  
                _wkt=value;
                _geometry=DbGeometry.FromText(_wkt);
                this.OnPropertyChanged("Geometry"); 
            }
        }
        
        
        
        #endregion            
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Zdjbxx record = obj as Zdjbxx;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZDJBXX,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);    				
                 command.Parameters.AddWithValue(PARAM_ZDDM,this.Zddm);    				
                 command.Parameters.AddWithValue(PARAM_BDCDYH,this.Bdcdyh);    				
                 command.Parameters.AddWithValue(PARAM_ZDTZM,this.Zdtzm);    				
                 command.Parameters.AddWithValue(PARAM_ZL,this.Zl);    				
                 command.Parameters.AddWithValue(PARAM_ZDMJ,this.Zdmj);    				
                 command.Parameters.AddWithValue(PARAM_MJDW,this.Mjdw);    				
                 command.Parameters.AddWithValue(PARAM_YT,this.Yt);    				
                 command.Parameters.AddWithValue(PARAM_DJ,this.Dj);    				
                 command.Parameters.AddWithValue(PARAM_JG,this.Jg);    				
                 command.Parameters.AddWithValue(PARAM_QLLX,this.Qllx);    				
                 command.Parameters.AddWithValue(PARAM_QLXZ,this.Qlxz);    				
                 command.Parameters.AddWithValue(PARAM_QLSDFS,this.Qlsdfs);    				
                 command.Parameters.AddWithValue(PARAM_RJL,this.Rjl);    				
                 command.Parameters.AddWithValue(PARAM_JZMD,this.Jzmd);    				
                 command.Parameters.AddWithValue(PARAM_JZXG,this.Jzxg);    				
                 command.Parameters.AddWithValue(PARAM_ZDSZD,this.Zdszd);    				
                 command.Parameters.AddWithValue(PARAM_ZDSZN,this.Zdszn);    				
                 command.Parameters.AddWithValue(PARAM_ZDSZX,this.Zdszx);    				
                 command.Parameters.AddWithValue(PARAM_ZDSZB,this.Zdszb);    				
                 command.Parameters.AddWithValue(PARAM_ZDT,this.Zdt);    				
                 command.Parameters.AddWithValue(PARAM_TFH,this.Tfh);    				
                 command.Parameters.AddWithValue(PARAM_DJH,this.Djh);    				
                 command.Parameters.AddWithValue(PARAM_DAH,this.Dah);    				
                 command.Parameters.AddWithValue(PARAM_BZ,this.Bz);    				
                 command.Parameters.AddWithValue(PARAM_ZT,this.Zt);    				
                 command.Parameters.AddWithValue(PARAM_WX_DCY,this.WxDcy);    				
                 command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_CLY,this.WxCly);    				
                 command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZTY,this.WxZty);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZJY,this.WxZjy);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);    				
                 command.Parameters.AddWithValue(PARAM_DATABASEID,this.DatabaseID);    				
                 command.Parameters.AddWithValue(PARAM_FLAGS,this.Flags);    				
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",srid);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZDJBXX,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);  
				command.Parameters.AddWithValue(PARAM_ZDDM,this.Zddm);  
				command.Parameters.AddWithValue(PARAM_BDCDYH,this.Bdcdyh);  
				command.Parameters.AddWithValue(PARAM_ZDTZM,this.Zdtzm);  
				command.Parameters.AddWithValue(PARAM_ZL,this.Zl);  
				command.Parameters.AddWithValue(PARAM_ZDMJ,this.Zdmj);  
				command.Parameters.AddWithValue(PARAM_MJDW,this.Mjdw);  
				command.Parameters.AddWithValue(PARAM_YT,this.Yt);  
				command.Parameters.AddWithValue(PARAM_DJ,this.Dj);  
				command.Parameters.AddWithValue(PARAM_JG,this.Jg);  
				command.Parameters.AddWithValue(PARAM_QLLX,this.Qllx);  
				command.Parameters.AddWithValue(PARAM_QLXZ,this.Qlxz);  
				command.Parameters.AddWithValue(PARAM_QLSDFS,this.Qlsdfs);  
				command.Parameters.AddWithValue(PARAM_RJL,this.Rjl);  
				command.Parameters.AddWithValue(PARAM_JZMD,this.Jzmd);  
				command.Parameters.AddWithValue(PARAM_JZXG,this.Jzxg);  
				command.Parameters.AddWithValue(PARAM_ZDSZD,this.Zdszd);  
				command.Parameters.AddWithValue(PARAM_ZDSZN,this.Zdszn);  
				command.Parameters.AddWithValue(PARAM_ZDSZX,this.Zdszx);  
				command.Parameters.AddWithValue(PARAM_ZDSZB,this.Zdszb);  
				command.Parameters.AddWithValue(PARAM_ZDT,this.Zdt);  
				command.Parameters.AddWithValue(PARAM_TFH,this.Tfh);  
				command.Parameters.AddWithValue(PARAM_DJH,this.Djh);  
				command.Parameters.AddWithValue(PARAM_DAH,this.Dah);  
				command.Parameters.AddWithValue(PARAM_BZ,this.Bz);  
				command.Parameters.AddWithValue(PARAM_ZT,this.Zt);  
				command.Parameters.AddWithValue(PARAM_WX_DCY,this.WxDcy);  
				command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);  
				command.Parameters.AddWithValue(PARAM_WX_CLY,this.WxCly);  
				command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);  
				command.Parameters.AddWithValue(PARAM_WX_ZTY,this.WxZty);  
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);  
				command.Parameters.AddWithValue(PARAM_WX_ZJY,this.WxZjy);  
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);  
				command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);  
				command.Parameters.AddWithValue(PARAM_DATABASEID,this.DatabaseID);  
				command.Parameters.AddWithValue(PARAM_FLAGS,this.Flags);  
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZDJBXX,connection))
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