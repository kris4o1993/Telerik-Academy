﻿using System;

//Declare a character variable and assign it with the symbol that has Unicode code 72. 
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

class UnicodeChar
{
    static void Main()
    {
        char symbol = '\u0048'; //72 in hexadecimal format is 48
        Console.WriteLine(symbol);
    }
}

