using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.


class RepeatedNumber
{
    static void CheckElement(int[] array, int number)
    {
        Array.Sort(array);
        int bestRepeat = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                bestRepeat++;
            }
        }
        Console.WriteLine("The number {0} is repeated {1} times.", number, bestRepeat);
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
        Console.Write("What number you want to check: ");
        int numCheck = int.Parse(Console.ReadLine());
        CheckElement(myArray, numCheck);
    }
}

