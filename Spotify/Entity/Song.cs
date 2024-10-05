using Spotify.Enums;
using System.ComponentModel.DataAnnotations;

namespace Spotify.Entity
{
    internal class Song
    {
        [Key]
        public long SongId { get; set; }
        public string Name { get; set; }
        public TypeOfSong TypeOfSong { get; set; }
        public int Duration { get; set; }
        public string FilePath { get; set; }
        public Genre Genre { get; set; }
        public Performer Performer { get; set; }

        public Song() {}

        public Song(string name, TypeOfSong typeOfSong, int duration, string filePath, Genre genre)
        {
            Name = name;
            TypeOfSong = typeOfSong;
            Duration = duration;
            FilePath = filePath;
            Genre = genre;
        }
    }
}
