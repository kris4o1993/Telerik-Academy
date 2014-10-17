namespace Task07_RepeatCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that finds in given array of integers (all belonging to the range [0..1000]) 
    /// how many times each of them occurs.
    /// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    /// 2 -> 2 times
    /// 3 -> 4 times
    /// 4 -> 3 times
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
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
                Console.WriteLine("Element {0} occurs {1} times.", item.Key, item.Value);
            }
        }
    }
}
