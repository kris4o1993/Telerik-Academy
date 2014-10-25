using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

class Bigger
{
    static bool IsBigger(int[] array, int index)
    {
        if (index <= 0 || index >= array.Length - 1)
        {
            return false;
        }

        else
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element on position [{0}] : ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("What index you want to check: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("The element on position {0} is bigger than it's neighbors: {1}.", index, IsBigger(myArray, index));
    }
}

