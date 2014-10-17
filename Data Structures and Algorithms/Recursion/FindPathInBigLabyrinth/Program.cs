namespace FindPathInBigLabyrinth
{
    using System;

    public class Program
    {
        private const int Size = 20;
        private static readonly int[] dirRow = { 0, 1, 0, -1 };
        private static readonly int[] dirCol = { 1, 0, -1, 0 };
        private static readonly char[,] labyrinth = new char[Size, Size];

        public static void Main()
        {
            int exitRow = Size - 1;
            int exitCol = Size - 1;
            labyrinth[exitRow, exitCol] = 'E';

            FindAllPaths(0, 0);

            Console.WriteLine("Path is not exist!");
        }

        private static void FindAllPaths(int row, int col)
        {
            if (!InRange(row, col) || labyrinth[row, col] == 'o')
            {
                return;
            }

            if (labyrinth[row, col] == 'E')
            {
                PrintPath(labyrinth);
                Console.WriteLine("Path is found!");
                Environment.Exit(0);
            }

            labyrinth[row, col] = 'o';

            for (int dir = 0; dir < dirRow.Length; dir++)
            {
                FindAllPaths(row + dirRow[dir], col + dirCol[dir]);
            }

            labyrinth[row, col] = '\0';
        }

        private static bool InRange(int row, int col)
        {
            bool horizontal = 0 <= row && row < labyrinth.GetLength(0);
            bool vertical = 0 <= col && col < labyrinth.GetLength(1);
            return horizontal && vertical;
        }

        private static void PrintPath(char[,] path)
        {
            for (int row = 0; row < path.GetLength(0); row++)
            {
                for (int col = 0; col < path.GetLength(1); col++)
                {
                    if (path[row, col] == 'o' || path[row, col] == 'E')
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (path[row, col] == '\0')
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write(path[row, col]);                        
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
