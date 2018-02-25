using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace VastGIS.Shared
{
    public static class StringHelper
    {
        public static bool EqualsIgnoreCase(this string s1, string s2)
        {
            return string.Equals(s1, s2, StringComparison.OrdinalIgnoreCase);
        }

        public static bool ContainsIgnoreCase(this string s1, string s2)
        {
            return s1.ToLower().Contains(s2.ToLower());
        }

        public static bool StartsWithIgnoreCase(this string s1, string s2)
        {
            return s1.ToLower().StartsWith(s2.ToLower());
        }

        // just as a memo, for not forgeting it
        public static string Join(IEnumerable<string> list, string separator)
        {
            return String.Join(separator, list.ToArray());
        }

        public static string Fill(string pattern, int count)
        {
            return Enumerable.Range(0, count).Aggregate(string.Empty, (current, item) => current + pattern);
        }

        public  static string StringToUtf8(string str,string fromEncoding="CP936")
        {
            Encoding utf8;
            Encoding cp936;
            utf8 = Encoding.GetEncoding("UTF-8");
            cp936 = System.Text.Encoding.GetEncoding(fromEncoding);
            byte[] gb = System.Text.Encoding.Default.GetBytes(str);
            byte[]  gb2 = Encoding.Convert(cp936, utf8, gb);
            return utf8.GetString(gb2);
        }
        /// 字符串转Unicode  
        /// </summary>  
        /// <param name="source">源字符串</param>  
        /// <returns>Unicode编码后的字符串</returns>  
        public static string String2Unicode(string source)
        {
            
            var bytes = Encoding.Unicode.GetBytes(source);
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < bytes.Length; i += 2)
            {
                stringBuilder.AppendFormat("\\u{0:x2}{1:x2}", bytes[i + 1], bytes[i]);
            }
            return stringBuilder.ToString();
        }

        /// <summary>    
        /// 字符串转为UniCode码字符串    
        /// </summary>    
        /// <param name="s"></param>    
        /// <returns></returns>    
        public static string StringToUnicode(string s)
        {
            char[] charbuffers = s.ToCharArray();
            byte[] buffer;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < charbuffers.Length; i++)
            {
                buffer = System.Text.Encoding.Unicode.GetBytes(charbuffers[i].ToString());
                sb.Append(String.Format("\\u{0:X2}{1:X2}", buffer[1], buffer[0]));
            }
            return sb.ToString();
        }
        /// <summary>    
        /// Unicode字符串转为正常字符串    
        /// </summary>    
        /// <param name="srcText"></param>    
        /// <returns></returns>    
        public static string UnicodeToString(string srcText)
        {
            string dst = "";
            string src = srcText;
            int len = srcText.Length / 6;
            for (int i = 0; i <= len - 1; i++)
            {
                string str = "";
                str = src.Substring(0, 6).Substring(2);
                src = src.Substring(6);
                byte[] bytes = new byte[2];
                bytes[1] = byte.Parse(int.Parse(str.Substring(0, 2), System.Globalization.NumberStyles.HexNumber).ToString());
                bytes[0] = byte.Parse(int.Parse(str.Substring(2, 2), System.Globalization.NumberStyles.HexNumber).ToString());
                dst += Encoding.Unicode.GetString(bytes);
            }
            return dst;
        }
    }
}
