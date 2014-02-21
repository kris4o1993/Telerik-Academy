using System;
using System.Collections.Generic;

//Write a program to print the first 100 members of the sequence 
//of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class Fibonacci
{
    static void Main()
    {
        Console.Write("How many members of the sequence you want to print? ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);
            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}
