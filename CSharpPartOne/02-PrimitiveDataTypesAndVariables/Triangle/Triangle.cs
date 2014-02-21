using System;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.

class Triangle
{
    static void Main()
    {
        char copyright = '©';
        Console.WriteLine("{0}", copyright);
        Console.WriteLine("{0} {0}", copyright);
        Console.WriteLine("{0} {0} {0}", copyright);
    }
}
