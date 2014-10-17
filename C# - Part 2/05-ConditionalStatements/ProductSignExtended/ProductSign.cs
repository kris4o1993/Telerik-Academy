using System;

//Write a program that shows the sign (+ or -) of the product of N real numbers
//without calculating it.

class Product
{
    static void Main()
    {
        Console.Write("How many numbers will you enter: ");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        int countNegative = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            numbers[i] = double.Parse(Console.ReadLine());
            if (numbers[i] < 0)
            {
                countNegative++;
            }
        }
        if (countNegative % 2 == 0)
        {
            Console.WriteLine("The product is positive.");
        }
        else
        {
            Console.WriteLine("The product is negative.");
        }
        
    }
}

