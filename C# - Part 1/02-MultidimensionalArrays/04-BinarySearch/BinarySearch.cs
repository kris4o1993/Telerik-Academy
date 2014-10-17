using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the 
//method Array.BinSearch() finds the largest number in the array which is ≤ K. 

class BinarySearch
{
    static void Main()
    {
        Console.Write("Array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element on position [{0}] = ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);
        int index = Array.BinarySearch(array, k);
        if (k < array[0])
        {
            Console.WriteLine("No such element exist.");
        }
        else
        {
            while ( index < array[0])
            {
                k--;
            }
            Console.WriteLine("Closest number to k is {0} on index {1}.", array[index], index);
        }
    }
}

