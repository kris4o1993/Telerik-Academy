using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file and prints on the console its odd lines.

class Reader
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\prologue.txt", Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine(line);
                    lineNumber++;
                    line = reader.ReadLine();
                }

                else
                {
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }

    }
}
