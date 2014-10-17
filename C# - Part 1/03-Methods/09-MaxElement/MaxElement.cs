using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxElement
{
    static void PrintMax(int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine("Biggest element is {0}.", max);
    }

    static void Ascending(int[] array)
    {
        Array.Sort(array);
        Console.WriteLine(String.Join(", ", array));
    }

    static void Descending(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine(String.Join(", ", array));
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

        Console.Write("Enter start index: ");
        int startIndex = int.Parse(Console.ReadLine());
        Console.Write("Enter end index: ");
        int endIndex = int.Parse(Console.ReadLine());

        int[] newArray = new int[endIndex - startIndex + 1];

        for (int i = startIndex, j = 0; i <= endIndex; i++, j++)
        {
            newArray[j] = myArray[i];
        }

        PrintMax(newArray);
        Ascending(newArray);
        Descending(newArray);

    }
}

