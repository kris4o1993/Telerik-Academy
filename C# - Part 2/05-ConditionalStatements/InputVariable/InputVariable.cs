using System;

//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, 
//appends "*" at its end. The program must show the value of that variable as a console output. 
//Use switch statement.

class InputVariable
{
    static void Main()
    {
        Console.WriteLine("Press \"1\" to input integer, \"2\" to input double and \"3\" to input string");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter integer: ");
                int integerNumber = int.Parse(Console.ReadLine());
                integerNumber++;
                Console.WriteLine("New integer: " + integerNumber);
                break;
            case "2":
                Console.Write("Enter double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                doubleNumber++;
                Console.WriteLine("New double: " + doubleNumber);
                break;
            case "3":
                Console.Write("Enter string: ");
                string stringInput = Console.ReadLine();
                stringInput = stringInput + "*";
                Console.WriteLine("New string: " + stringInput);
                break;
        }
    }
}
