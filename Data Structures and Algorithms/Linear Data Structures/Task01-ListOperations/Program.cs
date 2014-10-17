namespace Task01_ListOperations
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a program that reads from the console a sequence of positive integer numbers. 
    /// The sequence ends when empty line is entered. Calculate and print the sum and 
    /// average of the elements of the sequence. Keep the sequence in List<int>.
    /// 
    /// I will not use the available LINQ operations for this. Instead I will do my own 
    /// methods.
    /// </summary>
    public class Program
    {
        static void Main()
        {
            var sequence = InputSequence();

            if (sequence.Count == 0 || sequence == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Console.WriteLine("Sum = " + MathOperations.FindSum(sequence));
                Console.WriteLine("Average = " + MathOperations.FindAverage(sequence));
            }
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
