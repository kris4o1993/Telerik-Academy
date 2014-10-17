namespace SchoolSystem.Data
{
    using System.Data.Entity;
    using SchoolSystem.Data.Configuration;
    using SchoolSystem.Models;

    public class SchoolSystemDbContext : DbContext
    {
        public SchoolSystemDbContext()
            : base(nameOrConnectionString: "SchoolSystem")
        {
            //
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<School> Schools { get; set; }

        public DbSet<Mark> Marks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new SchoolConfiguration());
            modelBuilder.Configurations.Add(new MarkConfiguration());
        }
    }
}
