using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\prologue.txt", Encoding.GetEncoding("windows-1251"));
        StreamWriter writer = new StreamWriter(@"..\..\prologue-lines.txt",false, Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {    
                    writer.WriteLine("{0}.   {1}", lineNumber, line);
                    lineNumber++;
                    line = reader.ReadLine();
            }
        }
    }
}

