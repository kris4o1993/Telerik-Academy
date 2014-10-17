using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08_FindMajorant
{
    /// <summary>
    /// * The majorant of an array of size N is a value that occurs in it at 
    /// least N/2 + 1 times. Write a program to find the majorant of given array (if exists). 
    /// Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3

    /// </summary>
    public class Program
    {
        static void Main()
        {
            var numbers = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            Dictionary<int, int> occurs = new Dictionary<int, int>();

            foreach (var item in numbers)
            {
                if (!occurs.Keys.Contains(item))
                {
                    occurs.Add(item, 1);
                }
                else
                {
                    occurs[item]++;
                }
            }

            foreach (var item in occurs)
            {
                if (item.Value >= (numbers.Length / 2) + 1)
                {
                    Console.WriteLine("The majorant is {0}", item.Key);
                    break;
                }
            }
        }
    }
}
