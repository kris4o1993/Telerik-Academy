using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that can solve these tasks:
//   Reverses the digits of a number
//   Calculates the average of a sequence of integers
//   Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//   The decimal number should be non-negative
//   The sequence should not be empty
//   a should not be equal to 0


class CoolStuff
{
    static string Reverser()
    {
        string number = Console.ReadLine();
        bool isValid = false;
        for (int i = 0; i < number.Length; i++)
        {
            if ((number[i] > '0' && number[i] < '9') || (number[i] == '.' || number[i] == ','))
            {
                isValid = true;
            }
        }

        if (isValid)
        {
            char[] reversedNumber = number.ToCharArray();
            Array.Reverse(reversedNumber);
            return String.Join("", reversedNumber);
        }
        Console.WriteLine("Enter valid POSITIVE decimal number.");
        return Reverser();

    }

    static double Average()
    {
        Console.WriteLine("Enter the length of the array of integers: ");
        int length = int.Parse(Console.ReadLine());
        if (length <= 0)
        {
            Console.WriteLine("Enter positive length.");
            Average();
        }
        int[] integers = new int[length];
        int sum = 0;
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter element {0}: ", i);
            integers[i] = int.Parse(Console.ReadLine());
            sum += integers[i];
        }
        return (double)(sum) / (double)(length - 1);
    }

    static double Solver()
    {
        Console.Write("Enter integer A: ");
        double a = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("A must not be 0.");
            Solver();
        }
        Console.Write("Enter integer B: ");
        double b = -(double.Parse(Console.ReadLine()));

        return b / a;
    }
    
    static void Main()
    {
        Console.WriteLine("Type one of these commands exactly as you see it (with CAPITAL letters): ");
        Console.WriteLine("REVERSE - Reverses the digits of a number.");
        Console.WriteLine("AVERAGE - Calculates the average of a sequence of integers");
        Console.WriteLine("SOLVE - Solves a linear equation a * x + b = 0");
        string command = Console.ReadLine();

        if (command == "REVERSE")
        {
            Console.WriteLine("Enter a number you want to reverse (you may type even decimal numbers. HOW COOL IS THAT!?!?): ");
            string reversedNumber = Reverser();
            Console.WriteLine("Reversed number is: " + reversedNumber);
            Main();
        }

        else if (command == "AVERAGE")
        {
            double average = Average();
            Console.WriteLine("The average of the integers is: " + average);
        }

        else if (command == "SOLVE")
        {
            double result = Solver();
            Console.WriteLine("Result: " + result);
        }

        else if (command == "EXIT")
        {
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Wrong command entered.");
            Main();
        }



    }
}

