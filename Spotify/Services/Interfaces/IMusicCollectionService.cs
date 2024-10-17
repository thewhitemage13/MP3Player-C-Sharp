using Spotify.Entity;

namespace Spotify.Services.Interfaces
{
    /// <summary>
    /// Provides operations for managing <see cref="MusicCollection"/> entities.
    /// </summary>
    public interface IMusicCollectionService
    {
        MusicCollection GetMusicCollectionById(long id);
        List<MusicCollection> GetAllMusicCollections();
        void AddMusicCollection(MusicCollection musicCollection);
        void UpdateMusicCollection(MusicCollection musicCollection);
        void DeleteMusicCollection(long id);
    }
}
