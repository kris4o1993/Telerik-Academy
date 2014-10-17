namespace AllPathsInLabyrint
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static readonly List<char[,]> allPaths = new List<char[,]>();
        private static readonly int[] dirRow = { 0, 1, 0, -1 };
        private static readonly int[] dirCol = { 1, 0, -1, 0 };
        private static readonly char[,] labyrinth = 
            {
                { '-', '-', '-', '#', '-', '-', '-' },
                { '#', '#', '-', '#', '-', '#', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '#', '#', '#', '#', '#', '-' },
                { '-', '-', '-', '-', '-', '-', 'E' },
            };

        public static void Main()
        {
            FindAllPaths(0, 0);
            PrintAllPaths();
        }

        private static void FindAllPaths(int row, int col)
        {
            if (!InRange(row, col) || labyrinth[row, col] == '#' || labyrinth[row, col] == 'o')
            {
                return;
            }

            if (labyrinth[row, col] == 'E')
            {
                char[,] path = (char[,])labyrinth.Clone();
                allPaths.Add(path);
                return;
            }

            labyrinth[row, col] = 'o';

            for (int dir = 0; dir < dirRow.Length; dir++)
            {
                FindAllPaths(row + dirRow[dir], col + dirCol[dir]);
            }

            labyrinth[row, col] = '-';          
        }

        private static bool InRange(int row, int col)
        {
            bool horizontal = 0 <= row && row < labyrinth.GetLength(0);
            bool vertical = 0 <= col && col < labyrinth.GetLength(1);
            return horizontal && vertical;
        }

        private static void PrintAllPaths()
        {
            foreach (var path in allPaths)
            {
                for (int row = 0; row < path.GetLength(0); row++)
                {
                    for (int col = 0; col < path.GetLength(1); col++)
                    {
                        if (path[row, col] == 'o' || path[row, col] == 'E')
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }

                        Console.Write(path[row, col]);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
