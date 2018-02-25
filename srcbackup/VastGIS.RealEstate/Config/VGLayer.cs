using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using VastGIS.Services.Serialization;
using VastGIS.Shared;

namespace VastGIS.Plugins.RealEstate.Config
{
    public class VGLayer
    {
        private List<VGXmlGroup> _groups;
        private string _xmlFile;

        public VGLayer()
        {
            _groups = new List<VGXmlGroup>();
        }

        public List<VGXmlGroup> Groups
        {
            get { return _groups; }
            set { _groups = value; }
        }

        public string XmlFile
        {
            get { return _xmlFile; }
        }

        public void LoadFromXml(string fileName, string projectPath)
        {
            try
            {
                _groups.Clear();
                _xmlFile = fileName;
                XmlDocument doc = new XmlDocument();
                doc.Load(_xmlFile);

                XmlNodeList nodes = doc.SelectNodes("/VGLayer/Groups/XmlGroup");
                if (nodes != null)
                {
                    foreach (XmlNode node in nodes)
                    {
                        VGXmlGroup xmlGroup = new VGXmlGroup(node, fileName, projectPath);
                        _groups.Add(xmlGroup);
                    }
                }
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }
        }
    }

    public class VGXmlGroup
    {
        private bool _expanded;
        private List<VGXmlLayer> _layers;
        private string _fileName;
        private string _name = "新图层组";
        private int _position = -1;
        private string _projectPath;
        private int _handle;

        public VGXmlGroup()
        {
            _layers = new List<VGXmlLayer>();
        }

        public VGXmlGroup(XmlNode xml, string fileName, string projectPath)
        {
            _projectPath = projectPath;
            _fileName = fileName;
            _layers = new List<VGXmlLayer>();
            ReadFromXml(xml);
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public bool Expanded
        {
            get { return _expanded; }
            set { _expanded = value; }
        }

        public List<VGXmlLayer> Layers
        {
            get { return _layers; }
            set { _layers = value; }
        }

        public int Handle
        {
            get { return _handle; }
            set { _handle = value; }
        }

        public void ReadFromXml(XmlNode xml)
        {
            if (xml == null) return;
            try
            {
                if (xml.Attributes != null) _position = Convert.ToInt32(xml.Attributes["position"].Value);
            }
            catch
            {
                _position = -1;
            }

            XmlNode expendedNode = xml.SelectSingleNode($"/VGLayer/Groups/XmlGroup[@position='{_position}']/Expanded");
            if (expendedNode != null) _expanded = Convert.ToBoolean(expendedNode.InnerText);

            XmlNode nameNode = xml.SelectSingleNode($"/VGLayer/Groups/XmlGroup[@position='{_position}']/Name");
            if (nameNode != null) _name = nameNode.InnerText;

            XmlNodeList nodes = xml.SelectNodes($"/VGLayer/Groups/XmlGroup[@position='{_position}']/Layers/Layer");
            if (nodes != null)
                foreach (XmlNode node in nodes)
                {
                    int position = -1;
                    try
                    {
                        if (node.Attributes != null) position = Convert.ToInt32(node.Attributes["position"].Value);
                    }
                    catch
                    {
                        position = -1;
                    }
                    string name = (node.Attributes?["name"] == null) ? "" : node.Attributes["name"].Value;
                    string fileName = string.Format("{0}\\Layers\\{1}.vglayer", Path.GetDirectoryName(_fileName), name);
                    if (File.Exists(fileName))
                    {
                        VGXmlLayer vgXmlLayer = new VGXmlLayer(fileName, _projectPath);
                        vgXmlLayer.Position = position;
                        vgXmlLayer.Name = name;
                        _layers.Add(vgXmlLayer);
                    }
                }
        }
    }

    public class VGXmlLayer
    {
        private string _name;
        private string _xmlFile;
        private int _position;
        private XmlLayer _xmlLayer;
        private string _projectPath;

        public VGXmlLayer() { }

        public VGXmlLayer(string fileName, string projectPath)
        {
            _xmlFile = fileName;
            _projectPath = projectPath;
            using (var reader = new StreamReader(fileName))
            {
                string content = reader.ReadToEnd();
                content = content.Replace("{ProjectPath}", _projectPath);
                _xmlLayer = content.Deserialize<XmlLayer>();
            }

        }

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public XmlLayer XmlLayer
        {
            get { return _xmlLayer; }
            set { _xmlLayer = value; }
        }

        public string XmlFile
        {
            get { return _xmlFile; }
        }
        public static string FileToString(string filePath, Encoding encoding)
        {
            //创建流读取器  
            StreamReader reader = new StreamReader(filePath, encoding);
            try
            {
                //读取流  
                return reader.ReadToEnd();
            }
            catch
            {
                return string.Empty;
            }
            finally
            {
                //关闭流读取器  
                reader.Close();
            }
        }
    }

}
