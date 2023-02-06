using GenericsPractice.Entities;

namespace GenericsPractice.Repositories
{
    /// <summary>
    /// generic class that inherits form a generic class.
    /// </summary>
    public class GenericRepositoryWithRemove<T> : GenericRepository<T, string>
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }

    }

}
