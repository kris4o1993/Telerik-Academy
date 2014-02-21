using System;

//Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).


class GCD
{
    static void Main()
    {
        Console.Write("Enter A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        int b = int.Parse(Console.ReadLine());

        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }

            else if (b > a)
            {
                b = b - a;
            }
        }

        Console.WriteLine("The GCD is {0}", a);
    }
}

