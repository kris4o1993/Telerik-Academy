using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

namespace _07_SelectionSort
{
    class Sort
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter an integer on position[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int smallest = int.MaxValue;
            int smallestPosition = 0;
            int moveToPosition = 0;
            int temp = 0;

            for (int i = 0; i < n; i++, moveToPosition++)
            {
                for (int j = moveToPosition; j < n; j++)
                {
                    if (array[j] < smallest )
                    {
                        smallest = array[j];
                        smallestPosition = j;
                    }
                }

                temp = array[i];
                array[i] = smallest;
                array[smallestPosition] = temp;
                smallest = int.MaxValue;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
