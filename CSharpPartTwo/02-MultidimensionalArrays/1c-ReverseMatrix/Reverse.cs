using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that fills and prints a matrix of size (n, n) 

class Matrix
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int N = int.Parse(Console.ReadLine());

        int[,] arr = new int[N, N];


        ExamC(arr);
    }

    static void PrintMatrix(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0, -4}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void ExamC(int[,] arr)
    {
        int counter = 1;
        int curLen = arr.GetLength(0) - 1;

        while (curLen >= 0)
        {
            for (int i = curLen; i < arr.GetLength(0); i++)
            {
                arr[i, i - curLen] = counter;
                counter++;
            }

            curLen--;
        }

        curLen = 1;

        while (curLen <= arr.GetLength(0) - 1)
        {
            for (int i = curLen; i < arr.GetLength(0); i++)
            {
                arr[i - curLen, i] = counter;
                counter++;
            }

            curLen++;
        }

        PrintMatrix(arr);
    }
}