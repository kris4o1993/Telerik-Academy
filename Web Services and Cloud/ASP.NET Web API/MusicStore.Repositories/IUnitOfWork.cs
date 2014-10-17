namespace MusicStore.Repositories
{
    using System;

    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
