namespace _09_OrderAndSelect
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            var students = new List<Students>()
            {
                new Students
                { 
                    FirstName = "Kristiyan", 
                    LastName = "Petrov",
                    FN = "123306",
                    Tel = "02-122-123",
                    Email = "xxx@abv.bg",
                    Marks = new List<int> {2, 5, 6, 6},
                    GroupNumber = "1"
                },

                new Students
                { 
                    FirstName = "Hristo", 
                    LastName = "Yanchev",
                    FN = "645105",
                    Tel = "xxx",
                    Email = "xxx@xxxx.xx",
                    Marks = new List<int> {3, 5, 4, 6},
                    GroupNumber = "1"
                },

                new Students
                { 
                    FirstName = "Elena", 
                    LastName = "Pitsin",
                    FN = "292905",
                    Tel = "02-122-123",
                    Email = "xxx@abv.bg",
                    Marks = new List<int> {6, 6, 4, 6},
                    GroupNumber = "3"
                },

                new Students
                { 
                    FirstName = "Alexander", 
                    LastName = "Djajev",
                    FN = "144406",
                    Tel = "xxx",
                    Email = "xxx@abv.bg",
                    Marks = new List<int> {3, 5, 4, 6},
                    GroupNumber = "2"
                },

                new Students
                { 
                    FirstName = "Ivo", 
                    LastName = "Alexanderov",
                    FN = "369904",
                    Tel = "xxx",
                    Email = "xxx@abv.bg",
                    Marks = new List<int> {3, 2, 2, 6},
                    GroupNumber = "1"
                },

                new Students
                { 
                    FirstName = "Todor",
                    LastName = "Atanasov",
                    FN = "857404",
                    Tel = "02-122-123",
                    Email = "xxx@abv.bg",
                    Marks = new List<int> {4, 5, 4, 4},
                    GroupNumber = "2"
                },

                new Students
                { 
                    FirstName = "Martin",
                    LastName = "Stankov",
                    FN = "777706",
                    Tel = "xxx",
                    Email = "xxx@xxxx.xx",
                    Marks = new List<int> {3, 2, 4, 2},
                    GroupNumber = "2"
                },

                new Students
                { 
                    FirstName = "Martin", 
                    LastName = "Petrov",
                    FN = "982007",
                    Tel = "02-122-123",
                    Email = "xxx@xxxx.xx",
                    Marks = new List<int> {3, 5, 3, 2},
                    GroupNumber = "3"
                },

                new Students
                { 
                    FirstName = "Alexander", 
                    LastName = "Vasilev",
                    FN = "213106",
                    Tel = "02-122-223",
                    Email = "xxx@xxxx.xx",
                    Marks = new List<int> {3, 3, 3, 6},
                    GroupNumber = "3"
                },

                new Students
                { 
                    FirstName = "Ladislav", 
                    LastName = "Grigorov",
                    FN = "358909",
                    Tel = "02-122-123",
                    Email = "xxx@abv.bg",
                    Marks = new List<int> {3, 5, 4, 6},
                    GroupNumber = "1"
                }
            };

            //task 9
            //var firstNameAndGroupTwo =
            //    from student in students
            //    where student.GroupNumber == "2"
            //    orderby student.FirstName ascending
            //    select student;
            //Console.WriteLine("ORDER BY FIRST NAME AND IN GROUP 2");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in firstNameAndGroupTwo)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");

            //task 11
            //var haveEmailInAbv =
            //    from student in students
            //    where student.Email.EndsWith("abv.bg")
            //    select student;
            //Console.WriteLine("EMAIL IN ABV");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in haveEmailInAbv)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");

            //task 12
            //var telephoneFromSofia =
            //    from student in students
            //    where student.Tel.StartsWith("02")
            //    select student;
            //Console.WriteLine("TELEPHONE FROM SOFIA");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in telephoneFromSofia)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");

            //task 13
            //var hasAtLeastOneSix =
            //    from student in students
            //    where student.Marks.Contains(6)
            //    select student;
            //Console.WriteLine("HAS AT LEAST ONE MARK 6");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //foreach (var item in hasAtLeastOneSix)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------------------------------------------------------------");

            //task 15
            var enrolledIn2006 =
                from student in students
                where student.FN.EndsWith("06")
                select student;
            Console.WriteLine("ENROLLED IN 2006");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (var item in enrolledIn2006)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}
