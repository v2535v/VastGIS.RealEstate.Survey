using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace VastGIS.RealEstate.Data.Helpers
{
    public class StringUtil
    {
        private const string string_0 = "Plural-Overrides";

        private readonly static Regex regex_0;

        private readonly static Regex regex_1;

        private readonly static Regex regex_2;

        private readonly static Regex regex_3;

        private readonly static Regex regex_4;

        private readonly static Regex regex_5;

        private readonly static Regex regex_6;

        private readonly static Regex regex_7;

        private readonly static Regex regex_8;

        private readonly static Regex regex_9;

       // private readonly static Dictionary<int, Tuple<DateTime, MapCollection>> dictionary_0;

        static StringUtil()
        {
            StringUtil.regex_0 = new Regex("(?<keep>[^aeiou])y$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            StringUtil.regex_1 = new Regex("(?<keep>[aeiou]y)$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            StringUtil.regex_2 = new Regex("(?<keep>[sxzh])$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            StringUtil.regex_3 = new Regex("(?<keep>[^sxzhy])$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            StringUtil.regex_4 = new Regex("(?<keep>[^aeiou])ies$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            StringUtil.regex_5 = new Regex("(?<keep>[aeiou]y)s$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            StringUtil.regex_6 = new Regex("(?<keep>[sxzh])es$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            StringUtil.regex_7 = new Regex("(?<keep>[^sxzhy])s$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            StringUtil.regex_8 = new Regex("[\\W_]+", RegexOptions.Compiled);
            StringUtil.regex_9 = new Regex("([A-Z][a-z]*)|([0-9]+)", RegexOptions.Compiled);
           // StringUtil.dictionary_0 = new Dictionary<int, Tuple<DateTime, MapCollection>>();
        }

        private StringUtil()
        {
        }

        public static string GetEntityName(string value)
        {
            return ToPascalCase(value);
        }
        public static string ToPascalCase(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }
            bool flag = false;
            bool flag1 = false;
            string str = value;
            for (int i = 0; i < str.Length; i++)
            {
                char chr = str[i];
                if (char.IsUpper(chr))
                {
                    flag = true;
                }
                if (char.IsLower(chr))
                {
                    flag1 = true;
                }
            }
            bool flag2 = (!flag1 ? false : flag);
            string[] strArrays = StringUtil.regex_8.Split(value);
            StringBuilder stringBuilder = new StringBuilder();
            if ((int)strArrays.Length > 1)
            {
                string[] strArrays1 = strArrays;
                for (int j = 0; j < (int)strArrays1.Length; j++)
                {
                    string str1 = strArrays1[j];
                    if (str1.Length <= 1)
                    {
                        stringBuilder.Append(str1.ToUpper());
                    }
                    else
                    {
                        stringBuilder.Append(char.ToUpper(str1[0]));
                        if (!flag2)
                        {
                            stringBuilder.Append(str1.Substring(1).ToLower());
                        }
                        else
                        {
                            stringBuilder.Append(str1.Substring(1));
                        }
                    }
                }
            }
            else if (value.Length <= 1)
            {
                stringBuilder.Append(value.ToUpper());
            }
            else
            {
                stringBuilder.Append(char.ToUpper(value[0]));
                stringBuilder.Append((flag2 ? value.Substring(1) : value.Substring(1).ToLower()));
            }
            return stringBuilder.ToString();
        }

    }
}