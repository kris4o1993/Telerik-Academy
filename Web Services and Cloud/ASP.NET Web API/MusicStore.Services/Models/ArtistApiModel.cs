namespace MusicStore.Services
{
    using System;
    using System.Runtime.Serialization;
    using MusicStore.Models;

    [DataContract(IsReference = true, Name = "Artist")]
    public class ArtistApiModel
    {
        public ArtistApiModel(Artist artist)
        {
            if (artist != null)
            {
                this.Id = artist.Id;
                this.Name = artist.Name;
                this.Country = artist.Country;
                this.DateOfBirth = artist.DateOfBirth;
            }
        }

        [DataMember]
        public int Id { get; private set; }

        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public string Country { get; private set; }

        [DataMember]
        public DateTime? DateOfBirth { get; private set; }

        public override string ToString()
        {
            var output = string.Format("Id:{0}, Name:{1}, Country:{2}, DateOfBirth:{3}", this.Id, this.Name, this.Country, this.DateOfBirth);
            return output;
        }
    }
}