using System;

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix 

class Matrix
{
    static void Main()
    {
        Console.Write("Input N (must be < 20): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n,n];

        for (int row = 1; row <= n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(row + col);
            }
            Console.WriteLine();
        }
    }
}
