using System;
using System.Data.Entity.Spatial;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IFeature
    {
        DbGeometry GetGeometry();
        DbGeometry Geometry { get; }
        void SetGeometry(DbGeometry geometry);
        String Wkt { get; set; }
        String TableName { get; set; }

    }

    public interface IBackFeature:IFeature,IBackEntity
    {

    }
}