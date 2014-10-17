using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

namespace _04_MaxSequence
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

            int max = 1;
            int counter = 1;
            int maxSequenceMember = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] == array[i - 1])
                {
                    counter++;

                    if (counter > max)
                    {
                        max = counter;
                        maxSequenceMember = array[i];
                    }
                }
                else 
                {
                    counter = 1;
                }
            }

            Console.WriteLine("{ " + string.Concat(Enumerable.Repeat(maxSequenceMember + " ", max)) + "}");

        }
    }
}
