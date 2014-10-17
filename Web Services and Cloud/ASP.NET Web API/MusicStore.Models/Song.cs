namespace MusicStore.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int? Year { get; set; }

        public string Genre { get; set; }

        public virtual Album Album { get; set; }

        public virtual Artist Artist { get; set; }
    }
}