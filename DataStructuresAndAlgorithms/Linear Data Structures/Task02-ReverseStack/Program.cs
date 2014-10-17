namespace Task02_ReverseStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that reads N integers from the console and reverses 
    /// them using a stack. Use the Stack<int> class.
    /// </summary>
    public class Program
    {
        static void Main()
        {
            var sequence = FillStack();
            PrintReversedInput(sequence);
        }

        public static Stack<int> FillStack()
        {
            Stack<int> sequence = new Stack<int>();

            while (true)
            {
                string currentInputRow = Console.ReadLine();

                if (currentInputRow == string.Empty)
                {
                    return sequence;
                }
                else
                {
                    sequence.Push(int.Parse(currentInputRow));
                }
            }
        }

        public static void PrintReversedInput(Stack<int> sequence)
        {
            while (sequence.Count > 0)
            {
                Console.WriteLine(sequence.Pop());
            }
        }
    }
}
