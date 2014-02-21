using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements 
//located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 


//Бележка на автора: не съм направил задачата да търси по диагонал. Опитах се всякак, но все още не знам рекурсия и ми отне много време. Като науча рекурсия
//ще си я напиша наново за себе си. Ако искаш ми вземи точки, за това, че не съм изпълнил това условие :) 

class Hahaha
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

    static void Main()
    {
        Console.Write("Height = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Width = ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("[{0}], [{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        int startRow = 0;
        int startCol = 0;
        int currentRow = 0;
        int currentCol = 0;
        bool doContinue = true;
        int currentCounter = 1;
        int maxCounter = 0;
        string currentElement = "";

        while (startCol < matrix.GetLength(1))
        {
            while (currentRow < matrix.GetLength(0) - 1)
            {
                if (matrix[currentRow, currentCol] == matrix[currentRow + 1, currentCol])
                {

                    currentCounter++;
                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                        currentElement = matrix[currentRow, currentCol];
                    }
                }

                else
                {
                    currentCounter = 1;
                }
                currentRow++;
            }
            startCol++;
            startRow = 0;
            currentCol = startCol;
            currentRow = startRow;
            currentCounter = 1;
        }

        startRow = 0;
        startCol = 0;
        currentCol = 0;
        currentRow = 0;

        while (startRow < matrix.GetLength(0))
        {
            while (currentCol < matrix.GetLength(1) - 1)
            {
                if (matrix[currentRow, currentCol] == matrix[currentRow, currentCol + 1])
                {

                    currentCounter++;
                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                        currentElement = matrix[currentRow, currentCol];
                    }
                }

                else
                {
                    currentCounter = 1;
                }
                currentCol++;
            }
            startRow++;
            startCol = 0;
            currentCol = startCol;
            currentRow = startRow;
            currentCounter = 1;
        }

        Console.WriteLine(string.Concat(Enumerable.Repeat(currentElement, maxCounter)));
    }
}

