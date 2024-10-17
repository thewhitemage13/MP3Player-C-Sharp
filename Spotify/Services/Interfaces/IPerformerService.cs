using Spotify.Entity;

namespace Spotify.Services.Interfaces
{
    /// <summary>
    /// Provides operations for managing <see cref="Performer"/> entities.
    /// </summary>
    public interface IPerformerService
    {
        Performer GetPerformerById(long id);
        List<Performer> GetAllPerformers();
        void AddPerformer(Performer performer);
        void UpdatePerformer(Performer performer);
        void DeletePerformer(long id);
    }
}
