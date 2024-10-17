namespace Spotify.Repository.Interfaces
{
    /// <summary>
    /// Defines the standard CRUD (Create, Read, Update, Delete) operations for a given entity type.
    /// </summary>
    /// <typeparam name="T">The type of entity the CRUD operations will be applied to.</typeparam>
    public interface ICrudOperations<T>
    {
        T GetById(long id);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(long id);
    }
}
