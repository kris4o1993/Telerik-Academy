using System;

//Write a program that finds the greatest of given N variables.

class Program
{
    static void Main()
    {
        Console.Write("Number of variables: ");
        int n = int.Parse(Console.ReadLine());

        double maxNumber = double.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            double currentNumber = double.Parse(Console.ReadLine());
            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
            }
        }
        Console.WriteLine("The biggest number is " + maxNumber);
    }
}

