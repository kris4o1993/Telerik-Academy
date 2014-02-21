using System;

//Write a program to calculate the Nth Catalan number by given N.

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int nFactorial = 1;
        int twoTimesNFactorial = 1;
        int nFactorialPlusOne = 1;
        for (int i = n; i > 1; i--)
        {
            nFactorial = nFactorial * i;
        }
        for (int i = 2*n; i > 1; i--)
        {
            twoTimesNFactorial = twoTimesNFactorial * i;
        }
        for (int i = n+1; i > 1; i--)
        {
            nFactorialPlusOne = nFactorialPlusOne * i;
        }
        double result = twoTimesNFactorial / (nFactorialPlusOne * nFactorial);
        Console.WriteLine("Result: " + result);
    }
}

