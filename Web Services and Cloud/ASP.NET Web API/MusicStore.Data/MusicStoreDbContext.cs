namespace MusicStore.Data
{
    using System.Data.Entity;
    using MusicStore.Models;

    public class MusicStoreDbContext : DbContext
    {
        public MusicStoreDbContext()
            : base("MusicStore")
        {
        }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }
 
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasKey(x => x.Id);
            modelBuilder.Entity<Album>().Property(x => x.Title).IsOptional();
            modelBuilder.Entity<Album>().Property(x => x.Year).IsOptional();
            modelBuilder.Entity<Album>().Property(x => x.Producer).IsOptional();
            modelBuilder.Entity<Album>().HasMany(x => x.Songs).WithOptional(x => x.Album).WillCascadeOnDelete(true);

            modelBuilder.Entity<Artist>().HasKey(x => x.Id);
            modelBuilder.Entity<Artist>().Property(x => x.Name).IsOptional();
            modelBuilder.Entity<Artist>().Property(x => x.Country).IsOptional();
            modelBuilder.Entity<Artist>().Property(x => x.DateOfBirth).IsOptional();

            modelBuilder.Entity<Song>().HasKey(x => x.Id);
            modelBuilder.Entity<Song>().Property(x => x.Title).IsOptional();
            modelBuilder.Entity<Song>().Property(x => x.Year).IsOptional();
            modelBuilder.Entity<Song>().Property(x => x.Genre).IsOptional();
        }
    }
}
