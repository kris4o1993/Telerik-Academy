using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Creating rocks
struct Rock
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

//Creating the Dwarf
struct Dwarf
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

class JustRocks
{
    //Printing objects pattern
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(c);
    }

    //Printing information pattern
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(str);
    }

    static void Main()
    {
        //Basic game information
        double speed = 300.0;
        int playFieldWidth = 20;
        int livesCount = 5;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 40;

        //Drawing the Dwarf
        Dwarf user = new Dwarf();
        user.x = 5;
        user.y = Console.WindowHeight - 1;
        user.c = 'O';
        user.color = ConsoleColor.Yellow;

        //Drawing rocks
        Random randomGenerator = new Random();
        List<Rock> rocks = new List<Rock>();
        while (true)
        {
            //increasing difficulty over time
            if (speed < 400)
            {
                speed++;
            }
            {
                Rock newRock = new Rock();
                newRock.color = ConsoleColor.Green;
                newRock.x = randomGenerator.Next(0, playFieldWidth);
                newRock.y = 0;
                newRock.c = '@';
                rocks.Add(newRock);
            }

            //Controls
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (user.x - 1 >= 0)
                    {
                        user.x = user.x - 1;
                    }
                }

                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (user.x + 1 < playFieldWidth)
                    {
                        user.x = user.x + 1;
                    }
                }

            }

            //Moving rocks
            List<Rock> newList = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;

                //Collision
                if (newRock.y == user.y && newRock.x == user.x)
                {
                    livesCount--;
                    PrintStringOnPosition(user.x, user.y, "X", ConsoleColor.Red);
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(23, 10, "GAME OVER!!!", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
                
            }
            rocks = newList;
            Console.Clear();
            PrintOnPosition(user.x, user.y, user.c, user.color);
            foreach (Rock rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.c, rock.color);
            }

            //Info
            PrintStringOnPosition(23, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(23, 5, "Rock speed: " + speed, ConsoleColor.White);

            //Game speed
            Thread.Sleep((int)(600-speed));
        }
    }
}

