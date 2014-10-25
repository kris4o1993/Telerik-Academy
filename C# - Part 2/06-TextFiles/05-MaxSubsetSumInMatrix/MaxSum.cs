using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file containing a square matrix of numbers and 
//finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. Each of the next N 
//lines contain N numbers separated by space. The output should be a single number in a 
//separate text file.

class MaxSum
{
    /// <summary>
    /// Reading matrix from file
    /// </summary>
    /// <returns>Integer matrix from the read-file</returns>
    static int[,] ReadMatrix()
    {
        StreamReader reader = new StreamReader(@"..\..\matrix.txt");
        int[,] matrix;
        using (reader)
        {
            string size = reader.ReadLine();
            int matrixSize = int.Parse(size);

            matrix = new int[matrixSize, matrixSize];

            //filling matrix
            for (int i = 0; i < matrixSize; i++)
            {
                string[] currentRow = reader.ReadLine().Split(' ');

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = int.Parse(currentRow[j]);
                }
            }

            return matrix;
        }
    }

    /// <summary>
    /// Calculating the maximum subset sum of 2x2 area
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>String with the result</returns>
    static string MaxSubsetSum(int[,] matrix)
    {
        int maxSum = int.MinValue;
        int curentSum;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                curentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (curentSum > maxSum)
                {
                    maxSum = curentSum;
                }
            }
        }

        return maxSum.ToString();
    }

    /// <summary>
    /// riting into an external file
    /// </summary>
    /// <param name="output"></param>
    static void OutputInFile(string output)
    {
        StreamWriter writer = new StreamWriter(@"..\..\result.txt", false);
        using(writer)
        {
            writer.WriteLine(output);
        }
    }


    static void Main()
    {
        int[,] matrix = ReadMatrix();
        string maxSubsetSum = MaxSubsetSum(matrix);
        OutputInFile(maxSubsetSum);
    }
}

