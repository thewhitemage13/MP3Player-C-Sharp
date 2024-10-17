using Spotify.DataBase;
using Spotify.Entity;
using Spotify.Repository.Interfaces;

namespace Spotify.Repository
{
    /// <summary>
    /// Provides CRUD operations for <see cref="Radio"/> entities.
    /// </summary>
    internal class RadioRepository : ICrudOperations<Radio>
    {
        private readonly Context context;
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioRepository"/> class.
        /// </summary>
        /// <param name="context">The database context to use for data operations.</param>
        public RadioRepository(Context context)
        {
            this.context = context;
        }
        /// <summary>
        /// Retrieves a <see cref="Radio"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the radio.</param>
        /// <returns>
        /// The <see cref="Radio"/> entity that matches the specified identifier, 
        /// or null if not found.
        /// </returns>
        public Radio GetById(long id)
        {
            return context.Radios.Find(id);
        }
        /// <summary>
        /// Retrieves all <see cref="Radio"/> entities.
        /// </summary>
        /// <returns>A list of all radios.</returns>
        public List<Radio> GetAll()
        {
            return context.Radios.ToList();
        }
        /// <summary>
        /// Adds a new <see cref="Radio"/> entity to the database.
        /// </summary>
        /// <param name="radio">The radio to add.</param>
        public void Add(Radio radio)
        {
            context.Radios.Add(radio);
            context.SaveChanges();
        }
        /// <summary>
        /// Updates an existing <see cref="Radio"/> entity in the database.
        /// </summary>
        /// <param name="radio">The radio with updated values.</param>
        public void Update(Radio radio)
        {
            context.Radios.Update(radio);
            context.SaveChanges();
        }
        /// <summary>
        /// Deletes a <see cref="Radio"/> entity from the database by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the radio to delete.</param>
        public void Delete(long id)
        {
            var radio = context.Radios.Find(id);
            if (radio != null)
            {
                context.Radios.Remove(radio);
                context.SaveChanges();
            }
        }
    }
}
