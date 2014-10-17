namespace ColoredRabbits
{
    using System;
    using System.Linq;

    public class Program
    {
        private const int MaxRabbits = 1000000;

        public static void Main()
        {
            int[] rabbits = new int[MaxRabbits + 2];

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                rabbits[currentNumber + 1]++;
            }

            int minRabbits = 0;
            for (int i = 0; i < MaxRabbits; i++)
            {
                if (rabbits[i] == 0)
                {
                    continue;
                }

                if (rabbits[i] <= i)
                {
                    minRabbits += i;
                }
                else
                {
                    minRabbits += (int)Math.Ceiling((double)rabbits[i] / i) * i;
                }
            }

            Console.WriteLine(minRabbits);
        }
    }
}
