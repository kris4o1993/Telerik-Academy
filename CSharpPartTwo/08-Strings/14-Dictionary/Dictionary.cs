using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Dictionary
{
    static void Main()
    {
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"
        };
        string word = "namespace";
        foreach (string item in dictionary)
        {
            var fragments = Regex.Match(item, "(.*?) - (.*)").Groups;

            if (fragments[1].Value == word)
            {
                Console.WriteLine(fragments[2]);
            }
        }

    }
}

