namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Model;
    public class StudentSystemConsoleClient
    {
        static void Main()
        {
            var db = new StudentSystemDbContext();

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                var student = new Student
                {
                    Age = rand.Next(10, 100),
                    FirstName = "Pesho" + i,
                    LastName = "Goshov" + i,
                    StudentStatus = StudentStatus.Onsite
                };

                student.Courses.Add(new Course
                {
                    Name = "SomeCourse" + i,
                });

                db.Students.Add(student);
            }
            db.SaveChanges();

            var allStudents = db.Students;

            foreach (var item in allStudents)
            {
                Console.WriteLine("{0} - {1} {2}. Status: {3}", item.Id, item.FirstName, item.LastName, item.StudentStatus);
            }
        }
    }
}
