using System;

//Declare two string variables and assign them with following value:
//{The "use" of quotations causes difficulties.}
//Do the above in two different ways: with and without using quoted strings.

class Escaping
{
    static void Main()
    {
        string difficulties = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(difficulties);

        string evenMoreDifficulties = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(evenMoreDifficulties);
    }
}

