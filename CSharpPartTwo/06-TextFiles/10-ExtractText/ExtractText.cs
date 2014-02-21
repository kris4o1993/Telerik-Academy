using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Write a program that extracts from given XML file all the text without the tags.

class ExtractText
{
    static void Main(string[] args)
    {

        string output = String.Empty;
        using (StreamReader reader = new StreamReader(@"..\..\input.txt", Encoding.GetEncoding("windows-1251")))
            for (int i = 0; (i = reader.Read()) != -1; i++) if (i == '>') 
                while ((i = reader.Read()) != -1 && i != '<') output += ((char)i);

        List<string> result = new List<string>(output.Split(' '));
        result.RemoveAll(str => String.IsNullOrEmpty(str));
        Console.WriteLine(string.Join(" ", result));
    }
}

