namespace CombinationsWithDuplicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private const int N = 9;
        private const int K = 2;
        private static readonly List<int[]> combinations = new List<int[]>();

        public static void Main()
        {
            GenerateCombinations(new int[K], 0, 1);
            PrintCombinations();
        }

        private static void GenerateCombinations(int[] combination, int currentIndex, int startNumber)
        {
            if (currentIndex == K)
            {
                combinations.Add(combination.ToArray());
                return;
            }

            for (int i = startNumber; i <= N; i++)
            {
                combination[currentIndex] = i;
                GenerateCombinations(combination, currentIndex + 1, i);
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