namespace Task05_RemoveNegativeElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that removes from given sequence all negative numbers.
    /// </summary>
    public class Program
    {
        static void Main()
        {
            var sequence = InputSequence();
            sequence.RemoveAll(x => x < 0);
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
