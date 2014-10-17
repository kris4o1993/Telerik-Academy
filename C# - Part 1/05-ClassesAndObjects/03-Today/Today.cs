using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.

class Today
{
    static void Main(string[] args)
    {
        Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
    }
}
