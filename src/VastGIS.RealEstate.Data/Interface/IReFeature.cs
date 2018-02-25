using System;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IReFeature:IEntity
    {
        //DbGeometry GetDbGeometry();
        //DbGeometry DbGeometry { get; }
        // IGeometry GetGeometry();
        IGeometry Geometry { get; set; }
        // void SetGeometry(DbGeometry geometry);
        GeometryType GeometryType { get; }
        String Wkt { get; set; }
      
    }
    
}