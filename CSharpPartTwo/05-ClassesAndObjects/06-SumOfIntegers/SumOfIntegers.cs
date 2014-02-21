using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//string = "43 68 9 23 318" -> result = 461

class SumOfIntegers
{
    static void Main()
    {
        Console.Write("Enter the integers separated with a space: ");
        string integers = Console.ReadLine();

        string[] arrayOfIntegers = integers.Split(' ');
        int sum = 0;

        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            sum += int.Parse(arrayOfIntegers[i]);
        }

        Console.WriteLine("Sum = " + sum);
    }
}
