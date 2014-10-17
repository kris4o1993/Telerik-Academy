using System;

//Write a program that reads 3 integer numbers from the console and prints their sum.

class Sum
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int firstInteger = int.Parse(Console.ReadLine());
        Console.Write("Enter integer: ");
        int secondInteger = int.Parse(Console.ReadLine());
        Console.Write("Enter integer: ");
        int thirdInteger = int.Parse(Console.ReadLine());

        int sum = firstInteger + secondInteger + thirdInteger;
        Console.WriteLine("The sum of the three integers is " + sum);
    }
}

