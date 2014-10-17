namespace MusicStore.Services
{
    using System;
    using System.Runtime.Serialization;
    using System.Text;
    using MusicStore.Models;

    [DataContract(IsReference = true, Name = "Song")]
    public class SongApiModel
    {
        public SongApiModel(Song song)
        {
            if (song != null)
            {
                this.Id = song.Id;
                this.Title = song.Title;
                this.Year = song.Year;
                this.Genre = song.Genre;
            }
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public int? Year { get; set; }

        [DataMember]
        public string Genre { get; set; }

        public override string ToString()
        {
            var output = string.Format("Id:{0}, Title:{1}, Year:{2}, Genre:{3}", this.Id, this.Title, this.Year, this.Genre);
            return output;
        }
    }
}