using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaxSum
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" " + matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static int GetSum(int[,] matrix, int subWidth, int subHeight)
    {
        int maxWidth = matrix.GetLength(0) - subWidth;
        int maxHeight = matrix.GetLength(1) - subHeight;
        int currentSum = 0;
        int maxSum = 0;
        for (int row = 0; row < maxWidth; row++)
        {
            for (int col = 0; col < maxHeight; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] +
                    matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        return maxSum;

    }

    static void Main()
    {
        //Console.Write("N = ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("M = ");
        //int m = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[n, m];

        int[,] matrix = {
            {1, 7, 12, 5},
            {6, 9, 17, 7},
            {5, 10, 19, 9},
            {21, 23, 5, 9},
            {6, 9, 8, 1}
        };

       

        //fill matrix
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.WriteLine("Enter element on position {0},{1}", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        Console.WriteLine("Max sum = " + GetSum(matrix, 3, 3));
    }
}
