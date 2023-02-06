using GenericsPractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsPractice.Repositories
{
    /// <summary>
    /// When defined with entitybase, that is a referenced type
    /// when defined with IEntity it can be a value type or a reference type, which means cannot return null, because it can be a non nullable VALUE type and should use default(T)
    /// class and class? constraint define it is a reference type and can return null
    /// </summary>
    public class ListRepository<T> where T : IEntity 
        // Constraint for the T be a class, T be of type .... and new, should be the last constraint and indicated the value of T needs a parameterless constructor
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
