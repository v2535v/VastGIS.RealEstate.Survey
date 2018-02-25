﻿using System;
using MapWinGIS;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Shared;

namespace VastGIS.Api.Concrete
{
    public class SpatialReference: ISpatialReference
    {
        private readonly GeoProjection _projection;

        private int _epsgCode = -1;

        public SpatialReference()
        {
            _projection = new GeoProjection();
        }

        internal SpatialReference(GeoProjection projection)
        {
            if (projection == null)
            {
                throw new NullReferenceException("Internal reference is null");
            }
            _projection = projection;
        }

        public string GeogCoordinateSystemName
        {
            get { return _projection.GeogCSName; }
        }

        public bool HasTransformation
        {
            get { return _projection.HasTransformation; }
        }

        public double InverseFlattening
        {
            get { return _projection.InverseFlattening; }
        }

        public bool IsEmpty
        {
            get { return _projection.IsEmpty; }
        }

        public bool IsFrozen
        {
            get { return _projection.IsFrozen; }
        }

        public bool IsGeographic
        {
            get { return _projection.IsGeographic; }
        }

        public bool IsLocal
        {
            get { return _projection.IsLocal; }
        }

        public bool IsProjected
        {
            get { return _projection.IsProjected; }
        }

        public string Name
        {
            get { return _projection.Name; }
        }

        public string ProjectionName
        {
            get { return _projection.ProjectionName; }
        }

        public double SemiMajor
        {
            get { return _projection.SemiMajor; }
        }

        public double SemiMinor
        {
            get { return _projection.SemiMinor; }
        }

        public bool Clear()
        {
            return _projection.Clear();
        }

        public ISpatialReference Clone()
        {
            return new SpatialReference(_projection.Clone());
        }

        public bool CopyFrom(ISpatialReference sourceProj)
        {
            return _projection.CopyFrom(sourceProj.GetInternal());
        }

        public string ExportToProj4()
        {
            return _projection.ExportToProj4();
        }

        public string ExportToWkt()
        {
            return _projection.ExportToWKT();
        }

        public bool GetGeogCoordinateSystemParam(CoordinateSystemParameter name, ref double value)
        {
            return _projection.GeogCSParam[(tkGeogCSParameter) name, value];
        }

        public bool IsSame(ISpatialReference proj)
        {
            return _projection.IsSame[proj.GetInternal()];
        }

        public bool IsSameExt(ISpatialReference proj, IEnvelope bounds, int numSamplingPoints = 8)
        {
            return _projection.IsSameExt[proj.GetInternal(), bounds.GetInternal(), numSamplingPoints];
        }

        public bool GetIsSameGeogCoordinateSystem(ISpatialReference proj)
        {
            return _projection.IsSameGeogCS[proj.GetInternal()];
        }

        public bool GetProjectionParam(ProjectionParameter name, ref double value)
        {
            return _projection.GeogCSParam[(tkGeogCSParameter)name, value];
        }

        public bool ImportFromAutoDetect(string proj)
        {
            return _projection.ImportFromAutoDetect(proj);
        }

        public bool ImportFromEpsg(int projCode)
        {
            _epsgCode = projCode;
            return _projection.ImportFromEPSG(projCode);
        }

        public bool ImportFromEsri(string proj)
        {
            return _projection.ImportFromESRI(proj);
        }

        public bool ImportFromProj4(string proj)
        {
            return _projection.ImportFromProj4(proj);
        }

        public bool ImportFromWkt(string proj)
        {
            return _projection.ImportFromWKT(proj);
        }

        public bool ReadFromFile(string filename)
        {
            return _projection.ReadFromFile(filename);
        }

        public bool SetGoogleMercator()
        {
            _epsgCode = 3857;
            return _projection.SetGoogleMercator();
        }

        public bool SetWgs84()
        {
            _epsgCode = 4326;
            return _projection.SetWgs84();
        }

        public void SetWgs84Projection(Wgs84Projection projection)
        {
            _epsgCode = (int)projection;
            _projection.SetWgs84Projection((tkWgs84Projection)projection);
        }

        public bool StartTransform(ISpatialReference target)
        {
            return _projection.StartTransform(target.GetInternal());
        }

        public void StopTransform()
        {
            _projection.StopTransform();
        }

        public bool Transform(ref double x, ref double y)
        {
            return _projection.Transform(ref x, ref y);
        }

        public bool TryAutoDetectEpsg(out int epsgCode)
        {
            var retVal = _projection.TryAutoDetectEpsg(out epsgCode);
            _epsgCode = epsgCode;
            return retVal;
        }

        public bool WriteToFile(string filename)
        {
            return _projection.WriteToFile(filename);
        }

        public string ExportToEsri()
        {
            return _projection.ExportToEsri();
        }

        public ISpatialReference MorphToEsri()
        {
            string esri = ExportToEsri();
            var proj2 = new SpatialReference();
            return proj2.ImportFromWkt(esri) ? proj2 : null;
        }

        public int GetEpsgCode()
        {
            // Check cached value:
            if (_epsgCode > -1) return _epsgCode;

            // Get new:
            int epsgCode;
            if (!_projection.TryAutoDetectEpsg(out epsgCode))
            {
                // TODO Use dialects to get the GetCoordinateSystem, which has the epsgCode as well
                // See ProjectionMismatchService.HandleEmptyMapProjection()
                return -1;
            }

            _epsgCode = epsgCode;
            return _epsgCode;
        }

        public object InternalObject
        {
            get { return _projection; }
        }

        public string LastError
        {
            get { return _projection.ErrorMsg[_projection.LastErrorCode]; }
        }

        public string Tag
        {
            get { return _projection.Key; }
            set { _projection.Key = value; }
        }

        public override string ToString()
        {
            if (_projection.IsEmpty) return "No projection";
            return _projection.Name;
        }
    }
}
