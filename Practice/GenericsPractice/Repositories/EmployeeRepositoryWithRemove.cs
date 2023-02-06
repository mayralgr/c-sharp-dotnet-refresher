using GenericsPractice.Entities;

namespace GenericsPractice.Repositories
{
    /// <summary>
    /// Non generic class that inherits form a generic class with type employee
    /// </summary>
    public class EmployeeRepositoryWithRemove : GenericRepository<Employee>
    {
        public void Remove(Employee employee)
        {
            _items.Remove(employee);
        }

    }

}
