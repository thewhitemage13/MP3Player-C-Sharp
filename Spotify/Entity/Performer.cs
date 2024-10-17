using Spotify.Enums;
using System.ComponentModel.DataAnnotations;

namespace Spotify.Entity
{
    /// <summary>
    /// Represents a music performer in the Spotify application.
    /// This class contains information about the performer, including their name, genre, and associated music collections and songs.
    /// </summary>
    public class Performer
    {
        /// <summary>
        /// Gets or sets the unique identifier for the performer.
        /// </summary>
        [Key]
        public long PerformerId { get; set; }
        /// <summary>
        /// Gets or sets the name of the performer.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the genre of the performer.
        /// </summary>
        public Genre Genre { get; set; }
        /// <summary>
        /// Gets or sets the list of music collections associated with the performer.
        /// This property is required.
        /// </summary>
        [Required]
        public List<MusicCollection> MusicCollection {  get; set; }
        /// <summary>
        /// Gets or sets the list of songs associated with the performer.
        /// This property is required.
        /// </summary>
        [Required]
        public List<Song> Songs { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Performer"/> class.
        /// </summary>
        public Performer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Performer"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the performer.</param>
        /// <param name="genre">The genre of the performer.</param>
        public Performer(string name, Genre genre)
        {
            Name = name;
            Genre = genre;
            MusicCollection = new List<MusicCollection>();
            Songs = new List<Song>();
        }
        /// <summary>
        /// Adds a music collection to the performer's list of music collections.
        /// </summary>
        /// <param name="musicCollection">The music collection to add.</param>
        public void AddMusicCollection(MusicCollection musicCollection)
        {
            MusicCollection.Add(musicCollection);
        }
        /// <summary>
        /// Adds a song to the performer's list of songs.
        /// </summary>
        /// <param name="song">The song to add.</param>
        public void AddSong(Song song)
        {
            Songs.Add(song);
        }
        /// <summary>
        /// Returns a string that represents the current performer with detailed information.
        /// </summary>
        /// <returns>A detailed string representation of the performer.</returns>
        public override string ToString()
        {
            // Проверяем на null перед обращением к свойству Name
            string performerName = Name ?? "Unknown Performer";
            string genreInfo = Genre != null ? Genre.ToString() : "Unknown Genre";

            string musicCollectionInfo = MusicCollection != null && MusicCollection.Count > 0
                ? $"{MusicCollection.Count} Music Collection(s)"
                : "No Music Collections";

            string songInfo = Songs != null && Songs.Count > 0
                ? $"{Songs.Count} Song(s)"
                : "No Songs";

            return $"Performer: {performerName}\nGenre: {genreInfo}\n{musicCollectionInfo}\n{songInfo}";
        }
    }
}
