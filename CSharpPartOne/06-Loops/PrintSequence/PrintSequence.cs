using System;

//Write a program that prints all the numbers from 1 to N.

class PrintSequence
{
    static void Main()
    {
        Console.Write("You will print the numbers from 1 to ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
