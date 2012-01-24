using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Dispecerat.Common.Util
{
    static public class RegexBuilder
    {
        public static Regex BuildRegexDiacritice(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new Regex(""); // match anything
            }

            string[] strings = (from c in input
                                select BuildRegexComponent(c)).ToArray();

            return new Regex(@"\b" + string.Join("", strings), RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        }

        private static string BuildRegexComponent(char c)
        {
            switch (c)
            {
                case 'a':
                    return "[aâăá]";
                case 'e':
                    return "[eéè]";
                case 'i':
                    return "[iî]";
                case 'o':
                    return "[oóöőø]";
                case 's':
                    return "[sșş]";
                case 'ș':
                case 'ş':
                    return "[șş]";
                case 't':
                    return "[tțţ]";
                case 'ț':
                case 'ţ':
                    return "[țţ]";
                default:
                    return Regex.Escape(c.ToString());
            }
        }
    }
}
