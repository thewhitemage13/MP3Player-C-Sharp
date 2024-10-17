using Spotify.CustomException;
using Spotify.Entity;
using Spotify.Repository.Interfaces;
using Spotify.Services.Interfaces;

namespace Spotify.Services
{
    /// <summary>
    /// Provides operations for managing <see cref="MusicCollection"/> entities.
    /// </summary>
    public class MusicCollectionService : IMusicCollectionService
    {
        private readonly ICrudOperations<MusicCollection> repository;
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCollectionService"/> class.
        /// </summary>
        /// <param name="repository">The repository used for data access.</param>
        public MusicCollectionService(ICrudOperations<MusicCollection> repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// Retrieves a <see cref="MusicCollection"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the music collection.</param>
        /// <returns>The <see cref="MusicCollection"/> entity.</returns>
        /// <exception cref="MusicCollectionNotFoundException">
        /// Thrown when a music collection with the specified ID is not found.
        /// </exception>
        public MusicCollection GetMusicCollectionById(long id)
        {
            var collection = repository.GetById(id);
            if (collection == null)
            {
                throw new MusicCollectionNotFoundException($"Music Collection with ID {id} was not found.");
            }
            return collection;
        }
        /// <summary>
        /// Retrieves all <see cref="MusicCollection"/> entities.
        /// </summary>
        /// <returns>A list of all music collections.</returns>
        public List<MusicCollection> GetAllMusicCollections()
        {
            var mc = repository.GetAll();
            if(mc == null)
            {
                return null;
            }
            return mc;
        }
        /// <summary>
        /// Adds a new <see cref="MusicCollection"/> entity.
        /// </summary>
        /// <param name="collection">The music collection to add.</param>
        public void AddMusicCollection(MusicCollection collection)
        {
            repository.Add(collection);
        }
        /// <summary>
        /// Updates an existing <see cref="MusicCollection"/> entity.
        /// </summary>
        /// <param name="collection">The music collection with updated values.</param>
        public void UpdateMusicCollection(MusicCollection collection)
        {
            repository.Update(collection);
        }
        /// <summary>
        /// Deletes a <see cref="MusicCollection"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the music collection to delete.</param>
        public void DeleteMusicCollection(long id)
        {
            var collection = GetMusicCollectionById(id);
            repository.Delete(id);
        }
    }
}
