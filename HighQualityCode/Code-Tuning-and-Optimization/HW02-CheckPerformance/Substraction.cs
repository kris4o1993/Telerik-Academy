namespace HW02_CheckPerformance
{
    using System;
    using System.Linq;

    public class Substraction
    {
        public static void SubstractionOfIntegers(int firstNumber, int secondNumber)
        {
            Console.Write("Substr. of integers:\t");
            Program.DisplayExecutionTime(() =>
            {
                int result = firstNumber - secondNumber;
            });
        }

        public static void SubstractionOfLongs(long firstNumber, long secondNumber)
        {
            Console.Write("Substr. of longs:\t");
            Program.DisplayExecutionTime(() =>
            {
                long result = firstNumber - secondNumber;
            });
        }

        public static void SubstractionOfFloats(float firstNumber, float secondNumber)
        {
            Console.Write("Substr. of floats:\t");
            Program.DisplayExecutionTime(() =>
            {
                float result = firstNumber - secondNumber;
            });
        }

        public static void SubstractionOfDoubles(double firstNumber, double secondNumber)
        {
            Console.Write("Substr. of doubles:\t");
            Program.DisplayExecutionTime(() =>
            {
                double result = firstNumber - secondNumber;
            });
        }

        public static void SubstractionOfDecimals(decimal firstNumber, decimal secondNumber)
        {
            Console.Write("Substr. of decimals:\t");
            Program.DisplayExecutionTime(() =>
            {
                decimal result = firstNumber - secondNumber;
            });
        }
    }
}
