using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Structure3DPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point(2, 4, 4);
            Point secondPoint = new Point(4, 7, 10);

            Console.WriteLine(CalculatePath.Calculate(firstPoint, secondPoint));
        }
    }
}
