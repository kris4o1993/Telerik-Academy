namespace SumOfSubsets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static readonly List<int[]> combinations = new List<int[]>();
        private static int[] array;
        private static int n;
        private static int k;

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] nAndKValues = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                n = short.Parse(nAndKValues[0]);
                k = short.Parse(nAndKValues[1]);
                array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

                Generate(new int[k], 0, 0);

                int sum = 0;
                foreach (var num in combinations)
                {
                    for (int z = 0; z < num.Length; z++)
                    {
                        sum += num[z];
                    }
                }

                Console.WriteLine(sum);
                combinations.Clear();
            }
        }

        private static void Generate(int[] num, int index, int start)
        {
            if (index == k)
            {
                combinations.Add(num.ToArray());
                return;
            }

            for (int i = start; i < n; i++)
            {
                num[index] = array[i];
                Generate(num, index + 1, i + 1);
            }
        }
    }
}