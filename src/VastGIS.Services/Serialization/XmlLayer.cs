using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using VastGIS.Api;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Services;
using VastGIS.Shared;

namespace VastGIS.Services.Serialization
{
    [DataContract]
    public class XmlLayer
    {
        private IBroadcasterService _broadcaster;

        public bool ProjectStorage
        {
            get { return AppConfig.Instance.SymbolobyStorage == SymbologyStorage.Project; }
        }

        public XmlLayer(ILegendLayer layer, bool selected = false)
        {
            if (ProjectStorage)
            {
                OcxLayer = LayerToXmlElement(layer);
            }
            else
            {
                if (layer.SaveOptions("", true, ""))
                {
                    Logger.Current.Warn("Failed to save layer options: " + layer.Name);
                }
            }

            Identity = layer.Identity;
            Expanded = layer.Expanded;
            HideFromLegend = layer.HideFromLegend;
            ColorSchemeCaption = layer.SymbologyCaption;
            Guid = layer.Guid;
            LayerType = layer.LayerType;
            Name = layer.Name;
            SkipLoading = false;
            Selected = selected;

            SerializeCustomObjects(layer);
        }

        public void RestoreLayer(ILegendLayer layer, IBroadcasterService broadcaster)
        {
            AttributeTable table = null;
            if (layer.FeatureSet != null)
            {
                table = layer.FeatureSet.Table;
                table.UpdateJoin += table_UpdateJoin;
                _broadcaster = broadcaster;
            }

            if (OcxLayer != null)
            {
                layer.Deserialize(OcxLayer.OuterXml);
                layer.Name = layer.Name;// StringHelper.UnicodeToString(layer.Name);
            }
            else
            {
                if (!ProjectStorage)
                {
                    string description = string.Empty;
                    layer.LoadOptions("", ref description);
                }
            }

            if (table != null)
            {
                table.UpdateJoin -= table_UpdateJoin;
                _broadcaster = null;
            }

            RestoreCustomObjects(layer);

            layer.Name = StringHelper.UnicodeToString(Name);
            layer.Expanded = Expanded;
            layer.HideFromLegend = HideFromLegend;
            layer.SymbologyCaption = ColorSchemeCaption;
            layer.Guid = Guid;
        }

        private void table_UpdateJoin(object sender, Api.Events.UpdateJoinEventArgs e)
        {
            if (_broadcaster == null)
            {
                Logger.Current.Warn("No broadcaster attached to UpdateTableJoin event.");
                return;
            }

            _broadcaster.BroadcastEvent(p => p.UpdateTableJoin_, sender, e);
        }

        private void SerializeCustomObjects(ILegendLayer layer)
        {
            CustomObjects = new List<XmlCustomObject>();

            var legendLayer = layer as LegendLayer;
            if (legendLayer == null)
            {
                return;
            }

            foreach (var item in legendLayer.CustomObjects)
            {
                var cob = new XmlCustomObject()
                {
                    Object = item.Value,
                    Guid = item.Key,
                };

                CustomObjects.Add(cob);
            }
        }

        private void RestoreCustomObjects(ILegendLayer layer)
        {
            var legendLayer = layer as LegendLayer;
            if (legendLayer == null)
            {
                return;
            }

            legendLayer.ClearCustomObjects();

            foreach (var cob in CustomObjects)
            {
                legendLayer.RestoreCustomObject(cob.Object, cob.Guid);
            }
        }

        private XmlElement LayerToXmlElement(ILegendLayer layer)
        {
            string layName = StringHelper.StringToUnicode(layer.Name);
            layer.Name = layName;
            string xml = layer.Serialize();
            layer.Name = StringHelper.UnicodeToString(layName);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            return doc.DocumentElement;
        }

        [DataMember]
        public List<XmlCustomObject> CustomObjects { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Guid Guid { get; set; }
        [DataMember]
        public bool Expanded { get; set; }
        [DataMember]
        public bool HideFromLegend { get; set; }
        [DataMember]
        public string ColorSchemeCaption { get; set; }
        [DataMember]
        public XmlElement OcxLayer { get; set; }
        [DataMember]
        public LayerIdentity Identity { get; set; }
        [DataMember]
        public LayerType LayerType { get; set; }
        [DataMember]
        public bool Selected { get; set; }

        public bool SkipLoading { get; set; }
    }
}
