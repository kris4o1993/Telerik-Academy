namespace Task01_CountOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that counts in a given array of double values the number of occurrences of each value. 
    /// Use Dictionary<TKey,TValue>.
    /// Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
    /// -2.5 -> 2 times
    /// 3 -> 4 times
    /// 4 -> 3 times
    /// </summary>
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            double[] elements = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> occurences = new Dictionary<double, int>();

            foreach (var element in elements)
            {
                if (!occurences.ContainsKey(element))
                {
                    occurences.Add(element, 1);
                }
                else
                {
                    occurences[element]++;
                }
            }

            foreach (var item in occurences)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
