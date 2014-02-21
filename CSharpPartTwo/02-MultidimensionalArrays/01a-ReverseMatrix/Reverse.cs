using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that fills and prints a matrix of size (n, n) 

class Reverse
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" " + matrix[row,col]);
            }
            Console.WriteLine();
        }
        
    }

    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int counter = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++, counter ++)
            {
               matrix[row,col] = counter;
            }
        }

        PrintMatrix(matrix);
    }
}
