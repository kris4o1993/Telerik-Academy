namespace StudentSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using StudentSystem.Model;

    public class StudentSystemDbContext : DbContext
    {
        public IDbSet<Student> Students { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Course> Courses { get; set; }
    }
}
