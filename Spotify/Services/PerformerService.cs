namespace Spotify.Services
{
    using Spotify.CustomException;
    using Spotify.Entity;
    using Spotify.Repository.Interfaces;
    using Spotify.Services.Interfaces;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides operations for managing <see cref="Performer"/> entities.
    /// </summary>
    public class PerformerService : IPerformerService
    {
        private readonly ICrudOperations<Performer> repository;
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformerService"/> class.
        /// </summary>
        /// <param name="repository">The repository used for data access.</param>
        public PerformerService(ICrudOperations<Performer> repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// Retrieves a <see cref="Performer"/> by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the performer.</param>
        /// <returns>The <see cref="Performer"/> entity.</returns>
        /// <exception cref="PerformerNotFoundException">
        /// Thrown when a performer with the specified ID is not found.
        /// </exception>
        public Performer GetPerformerById(long id)
        {
            var performer = repository.GetById(id);
            if (performer == null)
            {
                throw new PerformerNotFoundException($"Performer with ID {id} was not found.");
            }
            return performer;
        }
        /// <summary>
        /// Retrieves all <see cref="Performer"/> entities.
        /// </summary>
        /// <returns>A list of all performers.</returns>
        public List<Performer> GetAllPerformers()
        {
            var performers = repository.GetAll();
            if(performers == null)
            {
                return null;
            }
            return performers;
        }
        /// <summary>
        /// Adds a new <see cref="Performer"/> entity.
        /// </summary>
        /// <param name="performer">The performer to add.</param>
        public void AddPerformer(Performer performer)
        {
            repository.Add(performer);
        }
        /// <summary>
        /// Updates an existing <see cref="Performer"/> entity.
        /// </summary>
        /// <param name="performer">The performer with updated values.</param>
        public void UpdatePerformer(Performer performer)
        {
            repository.Update(performer);
        }
        /// <summary>
        /// Deletes a <see cref="Performer"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the performer to delete.</param>
        public void DeletePerformer(long id)
        {
            var performer = GetPerformerById(id);
            repository.Delete(id);
        }
    }

}
