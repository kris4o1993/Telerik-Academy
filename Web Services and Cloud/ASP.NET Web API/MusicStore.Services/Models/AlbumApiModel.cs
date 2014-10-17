namespace MusicStore.Services
{
    using System.Runtime.Serialization;
    using MusicStore.Models;

    [DataContract(IsReference = true, Name = "Album")]
    public abstract class AlbumApiModel
    {
        protected AlbumApiModel(Album album)
        {
            if (album != null)
            {
                this.Id = album.Id;
                this.Title = album.Title;
                this.Year = album.Year;
                this.Producer = album.Producer;
            }
        }

        [DataMember]
        public int Id { get; private set; }

        [DataMember]
        public string Title { get; private set; }

        [DataMember]
        public int? Year { get; private set; }

        [DataMember]
        public string Producer { get; private set; }

        public override string ToString()
        {
            var output = string.Format("Id:{0}, Title:{1}, Year:{2}, Producer:{3}", this.Id, this.Title, this.Year, this.Producer);
            return output;
        }
    }
}