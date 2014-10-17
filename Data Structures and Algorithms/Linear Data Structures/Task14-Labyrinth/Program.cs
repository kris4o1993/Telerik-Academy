namespace Task14_Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// * We are given a labyrinth of size N x N. Some of its cells are empty (0) and some are full (x). 
    /// We can move from an empty cell to another empty cell if they share common wall. Given a starting 
    /// position (*) calculate and fill in the array the minimal distance from this position to any other 
    /// cell in the array. Use "u" for all unreachable cells
    /// </summary>
    class Program
    {
        struct Cell
        {
            public int Row;
            public int Col;
            public int Step;

            public Cell(int cellRow, int cellCol, int step)
            {
                this.Row = cellRow;
                this.Col = cellCol;
                this.Step = step;
            }
        }


        static void Main()
        {

            var labyrinth = Labyrinth();
            int maxRows = labyrinth.GetLength(0);
            int maxCols = labyrinth.GetLength(1);
            Cell cell = new Cell();

            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == "*")
                    {
                        cell.Row = i;
                        cell.Col = j;
                        cell.Step = 0;
                    }
                }
            }

            var frontier = new Queue<Cell>();
            frontier.Enqueue(cell);

            while (frontier.Count > 0)
            {
                var currentCell = frontier.Dequeue();
                labyrinth[currentCell.Row, currentCell.Col] = currentCell.Step.ToString();

                // using 2 nested loop to check the 4 neighbouring cells
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        //we dont want to check the same cell again or to move diaginally
                        if (!(Math.Abs(i) == Math.Abs(j)))
                        {
                            Cell nextCell = new Cell(currentCell.Row + i, currentCell.Col + j, currentCell.Step);
                            bool isNextCellValid = IsValidMove(nextCell, maxRows, maxCols, labyrinth);
                            if (isNextCellValid)
                            {
                                nextCell.Step++;
                                frontier.Enqueue(nextCell);
                            }
                        }
                    }
                }
            }

            //checking for unreachable cells
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == "_")
                    {
                        labyrinth[i, j] = "u";
                    }
                }
            }

            PrintLabyrinthSteps(labyrinth);
        }

        static bool IsValidMove(Cell cell, int maxRows, int maxCols, string[,] labyrinth)
        {
            bool isPassable =
                (cell.Row >= 0 && cell.Row < maxRows) &&
                (cell.Col >= 0 && cell.Col < maxCols) &&
                labyrinth[cell.Row, cell.Col] == "_";

            return isPassable;
        }

        static string[,] Labyrinth()
        {
            string[,] labyrinth =  
                        {
                            { "_", "_", "_", "_", "_", "X" , "X", "_", "X", "_", "X", "_", "_", "_", "_", "X" , "X", "_", "X", },
                            { "_", "X", "_", "X", "_", "_" , "_", "_", "X", "_", "_", "X", "_", "X", "_", "_" , "_", "_", "X", },
                            { "_", "_", "X", "_", "X", "_" , "_", "_", "_", "X", "X", "_", "X", "_", "X", "_" , "_", "_", "_", },
                            { "_", "X", "X", "X", "_", "_" , "_", "X", "X", "_", "_", "X", "X", "X", "_", "_" , "_", "X", "X", },
                            { "_", "X", "X", "X", "_", "_" , "_", "X", "X", "_", "_", "X", "X", "X", "_", "_" , "_", "X", "X", },
                            { "_", "_", "_", "_", "X", "_" , "_", "_", "_", "_", "_", "_", "_", "_", "X", "_" , "_", "_", "_", },
                            { "X", "X", "_", "X", "_", "X" , "X", "_", "X", "_", "X", "X", "_", "X", "_", "X" , "X", "_", "X", },
                            { "_", "X", "X", "X", "_", "_" , "_", "_", "X", "_", "_", "X", "X", "X", "_", "_" , "_", "_", "X", },
                            { "_", "X", "_", "X", "_", "_" , "X", "_", "X", "_", "_", "*", "_", "X", "_", "_" , "X", "_", "X", },
                            { "_", "_", "X", "_", "_", "X" , "X", "_", "_", "_", "X", "_", "X", "_", "_", "X" , "X", "_", "_", },
                            { "_", "_", "_", "_", "_", "X" , "X", "_", "_", "_", "X", "_", "_", "_", "_", "X" , "X", "_", "_", },
                            { "_", "_", "_", "_", "_", "_" , "_", "_", "_", "_", "X", "_", "_", "_", "_", "_" , "_", "_", "_", },
                            { "_", "X", "_", "X", "_", "X" , "X", "_", "X", "_", "X", "X", "_", "X", "_", "X" , "X", "_", "X", },
                            { "_", "X", "X", "X", "_", "_" , "_", "X", "X", "_", "_", "X", "X", "X", "_", "_" , "_", "X", "X", },
                            { "_", "_", "_", "_", "X", "_" , "_", "_", "_", "_", "_", "_", "_", "_", "_", "_" , "_", "_", "_", },
                            { "X", "X", "_", "X", "_", "X" , "X", "_", "X", "_", "X", "X", "_", "X", "_", "X" , "X", "_", "X", },
                            { "_", "X", "X", "X", "_", "_" , "_", "_", "X", "_", "_", "X", "X", "X", "_", "_" , "_", "_", "X", },
                            { "_", "X", "_", "X", "_", "_" , "X", "_", "X", "_", "_", "X", "_", "X", "_", "_" , "X", "_", "X", },
                            { "_", "_", "X", "_", "_", "X" , "X", "_", "_", "_", "X", "_", "X", "_", "_", "X" , "X", "_", "_", },
                            { "_", "_", "_", "_", "_", "X" , "X", "_", "_", "_", "X", "_", "_", "_", "_", "X" , "X", "_", "_", },
                            { "_", "_", "_", "_", "_", "_" , "_", "_", "_", "_", "X", "_", "_", "_", "_", "_" , "_", "_", "_", },
                        };

            return labyrinth;
        }

        static void PrintLabyrinthSteps(string[,] labyrinth)
        {
            int rows = labyrinth.GetLength(0);
            int cols = labyrinth.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (labyrinth[row, col] == "X")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("{0, -3}", labyrinth[row, col]);
                    }
                    else if (labyrinth[row, col] == "u")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("{0, -3}", labyrinth[row, col]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("{0, -3}", labyrinth[row, col]);
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
