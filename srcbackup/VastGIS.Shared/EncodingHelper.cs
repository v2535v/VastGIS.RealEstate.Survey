using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

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

        public static string Unicode2String(string source)
        {
            //byte[] utf8bytes = System.Text.Encoding.UTF8.GetBytes(source);
            //byte[] utf8bytes2 = System.Text.Encoding.Convert(System.Text.Encoding.UTF8,System.Text.Encoding.Default, utf8bytes);
            //string newString = System.Text.Encoding.Default.GetString(utf8bytes2);
            //return newString;
            return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase | RegexOptions.Compiled).Replace(
                source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
        }

        public static string String2Unicode(string source)
        {
            byte[] valueBytes2 = System.Text.Encoding.Default.GetBytes(source);
            byte[] gbBytes = System.Text.Encoding.Convert(System.Text.Encoding.Default, System.Text.Encoding.Unicode,
                valueBytes2);
            string gb = System.Text.Encoding.Unicode.GetString(gbBytes);
            return gb;
            //Debug.Print(System.Text.Encoding.Default.EncodingName);
            //Debug.Print(System.Text.Encoding.GetEncoding("CP936").EncodingName);
            //byte[] valueBytes2 = System.Text.Encoding.Default.GetBytes(source);
            //byte[] gbBytes = System.Text.Encoding.Convert(System.Text.Encoding.Default, System.Text.Encoding.GetEncoding("CP936"), valueBytes2);
            //string newValueString2 = System.Text.Encoding.GetEncoding("CP936").GetString(gbBytes);
            //return newValueString2;


            

        }
    }
}