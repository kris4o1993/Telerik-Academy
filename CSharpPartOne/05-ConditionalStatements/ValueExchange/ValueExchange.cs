using System;

//Write an if statement that examines two integer variables and exchanges 
//their values if the first one is greater than the second one.

class ValueExchange
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int second = int.Parse(Console.ReadLine());

        if (second > first)
        {
            Console.WriteLine("The second integer is greater than the first one.");
        }

        else if (second == first)
        {
            Console.WriteLine("The two integers are equal.");
        }
        else
        {
            Console.WriteLine("The first integer is bigger. \nExchanging values now... \nStand by...");
            int third = first;
            first = second;
            second = third;
            Console.WriteLine("First integer: {0} \nSecond integer: {1}", first, second);
        }
    }
}

