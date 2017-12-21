using System;

namespace VastGIS.Api.Events
{
    public class FileDroppedEventArgs: EventArgs
    {
        internal FileDroppedEventArgs(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename)) throw new ArgumentNullException("filename");
            Filename = filename;
        }

        public string Filename { get; private set; }
    }
}
