namespace AllStringSubsets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private const int K = 2;
        private static readonly List<string[]> combinations = new List<string[]>();
        private static readonly string[] set = new string[] { "test", "rock", "fun" };

        public static void Main()
        {
            GenerateCombinations(new string[K], 0, 0);
            PrintCombinations();
        }

        private static void GenerateCombinations(string[] combination, int currentIndex, int startIndex)
        {
            if (currentIndex == K)
            {
                combinations.Add(combination.ToArray());
                return;
            }

            for (int i = startIndex; i < set.Length; i++)
            {
                combination[currentIndex] = set[i];
                GenerateCombinations(combination, currentIndex + 1, i + 1);
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