using GenericsPractice.Entities;
using System.Collections.Generic;

namespace GenericsPractice.Repositories
{
    public interface IReadRepository<out T> // covariant
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    public interface IWriteRepository<in T> // Contravariant
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }

    public interface IRepository<T>: IReadRepository<T>, IWriteRepository<T> 
        where T : IEntity
    {
    }

}