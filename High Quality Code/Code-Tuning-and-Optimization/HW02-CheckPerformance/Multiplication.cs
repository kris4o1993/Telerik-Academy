namespace HW02_CheckPerformance
{
    using System;
    using System.Linq;

    public class Multiplication
    {
        public static void MultiplicationOfIntegers(int firstNumber, int secondNumber)
        {
            Console.Write("Multipl. of integers:\t");
            Program.DisplayExecutionTime(() =>
            {
                int result = firstNumber * secondNumber;
            });
        }

        public static void MultiplicationOfLongs(long firstNumber, long secondNumber)
        {
            Console.Write("Multipl. of longs:\t");
            Program.DisplayExecutionTime(() =>
            {
                long result = firstNumber * secondNumber;
            });
        }

        public static void MultiplicationOfFloats(float firstNumber, float secondNumber)
        {
            Console.Write("Multipl. of floats:\t");
            Program.DisplayExecutionTime(() =>
            {
                float result = firstNumber * secondNumber;
            });
        }

        public static void MultiplicationOfDoubles(double firstNumber, double secondNumber)
        {
            Console.Write("Multipl. of doubles:\t");
            Program.DisplayExecutionTime(() =>
            {
                double result = firstNumber * secondNumber;
            });
        }

        public static void MultiplicationOfDecimals(decimal firstNumber, decimal secondNumber)
        {
            Console.Write("Multipl. of decimals:\t");
            Program.DisplayExecutionTime(() =>
            {
                decimal result = firstNumber * secondNumber;
            });
        }
    }
}