using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_CheckPerformance
{
    public class Division
    {
        public static void DivisionOfIntegers(int firstNumber, int secondNumber)
        {
            Console.Write("Division of integers:\t");
            Program.DisplayExecutionTime(() =>
            {
                int result = firstNumber / secondNumber;
            });
        }

        public static void DivisionOfLongs(long firstNumber, long secondNumber)
        {
            Console.Write("Division of longs:\t");
            Program.DisplayExecutionTime(() =>
            {
                long result = firstNumber / secondNumber;
            });
        }

        public static void DivisionOfFloats(float firstNumber, float secondNumber)
        {
            Console.Write("Division of floats:\t");
            Program.DisplayExecutionTime(() =>
            {
                float result = firstNumber / secondNumber;
            });
        }

        public static void DivisionOfDoubles(double firstNumber, double secondNumber)
        {
            Console.Write("Division of doubles:\t");
            Program.DisplayExecutionTime(() =>
            {
                double result = firstNumber / secondNumber;
            });
        }

        public static void DivisionOfDecimals(decimal firstNumber, decimal secondNumber)
        {
            Console.Write("Division of decimals:\t");
            Program.DisplayExecutionTime(() =>
            {
                decimal result = firstNumber / secondNumber;
            });
        }
    }
}
