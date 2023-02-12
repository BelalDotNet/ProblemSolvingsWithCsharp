using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Console
{
    internal class TimeConversion12To24
    {
        public static string timeConversion(string s)
        {
            DateTime Parsed12Format = DateTime.Parse(s);
            string Converted24Format = Parsed12Format.ToString("HH:mm: ss");
            return Converted24Format;
        }
    }
}
