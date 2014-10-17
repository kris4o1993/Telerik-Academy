namespace SchoolSystem.Models
{
    using System.Collections.Generic;

    public class School : BaseModel
    {
        public School()
        {
            this.Students = new HashSet<Student>();
        }

        public string Name { get; set; }

        public string Location { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}