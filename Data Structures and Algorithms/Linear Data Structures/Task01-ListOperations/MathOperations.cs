namespace Task01_ListOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MathOperations
    {
        public static double FindAverage(List<int> sequence)
        {
            int sum = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                sum += sequence[i];
            }

            return sum / sequence.Count;
        }

        public static int FindSum(List<int> sequence)
        {
            int sum = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                sum += sequence[i];
            }

            return sum;
        }
    }
}
