namespace MusicStore.Repositories
{
    using System.Linq;

    public interface IRepository<T>
    {
        T Add(T item);

        T GetById(int id);

        IQueryable<T> GetAll();

        T Update(T item);

        void Delete(int id);
    }
}
