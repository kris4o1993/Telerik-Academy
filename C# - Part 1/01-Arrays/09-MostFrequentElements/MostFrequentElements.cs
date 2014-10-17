using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

namespace _09_MostFrequentElements
{
    class MostFrequentElements
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

            int currentElement = int.MinValue;
            int counter = 1;
            int maxCounter = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] == array[i])
                    {
                        counter++;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        currentElement = array[i];
                    }

                }
                counter = 0;
            }

            Console.WriteLine("The element {0} is repeated most times: {1}", currentElement, maxCounter);
        }
    }
}
