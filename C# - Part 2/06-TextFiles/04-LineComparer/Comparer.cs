using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that compares two text files line by line and prints the number of lines 
//that are the same and the number of lines that are different. Assume the files have equal number of lines.

class Comparer
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\prologue.txt", Encoding.GetEncoding("windows-1251"));
        StreamReader secondReader = new StreamReader(@"..\..\prologue2.txt", Encoding.GetEncoding("windows-1251"));

        int equalRows = 0;
        int nonEqualRows = 0;
        using (reader)
        {
            using (secondReader)
            {
                string lineRead = reader.ReadLine();
                string secondLineRead = secondReader.ReadLine();

                while (lineRead != null && secondLineRead != null)
                {
                    if (lineRead == secondLineRead)
                    {
                        equalRows++;
                    }

                    else
                    {
                        nonEqualRows++;
                    }

                    lineRead = reader.ReadLine();
                    secondLineRead = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Total: {0}", equalRows + nonEqualRows);
        Console.WriteLine("Equal: {0}", equalRows);
        Console.WriteLine("Different: {0}", nonEqualRows);
    }
}