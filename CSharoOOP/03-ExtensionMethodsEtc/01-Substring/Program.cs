using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Substring
{
    class Program
    {
        static void Main()
        {
            var sb = new StringBuilder();
            sb.Append("Keep calm and learn to code");
            sb = sb.Substring(0, 100);
            Console.WriteLine(sb);
        }
    }
}
