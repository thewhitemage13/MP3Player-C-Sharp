using Microsoft.EntityFrameworkCore;
using System.Net;
using System;
using Spotify.Entity;

namespace Spotify.DataBase
{
    /// <summary>
    /// Represents the database context for the Spotify application.
    /// This class derives from <see cref="DbContext"/> and provides access to the database.
    /// </summary>
    public class Context : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class.
        /// Ensures that the database is created when the context is instantiated.
        /// </summary>
        public Context()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        /// <summary>
        /// Configures the <see cref="DbContext"/> options.
        /// This method is called when the context is being configured.
        /// </summary>
        /// <param name="optionsBuilder">An options builder to configure the context.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=SpotifyCSharp;username=postgres;password=root");
        }
        /// <summary>
        /// Gets or sets the <see cref="DbSet{Performer}"/> for the performers in the database.
        /// </summary>
        public DbSet<Performer> Performers { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="DbSet{Song}"/> for the songs in the database.
        /// </summary>
        public DbSet<Song> Songs { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="DbSet{Radio}"/> for the radios in the database.
        /// </summary>
        public DbSet<Radio> Radios { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="DbSet{MusicCollection}"/> for the music collections in the database.
        /// </summary>
        public DbSet<MusicCollection> MusicCollections { get; set; }
    }
}