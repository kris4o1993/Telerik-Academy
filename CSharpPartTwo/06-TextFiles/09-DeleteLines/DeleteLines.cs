using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.

class DeleteLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\file.txt", Encoding.GetEncoding("windows-1251"));
        StringBuilder oddTextLines = new StringBuilder();

        using (reader)
        {
            string line = reader.ReadLine();
            int lineNumber = 1;
            while (line != null)
            {
                if (lineNumber % 2 == 1)
                {
                    lineNumber++;
                    line = reader.ReadLine();
                }
                else
                {
                    oddTextLines.AppendLine(line);
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }

        StreamWriter writer = new StreamWriter(@"..\..\file.txt", false, Encoding.GetEncoding("windows-1251"));
        using(writer)
        {
            writer.WriteLine(oddTextLines);
        }
    }
}

