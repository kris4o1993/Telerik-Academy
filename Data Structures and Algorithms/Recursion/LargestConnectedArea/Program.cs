namespace LargestConnectedArea
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static readonly HashSet<Tuple<int, int>> used = new HashSet<Tuple<int, int>>();
        private static readonly int[] dirRow = { 0, 1, 0, -1 };
        private static readonly int[] dirCol = { 1, 0, -1, 0 };
        private static readonly int[,] matrix = 
            {
                { 1, 3, 2, 2, 2, 4 },
                { 3, 3, 3, 2, 4, 4 },
                { 4, 3, 1, 2, 3, 3 },
                { 4, 3, 1, 3, 3, 1 },
                { 4, 3, 3, 3, 1, 1 }
            };

        public static void Main()
        {
            Tuple<int, int> largestConnectedAreaItem = new Tuple<int, int>(0, 0);
            int maxConnectedCells = -1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!used.Contains(new Tuple<int, int>(row, col)))
                    {
                        int connectedCells = CountAdjacentCells(matrix[row, col], row, col);

                        if (connectedCells > maxConnectedCells)
                        {
                            maxConnectedCells = connectedCells;
                            largestConnectedAreaItem = new Tuple<int, int>(row, col);
                        }
                    }
                }
            }

            int largestConnectedAreaValue = matrix[largestConnectedAreaItem.Item1, largestConnectedAreaItem.Item2];
            PrintMatrix(largestConnectedAreaValue);
        }

        private static int CountAdjacentCells(int value, int row, int col)
        {
            if (!InRange(row, col))
            {
                return 0;
            }

            if (matrix[row, col] != value || used.Contains(new Tuple<int, int>(row, col)))
            {
                return 0;
            }

            used.Add(new Tuple<int, int>(row, col));
            int count = 1;

            for (int dir = 0; dir < dirRow.Length; dir++)
            {
                count += CountAdjacentCells(value, row + dirRow[dir], col + dirCol[dir]);
            }

            return count;
        }

        private static bool InRange(int row, int col)
        {
            bool horizontal = 0 <= row && row < matrix.GetLength(0);
            bool vertical = 0 <= col && col < matrix.GetLength(1);
            return horizontal && vertical;
        }

        private static void PrintMatrix(int n)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == n)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }

                    Console.Write(matrix[row, col]);
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
