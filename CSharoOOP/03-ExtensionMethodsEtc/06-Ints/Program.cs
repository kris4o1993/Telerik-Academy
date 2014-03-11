namespace _06_Ints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 42, 9, 7, 21, 35, 312, 1, 2, 3, 4, 5, 5, 5, 2, 2, 56, 43, 63, 12, 4, 32 };

            //lambda
            //var divizibleBySevenAndThree = integers.Where(x => x % 7 == 0 && x % 3 == 0);
            //Console.WriteLine(String.Join(", ", divizibleBySevenAndThree));



            //LINQ
            var divizibleBySevenAndThree =
                from number in integers
                where number % 7 == 0 && number % 3 == 0
                select number;

            Console.WriteLine(String.Join(", ", divizibleBySevenAndThree));
        }
    }
}
