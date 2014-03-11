using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Generics
{
    class Program
    {
        static void Main()
        {
            GenericList<int> someElements = new GenericList<int>();

            someElements.AddBack(5);
            someElements.AddFront(4);
            someElements.InsertAt(3, 10);
            someElements.Clear();
            someElements.ElementOnIndex(3);
            someElements.IndexOf(5);
            someElements.RemoveAt(3);
            int elementsCount = someElements.Count;

        }
    }
}
