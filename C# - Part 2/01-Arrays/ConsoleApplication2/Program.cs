/* Write a program that finds the maximal sequence of equal elements in an array.
                Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
*/


using System;
using System.Linq;
class MaximalSequence
{
    static void Main()
    {
        Console.Write("Write how many elements you want to have the Array: ");
        int elementCount = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] array = new int[elementCount];

        for (int i = 0; i < elementCount; i++)
        {
            Console.Write("Put a number: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        int start = 0;
        int len = 0;
        int bestLen = 0;
        bool change = false;

        for (int i = 0; i < array.Length; i++)
        {
            for (int p = i + 1; p < array.Length; p++)
            {
                if (array[i] == array[p])
                {
                    len++;
                }

                else
                {
                    change = true;
                }

                if (len > bestLen)
                {
                    bestLen = len;
                    start = i;
                }

                if (change)
                {
                    i += len;
                    len = 0;
                    change = false;
                    break;
                }
            }
            len = 0;
        }

        Console.Write("Maximal sequence is: ");

        for (int i = start; i <= start + bestLen; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}