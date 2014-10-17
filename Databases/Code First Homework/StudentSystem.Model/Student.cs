namespace StudentSystem.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
        }

        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public StudentStatus StudentStatus { get; set; }

        //will not work if we dont make an instance of it. also we must make it virtual, because of performance issues.
        //if we dont set it virtual and we want to work with just one student, entity will get all data for all of 
        //the student's courses. It makes lazy loading. also we must make field for the virtual properties
        public virtual ICollection<Course> Courses 
        {
            get { return this.courses; }
            set { this.courses = value; } 
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }
    }
}
