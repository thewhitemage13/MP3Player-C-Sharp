using Spotify.DataBase;
using Spotify.Entity;
using Spotify.Repository.Interfaces;

namespace Spotify.Repository
{
    /// <summary>
    /// Provides CRUD operations for <see cref="Performer"/> entities.
    /// </summary>
    public class PerformerRepository : ICrudOperations<Performer>
    {
        private readonly Context context;
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformerRepository"/> class.
        /// </summary>
        /// <param name="context">The database context to use for data operations.</param>
        public PerformerRepository(Context context)
        {
            this.context = context;
        }
        /// <summary>
        /// Retrieves a <see cref="Performer"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the performer.</param>
        /// <returns>The <see cref="Performer"/> entity that matches the specified identifier, or null if not found.</returns>
        public Performer GetById(long id)
        {
            return context.Performers.Find(id);
        }
        /// <summary>
        /// Retrieves all <see cref="Performer"/> entities.
        /// </summary>
        /// <returns>A list of all performers.</returns>
        public List<Performer> GetAll()
        {
            return context.Performers.ToList();
        }
        /// <summary>
        /// Adds a new <see cref="Performer"/> entity to the database.
        /// </summary>
        /// <param name="performer">The performer to add.</param>
        public void Add(Performer performer)
        {
            context.Performers.Add(performer);
            context.SaveChanges();
        }
        /// <summary>
        /// Updates an existing <see cref="Performer"/> entity in the database.
        /// </summary>
        /// <param name="performer">The performer with updated values.</param>
        public void Update(Performer performer)
        {
            context.Performers.Update(performer);
            context.SaveChanges();
        }
        /// <summary>
        /// Deletes a <see cref="Performer"/> entity from the database by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the performer to delete.</param>
        public void Delete(long id)
        {
            var performer = context.Performers.Find(id);
            if (performer != null)
            {
                context.Performers.Remove(performer);
                context.SaveChanges();
            }
        }
    }
}
