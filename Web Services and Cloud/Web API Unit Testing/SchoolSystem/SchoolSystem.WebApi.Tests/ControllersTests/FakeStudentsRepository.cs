namespace SchoolSystem.WebApi.Tests.ControllersTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using SchoolSystem.Models;
    using SchoolSystem.Repositories;

    public class FakeStudentsRepository : StudentsDbRepository
    {
        public ICollection<Student> Students { get; set; }

        public FakeStudentsRepository()
        {
            this.Students = new HashSet<Student>();
        }

        public override IQueryable<T> All<T>(string[] includes = null)
        {
            return this.Students.AsQueryable() as IQueryable<T>;
        }

        public override T Get<T>(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            return this.All<T>().FirstOrDefault(expression);
        }

        public override IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            return this.All<T>().Where(predicate);
        }

        public override T Create<T>(T t)
        {
            this.Students.Add(t as Student);
            return t;
        }
    }
}
