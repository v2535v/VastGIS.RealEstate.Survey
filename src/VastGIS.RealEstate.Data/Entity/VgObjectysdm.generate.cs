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
    public partial class VgObjectysdm:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "vg_objectysdm";
        public string ObjectName
        {
         get{
                return "vg_objectysdm";
               }
        }
        public string EntityName{
            get{
                return "VgObjectysdm";
               }
        }
        public const string LAYER_NAME="";
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
        
        #region 查询
	
	    private const string SQL_INSERT_VG_OBJECTYSDM = "INSERT INTO vg_objectysdm (YSDM, YSMC, XSSX, QSBG, QSFH, SFKJ) VALUES ( @YSDM, @YSMC, @XSSX, @QSBG, @QSFH, @SFKJ);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_VG_OBJECTYSDM = "UPDATE vg_objectysdm SET YSDM = @YSDM, YSMC = @YSMC, XSSX = @XSSX, QSBG = @QSBG, QSFH = @QSFH, SFKJ = @SFKJ WHERE Id = @Id";
	
	    private const string SQL_DELETE_VG_OBJECTYSDM = "DELETE FROM vg_objectysdm WHERE  Id = @Id ";
        
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string ysdm = default(string);
		protected string ysmc = default(string);
		protected long? xssx = default(long?);
		protected string qsbg = default(string);
		protected string qsfh = default(string);
		protected bool sfkj = default(bool);
        
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
        public string Ysmc 
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
        public long? Xssx 
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
        public string Qsbg 
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
        public string Qsfh 
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
        public bool Sfkj 
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
        
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","vg_objectysdm",this.id,this.ysdm);
            }
        }
        
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","vg_objectysdm",this.id,this.ysdm);
            }
        }
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgObjectysdm()
        {
            
            
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
        
        public bool Create(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_OBJECTYSDM,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm); 
                 command.Parameters.AddWithValue(PARAM_YSMC,this.Ysmc); 
                 command.Parameters.AddWithValue(PARAM_XSSX,this.Xssx); 
                 command.Parameters.AddWithValue(PARAM_QSBG,this.Qsbg); 
                 command.Parameters.AddWithValue(PARAM_QSFH,this.Qsfh); 
                 command.Parameters.AddWithValue(PARAM_SFKJ,this.Sfkj); 
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_OBJECTYSDM,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID); 
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm); 
				command.Parameters.AddWithValue(PARAM_YSMC,this.Ysmc); 
				command.Parameters.AddWithValue(PARAM_XSSX,this.Xssx); 
				command.Parameters.AddWithValue(PARAM_QSBG,this.Qsbg); 
				command.Parameters.AddWithValue(PARAM_QSFH,this.Qsfh); 
				command.Parameters.AddWithValue(PARAM_SFKJ,this.Sfkj); 
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_OBJECTYSDM,connection))
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