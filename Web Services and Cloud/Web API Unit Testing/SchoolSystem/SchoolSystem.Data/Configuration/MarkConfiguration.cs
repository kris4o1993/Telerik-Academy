namespace SchoolSystem.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using SchoolSystem.Models;

    public class MarkConfiguration : EntityTypeConfiguration<Mark>
    {
        public MarkConfiguration()
        {
            this.HasKey(m => m.Id);

            this.Property(m => m.Subject).HasMaxLength(100);
            this.Property(m => m.Subject).IsUnicode(true);
            this.Property(m => m.Subject).IsRequired();

            this.Property(m => m.Value).IsRequired();
        }
    }
}
