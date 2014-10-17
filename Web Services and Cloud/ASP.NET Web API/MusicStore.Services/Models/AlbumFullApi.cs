namespace MusicStore.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using MusicStore.Models;

    [DataContract(IsReference = true, Name = "Album")]
    public class AlbumFullApi : AlbumApiModel
    {
        public AlbumFullApi(Album album)
            : base(album)
        {
            if (album != null)
            {
                if (album.Artists != null)
                {
                    this.Artists = album.Artists.Select(x => new ArtistApi(x)).ToList();                    
                }

                if (album.Songs != null)
                {
                    this.Songs = album.Songs.Select(x => new SongApi(x)).ToList();                    
                }
            }
        }

        [DataMember]
        public ICollection<ArtistApi> Artists { get; private set; }

        [DataMember]
        public ICollection<SongApi> Songs { get; private set; }

        public override string ToString()
        {
            var output = base.ToString();

            if (this.Artists != null)
            {
                output += string.Format(", Artists:[{0}]", string.Join(", ", this.Artists));
            }

            if (this.Songs != null)
            {
                output += string.Format(", Songs:[{0}]", string.Join(", ", this.Songs));
            }

            return output;
        }
    }
}
