namespace MusicStore.Repositories
{
    using System.Data;
    using System.Data.Entity;
    using System.Linq;

    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly DbContext dbContext;
        private readonly DbSet<T> dbSet;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<T>();
        }

        public T Add(T item)
        {
            this.dbSet.Add(item);
            return item;
        }

        public T GetById(int id)
        {
            var item = this.dbSet.Find(id);
            return item;
        }

        public IQueryable<T> GetAll()
        {
            return this.dbSet;
        }

        public T Update(T item)
        {
            this.dbSet.Attach(item);
            this.dbContext.Entry(item).State = EntityState.Modified;
            return item;
        }

        public void Delete(int id)
        {
            var item = this.dbSet.Find(id);
            if (item != null)
            {
                this.dbSet.Remove(item);
            }
        }
    }
}
