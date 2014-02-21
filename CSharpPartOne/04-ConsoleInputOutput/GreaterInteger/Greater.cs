using System;

//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

class Greater
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int greater = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number is " + greater);
    }
}
