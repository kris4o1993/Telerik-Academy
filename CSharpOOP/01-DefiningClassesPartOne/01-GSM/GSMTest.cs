using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GSM
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            List<GSM> gsms = new List<GSM>();

            gsms.Add(new GSM("N50", "Nokia"));
            gsms.Add(new GSM("A50", "Siemens", 30, "Korialstraz"));
            gsms.Add(new GSM("Lumia X10", "Nokia", 1000, "Nozdormu", new Battery("Crappy Battery", 10, 5), new Display(10, 10000000)));
            gsms.Add(GSM.IPhone4S);

            //display information. uncomment to do it!
            //foreach (var gsm in gsms)
            //{
            //    Console.WriteLine(gsm);
            //}


            //adding some calls
            //List<Call> calls = new List<Call>();
            //calls.Add(new Call(DateTime.Now, "+359dasdasd", 100));
            //calls.Add(new Call(DateTime.Now, "+359231234", 25));
            //calls.Add(new Call(DateTime.Now, "+42342342", 2100));
            //foreach (var call in calls)
            //{
            //    Console.WriteLine(call);
            //}

        }

    }
}
