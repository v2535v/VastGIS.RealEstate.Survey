using System.Data.SQLite;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IBasemapText
    {
        long ID { get; set; }

        string Wbnr { get; set; }

        string Tc { get; set; }

        string Cassdm { get; set; }

        string Fh { get; set; }

        double? Fhdx { get; set; }

        double? Xzjd { get; set; }

        string Ysdm { get; set; }

        long? DatabaseID { get; set; }

        short? Flags { get; set; }

        IGeometry Geometry { get; set; }

        GeometryType GeometryType { get; set; }

        string Wkt { get; set; }

        bool Create(SQLiteConnection connection,int srid);

        bool Update(SQLiteConnection connection,int srid);

        bool Save(SQLiteConnection connection,int srid);

        bool Delete(SQLiteConnection connection);
    }
}