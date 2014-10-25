using System;

//Write a program that safely compares floating-point numbers with 
//precision of 0.000001. Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true

class Compare
{
    static void Main()
    {
        //input the two numbers
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        double difference = Math.Abs(firstNumber - secondNumber);

        //checking their equality
        bool isEqual = true;
        if (difference <= 0.000001)
        {
            Console.WriteLine(isEqual);
        }
        else
        {
            Console.WriteLine(!isEqual);
        }

    }
}

