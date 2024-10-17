using Spotify.DataBase;
using Spotify.Entity;
using Spotify.Repository.Interfaces;
using System;

namespace Spotify.Repository
{
    /// <summary>
    /// Provides CRUD operations for <see cref="MusicCollection"/> entities.
    /// </summary>
    public class MusicCollectionRepository : ICrudOperations<MusicCollection>
    {
        private readonly Context context;
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCollectionRepository"/> class.
        /// </summary>
        /// <param name="context">The database context to use for data operations.</param>
        public MusicCollectionRepository(Context context)
        {
            this.context = context;
        }
        /// <summary>
        /// Retrieves a <see cref="MusicCollection"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the music collection.</param>
        /// <returns>The <see cref="MusicCollection"/> entity that matches the specified identifier, or null if not found.</returns>
        public MusicCollection GetById(long id)
        {
            return context.MusicCollections.Find(id);
        }
        /// <summary>
        /// Retrieves all <see cref="MusicCollection"/> entities.
        /// </summary>
        /// <returns>A list of all music collections.</returns>
        public List<MusicCollection> GetAll()
        {
            return context.MusicCollections.ToList();
        }
        /// <summary>
        /// Adds a new <see cref="MusicCollection"/> entity to the database.
        /// </summary>
        /// <param name="musicCollection">The music collection to add.</param>
        public void Add(MusicCollection musicCollection)
        {
            context.MusicCollections.Add(musicCollection);
            context.SaveChanges();
        }
        /// <summary>
        /// Updates an existing <see cref="MusicCollection"/> entity in the database.
        /// </summary>
        /// <param name="musicCollection">The music collection with updated values.</param>

        public void Update(MusicCollection musicCollection)
        {
            context.MusicCollections.Update(musicCollection);
            context.SaveChanges();
        }
        /// <summary>
        /// Deletes a <see cref="MusicCollection"/> entity from the database by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the music collection to delete.</param>

        public void Delete(long id)
        {
            var musicCollection = context.MusicCollections.Find(id);
            if (musicCollection != null)
            {
                context.MusicCollections.Remove(musicCollection);
                context.SaveChanges();
            }
        }
    }
}
