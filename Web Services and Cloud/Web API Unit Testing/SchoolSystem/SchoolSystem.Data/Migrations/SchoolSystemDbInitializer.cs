namespace SchoolSystem.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using SchoolSystem.Models;

    public class SchoolSystemDbInitializer : CreateDatabaseIfNotExists<SchoolSystemDbContext>
    {
        protected override void Seed(SchoolSystemDbContext context)
        {
            //var telerikAcademy = new School
            //{
            //    Name = "Telerik Academy",
            //    Location = "Sofia"
            //};

            //var unss = new School
            //{
            //    Name = "UNSS",
            //    Location = "Sofia"
            //};

            //context.Schools.Add(telerikAcademy);
            //context.Schools.Add(unss);
            //context.SaveChanges();

            //var goshoPetkov = new Student
            //{
            //    FirstName = "Gosho", 
            //    LastName = "Petkov", 
            //    Age = 16, 
            //    Grade = 9,
            //    Marks = new HashSet<Mark>
            //    {
            //        new Mark { Subject = "Math", Value = 5.50m },
            //        new Mark { Subject = "Biology", Value = 4.00m },
            //        new Mark { Subject = "English", Value = 6.00m },
            //        new Mark { Subject = "Sport", Value = 3.00m },
            //    }
            //};

            //var peshoIvanov = new Student
            //{
            //    FirstName = "Pesho",
            //    LastName = "Ivanov",
            //    Age = 17,
            //    Grade = 9,
            //    Marks = new HashSet<Mark>
            //    {
            //        new Mark { Subject = "Math", Value = 4.00m },
            //        new Mark { Subject = "Biology", Value = 3.00m },
            //        new Mark { Subject = "English", Value = 3.00m },
            //        new Mark { Subject = "Sport", Value = 6.00m },
            //    }
            //};

            //var ivanAngelov = new Student
            //{
            //    FirstName = "Ivan",
            //    LastName = "Angelov",
            //    Age = 15,
            //    Grade = 9,
            //    Marks = new HashSet<Mark>
            //    {
            //        new Mark { Subject = "Math", Value = 5.00m },
            //        new Mark { Subject = "Biology", Value = 5.00m },
            //        new Mark { Subject = "English", Value = 4.00m },
            //        new Mark { Subject = "Sport", Value = 5.00m },
            //    }
            //};

            //goshoPetkov.School = telerikAcademy;
            //peshoIvanov.School = telerikAcademy;
            //ivanAngelov.School = unss;

            //telerikAcademy.Students.Add(goshoPetkov);
            //telerikAcademy.Students.Add(peshoIvanov);
            //unss.Students.Add(ivanAngelov);

            //context.Schools.AddOrUpdate(telerikAcademy);
            //context.Schools.AddOrUpdate(unss);
            //context.Students.Add(goshoPetkov);
            //context.Students.Add(peshoIvanov);
            //context.Students.Add(ivanAngelov);
            //context.SaveChanges();
        }
    }
}
