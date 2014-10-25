using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that allocates array of 20 integers and initializes each element 
//by its index multiplied by 5. Print the obtained array on the console.

namespace _01_ElementsMultiplied
{
    class MultiplyArrayElements
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
                Console.WriteLine("{0} * 5 = {1}", array[i], array[i] * 5);
            }
        }
    }
}
