using System;
using System.Text;

namespace VastGIS.Shared
{
    public static class EncodingHelper
    {
        public static String ConvertCadCodePage(string cadCode)
        {
            if (cadCode == "ANSI_936")
            {
                Encoding encoding = System.Text.Encoding.GetEncoding(936);
                return encoding.BodyName;
            }
            try
            {
                Encoding encoding = System.Text.Encoding.GetEncoding(cadCode);
                if (encoding != null) return encoding.BodyName;
                return "";
            }
            catch (Exception exception)
            {
                return "";
            }
        }
    }
}