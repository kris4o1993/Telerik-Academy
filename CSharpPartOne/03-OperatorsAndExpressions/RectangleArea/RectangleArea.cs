using System;

//Write an expression that calculates rectangle’s area by given width and height.

class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter the rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter the rectangle's width: ");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}

