using System;

namespace VastGIS.Data.Repository
{
    internal class FileItemMetadata: IItemMetadata
    {
        public FileItemMetadata(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename)) throw new ArgumentNullException("filename");
            Filename = filename;
        }

        public string Filename { get; set; }

        public bool AddedToMap { get; set; }
    }
}
