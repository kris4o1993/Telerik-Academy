namespace MusicStore.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using MusicStore.Models;

    [DataContract(IsReference = true, Name = "Album")]
    public class AlbumApi : AlbumApiModel
    {
        public AlbumApi(Album album)
            : base(album)
        {
            if (album != null)
            {
                if (album.Artists != null)
                {
                    this.Artists = album.Artists.Select(x => x.Name).ToList();                    
                }

                if (album.Songs != null)
                {
                    this.Songs = album.Songs.Select(x => x.Title).ToList();                    
                }
            }
        }

        [DataMember]
        public ICollection<string> Artists { get; private set; }

        [DataMember]
        public ICollection<string> Songs { get; private set; }

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
