namespace Moneh
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
            
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Kristiyan","Petrov", 4),
                new Student("Martin","Petrov", 3),
                new Student("Martin","Stankov", 6),
                new Student("Hristo","Yanchev", 6),
                new Student("Elena","Pitsin", 5),
                new Student("Alexander","Dzhazhev", 6),
                new Student("Todor","Atanasov", 6),
                new Student("Stanislav","Malchev", 2),
                new Student("Ladislav","Grigorov", 3),
                new Student("Haris","Lepic", 5)
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("Hristina","Lukanova", 250, 6),
                new Worker("Alexy","Petrov", 300, 8),
                new Worker("Anton","Petrov", 100, 2),
                new Worker("Canka","Lukanova", 350, 8),
                new Worker("Snejana","Ivanova", 750, 12),
                new Worker("Denislav","Ivanov", 150, 8),
                new Worker("Gabiela","Ivanova", 400, 6),
                new Worker("Irina","Georgieva", 200, 5),
                new Worker("George","Grigorov", 500, 6),
                new Worker("Kristian","Atanasov", 900, 10)
            };

            var sortedStudents =
                                from student in students
                                orderby student.Grade ascending, student.FirstName ascending, student.LastName ascending
                                select student;

            //var sortedStudents = students.OrderBy(x => x.Grade).ThenBy(x => x.FirstName).ThenBy(x => x.LastName);
            Console.WriteLine("STUDENTS\n");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("\n\n----------------------------------------------------------------------------\n");

            var sortedWorkers =
                               from worker in workers
                               orderby worker.MoneyPerHour() ascending, worker.FirstName ascending, worker.LastName ascending
                               select worker;

            Console.WriteLine("WORKERS\n");
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine("\n\n----------------------------------------------------------------------------\n");

            var mergedList = new List<Human>();
            mergedList.AddRange(workers);
            mergedList.AddRange(students);

            var sortMergedList =
                                from human in mergedList
                                orderby human.FirstName ascending, human.LastName ascending
                                select human;

            Console.WriteLine("ALL PEOPLE\n");
            foreach (var item in sortMergedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n----------------------------------------------------------------------------\n");
        }
    }
}