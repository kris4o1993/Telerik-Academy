using System;

//Write a program to read your age from the console and print how old you will be after 10 years.

class AgeInTenYears
{
    static void Main()
    {
        Console.Write("How old are you now: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be {0} years old.", (age+10));
    }
}
