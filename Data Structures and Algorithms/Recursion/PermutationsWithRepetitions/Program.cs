namespace PermutationsWithRepetitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static readonly List<int[]> permutations = new List<int[]>();

        public static void Main()
        {
            int[] array = { 22, 23, 32, 23, 32 , 22};
            Permute(array, 0, 3);
            PrintAllPermutations();
            Console.WriteLine("Count of permutations: " + permutations.Count);
        }

        public static void Permute(int[] array, int start, int n)
        {
            permutations.Add(array.ToArray());

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (array[left] != array[right])
                    {
                        Swap(array, left, right);

                        Permute(array, left + 1, n);
                    }
                }

                int element = array[left];
                for (int k = left; k < n - 1; k++)
                {
                    array[k] = array[k + 1];
                }

                array[n - 1] = element;
            }
        }

        private static void Swap(int[] array, int first, int second)
        {
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        private static void PrintAllPermutations()
        {
            foreach (int[] perm in permutations)
            {
                Console.WriteLine(string.Join(" ", perm));
            }

            Console.WriteLine();
        }
    }
}
