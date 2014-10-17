namespace SchoolSystem.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using SchoolSystem.Models;

    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            this.HasKey(s => s.Id);

            this.Property(s => s.FirstName).HasMaxLength(60);
            this.Property(s => s.FirstName).IsUnicode(true);
            this.Property(s => s.FirstName).IsRequired();

            this.Property(s => s.LastName).HasMaxLength(60);
            this.Property(s => s.LastName).IsUnicode(true);
            this.Property(s => s.LastName).IsRequired();

            this.Property(s => s.Age).IsRequired();

            this.Property(s => s.Grade).IsRequired();
        }
    }
}
