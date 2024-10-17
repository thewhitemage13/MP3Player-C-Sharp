using Spotify.CustomException;
using Spotify.Entity;
using Spotify.Repository.Interfaces;
using Spotify.Services.Interfaces;

namespace Spotify.Services
{
    /// <summary>
    /// Provides operations for managing <see cref="Radio"/> entities.
    /// </summary>
    public class RadioService : IRadioService
    {
        private readonly ICrudOperations<Radio> repository;
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioService"/> class.
        /// </summary>
        /// <param name="repository">The repository used for data access.</param>
        public RadioService(ICrudOperations<Radio> repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// Adds a new <see cref="Radio"/> entity.
        /// </summary>
        /// <param name="radio">The radio entity to add.</param>
        public void AddRadio(Radio radio)
        {
            repository.Add(radio);
        }
        /// <summary>
        /// Deletes a <see cref="Radio"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the radio to delete.</param>
        /// <exception cref="RadioNotFoundException">
        /// Thrown when a radio with the specified ID is not found.
        /// </exception>
        public void DeleteRadio(long id)
        {
            var radio = GetRadioById(id);
            repository.Delete(id);
        }
        /// <summary>
        /// Retrieves all <see cref="Radio"/> entities.
        /// </summary>
        /// <returns>A list of all radios.</returns>
        public List<Radio> GetAllRadios()
        {
            var radios = repository.GetAll();
            if (radios == null)
            {
                return null;
            }
            return radios;
        }
        /// <summary>
        /// Retrieves a <see cref="Radio"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the radio.</param>
        /// <returns>The <see cref="Radio"/> entity.</returns>
        /// <exception cref="RadioNotFoundException">
        /// Thrown when a radio with the specified ID is not found.
        /// </exception>
        public Radio GetRadioById(long id)
        {
            var radio = repository.GetById(id);
            if (radio == null)
            {
                throw new RadioNotFoundException($"Radio with ID {id} was not found.");
            }
            return radio;
        }
        /// <summary>
        /// Updates an existing <see cref="Radio"/> entity.
        /// </summary>
        /// <param name="radio">The radio entity with updated values.</param>
        public void UpdateRadio(Radio radio)
        {
            repository.Update(radio);
        }
    }
}
