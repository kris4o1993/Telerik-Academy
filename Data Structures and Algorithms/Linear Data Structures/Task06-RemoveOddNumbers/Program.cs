namespace Task06_RemoveOddNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that removes from given sequence all numbers that occur odd 
    /// number of times. Example:
    /// {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
    /// </summary>
    public class Program
    {
        static void Main()
        {
            var numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            Dictionary<int, int> occurs = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!occurs.Keys.Contains(numbers[i]))
                {
                    occurs.Add(numbers[i], 1);
                }
                else
                {
                    occurs[numbers[i]]++;
                }
            }

            numbers.RemoveAll(x => occurs[x] % 2 != 0);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
