using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area.

class Circle
{
    static void Main()
    {
        Console.Write("Radius = ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = Math.PI * radius * 2;
        double area = Math.PI * radius * radius;

        Console.WriteLine("The perimeter is {0} and the area is {1}.", perimeter, radius);
    }
}

