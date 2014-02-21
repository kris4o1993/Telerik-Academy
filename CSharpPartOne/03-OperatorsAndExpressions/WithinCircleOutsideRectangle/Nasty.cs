using System;

//Write an expression that checks for given point (x, y) if it is within the 
//circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class WithinCircle
{
    static void Main()
    {
        Console.Write("Enter coordinate X: ");
        double pointX = double.Parse(Console.ReadLine());

        Console.Write("Enter coordinate Y: ");
        double pointY = double.Parse(Console.ReadLine());

        double radius = 3;

        double isInside = Math.Pow((pointX - 1), 2) + Math.Pow((pointY - 1), 2);
        if (isInside < radius * radius)
        {
            Console.WriteLine("The point is inside the circle");
            if (pointX < -1 || pointY > 1 || pointY < -1)
            {
                Console.WriteLine("The point is outside the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is inside the rectangle.");
            }
        }
        else
        {
            Console.WriteLine("The point is outside the circle");
        }
    }
}
