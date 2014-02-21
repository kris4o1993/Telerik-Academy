using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. Be sure to catch 
//all exceptions and to free any used resources in the finally block.

class Download
{
    static void Main()
    {
        using (WebClient Client = new WebClient())
        {
            try
            {
                Client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "pornpic.jpeg");
            }

            catch(ArgumentException)
            {
                Console.WriteLine("Empty url entered.");
            }

            catch(System.Net.WebException)
            {
                Console.WriteLine("Not valid url or target file entered.");
            }

            catch(Exception)
            {
                Console.WriteLine("FATAL ERROR! RUNN BEFORE IT LAYS EGGS");
            }

            //no need of finally because we use "using" keyword :P
        }
    }
}
