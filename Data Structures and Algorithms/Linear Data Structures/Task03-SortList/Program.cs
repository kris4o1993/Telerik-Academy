namespace Task03_SortList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that reads a sequence of integers (List<int>) ending with 
    /// an empty line and sorts them in an increasing order.
    /// </summary>
    public class Program
    {
        static void Main()
        {
            var sequence = InputSequence();
            sequence.Sort();
            Console.WriteLine(string.Join(", ", sequence));
        }

        public static List<int> InputSequence()
        {
            List<int> input = new List<int>();

            while (true)
            {
                string currentInputRow = Console.ReadLine();

                if (currentInputRow == string.Empty)
                {
                    return input;
                }
                else
                {
                    input.Add(int.Parse(currentInputRow));
                }
            }
        }
    }
}
