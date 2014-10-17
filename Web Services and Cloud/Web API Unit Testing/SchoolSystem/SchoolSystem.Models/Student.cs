namespace SchoolSystem.Models
{
    using System.Collections.Generic;

    public class Student : BaseModel
    {
        public Student()
        {
            this.Marks = new HashSet<Mark>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int Grade { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

        public virtual School School { get; set; }
    }
}
