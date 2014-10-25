using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

namespace _05_MaxIncreasingSequence
{
    class Sequence
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

            string temp = array[0].ToString();
            string maxSequence = array[0].ToString();

            for (int i = 1; i < n; i++)
            {
                if (array[i] == (array[i - 1] + 1))
                {
                    temp += ", " + array[i].ToString();
                    maxSequence = temp;
                }

                else
                {
                    temp = array[i].ToString();
                }
            }
            Console.WriteLine("{ " + maxSequence + " }");
        }
    }
}
