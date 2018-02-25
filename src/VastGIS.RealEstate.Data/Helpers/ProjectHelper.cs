using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.RealEstate.Data.Helpers
{
    public static class ProjectHelper
    {
        public static string GetAttachmentPath(string databaseName)
        {
            string dbPath = Path.GetDirectoryName(databaseName);
            string path = Path.Combine(dbPath, @"..\Attachments");
            return path;
        }

        public static string GetAttachmentFileName(string databaseName)
        {
            string dbPath = Path.GetDirectoryName(databaseName);
            string fileName = "J" + DateTime.Now.ToString("yyyyMMdd HHmmss");
            string path = Path.Combine(dbPath, @"..\Attachments\",fileName);
            return path;
        }
    }
}
