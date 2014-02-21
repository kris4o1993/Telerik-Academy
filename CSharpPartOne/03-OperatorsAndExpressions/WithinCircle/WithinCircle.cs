using System;

//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class WithinCircle
{
    static void Main()
    {
        Console.Write("Enter coordinate X: ");
        double pointX = double.Parse(Console.ReadLine());

        Console.Write("Enter coordinate Y: ");
        double pointY = double.Parse(Console.ReadLine());

        double radius = 5;

        double isInside = pointX * pointX + pointY * pointY;
        if (isInside < radius * radius)
        {
            Console.WriteLine("The point is inside the circle");
        }
        else
        {
            Console.WriteLine("The point is not inside the circle");
        }
    }
}

