using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class MathStuff
{
    static void Minimum(int[] array)
    {
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        Console.WriteLine("Minimum: " + min);
    }

    static void Maximum(int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        Console.WriteLine("Maximum: " + max);
    }

    static void Average(int[] array)
    {
        BigInteger sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        BigInteger average = sum / array.Length - 1;
        Console.WriteLine("Average: " + average);
    }

    static void Sum(int[] array)
    {
        decimal sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Sum: " + sum);
    }

    static void Product(int[] array)
    {
        BigInteger product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        Console.WriteLine("Product: " + product);
    }

    static void Main()
    {
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element on position [{0}] : ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Minimum(array);
        Maximum(array);
        Sum(array);
        Acerage(array);

    }
}

