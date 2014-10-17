using System;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

class HarderFactorial
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int nFactorial = 1;
        int kFactorial = 1;
        int znamenatel = 1;

        for (int i = n; i > 1; i--)
        {
            nFactorial = nFactorial * i;
        }
        for (int i = k; i > 1; i--)
        {
            kFactorial = kFactorial * i;
        }
        for (int i = k-n; i > 1; i--)
        {
            znamenatel = znamenatel * i;
        }

        int chislitel = nFactorial * kFactorial;
        double result = chislitel / znamenatel;
        Console.WriteLine("Result: " + result);
    }
}

