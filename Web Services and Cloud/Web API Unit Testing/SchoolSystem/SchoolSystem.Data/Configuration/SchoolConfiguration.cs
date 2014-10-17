namespace SchoolSystem.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using SchoolSystem.Models;

    public class SchoolConfiguration : EntityTypeConfiguration<School>
    {
        public SchoolConfiguration()
        {
            this.HasKey(s => s.Id);

            this.Property(s => s.Name).HasMaxLength(255);
            this.Property(s => s.Name).IsUnicode(true);
            this.Property(s => s.Name).IsRequired();

            this.Property(s => s.Location).HasMaxLength(100);
            this.Property(s => s.Location).IsUnicode(true);
            this.Property(s => s.Location).IsRequired();
        }
    }
}
