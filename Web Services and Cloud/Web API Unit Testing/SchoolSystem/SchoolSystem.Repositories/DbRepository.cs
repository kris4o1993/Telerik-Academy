namespace SchoolSystem.Repositories
{
    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using SchoolSystem.Data;
    using SchoolSystem.Models;

    public class DbRepository : IRepository
    {
        private readonly DbContext dbContext;

        public DbRepository(DbContext dbContext = null)
        {
            this.dbContext = dbContext ?? new SchoolSystemDbContext();

            //SERIALIZE WILL FAIL WITH PROXIED ENTITIES
            this.dbContext.Configuration.ProxyCreationEnabled = false;

            //ENABLING COULD CAUSE ENDLESS LOOPS AND PERFORMANCE PROBLEMS
            this.dbContext.Configuration.LazyLoadingEnabled = false;
        }

        public virtual IQueryable<T> All<T>(string[] includes = null) where T : class
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Any())
            {
                var query = this.dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);                    
                }

                return query.AsQueryable();
            }

            return this.dbContext.Set<T>().AsQueryable();
        }

        public virtual T Get<T>(Expression<Func<T, bool>> expression, string[] includes = null) where T : class
        {
            return this.All<T>(includes).FirstOrDefault(expression);
        }

        public virtual T Find<T>(Expression<Func<T, bool>> predicate, string[] includes = null) where T : class
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Any())
            {
                var query = this.dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                }

                return query.FirstOrDefault<T>(predicate);
            }

            return this.dbContext.Set<T>().FirstOrDefault<T>(predicate);
        }

        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate, string[] includes = null) where T : class
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Any())
            {
                var query = this.dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                }

                return query.Where<T>(predicate).AsQueryable<T>();
            }

            return this.dbContext.Set<T>().Where<T>(predicate).AsQueryable<T>();
        }

        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 50, string[] includes = null) where T : class
        {
            int skipCount = index * size;
            IQueryable<T> resetSet;

            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Any())
            {
                var query = this.dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                }

                resetSet = predicate != null ? query.Where<T>(predicate).AsQueryable() : query.AsQueryable();
            }
            else
            {
                resetSet = predicate != null ? this.dbContext.Set<T>().Where<T>(predicate).AsQueryable() : this.dbContext.Set<T>().AsQueryable();
            }

            resetSet = skipCount == 0 ? resetSet.Take(size) : resetSet.OrderBy(predicate).Skip(skipCount).Take(size);
            total = resetSet.Count();
            return resetSet.AsQueryable();
        }

        public virtual bool Contains<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return this.dbContext.Set<T>().Count<T>(predicate) > 0;
        }

        public virtual T Create<T>(T t) where T : class
        {
            var newEntry = this.dbContext.Set<T>().Add(t);
            this.dbContext.SaveChanges();
            return newEntry;
        }

        public virtual int Delete<T>(T t) where T : class
        {
            this.dbContext.Set<T>().Remove(t);
            return this.dbContext.SaveChanges();
        }

        public virtual int Delete<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            var objects = this.Filter<T>(predicate);
            foreach (var obj in objects)
            {
                this.dbContext.Set<T>().Remove(obj);
            }

            return this.dbContext.SaveChanges();
        }

        public virtual int Update<T>(T t) where T : class
        {
            var entry = this.dbContext.Entry(t);
            this.dbContext.Set<T>().Attach(t);
            entry.State = EntityState.Modified;
            return this.dbContext.SaveChanges();
        }

        public virtual void Dispose()
        {
            if (this.dbContext != null)
            {
                this.dbContext.Dispose();
            }
        }
    }
}
