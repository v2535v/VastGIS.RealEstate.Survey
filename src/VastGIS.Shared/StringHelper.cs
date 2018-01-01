using System;
using System.Collections.Generic;
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
    }
}
