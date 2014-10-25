using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

class SubsetSum
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] myArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter an integer on position[{0}]: ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter desired sum: ");
        int desiredSum = int.Parse(Console.ReadLine());

        int currentSum = 0;
        int maxSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        List<int> combination = new List<int>();


        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                currentSum += myArray[j];
                if (currentSum == desiredSum)
                {
                    startIndex = i;
                    endIndex = j;
                    for (int k = startIndex; k <= endIndex; k++)
                    {
                        combination.Add(myArray[k]);
                    }
                    Console.WriteLine("A sequence with the sum {0} exist in the scope:", desiredSum);
                    Console.WriteLine(String.Join(", ", combination));
                    combination.Clear();
                    currentSum = 0;
                    break;
                }
            }
            currentSum = 0;
        }
    }
}

