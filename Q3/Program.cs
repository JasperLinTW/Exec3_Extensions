using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "20";
            Console.WriteLine(value.ToInt(-1));
        }
    }
    public static class StringExtension
    {
        public static int ToInt(this string value, int defaultValue)
        {
            bool isInt = int.TryParse(value, out int result);
            return isInt ? result : defaultValue;
        }
    }
}
