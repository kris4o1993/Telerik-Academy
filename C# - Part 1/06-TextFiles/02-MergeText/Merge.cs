using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that concatenates two text files into another text file.

class Merge
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\firstfile.txt", Encoding.GetEncoding("windows-1251"));
        StreamWriter writer = new StreamWriter(@"..\..\resultfile.txt", false, Encoding.GetEncoding("windows-1251"));
        using(reader)
        {
            string read = reader.ReadToEnd();
            using(writer)
            {
                writer.WriteLine(read);
            }
        }
        reader = new StreamReader(@"..\..\secondfile.txt", Encoding.GetEncoding("windows-1251"));
        writer = new StreamWriter(@"..\..\resultfile.txt", true, Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            string read = reader.ReadToEnd();
            using (writer)
            {
                writer.WriteLine(read);
            }
        }
    }
}

