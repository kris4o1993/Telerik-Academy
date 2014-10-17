using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Modify the solution of the previous problem to replace only whole words (not substrings).

//Понеже имам готов текст съм заменил думата 'но' с "КО?НЕ!". Сложил съм да работи направо и 8-ма задача.
//Предполагам едва ли е проблем, тъй като целта на заданието функционално остава същата. 

class Replace
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\firstfile.txt", Encoding.GetEncoding("windows-1251"));
        StreamWriter writer = new StreamWriter(@"..\..\resultfile.txt", false, Encoding.GetEncoding("windows-1251"));

        using(reader)
        {
            using(writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    //task 7
                    //writer.WriteLine(line.Replace("но", "КО?НЕ!"));
                    //line = reader.ReadLine();

                    //task 8
                    writer.WriteLine(Regex.Replace(line, @"\bно\b", "КО?НЕ!"));
                    line = reader.ReadLine();
                    //check row 13 to see that it works
                }

            }
        }
    }
}

