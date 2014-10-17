using System;

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

class Program
{
    static void Main()
    {
        Console.Write("How many are the integers you want to sum: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n ; i++)
        {
            Console.Write("Enter integer: ");
            int newInteger = int.Parse(Console.ReadLine());
            sum = sum + newInteger;
        }
        Console.WriteLine("The sum is " + sum);
    }
}
