namespace NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private const int N = 3;
        private static readonly List<int[]> combinations = new List<int[]>();

        public static void Main()
        {
            GenerateCombinations(new int[N], 0);
            PrintCombinations();
        }

        private static void GenerateCombinations(int[] combination, int currentIndex)
        {
            if (currentIndex == N)
            {
                combinations.Add(combination.ToArray());
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                combination[currentIndex] = i;
                GenerateCombinations(combination, currentIndex + 1);
            }
        }

        private static void PrintCombinations()
        {
            foreach (var combination in combinations)
            {
                Console.WriteLine(string.Join(" ", combination));
            }
        }
    }
}
