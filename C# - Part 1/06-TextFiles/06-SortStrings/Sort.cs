using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 

class Sort
{
    /// <summary>
    /// Reading names from file and sorting them
    /// </summary>
    /// <returns>List<string> of names</returns>
    static List<string> Names()
    {
        StreamReader reader = new StreamReader(@"..\..\unsortedNames.txt");
        List<string> names = new List<string>();
        string currentName = reader.ReadLine();
        while (currentName != null)
        {
            names.Add(currentName);
            currentName = reader.ReadLine();
        }
        names.RemoveAll(item => item.Length == 0);
        names.Sort();

        return names;
    } 

    static void Output(List<string> names)
    {
        StreamWriter writer = new StreamWriter(@"..\..\sortedNames.txt", false);
        using (writer)
        {
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine(names[i]);
            }
        }
    }

    static void Main()
    {
        Output(Names());
    }
}
