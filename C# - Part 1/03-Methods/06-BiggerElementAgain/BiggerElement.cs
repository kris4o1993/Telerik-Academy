using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.

class Bigger
{
    static int IsBigger(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i;
            }
    
        }
        return -1;
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
        Console.WriteLine("Index: {0}", IsBigger(myArray));
    }
}

