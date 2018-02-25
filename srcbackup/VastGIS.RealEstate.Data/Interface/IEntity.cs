using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface ISQLiteDao
    {
        int GetSRID();
        SQLiteConnection Connection { get; }
        string CurrentUser { get; set; }
    }
    public interface IEntity
    {
        long ID { get; set; }
        string EntityName { get; }
        string ObjectName { get; }
        String TableName { get; }
        string SimpleLabelString { get; }
        string FullLabelString { get; }
        bool Save(ISQLiteDao dao);
        bool Delete(ISQLiteDao dao);
    }

    public interface IYsdmEntity : IEntity
    {
        string Ysdm { get; set; }
    }
    //表示有可能会和服务器进行交互，所有有两个标记字段
    public interface IDatabaseEntity:IEntity
    {
    
        long? DatabaseID { get; set; }
        short? Flags { get; set; }
        string Xgr { get; set; }
        System.DateTime? Xgsj { get; set; }

    }


    public interface IGlobalEntity : IEntity
    {
        System.Guid? WxWydm { get; set; }
    }
    public interface ISurveyEntity : IGlobalEntity,IYsdmEntity,IDatabaseEntity
    {
        string WxDcy { get; set; }
        System.DateTime? WxDcsj { get; set; }
        string WxCly { get; set; }
        System.DateTime? WxClsj { get; set; }
        string WxZty { get; set; }
        System.DateTime? WxZtsj { get; set; }
        string WxZjy { get; set; }
        System.DateTime? WxZjsj { get; set; }
    }

    public interface IReFeature:IEntity
    {
        //DbGeometry GetDbGeometry();
        //DbGeometry DbGeometry { get; }
       // IGeometry GetGeometry();
        IGeometry Geometry { get; }
       // void SetGeometry(DbGeometry geometry);
       GeometryType GeometryType { get; }
        String Wkt { get; set; }
      
    }
    public interface IDatabaseFeature : IReFeature, IDatabaseEntity, IYsdmEntity
    {
    }

    public interface ISurveyFeature : ISurveyEntity, IReFeature
    {
      
    }
}
