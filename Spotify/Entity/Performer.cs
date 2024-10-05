using Spotify.Enums;
using System.ComponentModel.DataAnnotations;

namespace Spotify.Entity
{
    internal class Performer
    {
        [Key]
        public long PerformerId { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required]
        public List<MusicCollection> MusicCollection {  get; set; }
        [Required]
        public List<Song> Songs { get; set; }

        public Performer() { }

        public Performer(string name, Genre genre)
        {
            Name = name;
            Genre = genre;
            MusicCollection = new List<MusicCollection>();
            Songs = new List<Song>();
        }

        public void AddMusicCollection(MusicCollection musicCollection)
        {
            MusicCollection.Add(musicCollection);
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }
    }
}
