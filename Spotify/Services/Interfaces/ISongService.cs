using Spotify.Entity;

namespace Spotify.Services.Interfaces
{
    /// <summary>
    /// Provides operations for managing <see cref="Song"/> entities.
    /// </summary>
    public interface ISongService
    {
        Song GetSongById(long id);
        List<Song> GetAllSongs();
        void AddSong(Song song);
        void UpdateSong(Song song);
        void DeleteSong(long id);
    }
}
