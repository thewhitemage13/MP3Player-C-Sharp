using Spotify.Enums;
using System.ComponentModel.DataAnnotations;

namespace Spotify.Entity
{
    /// <summary>
    /// Represents a music collection in the Spotify application.
    /// This class contains information about the collection, including its name, type, release date, performer, and songs.
    /// </summary>
    public class MusicCollection
    {
        /// <summary>
        /// Gets or sets the unique identifier for the music collection.
        /// </summary>
        [Key]
        public long MusicCollectionId { get; set; }
        /// <summary>
        /// Gets or sets the name of the music collection.
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Gets or sets the type of the music collection.
        /// </summary>
        public TypeOfCollection TypeOfCollection { get; set; }
        /// <summary>
        /// Gets or sets the release date of the music collection.
        /// </summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// Gets or sets the performer associated with the music collection.
        /// This property is required.
        /// </summary>
        [Required]
        public Performer Performer {  get; set; }
        /// <summary>
        /// Gets or sets the list of songs in the music collection.
        /// This property is required.
        /// </summary>
        [Required]
        public List<Song> Songs {  get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCollection"/> class.
        /// </summary>
        public MusicCollection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCollection"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the music collection.</param>
        /// <param name="typeOfCollection">The type of the music collection.</param>
        /// <param name="releaseDate">The release date of the music collection.</param>
        /// <param name="performer">The performer associated with the music collection.</param>
        public MusicCollection(string name, TypeOfCollection typeOfCollection, DateTime releaseDate, Performer performer) 
        {
            Name = name;
            TypeOfCollection = typeOfCollection;
            ReleaseDate = releaseDate;
            Performer = performer;
            Songs = new List<Song>();
        }
        /// <summary>
        /// Adds a song to the music collection.
        /// </summary>
        /// <param name="song">The song to add to the collection.</param>
        public void AddSong(Song song)
        {
            Songs.Add(song);
        }
        /// <summary>
        /// Returns a string that represents the current music collection.
        /// </summary>
        /// <returns>A string containing details about the music collection.</returns>
        public override string ToString()
        {
            string songCount = Songs.Count > 0 ? $"{Songs.Count} song(s)" : "No songs";
            return $"Music Collection: {Name}\nType: {TypeOfCollection}\nReleased: {ReleaseDate.ToShortDateString()}\nPerformer: {Performer.Name}\nSongs: {songCount}";
        }
    }
}
