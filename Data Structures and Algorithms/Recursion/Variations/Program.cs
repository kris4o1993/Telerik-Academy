namespace Variations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private const int N = 3;
        private const int K = 2;
        private static readonly List<string[]> combinations = new List<string[]>();
        private static readonly string[] set = new string[] { "hi", "a", "b" };

        public static void Main()
        {
            GenerateVariations(new string[K], 0);
            PrintCombinations();
        }

        private static void GenerateVariations(string[] combination, int currentIndex)
        {
            if (currentIndex == K)
            {
                combinations.Add(combination.ToArray());
                return;
            }

            for (int i = 0; i < N; i++)
            {
                combination[currentIndex] = set[i];
                GenerateVariations(combination, currentIndex + 1);
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