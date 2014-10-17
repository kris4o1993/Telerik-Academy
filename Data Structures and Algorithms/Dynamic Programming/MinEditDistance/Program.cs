namespace MinEditDistance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private const double ReplaceCost = 1d;
        private const double DeleteCost = 0.9d;
        private const double InsertCost = 0.8d;
        private static readonly List<Tuple<string, int, string>> operations = new List<Tuple<string, int, string>>();
        private static double[,] matrix;

        public static void Main()
        {
            string firstStr = "developer";
            string secondStr = "enveloped";
            matrix = new double[firstStr.Length + 1, secondStr.Length + 1];

            double med = CalculateMED(firstStr, secondStr);
            AddOperations(firstStr, secondStr);

            // Print operations
            foreach (Tuple<string, int, string> operation in operations)
            {
                Console.WriteLine("{0} ({1}, {2})", operation.Item1, operation.Item2, operation.Item3);
            }

            Console.WriteLine("Total cost: " + med);
        }

        private static double CalculateMED(string firstStr, string secondStr)
        {
            int firstStrLen = firstStr.Length;
            int secondStrLen = secondStr.Length;

            // If second string is empty, med = first.Str.Lenght x Delete
            if (secondStrLen == 0)
            {
                return firstStrLen * DeleteCost;
            }

            // If first string is empty, med = secondStr.Length x Insert
            if (firstStrLen == 0)
            {
                return secondStrLen * InsertCost;
            }

            for (int i = 0; i <= firstStrLen; i++)
            {
                matrix[i, 0] = i * DeleteCost;
            }

            for (int i = 0; i <= secondStrLen; i++)
            {
                matrix[0, i] = i * InsertCost;
            }

            for (int i = 1; i <= firstStrLen; i++)
            {
                for (int j = 1; j <= secondStrLen; j++)
                {
                    double insert = matrix[i, j - 1] + InsertCost;
                    double delete = matrix[i - 1, j] + DeleteCost;
                    double replace = matrix[i - 1, j - 1];

                    if (firstStr[i - 1] != secondStr[j - 1])
                    {
                        // With replace
                        matrix[i, j] = MinOfThree(insert, delete, replace + ReplaceCost);
                    }
                    else
                    {
                        // Without replace
                        matrix[i, j] = MinOfThree(insert, delete, replace);
                    }
                }
            }

            return matrix[firstStrLen, secondStrLen];
        }

        private static double MinOfThree(double a, double b, double c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        private static void AddOperations(string firstStr, string secondStr)
        {
            int fLen = firstStr.Length;
            int sLen = secondStr.Length;

            if (sLen == 0)
            {
                for (sLen = 0; sLen < fLen; sLen++)
                {
                    operations.Add(new Tuple<string, int, string>(
                        "DELETE", sLen, firstStr[fLen - 1].ToString()));
                }
            }
            else if (fLen == 0)
            {
                for (fLen = 0; fLen < sLen; fLen++)
                {
                    operations.Add(new Tuple<string, int, string>(
                        "INSERT", fLen, secondStr[fLen].ToString()));
                } 
            }
            else if (fLen > 0 && sLen > 0)
            {
                if (matrix[fLen, sLen] == matrix[fLen - 1, sLen - 1])
                {
                    AddOperations(firstStr.Substring(0, fLen - 1), secondStr.Substring(0, sLen - 1));
                }
                else if (matrix[fLen, sLen] == matrix[fLen - 1, sLen - 1] + ReplaceCost)
                {
                    AddOperations(firstStr.Substring(0, fLen - 1), secondStr.Substring(0, sLen - 1));
                    operations.Add(new Tuple<string, int, string>(
                        "REPLACE", fLen - 1, string.Format("{0} -> {1}", firstStr[fLen - 1], secondStr[sLen - 1])));
                }
                else if (matrix[fLen, sLen] == matrix[fLen, sLen - 1] + InsertCost)
                {
                    AddOperations(firstStr, secondStr.Substring(0, sLen - 1));
                    operations.Add(new Tuple<string, int, string>(
                        "INSERT", fLen - 1, secondStr[sLen - 1].ToString()));
                }
                else if (matrix[fLen, sLen] == matrix[fLen - 1, sLen] + DeleteCost)
                {
                    AddOperations(firstStr.Substring(0, fLen - 1), secondStr);
                    operations.Add(new Tuple<string, int, string>(
                        "DELETE", fLen - 1, firstStr[fLen - 1].ToString()));
                }
            }
        }
    }
}
