namespace _01_School
{
    using System;
    using System.Collections.Generic;
    using School;

    class Program
    {
        static void Main()
        {
            List<Discipline> disciplines = new List<Discipline> 
            {
                new Discipline("C Sharp", 10, 10),
                new Discipline("Java", 5, 5),
                new Discipline("Computer Architecture", 20, 20),
                new Discipline("Databases", 15, 15),
                new Discipline("Web Design", 10, 30)
            };

            List<Student> students = new List<Student>
            {
                new Student("Kristiyan Petrov", 1),
                new Student("Martin Petrov", 2),
                new Student("Martin Stankov", 3),
                new Student("Hristo Yanchev", 4),
                new Student("Elena Pitsin", 5),
                new Student("Alexander Dzhazhev", 6),
                new Student("Todor Atanasov", 7),
                new Student("Stanislav Malchev", 8),
                new Student("Ladislav Grigorov", 9),
                new Student("Haris Lepic", 10)
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("Doncho Minkov", disciplines),
                new Teacher("Ivailo Kenov", disciplines),
                new Teacher("George Georgiev", disciplines),
                new Teacher("Nikolay Kostov", disciplines),
            };

            Class exampleClass = new Class("12E", teachers, students);

            //foreach (var discipline in disciplines)
            //{
            //    Console.WriteLine(discipline);
            //}

            Console.WriteLine(exampleClass);
        }
    }
}
