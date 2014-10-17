namespace Salaries
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            bool[,] matrix = ReadInput();

            Person[] staff = new Person[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                staff[i] = new Person();
            }

            long salaries = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                salaries += GetSalary(matrix, staff, i);
            }

            Console.WriteLine(salaries);
        }

        private static long GetSalary(bool[,] matrix, Person[] staff, int personIndex)
        {
            if (staff[personIndex].Salary > 0)
            {
                return staff[personIndex].Salary;
            }

            for (var i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[personIndex, i])
                {
                    staff[personIndex].Salary += GetSalary(matrix, staff, i);                    
                }
            }

            if (staff[personIndex].Salary == 0)
            {
                return 1L;
            }

            return staff[personIndex].Salary;
        }
  
        private static bool[,] ReadInput()
        {
            int c = int.Parse(Console.ReadLine());
            bool[,] matrix = new bool[c, c];

            for (int i = 0; i < c; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < c; j++)
                {
                    if (line[j] == 'Y')
                    {
                        matrix[i, j] = true;
                    }
                }
            }

            return matrix;
        }
    }
}
