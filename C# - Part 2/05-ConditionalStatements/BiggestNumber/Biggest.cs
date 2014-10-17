using System;

//Write a program that finds the biggest of three integers using nested if statements.

class Biggest
{
    static void Main()
    {
        Console.WriteLine("Enter the three integers: ");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggest = firstNumber;
        if (secondNumber > firstNumber || thirdNumber > firstNumber)
        {
            if (thirdNumber > secondNumber)
            {
                Console.WriteLine("The biggest number is the third integer: {0}.", thirdNumber);
            }
            else
            {
                Console.WriteLine("The biggest number is the second integer: {0}.", secondNumber);
            }
        }
        else
        {
            Console.WriteLine("The biggest number is the first integer: {0}.", firstNumber);
        }
    }
}

