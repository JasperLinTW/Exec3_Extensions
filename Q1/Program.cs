using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 90;
            Console.WriteLine(x.IsEven());
            Console.WriteLine(x.IsODD());
        }
    }
    public static class IntExtensions
    {
        public static bool IsODD(this int num)
        {
            return num % 2 == 1;
        }
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
    }
}
