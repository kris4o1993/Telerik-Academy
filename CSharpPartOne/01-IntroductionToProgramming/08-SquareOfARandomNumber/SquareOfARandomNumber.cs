using System;

//Create a console application that calculates and prints the square of a number entered by the user.
//This is an extended version of task 8.


class SquareOfARandomNumber
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine());
        int numberOnSquare = number * number;
        Console.WriteLine("Your squared number is " + numberOnSquare);
    }
}
