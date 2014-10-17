namespace HW02_CheckPerformance
{
    using System;
    using System.Linq;

    public class Sinus
    {
        public static void SinOfFloats(float number)
        {
            Console.Write("Sin(n) of floats:\t");
            Program.DisplayExecutionTime(() =>
            {
                float result = (float)Math.Sin(number);
            });
        }

        public static void SinOfDoubles(double number)
        {
            Console.Write("Sin(n) of doubles:\t");
            Program.DisplayExecutionTime(() =>
            {
                double result = Math.Sin(number);
            });
        }

        public static void SinOfDecimals(decimal number)
        {
            Console.WriteLine("Impossible to do Math.Sin(decimalNum)");
        }
    }
}
