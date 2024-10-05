using Spotify.Enums;
using System.ComponentModel.DataAnnotations;

namespace Spotify.Entity
{
    internal class MusicCollection
    {
        [Key]
        public long MusicCollectionId { get; set; }
        public string Name;
        public TypeOfCollection TypeOfCollection { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        public Performer Performer {  get; set; }
        [Required]
        public List<Song> Song {  get; set; }

        public MusicCollection() { }

        public MusicCollection(string name, TypeOfCollection typeOfCollection, DateTime releaseDate, Performer performer) 
        {
            Name = name;
            TypeOfCollection = typeOfCollection;
            ReleaseDate = releaseDate;
            Performer = performer;
            Song = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Song.Add(song);
        }
    }
}
