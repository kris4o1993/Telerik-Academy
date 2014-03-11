using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Structure3DPoint
{
    public static class CalculatePath
    {
        public static double Calculate(Point first, Point second)
        {
            return Math.Sqrt(
                ((first.pointX - second.pointX) * (first.pointX - second.pointX)) + 
                ((first.pointY - second.pointY) * (first.pointY - second.pointY)) + 
                ((first.pointZ - second.pointZ) * (first.pointZ - second.pointZ))
                );
        }
    }
}
