﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Shared;

namespace VastGIS.Api.Concrete
{
    [DataContract]
    public class LayerIdentity : CompareByValueBase, IEquatable<LayerIdentity>
    {
        public LayerIdentity(string filename)
        {
            Filename = filename;
            IdentityType = LayerIdentityType.File;
            GeometryType = GeometryType.None;
        }

        public LayerIdentity(string connection, string query)
        {
            Connection = connection;
            Query = query;
            IdentityType = LayerIdentityType.OgrDatasource;
            GeometryType = GeometryType.None;
        }

        public LayerIdentity(string connection, string query, GeometryType geometryType, ZValueType zValue = ZValueType.None)
        {
            Connection = connection;
            Query = query;
            IdentityType = LayerIdentityType.OgrDatasource;
            GeometryType = geometryType;
        }

        public LayerIdentity(WmsSource wms)
        {
            IdentityType = LayerIdentityType.Wms;
            Connection = wms.BaseUrl;
            Query = wms.Layers;
        }

        [DataMember]
        public ZValueType ZValueType { get; set; }

        [DataMember]
        public GeometryType GeometryType { get; set; }

        [DataMember]
        public string Filename { get; set; }
        
        [DataMember]
        public string Connection { get; private set; }

        [DataMember]
        public string Query { get; private set; }

        [DataMember]
        public LayerIdentityType IdentityType { get; private set; }

        /// <summary>
        /// Forces to refresh layer in the repository.
        /// </summary>
        public bool ForceRefresh { get; set; }

        public bool Equals(LayerIdentity other)
        {
            if (IdentityType != other.IdentityType)
            {
                return false;
            }

            switch (IdentityType)
            {
                case LayerIdentityType.File:
                    return Filename.EqualsIgnoreCase(other.Filename);
                case LayerIdentityType.OgrDatasource:
                    return Connection.EqualsIgnoreCase(other.Connection) && 
                            Query.EqualsIgnoreCase(other.Query) && 
                            (GeometryType == other.GeometryType || GeometryType == GeometryType.None || other.GeometryType == GeometryType.None) && 
                            ZValueType == other.ZValueType;
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            var other = obj as LayerIdentity;
            if (other != null)
            {
                return Equals(other);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return IdentityType.GetHashCode();
        }

        public string Serialize()
        {
            return string.Format("OgrConnection|{0}|{1}", Connection, Query);
        }

        public override string ToString()
        {
            switch (IdentityType)
            {
                case LayerIdentityType.File:
                    return Filename;
                case LayerIdentityType.OgrDatasource:
                    return string.Format("{0}: {1}", Connection, Query);
            }

            return "Unknown layer identity type.";
        }
    }
}
