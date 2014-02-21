using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.


class ReadAllText
{
    static void Main()
    {
        try
        {
            string fileContent = File.ReadAllText(@"C:\asd\file.txt");
            Console.WriteLine(fileContent);
        }

        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long. Enter correct path.");
        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory can not be found.");
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("File can not be found.");
        }

        catch (IOException)
        {
            Console.WriteLine("I/O error!");
        }

        catch (System.Security.SecurityException)
        {
            Console.WriteLine("Security Error.");
        }

        catch (Exception)
        {
            Console.WriteLine("FATAL ERROR!");
        }
    }
}

