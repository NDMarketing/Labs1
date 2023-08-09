using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace QACalculator
{
    internal static class Utils
    {
        public static int ToNumber(String s)
        {
            return int.Parse(s);
        }

        public static bool IsNumeric(String str)
        {
            var result = int.TryParse(str, out _);
            return result;
        }

        // Example of a slow method
        public static char ValidSeperator(String s)
        {
            int index = 0;
            while (char.IsDigit(s[index]))
                index++;
            return s[index];
        }
    }
}
