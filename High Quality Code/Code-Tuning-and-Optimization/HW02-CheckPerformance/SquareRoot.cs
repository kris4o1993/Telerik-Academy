namespace HW02_CheckPerformance
{
    using System;
    using System.Linq;

    public class SquareRoot
    {
        public static void SqrtOfFloats(float number)
        {
            Console.Write("Sqrt of floats:\t\t");
            Program.DisplayExecutionTime(() =>
            {
                float result = (float)Math.Sqrt(number);
            });
        }

        public static void SqrtOfDoubles(double number)
        {
            Console.Write("Sqrt of doubles:\t");
            Program.DisplayExecutionTime(() =>
            {
                double result = Math.Sqrt(number);
            });
        }

        public static void SqrtOfDecimals(decimal number)
        {
            Console.WriteLine("Impossible to do Math.Sqrt(decimalNum)");
        }
    }
}
