using System;

//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

class ValueShift
{
    static void Main()
    {
        //printing default result
        int a = 5;
        int b = 10;
        Console.WriteLine("A is " + a);
        Console.WriteLine("B is " + b);

        //shifting values
        int c = a;
        a = b;
        b = c;

        //printing new result
        Console.WriteLine("A is " + a);
        Console.WriteLine("B is " + b);
    }
}
