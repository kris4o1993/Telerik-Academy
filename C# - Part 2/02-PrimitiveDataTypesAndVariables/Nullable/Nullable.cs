using System;

//Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, try to add some values or the null literal to them and see the result.

class Nullable
{
    static void Main()
    {
        int? firstVariable = null;
        double? secondVariable = null;
        Console.WriteLine(firstVariable);
        Console.WriteLine(secondVariable);

        firstVariable = 0;
        secondVariable = 0;
        Console.WriteLine(firstVariable);
        Console.WriteLine(secondVariable);
    }
}
