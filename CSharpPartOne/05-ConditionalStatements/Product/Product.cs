using System;

//Write a program that shows the sign (+ or -) of the product of three real numbers
//without calculating it. Use a sequence of if statements.

class Product
{
    static void Main()
    {
        Console.WriteLine("Enter the three numbers: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        int countNegative = 0;
        if (firstNumber < 0)
        {
            countNegative++;
        }
        if (secondNumber < 0)
        {
            countNegative++;
        }
        if (thirdNumber < 0)
        {
            countNegative++;
        }
        if (countNegative == 0 || countNegative == 2)
        {
            Console.WriteLine("The product is positive.");
        }
        else
        {
            Console.WriteLine("The product is negative.");
        }
    }
}

