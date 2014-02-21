using System;

//* Write a program that reads a positive integer number N (N < 20) from console and 
//outputs in the console the numbers 1 ... N numbers arranged as a spiral.

class Matrix
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] spiralArray = new int[size, size];
        int start = 0;
        int end = size;
        int k = 1;

        while (end - start >= 1)
        {
            for (int p = start; p < end; p++)
            {
                spiralArray[start, p] = k;
                ++k;
            }
            for (int q = start + 1; q < end; q++)
            {
                spiralArray[q, end - 1] = k;
                ++k;
            }
            for (int r = end - 2; r >= start; r--)
            {
                spiralArray[end - 1, r] = k;
                ++k;
            }
            for (int s = end - 2; s >= start + 1; s--)
            {
                spiralArray[s, start] = k;
                ++k;
            }
            start = start + 1;
            end = end - 1;
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (j == size - 1)
                {
                    Console.Write(spiralArray[i, j]);
                }
                else
                {
                    Console.Write(spiralArray[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }

    }
}

