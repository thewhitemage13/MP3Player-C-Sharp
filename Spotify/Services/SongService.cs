using Spotify.CustomException;
using Spotify.Entity;
using Spotify.Repository.Interfaces;
using Spotify.Services.Interfaces;

namespace Spotify.Services
{
    /// <summary>
    /// Service class to manage <see cref="Song"/> entities.
    /// </summary>
    public class SongService : ISongService
    {
        private readonly ICrudOperations<Song> repository;
        /// <summary>
        /// Initializes a new instance of the <see cref="SongService"/> class.
        /// </summary>
        /// <param name="repository">The repository used for CRUD operations.</param>
        public SongService(ICrudOperations<Song> repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// Gets a <see cref="Song"/> by its unique identifier.
        /// </summary>
        /// <param name="id">The ID of the song.</param>
        /// <returns>The <see cref="Song"/> entity.</returns>
        /// <exception cref="SongNotFoundException">
        /// Thrown when a song with the specified ID is not found.
        /// </exception>
        public Song GetSongById(long id)
        {
            var song = repository.GetById(id);
            if (song == null)
            {
                throw new SongNotFoundException($"Song with ID {id} was not found.");
            }
            return song;
        }
        /// <summary>
        /// Gets all songs.
        /// </summary>
        /// <returns>A list of all <see cref="Song"/> entities.</returns>
        public List<Song> GetAllSongs()
        {
            var list = repository.GetAll();
            if (list == null)
            {
                return null;
            }
            else
            {
                return repository.GetAll();
            }
        }
        /// <summary>
        /// Adds a new <see cref="Song"/> entity.
        /// </summary>
        /// <param name="song">The song to add.</param>
        public void AddSong(Song song)
        {
            repository.Add(song);
        }
        /// <summary>
        /// Updates an existing <see cref="Song"/> entity.
        /// </summary>
        /// <param name="song">The song entity with updated values.</param>
        public void UpdateSong(Song song)
        {
            repository.Update(song);
        }
        /// <summary>
        /// Deletes a <see cref="Song"/> entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the song to delete.</param>
        /// <exception cref="SongNotFoundException">
        /// Thrown when a song with the specified ID is not found.
        /// </exception>
        public void DeleteSong(long id)
        {
            var song = GetSongById(id);
            if (song == null)
            {
                throw new SongNotFoundException($"Song with ID {id} was not found.");
            }
            repository.Delete(id);
        }
    }
}
