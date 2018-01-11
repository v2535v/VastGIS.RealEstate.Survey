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
    public partial class VgFieldinfo:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "vg_fieldinfo";
        public string ObjectName
        {
         get{
                return "vg_fieldinfo";
               }
        }
        public string EntityName{
            get{
                return "VgFieldinfo";
               }
        }
        public const string LAYER_NAME="";
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
        
        #region 查询
	
	    private const string SQL_INSERT_VG_FIELDINFO = "INSERT INTO vg_fieldinfo (BM, BNSX, ZDZWMC, ZDMC, ZDLX, ZDCD, ZDXSWS, SYZD, YS, SYZDYW) VALUES ( @BM, @BNSX, @ZDZWMC, @ZDMC, @ZDLX, @ZDCD, @ZDXSWS, @SYZD, @YS, @SYZDYW);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_VG_FIELDINFO = "UPDATE vg_fieldinfo SET BM = @BM, BNSX = @BNSX, ZDZWMC = @ZDZWMC, ZDMC = @ZDMC, ZDLX = @ZDLX, ZDCD = @ZDCD, ZDXSWS = @ZDXSWS, SYZD = @SYZD, YS = @YS, SYZDYW = @SYZDYW WHERE Id = @Id";
	
	    private const string SQL_DELETE_VG_FIELDINFO = "DELETE FROM vg_fieldinfo WHERE  Id = @Id ";
        
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string bm = default(string);
		protected long? bnsx = default(long?);
		protected string zdzwmc = default(string);
		protected string zdmc = default(string);
		protected string zdlx = default(string);
		protected long? zdcd = default(long?);
		protected long? zdxsw = default(long?);
		protected string syzd = default(string);
		protected string y = default(string);
		protected string syzdyw = default(string);
        
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
        public string Bm 
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
        public long? Bnsx 
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
        public string Zdzwmc 
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
        public string Zdmc 
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
        public string Zdlx 
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
        public long? Zdcd 
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
        public long? Zdxsws 
        {
            get { return this.zdxsw; }
			set	{ 
                  if(this.zdxsw != value)
                    {
                        this.OnPropertyChanging("Zdxsws");  
                        this.zdxsw = value;                        
                        this.OnPropertyChanged("Zdxsws");
                    }   
                }
        }	
        public string Syzd 
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
        public string Ys 
        {
            get { return this.y; }
			set	{ 
                  if(this.y != value)
                    {
                        this.OnPropertyChanging("Ys");  
                        this.y = value;                        
                        this.OnPropertyChanged("Ys");
                    }   
                }
        }	
        public string Syzdyw 
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
        
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_fieldinfo",this.id);
            }
        }
        
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_fieldinfo",this.id);
            }
        }
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgFieldinfo()
        {
            
            
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
        
        public bool Create(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_FIELDINFO,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_BM,this.Bm); 
                 command.Parameters.AddWithValue(PARAM_BNSX,this.Bnsx); 
                 command.Parameters.AddWithValue(PARAM_ZDZWMC,this.Zdzwmc); 
                 command.Parameters.AddWithValue(PARAM_ZDMC,this.Zdmc); 
                 command.Parameters.AddWithValue(PARAM_ZDLX,this.Zdlx); 
                 command.Parameters.AddWithValue(PARAM_ZDCD,this.Zdcd); 
                 command.Parameters.AddWithValue(PARAM_ZDXSWS,this.Zdxsws); 
                 command.Parameters.AddWithValue(PARAM_SYZD,this.Syzd); 
                 command.Parameters.AddWithValue(PARAM_YS,this.Ys); 
                 command.Parameters.AddWithValue(PARAM_SYZDYW,this.Syzdyw); 
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_FIELDINFO,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID); 
				command.Parameters.AddWithValue(PARAM_BM,this.Bm); 
				command.Parameters.AddWithValue(PARAM_BNSX,this.Bnsx); 
				command.Parameters.AddWithValue(PARAM_ZDZWMC,this.Zdzwmc); 
				command.Parameters.AddWithValue(PARAM_ZDMC,this.Zdmc); 
				command.Parameters.AddWithValue(PARAM_ZDLX,this.Zdlx); 
				command.Parameters.AddWithValue(PARAM_ZDCD,this.Zdcd); 
				command.Parameters.AddWithValue(PARAM_ZDXSWS,this.Zdxsws); 
				command.Parameters.AddWithValue(PARAM_SYZD,this.Syzd); 
				command.Parameters.AddWithValue(PARAM_YS,this.Ys); 
				command.Parameters.AddWithValue(PARAM_SYZDYW,this.Syzdyw); 
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(SQLiteConnection connection)
        {
            if(this.id == default(long))
            {
                return Create(connection);
            }
            else
            {
                return Update(connection);
            }            
        }

		public bool Delete(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_FIELDINFO,connection))
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