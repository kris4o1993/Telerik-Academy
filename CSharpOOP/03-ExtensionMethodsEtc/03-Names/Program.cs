using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Names
{
    class Program
    {

        static void Main(string[] args)
        {
            var students = new List<Students>()
            {
                new Students 
                { 
                    FirstName = "Kristiyan", 
                    LastName = "Petrov",
                    Age = 21
                },

                new Students 
                { 
                    FirstName = "Hristo", 
                    LastName = "Yanchev",
                    Age = 23
                },

                new Students 
                { 
                    FirstName = "Elena", 
                    LastName = "Pitsin",
                    Age = 17
                },

                new Students 
                { 
                    FirstName = "Alexander", 
                    LastName = "Djajev",
                    Age = 19
                },

                new Students 
                { 
                    FirstName = "Ivo", 
                    LastName = "Alexanderov",
                    Age = 27
                },

                new Students 
                { 
                    FirstName = "Todor",
                    LastName = "Atanasov",
                    Age = 29
                },

                new Students 
                { 
                    FirstName = "Martin",
                    LastName = "Stankov",
                    Age = 12
                },

                new Students 
                { 
                    FirstName = "Martin", 
                    LastName = "Petrov",
                    Age = 21
                },

                new Students 
                { 
                    FirstName = "Alexander", 
                    LastName = "Vasilev",
                    Age = 33
                },

                new Students 
                { 
                    FirstName = "Ladislav", 
                    LastName = "Grigorov",
                    Age = 25
                }
            };

            //TASK 3 WITH LINQ

            //var firstNameBeforeLastName =
            //    from student in students
            //    where student.FirstName.CompareTo(student.LastName) == -1
            //    select student;
            //Console.WriteLine("FIRST NAME BEFORE LAST NAME");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in firstNameBeforeLastName)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");




            //TASK 3 WITH LAMBDA

            //var firstNameBeforeLastName = students.Where(st => st.FirstName.CompareTo(st.LastName) == -1);
            //Console.WriteLine("FIRST NAME BEFORE LAST NAME");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in firstNameBeforeLastName)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");



            //TASK 4 WITH LAMBDA

            //var youngGuys = students.Where(st => st.Age >= 18 && st.Age <= 24);
            //Console.WriteLine("AGE BETWEEN 18 AND 24");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in youngGuys)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");



            //TASK 4 WITH LINQ

            //var youngGuys =
            //    from student in students
            //    where student.Age >= 18 && student.Age <= 24
            //    select student;
            //Console.WriteLine("AGE BETWEEN 18 AND 24");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in youngGuys)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");
            
        

            //TASK 5 WITH LAMBDA

            //var sortedByFirstName = students
            //    .OrderByDescending(st => st.FirstName)
            //    .ThenByDescending(st => st.LastName);
            //Console.WriteLine("DESCENDING NAME");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in sortedByFirstName)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");




            //TASK 5 WITH LINQ

            //var sortedByFirstName =
            //    from student in students
            //    orderby student.FirstName descending, student.LastName descending
            //    select student;
            //Console.WriteLine("DESCENDING NAME");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in sortedByFirstName)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}
