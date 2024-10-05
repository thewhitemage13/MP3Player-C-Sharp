using Microsoft.EntityFrameworkCore;
using System.Net;
using System;
using Spotify.Entity;

namespace Spotify.DataBase
{
    internal class Context : DbContext
    {
        public Context()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=SpotifyCSharp;username=postgres;password=root");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>().Property(p => p.Name).IsRequired();

        //    modelBuilder.Entity<Department>().Property(p => p.Name).HasColumnName("Title");
        //}

        public DbSet<Performer> Performers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Radio> Radios { get; set; }
        public DbSet<MusicCollection> MusicCollections { get; set; }
    }
}