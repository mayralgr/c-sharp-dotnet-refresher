using GenericsPractice.Entities;
using System.Collections.Generic;

namespace GenericsPractice.Repositories
{
    public interface IReadRepository<out T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();

    }
    public interface IRepository<T>: IReadRepository<T> where T : IEntity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}