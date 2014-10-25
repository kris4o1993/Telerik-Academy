using System;

//Write a program that calculates N!/K! for given N and K (1<K<N).

class Factorial
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int nFactorial = 1;
        int kFactorial = 1;

        for (int i = n; i > 1; i--)
        {
            nFactorial = nFactorial * i;
        }
        for (int i = k; i > 1; i--)
        {
            kFactorial = kFactorial * i;
        }

        double result = nFactorial / kFactorial;
        Console.WriteLine("Result: " + result);
    }
}

