using System.Data.Entity.Spatial;

namespace VastGIS.RealEstate.Data.Entity
{
    public class SearchFeature : Feature
    {
        
    }
    public abstract class Feature : IFeature
    {
        internal string _wkt;
        internal DbGeometry _geometry;

        public DbGeometry GetGeometry()
        {
            return _geometry;
        }

        public DbGeometry Geometry
        {
            get { return _geometry; }
        }

        public void SetGeometry(DbGeometry geometry)
        {
            _wkt = geometry.AsText();
            _geometry = geometry;
        }

        public string Wkt
        {
            get { return _wkt; }
            set
            {
                _wkt = value;
                _geometry=DbGeometry.FromText(_wkt);
            }
        }

        public string TableName { get; set; }
    }
}