namespace NQueensPuzle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private const int N = 10;
        private static readonly List<int[]> solutions = new List<int[]>();

        public static void Main()
        {
            SolvePuzzle(new int[N], new int[N, N], 0);

            //foreach (var solution in solutions)
            //{
            //    PrintSolution(solution);
            //}

            Console.WriteLine("Non-unique solutions: " + solutions.Count);
        }
  
        private static void SolvePuzzle(int[] queens, int[,] used, int col)
        {
            if (col == used.GetLength(1))
            {
                solutions.Add(queens.ToArray());
                //PrintSolution(queens);
                return;
            }

            for (int row = 0; row < queens.Length; row++)
            {
                if (used[row, col] == 0)
                {
                    MarkCell(used, row, col, 1);
                    queens[col] = row;
                    SolvePuzzle(queens, used, col + 1);
                    queens[col] = 0;
                    MarkCell(used, row, col, -1);
                }
            }
        }

        private static void MarkCell(int[,] used, int rowPos, int colPos, int value)
        {
            // Mark column and row
            for (int i = 0; i < used.GetLength(0); i++)
            {
                used[i, colPos] += value;
                used[rowPos, i] += value;
            }

            int tempRow = rowPos;
            int tempCol = colPos;

            // Mark up-right diagonal
            while (InBoard(used, --tempRow, ++tempCol))
            {
                used[tempRow, tempCol] += value;
            }

            tempRow = rowPos;
            tempCol = colPos;

            // Mark down-right diagonal
            while (InBoard(used, ++tempRow, ++tempCol))
            {
                used[tempRow, tempCol] += value;
            }
        }

        private static bool InBoard(int[,] board, int row, int col)
        {
            bool horizontal = 0 <= row && row < board.GetLength(0);
            bool vertical = 0 <= col && col < board.GetLength(1);
            return horizontal && vertical;
        }

        private static void PrintSolution(int[] queens)
        {
            bool[,] matrix = new bool[queens.Length, queens.Length];

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[queens[col], col] = true;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("♥");
                    }
                    else
                    {
                        Console.Write("#");
                    }

                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
