using System;
using System.Data.Entity.Spatial;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Entity
{
    public abstract class BackFeature : IBackFeature
    {
        internal string _wkt;
        internal DbGeometry _dbgeometry;
        internal IGeometry _geometry;
        private string _simpleLabelString;
        private string _fullLabelString;
        private long _id;
        private string _ysdm = default(string);

        public DbGeometry GetDbGeometry()
        {
            return _dbgeometry;
        }

        public IGeometry Geometry
        {
            get { return _geometry; }
        }

        public IGeometry GetGeometry()
        {
            return _geometry;
        }

        public DbGeometry DbGeometry
        {
            get { return _dbgeometry; }
        }

        public void SetGeometry(DbGeometry geometry)
        {
            _wkt = geometry.AsText();
            _dbgeometry = geometry;
            _geometry = GeometryHelper.CreateGeometryByDbGeometry(_dbgeometry);
        }

        public string Wkt
        {
            get { return _wkt; }
            set
            {
                _wkt = value;
                _dbgeometry = DbGeometry.FromText(_wkt);
                _geometry = GeometryHelper.CreateGeometryByDbGeometry(_dbgeometry);
            }
        }

        public string Ysdm { get { return _ysdm; } set { _ysdm = value; } }
        public long ID { get { return _id; } set { _id = value; } }

        public string TableName { get; set; }

        public string SimpleLabelString
        {
            get { return string.Format("{0} {1} ({2})", TableName, _id, _ysdm); }
        }

        public string FullLabelString
        {
            get { return string.Format("{0} {1} ({2})", TableName, _id, _ysdm); }
        }

        public DateTime? WxDcsj { get; set; }

        public string WxCly { get; set; }

        public DateTime? WxClsj { get; set; }

        public string WxZty { get; set; }

        public DateTime? WxZtsj { get; set; }

        public string WxZjy { get; set; }

        public DateTime? WxZjsj { get; set; }

        public Guid? WxWydm { get; set; }
    }
}