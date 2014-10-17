namespace MusicStore.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using MusicStore.Models;

    [DataContract(IsReference = true, Name = "Artist")]
    public class ArtistApi : ArtistApiModel
    {
        public ArtistApi(Artist artist)
            : base(artist)
        {
            if (artist != null)
            {
                if (artist.Albums != null)
                {
                    this.Albums = artist.Albums.Select(x => x.Title).ToList();                    
                }

                if (artist.Songs != null)
                {
                    this.Songs = artist.Songs.Select(x => x.Title).ToList();                    
                }
            }
        }

        [DataMember]
        public ICollection<string> Albums { get; private set; }

        [DataMember]
        public ICollection<string> Songs { get; private set; }

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