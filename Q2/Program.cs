using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "123456789";
            Console.WriteLine(s.Left(-1));
        }
    }
    public static class StringExtension
    {
        public static string Left(this string sources, int length)
        {
            if (string.IsNullOrEmpty(sources) || length <= 0) return string.Empty;
            if (sources.Length < length) return sources;
            string result = sources.Substring(0, length);
            return result;
        }
    }
}
