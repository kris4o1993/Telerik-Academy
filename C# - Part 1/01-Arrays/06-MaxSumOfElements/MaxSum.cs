using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

namespace _06_MaxSumOfElements
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of elements which should make the maximal sum: ");
            int k = int.Parse(Console.ReadLine());

            int[] myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter an integer on position[{0}]: ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(myArray);
            Array.Reverse(myArray);
            int sum = 0;
            Console.Write("The {0} elements with maximum sum are ", k);
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", myArray[i]);
                sum += myArray[i];
            }
            Console.WriteLine("and their sum is equal to {0}", sum);           
        }
    }
}
