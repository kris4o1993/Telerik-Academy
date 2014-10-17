namespace MineSweeperRefactored
{
    using System;
    using System.Collections.Generic;

    public class MineSweeper
    {        
        public static void Main()
        {
            const int Max = 35;
            string command = string.Empty;
            char[,] playingField = CreatePlayingField();
            char[,] mines = PlantMines();
            int points = 0;
            bool isDead = false;
            List<Player> players = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isNewGame = true;
            bool isWinner = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("COMMANDS:");
                    Console.WriteLine("\"top\" shows the rankings");
                    Console.WriteLine("\"restart\" starts a new game");
                    Console.WriteLine("\"exit\" quits from the game");
                    DrawPlayingFieldBorders(playingField);
                    isNewGame = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= playingField.GetLength(0) && column <= playingField.GetLength(1))
                    {
                        command = "turn";
                    }

                }

                switch (command)
                {
                    case "top":
                        Rank(players);
                        break;
                    case "restart":
                        playingField = CreatePlayingField();
                        mines = PlantMines();
                        DrawPlayingFieldBorders(playingField);
                        isDead = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("===END===");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                TakeTurn(playingField, mines, row, column);
                                points++;
                            }

                            if (Max == points)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                DrawPlayingFieldBorders(playingField);
                            }
                        }
                        else
                        {
                            isDead = true;
                        }

                        break;
                    default:
                        Console.WriteLine(Environment.NewLine + "Error! Invalid command" + Environment.NewLine);
                        break;
                }

                if (isDead)
                {
                    DrawPlayingFieldBorders(mines);
                    Console.Write(Environment.NewLine + "You died :(. You have {0} points. " + "Enter your name: ", points);
                    string playerName = Console.ReadLine();
                    Player player = new Player(playerName, points);
                    if (players.Count < 5)
                    {
                        players.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < player.Points)
                            {
                                players.Insert(i, player);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    players.Sort((Player firstPlayer, Player secondPlayer) =>
                        secondPlayer.Name.CompareTo(firstPlayer.Name));
                    players.Sort((Player firstPlayer, Player secondPlayer) => 
                        secondPlayer.Points.CompareTo(firstPlayer.Points));
                    Rank(players);

                    playingField = CreatePlayingField();
                    mines = PlantMines();
                    points = 0;
                    isDead = false;
                    isNewGame = true;
                }

                if (isWinner)
                {
                    Console.WriteLine(Environment.NewLine + "Congratulations.You succeeded in opening all 35 squares without mines");
                    DrawPlayingFieldBorders(mines);
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Player playeres = new Player(name, points);
                    players.Add(playeres);
                    Rank(players);
                    playingField = CreatePlayingField();
                    mines = PlantMines();
                    points = 0;
                    isWinner = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.Read();
        }

        private static void Rank(List<Player> players)
        {
            Console.WriteLine(Environment.NewLine + "Points:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rankings" + Environment.NewLine);
            }
        }

        private static void TakeTurn(char[,] playingField, char[,] mines, int row, int column)
        {
            char kolkoBombi = CountAdjacentMines(mines, row, column);
            mines[row, column] = kolkoBombi;
            playingField[row, column] = kolkoBombi;
        }

        private static void DrawPlayingFieldBorders(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine(Environment.NewLine + "    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------" + Environment.NewLine);
        }

        private static char[,] CreatePlayingField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] playingField = new char[fieldRows, fieldColumns];
            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldColumns; j++)
                {
                    playingField[i, j] = '?';
                }
            }

            return playingField;
        }

        private static char[,] PlantMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] playingField = new char[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> bombList = new List<int>();
            while (bombList.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!bombList.Contains(asfd))
                {
                    bombList.Add(asfd);
                }
            }

            foreach (int bomb in bombList)
            {
                int column = bomb / columns;
                int row = bomb % columns;
                if (row == 0 && bomb != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playingField[column, row - 1] = '*';
            }

            return playingField;
        }

        private static char CountAdjacentMines(char[,] r, int row, int column)
        {
            int minesCounter = 0;
            int rows = r.GetLength(0);
            int columns = r.GetLength(1);

            if (row - 1 >= 0)
            {
                if (r[row - 1, column] == '*')
                {
                    minesCounter++;
                }
            }

            if (row + 1 < rows)
            {
                if (r[row + 1, column] == '*')
                {
                    minesCounter++;
                }
            }

            if (column - 1 >= 0)
            {
                if (r[row, column - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if (column + 1 < columns)
            {
                if (r[row, column + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (r[row - 1, column - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (r[row - 1, column + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (r[row + 1, column - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (r[row + 1, column + 1] == '*')
                {
                    minesCounter++;
                }
            }

            return char.Parse(minesCounter.ToString());
        }
    }
}
