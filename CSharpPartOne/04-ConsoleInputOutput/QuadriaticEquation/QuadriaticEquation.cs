using System;

//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2+bx+c=0 and solves it (prints its real roots).

class QuadriaticEquation
{
    static void Main()
    {
        Console.Write("Enter the coefficient a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Your equation looks like this: ({0})*X^2 + ({1})*X + ({2}) = 0", a, b, c);

        double d = (b * b) - (4 * a * c);
        Console.WriteLine("Discriminant is equal to " + d);
        if (d > 0)
        {
            Console.WriteLine("D > 0 => The equation has two roots.");
            double sqrtD = Math.Sqrt(d);
            double x1 = (-b + sqrtD) / 2 * a;
            double x2 = (-b - sqrtD) / 2 * a;
            Console.WriteLine("X1 = " + x1);
            Console.WriteLine("X2 = " + x2);
        }
        else if (d == 0)
        {
            Console.WriteLine("D = 0 => The equation has one root.");
            double x = (-b) / (2 * a);
            Console.WriteLine("X = " + x);
        }
        else
        {
            Console.WriteLine("D < 0 => The equation has no roots.");
        }
    }
}