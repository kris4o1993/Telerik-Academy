namespace MusicStore.Repositories
{
    using System;
    using System.Data.Entity;
    using MusicStore.Models;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;
        private Repository<Album> albumsRepository;
        private Repository<Artist> artistsRepository;
        private Repository<Song> songsRepository;
        private bool disposed;

        public UnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Repository<Album> AlbumsRepository
        {
            get
            {
                return this.albumsRepository ?? 
                    (this.albumsRepository = new Repository<Album>(this.dbContext));
            }
        }

        public Repository<Artist> ArtistsRepository
        {
            get
            {
                return this.artistsRepository ??
                    (this.artistsRepository = new Repository<Artist>(this.dbContext));
            }
        }

        public Repository<Song> SongsRepository
        {
            get
            {
                return this.songsRepository ??
                    (this.songsRepository = new Repository<Song>(this.dbContext));
            }
        }

        public void Commit()
        {
            this.dbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.dbContext.Dispose();
                }
            }

            this.disposed = true;
        }
    }
}
