using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this String str)
        {
            StringBuilder sb = new StringBuilder();
            string[] parts = str.Split(" ");
            foreach(string part in parts)
            {
                sb.Append(Capitalize(part));
            }
            return sb.ToString();
        }

        public static string Capitalize(this String str)
        {
            string first = str.ToString().ToUpper();
            return first[0] + str.Substring(1);
        }

        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '\n', '\t' }, 
                StringSplitOptions.RemoveEmptyEntries).Length; 
        }

        public static string Smurf(this string s, string replace)
        {
            return s.Replace(replace, " Smurf ");
        }
    }
}
