namespace AllConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static readonly List<HashSet<Tuple<int, int>>> allAreas = new List<HashSet<Tuple<int, int>>>();
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
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!used.Contains(new Tuple<int, int>(row, col)))
                    {
                        HashSet<Tuple<int, int>> area = new HashSet<Tuple<int, int>>();
                        CountAdjacentCells(area, matrix[row, col], row, col);
                        allAreas.Add(area);
                    }
                }
            }

            foreach (var area in allAreas)
            {
                PrintMatrix(area);
            }
        }

        private static void CountAdjacentCells(HashSet<Tuple<int, int>> area, int value, int row, int col)
        {
            if (!InRange(row, col))
            {
                return;
            }

            if (matrix[row, col] != value || used.Contains(new Tuple<int, int>(row, col)))
            {
                return;
            }

            used.Add(new Tuple<int, int>(row, col));
            area.Add(new Tuple<int, int>(row, col));

            for (int dir = 0; dir < dirRow.Length; dir++)
            {
                CountAdjacentCells(area, value, row + dirRow[dir], col + dirCol[dir]);
            }
        }

        private static bool InRange(int row, int col)
        {
            bool horizontal = 0 <= row && row < matrix.GetLength(0);
            bool vertical = 0 <= col && col < matrix.GetLength(1);
            return horizontal && vertical;
        }

        private static void PrintMatrix(HashSet<Tuple<int, int>> area)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (area.Contains(new Tuple<int, int>(row, col)))
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
