using Spotify.DataBase;
using Spotify.Entity;
using Spotify.Repository.Interfaces;
using System;

namespace Spotify.Repository
{
    /// <summary>
    /// Provides CRUD operations for <see cref="Song"/> entities.
    /// </summary>
    public class SongRepository : ICrudOperations<Song>
    {
        private readonly Context context;
        /// <summary>
        /// Initializes a new instance of the <see cref="SongRepository"/> class.
        /// </summary>
        /// <param name="context">The database context to use for data operations.</param>
        public SongRepository(Context context)
        {
            this.context = context;
        }
        /// <summary>
        /// Retrieves a <see cref="Song"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the song.</param>
        /// <returns>
        /// The <see cref="Song"/> entity that matches the specified identifier, 
        /// or null if not found.
        /// </returns>
        public Song GetById(long id)
        {
            return context.Songs.Find(id);
        }
        /// <summary>
        /// Retrieves all <see cref="Song"/> entities.
        /// </summary>
        /// <returns>A list of all songs.</returns>
        public List<Song> GetAll()
        {
            return context.Songs.ToList();
        }
        /// <summary>
        /// Adds a new <see cref="Song"/> entity to the database.
        /// </summary>
        /// <param name="song">The song to add.</param>
        public void Add(Song song)
        {
            context.Songs.Add(song);
            context.SaveChanges();
        }
        /// <summary>
        /// Updates an existing <see cref="Song"/> entity in the database.
        /// </summary>
        /// <param name="song">The song with updated values.</param>
        public void Update(Song song)
        {
            context.Songs.Update(song);
            context.SaveChanges();
        }
        /// <summary>
        /// Deletes a <see cref="Song"/> entity from the database by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the song to delete.</param>
        public void Delete(long id)
        {
            var song = context.Songs.Find(id);
            if (song != null)
            {
                context.Songs.Remove(song);
                context.SaveChanges();
            }
        }
    }
}
