namespace StudentSystem.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string FilePath { get; set; }

        public DateTime TimeSent { get; set; }

        public Guid CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
