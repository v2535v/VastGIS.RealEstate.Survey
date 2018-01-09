using System;
using System.Data.Entity.Spatial;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IFeature
    {
        long ID { get; set; }
        DbGeometry GetDbGeometry();
        DbGeometry DbGeometry { get; }
        IGeometry GetGeometry();
        IGeometry Geometry { get; }
        void SetGeometry(DbGeometry geometry);
        String Wkt { get; set; }
        String TableName { get; set; }
        string Ysdm { get; set; }

        string SimpleLabelString { get; }
        string FullLabelString { get; }

    }

    public interface IBackFeature:IFeature,IBackEntity
    {

    }
}