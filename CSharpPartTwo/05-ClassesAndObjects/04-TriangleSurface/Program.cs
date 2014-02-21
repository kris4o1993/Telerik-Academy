using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.


class Program
{
    static void SideAndAltitude()
    {
        Console.Write("Enter side: ");
        double side = double.Parse(Console.ReadLine());

        Console.Write("Enter altitude: ");
        double altitude = double.Parse(Console.ReadLine());

        double area = (side * altitude) / 2;
        Console.WriteLine("Area = " + area);
    }

    static void ThreeSides()
    {
        Console.Write("Enter side a: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Enter side b: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Enter side c: ");
        double sideC = double.Parse(Console.ReadLine());

        double p = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        Console.WriteLine("Area = " + area);
    }

    static void TwoSidesAndAngle()
    {
        Console.Write("Enter side a: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Enter side b: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Enter angle : ");
        double angle = double.Parse(Console.ReadLine());

        double area = (sideA * sideB * Math.Sin(Math.PI * angle / 180)) / 2;
        Console.WriteLine("Area = " + area);
    }

    static void Main()
    {
        Console.WriteLine("Which elements of the triangle you have?");
        Console.WriteLine("1 - side and an altitude to it");
        Console.WriteLine("2 - Three sides");
        Console.WriteLine("3 - Two sides and an angle between them");

        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: SideAndAltitude(); break;
            case 2: ThreeSides(); break;
            case 3: TwoSidesAndAngle(); break;
            default: Main(); break;
        }
        
    }
}

