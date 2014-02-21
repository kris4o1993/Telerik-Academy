using System;
using System.Numerics;

//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN


class Sum
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X:");
        int x = int.Parse(Console.ReadLine());

        double numerator = 1;
        double denominator = 1;
        double singleResult = 0;
        double totalResult = 0;

        for (double i = n; i >= 1; i--)
        {
            for (double j = 1; j <= i; j++)
            {
                numerator = numerator * j;
                denominator = denominator * x;
            }
            singleResult = numerator / denominator;
            Console.WriteLine("{0}!/{1}^{0} = {2} / {3} = {4}", i, x, numerator, denominator, singleResult);
            numerator = 1;
            denominator = 1;
            totalResult += singleResult;
        }
        Console.WriteLine("-----------");
        Console.WriteLine("Total Sum: {0}", totalResult + 1);
    }
}

