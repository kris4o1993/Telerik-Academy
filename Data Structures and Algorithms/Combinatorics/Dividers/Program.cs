namespace Dividers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static readonly List<int[]> combinations = new List<int[]>();
        private static int[] array;
        private static bool[] used;

        public static void Main()
        {
            // Read input
            int n = int.Parse(Console.ReadLine());
            array = new int[n];
            used = new bool[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            // Generate combinations
            Generate(new int[array.Length], 0);

            // Join combinations arrays to numbers
            int[] numbers = new int[combinations.Count];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(string.Join("", combinations[i]));
            }

            // Find result
            int min = int.MaxValue;
            int best = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = 0;
                for (int j = 2; j < numbers[i] / 2 + 1; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        current++;
                    }
                }

                if (current < min)
                {
                    min = current;
                    best = i;
                }
                else if (current == min)
                {
                    if (numbers[i] < numbers[best])
                    {
                        best = i;
                    }
                }
            }

            // Output
            Console.WriteLine(numbers[best]);
        }

        private static void Generate(int[] num, int index)
        {
            if (index == num.Length)
            {
                combinations.Add(num.ToArray());
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    num[index] = array[i];
                    Generate(num, index + 1);
                    used[i] = false;
                }
            }
        }
    }
}