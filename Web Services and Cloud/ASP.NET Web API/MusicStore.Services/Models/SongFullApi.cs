namespace MusicStore.Services
{
    using System.Runtime.Serialization;
    using System.Text;
    using MusicStore.Models;

    [DataContract(IsReference = true, Name = "Song")]
    public class SongFullApi : SongApiModel
    {
        public SongFullApi(Song song)
            : base(song)
        {
            if (song != null)
            {
                if (song.Album != null)
                {
                    this.Album = new AlbumApi(song.Album);                    
                }

                if (song.Artist != null)
                {
                    this.Artist = new ArtistApi(song.Artist);                    
                }
            }
        }

        [DataMember]
        public AlbumApi Album { get; private set; }

        [DataMember]
        public ArtistApi Artist { get; private set; }

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