namespace HW02_CheckPerformance
{
    using System;
    using System.Linq;

    public class NaturalLog
    {
        public static void LogOfFloats(float number)
        {
            Console.Write("Log(n) of floats:\t");
            Program.DisplayExecutionTime(() =>
            {
                float result = (float)Math.Log(number);
            });
        }

        public static void LogOfDoubles(double number)
        {
            Console.Write("Log(n) of doubles:\t");
            Program.DisplayExecutionTime(() =>
            {
                double result = Math.Log(number);
            });
        }

        public static void LogOfDecimals(decimal number)
        {
            Console.WriteLine("Impossible to do Math.Log(decimalNum)");
        }
    }
}
