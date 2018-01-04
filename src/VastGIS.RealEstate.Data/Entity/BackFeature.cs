using System;
using System.Data.Entity.Spatial;

namespace VastGIS.RealEstate.Data.Entity
{
    public abstract class BackFeature : IBackFeature
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
                _geometry = DbGeometry.FromText(_wkt);
            }
        }

        public string TableName { get; set; }

        public long ID { get; set; }

        public DateTime? WxDcsj { get; set; }

        public string WxCly { get; set; }

        public DateTime? WxClsj { get; set; }

        public string WxZty { get; set; }

        public DateTime? WxZtsj { get; set; }

        public string WxZjy { get; set; }

        public DateTime? WxZjsj { get; set; }

        public Guid WxWydm { get; set; }
    }
}