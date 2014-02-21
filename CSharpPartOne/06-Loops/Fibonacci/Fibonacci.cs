using System;
using System.Collections.Generic;

//Write a program that reads a number N and calculates the sum of the 
//first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 
//21, 34, 55, 89, 144, 233, 377, …

class Fibonacci
{
    static void Main()
    {
        Console.Write("Sequence length: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum = sum + a;
            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine("Sum: " + sum);
    }
}
