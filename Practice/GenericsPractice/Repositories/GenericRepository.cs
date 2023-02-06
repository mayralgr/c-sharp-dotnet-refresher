using GenericsPractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsPractice.Repositories
{
    public class GenericRepository<T> where T : EntityBase // Constraint for the T be of type ....
    {
        private readonly List<T> _items = new();
        public void Add(T item)
        {
            item.Id = _items.Any() ? _items.Max(item => item.Id) + 1 : 1; 
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public T GetById(int id)
        {
            return _items.Single(x => x.Id == id);
        }
    }
}
