using System;
using System.IO;
using System.Linq;
using VastGIS.RealEstate.Data.Enums;

namespace VastGIS.RealEstate.Data.Helpers
{
    public class FileExtensionHelper
    {
        private static string[] docExtensions = {".DOC", ".DOCX"};
        private static string[] pdfExtensions = { ".PDF" };
        private static string[] xlsExtensions = { ".XLS",".XLSX" };
        private static string[] audioExtensions = { ".aac", ".m4a", ".mp1", ".mp2", ".mp3", ".mpa", ".wav", ".wma" };
        private static string[]zipExtensions = { ".zip", ".rar", ".7z" };
        private static string[] imageExtensions = {
                                                          ".PNG", ".JPG", ".JPEG", ".BMP", ".GIF", ".WMF", ".TIF", ".TIFF" , ".EMF"//etc
                                                      };
        private static string[] videoExtensions = {
                                           ".webm",
                                           ".mkv",
                                           ".flv",
                                           ".vob",
                                           ".ogv",
                                           ".ogg",
                                           ".drc",
                                           ".gif",
                                           ".gifv",
                                           ".mng",
                                           ".avi",
                                           ".mov",
                                           ".qt",
                                           ".wmv",
                                           ".yuv",
                                           ".rm",
                                           ".rmvb",
                                           ".asf",
                                           ".mp4",
                                           ".m4p",
                                           ".m4v",
                                           ".mpg",
                                           ".mp2",
                                           ".mpeg",
                                           ".mpe",
                                           ".mpv",
                                           ".mpg",
                                           ".mpeg",
                                           ".m2v",
                                           ".svi",
                                           ".3gp",
                                           ".3g2",
                                           ".mxf",
                                           ".roq",
                                           ".nsv",
                                           ".flv",
                                           ".f4v",
                                           ".f4p",
                                           ".f4a",
                                           ".f4b"
                                       };
        public static AttachmentFileType GetFileType(string path)
        {
            string ext = Path.GetExtension(path);
            bool retVal= imageExtensions.Contains(ext, StringComparer.CurrentCultureIgnoreCase);
            if(retVal) return AttachmentFileType.Image;

            retVal = videoExtensions.Contains(ext, StringComparer.CurrentCultureIgnoreCase);
            if (retVal) return AttachmentFileType.Video;

            retVal = audioExtensions.Contains(ext, StringComparer.CurrentCultureIgnoreCase);
            if (retVal) return AttachmentFileType.Audio;

            retVal = pdfExtensions.Contains(ext, StringComparer.CurrentCultureIgnoreCase);
            if (retVal) return AttachmentFileType.Pdf;

            retVal = docExtensions.Contains(ext, StringComparer.CurrentCultureIgnoreCase);
            if (retVal) return AttachmentFileType.Docx;

            retVal = xlsExtensions.Contains(ext, StringComparer.CurrentCultureIgnoreCase);
            if (retVal) return AttachmentFileType.Excel;

            retVal = zipExtensions.Contains(ext, StringComparer.CurrentCultureIgnoreCase);
            if (retVal) return AttachmentFileType.Zip;
            return AttachmentFileType.Unknown;

        }
        public static bool IsVideo(string path)
        {
            
            var isVideo = videoExtensions.Contains(Path.GetExtension(path), StringComparer.CurrentCultureIgnoreCase);
            return isVideo;
        }

        public static bool IsImage(string path)
        {
           
            var isImage = imageExtensions.Contains(Path.GetExtension(path), StringComparer.CurrentCultureIgnoreCase);
            return isImage;
        }

    }
}