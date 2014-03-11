using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string> { "1", "22", "55555", "7777777", "333", "4444", "666666" };

            var longestString =
                from longest in strings
                orderby longest.Length descending
                select longest;

            Console.WriteLine(longestString.ElementAt(0));
        }
    }
}
