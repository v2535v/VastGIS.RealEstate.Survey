﻿using System;
using System.Globalization;
using System.Runtime.Serialization;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.Plugins.Model
{
    [DataContract]
    public class TmsProvider
    {
        public const int MinId = 1000;
        public static Guid DefaultGroupId = new Guid("104229EC-8F3E-4C19-A15B-C871109B61FE");
        public static Guid CustomGroupId = new Guid("6932A104-7644-4964-AEDC-DCCB2E7BB72A");

        public static int GenerateId(string url)
        {
            int value = Math.Abs(url.GetHashCode());
            if (value < MinId)
            {
                value += MinId;
            }

            return value;
        }

        public TmsProvider()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            MinZoom = 0;
            MaxZoom = 17;
            Name = string.Empty;
            Id = -1;
            Projection = TileProjection.SphericalMercator;
            Url = string.Empty;
            Description = string.Empty;
            IsCustom = true;

            Bounds = DefaultBounds;
        }

        public static IEnvelope DefaultBounds
        {
            get
            {
                var box = new Envelope();
                box.SetBounds(-180.0, 180.0, -85.05112878, 85.05112878);
                return box;
            }
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            SetDefaults();
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public TileProjection Projection { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public int MinZoom { get; set; }

        [DataMember]
        public int MaxZoom { get; set; }

        [DataMember]
        public string Description { get; set; }

        public IEnvelope Bounds
        {
            get { return new Envelope(MinX, MaxX, MinY, MaxY); }
            set
            {
                var bounds = value;

                MinX = bounds.MinX;
                MaxX = bounds.MaxX;
                MinY = bounds.MinY;
                MaxY = bounds.MaxY;
            }
        }

        public bool IsCustom { get; set; }

        [DataMember]
        public double MinX { get; set; }

        [DataMember]
        public double MaxX { get; set; }

        [DataMember]
        public double MinY { get; set; }

        [DataMember]
        public double MaxY { get; set; }

        [DataMember]
        public bool UseBounds { get; set; }
    }
}
