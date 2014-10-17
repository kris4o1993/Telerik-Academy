namespace Permutations
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
            GeneratePermutations(new int[N], new bool[N], 0);
            PrintCombinations();
        }

        private static void GeneratePermutations(int[] combination, bool[] used, int currentIndex)
        {
            if (currentIndex == N)
            {
                combinations.Add(combination.ToArray());
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                if (!used[i - 1])
                {
                    combination[currentIndex] = i;
                    used[i - 1] = true;
                    GeneratePermutations(combination, used, currentIndex + 1);
                    used[i - 1] = false;
                }
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
