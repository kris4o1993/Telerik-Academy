namespace MusicStore.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using MusicStore.Models;

    [DataContract(IsReference = true, Name = "Artist")]
    public class ArtistFullApi : ArtistApiModel
    {
        public ArtistFullApi(Artist artist)
            : base(artist)
        {
            if (artist != null)
            {
                if (artist.Albums != null)
                {
                    this.Albums = artist.Albums.Select(x => new AlbumApi(x)).ToList();                    
                }

                if (artist.Songs != null)
                {
                    this.Songs = artist.Songs.Select(x => new SongApi(x)).ToList();                    
                }
            }
        }

        [DataMember]
        public ICollection<AlbumApi> Albums { get; set; }
 
        [DataMember]
        public ICollection<SongApi> Songs { get; set; }

        public override string ToString()
        {
            var output = base.ToString();

            if (this.Albums != null)
            {
                output += string.Format(", Albums:[{0}]", string.Join(", ", this.Albums));
            }

            if (this.Songs != null)
            {
                output += string.Format(", Songs:[{0}]", string.Join(", ", this.Songs));
            }

            return output;
        }
    }
}