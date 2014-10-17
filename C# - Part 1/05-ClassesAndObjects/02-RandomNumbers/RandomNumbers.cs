using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].


class RandomNumber
{
    static void Main(string[] args)
    {
        Random numbers = new Random();
        for (int number = 1; number <= 10; number++)
        {
            int randomNumber = numbers.Next(100, 200);
            Console.Write("{0} ", randomNumber);
        }
        Console.WriteLine();

    }
}

