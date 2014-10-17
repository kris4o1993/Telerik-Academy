namespace MusicStore.Client.ConsoleApp
{
    using System;
    using System.Linq;
    using MusicStore.Data;
    using MusicStore.Models;

    public class Demos
    {
        public static void Main()
        {
            // In the MusicStoreClient class you can choose work with JSON or XML
            // Uncomment lines endings with XML and comment lines endings with JSON to work with XML
            // Sorry for XML printing on the console, i had problems with xml deserialization

            /* ----------------- */
            /*  CRUD Operations  */
            /* ----------------- */

            // Fill db with add methods (only 1 time if you wont data duplication) and test get, update and delete methods

            //AddAlbum();
            //AddArtists();
            //AddSongs();
            //AddRelationships();

            //GetAllAlbums();
            //GetAllArtists();
            //GetAllSongs();

            //GetAlbum(1);
            //GetArtist(1);
            //GetSong(1);

            //UpdateAlbum(1);
            //UpdateArtist(1);
            //UpdateSong(1);

            //DeleteAlbum(1);
            //DeleteArtist(1);
            //DeleteSong(99);
        }

        private static void AddAlbum()
        {
            var album1 = new Album { Title = "European Artists", Producer = "Wikipedia", Year = 2013 };
            
            MusicStoreClient.Add(album1);
        }

        private static void AddArtists()
        {
            var artist1 = new Artist { Name = "Artist1", Country = "Bulgaria", DateOfBirth = DateTime.Now };
            var artist2 = new Artist { Name = "Artist2", Country = "Germany", DateOfBirth = DateTime.Now };

            MusicStoreClient.Add(artist1);
            MusicStoreClient.Add(artist2);
        }

        private static void AddSongs()
        {
            var song1 = new Song { Title = "Song1", Genre = "Dance", Year = 2011 };
            var song2 = new Song { Title = "Song2", Genre = "Slow", Year = 2000 };
            var song3 = new Song { Title = "Song3", Genre = "Pop", Year = 2013 };

            MusicStoreClient.Add(song1);
            MusicStoreClient.Add(song2);
            MusicStoreClient.Add(song3);
        }

        private static void AddRelationships()
        {
            using (var db = new MusicStoreDbContext())
            {
                var albums = db.Albums.ToList();
                var artists = db.Artists.ToList();
                var songs = db.Songs.ToList();

                albums[0].Artists.Add(artists[0]);
                albums[0].Artists.Add(artists[1]);

                songs[0].Artist = artists[0];
                songs[1].Artist = artists[1];
                songs[2].Artist = artists[1];

                songs[0].Album = albums[0];
                songs[1].Album = albums[0];
                songs[2].Album = albums[0];

                db.SaveChanges();
            }

            Console.WriteLine("Relationships are successfully added!");
        }

        private static void GetAllAlbums()
        {
            MusicStoreClient.GetAll<Album>();
        }

        private static void GetAllArtists()
        {
            MusicStoreClient.GetAll<Artist>();
        }

        private static void GetAllSongs()
        {
            MusicStoreClient.GetAll<Song>();
        }

        private static void GetAlbum(int id)
        {
            MusicStoreClient.GetById<Album>(id);
        }

        private static void GetArtist(int id)
        {
            MusicStoreClient.GetById<Artist>(id);
        }

        private static void GetSong(int id)
        {
            MusicStoreClient.GetById<Song>(id);
        }

        private static void UpdateAlbum(int id)
        {
            using (var db = new MusicStoreDbContext())
            {
                var album = db.Albums.First(x => x.Id == id);
                album.Year = 2;

                MusicStoreClient.Update(id, album);
            }
        }

        private static void UpdateArtist(int id)
        {
            using (var db = new MusicStoreDbContext())
            {
                var artist = db.Artists.First(x => x.Id == id);
                artist.Country = "Brazil";

                MusicStoreClient.Update(id, artist);
            }
        }

        private static void UpdateSong(int id)
        {
            using (var db = new MusicStoreDbContext())
            {
                var song = db.Songs.First(x => x.Id == id);
                song.Year = 190;

                MusicStoreClient.Update(id, song);
            }
        }

        private static void DeleteAlbum(int id)
        {
            MusicStoreClient.Delete<Album>(id);
        }

        private static void DeleteArtist(int id)
        {
            MusicStoreClient.Delete<Artist>(id);
        }

        private static void DeleteSong(int id)
        {
            MusicStoreClient.Delete<Song>(id);
        }
    }
}
