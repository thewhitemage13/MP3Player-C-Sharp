using Spotify.Enums;
using System.ComponentModel.DataAnnotations;

namespace Spotify.Entity
{
    /// <summary>
    /// Represents a song in the Spotify application.
    /// This class contains information about the song, including its name, type, duration, file path, genre, performer, and upload date.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Gets or sets the unique identifier for the song.
        /// </summary>
        [Key]
        public long SongId { get; set; }
        /// <summary>
        /// Gets or sets the name of the song.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the type of the song.
        /// </summary>
        public TypeOfSong TypeOfSong { get; set; }
        /// <summary>
        /// Gets or sets the duration of the song in seconds.
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// Gets or sets the file path of the song.
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// Gets or sets the genre of the song.
        /// </summary>
        public Genre Genre { get; set; }
        /// <summary>
        /// Gets or sets the performer of the song.
        /// </summary>
        public Performer Performer { get; set; }
        /// <summary>
        /// Gets or sets the date when the song was uploaded.
        /// </summary>
        public DateTime UploadedTo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class.
        /// </summary>
        public Song() {}
        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the song.</param>
        /// <param name="typeOfSong">The type of the song.</param>
        /// <param name="duration">The duration of the song in seconds.</param>
        /// <param name="filePath">The file path of the song.</param>
        /// <param name="genre">The genre of the song.</param>
        /// <param name="uploadedTo">The date when the song was uploaded.</param>
        public Song(string name, TypeOfSong typeOfSong, int duration, string filePath, Genre genre, DateTime uploadedTo)
        {
            Name = name;
            TypeOfSong = typeOfSong;
            Duration = duration; 
            FilePath = filePath;
            Genre = genre;
            UploadedTo = uploadedTo;
        }
        /// <summary>
        /// Returns a string that represents the current song with detailed information.
        /// </summary>
        /// <returns>A string containing the name, type, duration, genre, and performer.</returns>
        public override string ToString()
        {
            // Форматируем строку с нужной информацией
            string performerName = Performer != null ? Performer.Name : "Unknown Performer";
            return $"{Name} - {TypeOfSong}, Duration: {Duration} sec, Genre: {Genre}, Performer: {performerName}";
        }
    }
}
