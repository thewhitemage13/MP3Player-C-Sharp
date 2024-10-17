using Spotify.Entity;
using Spotify.Repository.Interfaces;
using Spotify.Repository;
using System;

namespace Spotify.DataBase
{
    /// <summary>
    /// Represents a unit of work for managing database operations.
    /// This class provides an abstraction for working with multiple repositories.
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        private readonly Context context;
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="context">The database context to be used with the unit of work.</param>
        public UnitOfWork(Context context)
        {
            this.context = context;
            Songs = new SongRepository(context);
            Performers = new PerformerRepository(context);
            MusicCollections = new MusicCollectionRepository(context);
            Radios = new RadioRepository(context);
        }
        /// <summary>
        /// Gets the repository for managing <see cref="Song"/> entities.
        /// </summary>
        public ICrudOperations<Song> Songs { get; }
        /// <summary>
        /// Gets the repository for managing <see cref="Performer"/> entities.
        /// </summary>
        public ICrudOperations<Performer> Performers { get; }
        /// <summary>
        /// Gets the repository for managing <see cref="MusicCollection"/> entities.
        /// </summary>
        public ICrudOperations<MusicCollection> MusicCollections { get; }
        /// <summary>
        /// Gets the repository for managing <see cref="Radio"/> entities.
        /// </summary>
        public ICrudOperations<Radio> Radios { get; }
        /// <summary>
        /// Releases the resources used by the <see cref="UnitOfWork"/> class.
        /// </summary>
        public void Dispose()
        {
            context.Dispose();
        }
    }

}
