using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The area of the trapezoid is " + area);
    }
}

