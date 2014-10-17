namespace SchoolSystem.Repositories
{
    using System.Data.Entity;

    public class StudentsDbRepository : DbRepository
    {
        public StudentsDbRepository(DbContext dbContext = null)
            : base(dbContext)
        {
            
        }
    }
}
