namespace HW02_CheckPerformance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Addition
    {
        public static void AdditionOfIntegers(int firstNumber, int secondNumber)
        {
            Console.Write("Addition of integers:\t");
            Program.DisplayExecutionTime(() =>
            {
                int result = firstNumber + secondNumber;
            });
        }

        public static void AdditionOfLongs(long firstNumber, long secondNumber)
        {
            Console.Write("Addition of longs:\t");
            Program.DisplayExecutionTime(() =>
            {
                long result = firstNumber + secondNumber;
            });
        }

        public static void AdditionOfFloats(float firstNumber, float secondNumber)
        {
            Console.Write("Addition of floats:\t");
            Program.DisplayExecutionTime(() =>
            {
                float result = firstNumber + secondNumber;
            });
        }

        public static void AdditionOfDoubles(double firstNumber, double secondNumber)
        {
            Console.Write("Addition of doubles:\t");
            Program.DisplayExecutionTime(() =>
            {
                double result = firstNumber + secondNumber;
            });
        }

        public static void AdditionOfDecimals(decimal firstNumber, decimal secondNumber)
        {
            Console.Write("Addition of decimals:\t");
            Program.DisplayExecutionTime(() =>
            {
                decimal result = firstNumber + secondNumber;
            });
        }
    }
}
