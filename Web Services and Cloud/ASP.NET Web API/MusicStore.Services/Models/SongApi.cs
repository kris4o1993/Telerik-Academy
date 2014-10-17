namespace MusicStore.Services
{
    using System.Runtime.Serialization;
    using System.Text;
    using MusicStore.Models;

    [DataContract(IsReference = true, Name = "Song")]
    public class SongApi : SongApiModel
    {
        public SongApi(Song song)
            : base(song)
        {
            if (song != null)
            {
                if (song.Album != null)
                {
                    this.Album = song.Album.Title;                    
                }

                if (song.Artist != null)
                {
                    this.Artist = song.Artist.Name;                    
                }
            }
        }

        [DataMember]
        public string Album { get; set; }

        [DataMember]
        public string Artist { get; set; }

        public override string ToString()
        {
            var output = base.ToString();

            if (this.Album != null)
            {
                output += string.Format(", Album:[{0}]", this.Album);
            }

            if (this.Artist != null)
            {
                output += string.Format(", Artist:[{0}]", this.Artist);
            }

            return output;
        }
    }
}