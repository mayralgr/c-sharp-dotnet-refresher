// See https://aka.ms/new-console-template for more information
using GenericsPractice.Data;
using GenericsPractice.Entities;
using GenericsPractice.Repositories;
using System;

Console.WriteLine("Hello, World!");

var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());

AddEmployees(employeeRepository);
AddManagers(employeeRepository);

GetEmployeeById(employeeRepository);

WriteAllToConsole(employeeRepository);

var organizationRepository = new ListRepository<Organization>();

AddOrganizations(organizationRepository);
WriteAllToConsole(organizationRepository);
Console.ReadLine();

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee
    {
        FirstName = "Some name",
    });


    employeeRepository.Add(new Employee
    {
        FirstName = "Some OTHER",
    });


    employeeRepository.Add(new Employee
    {
        FirstName = "NAME",
    });


    employeeRepository.Save();
}

static void AddOrganizations(IRepository<Organization> organizationRepository)
{
    organizationRepository.Add(new Organization
    {
        FirstName = "Org 1",
    });

    var org2 = new Organization
    {
        FirstName = "Org 3"
    };
    organizationRepository.Add(org2);

    organizationRepository.Add(new Organization
    {
        FirstName = "Org 33",
    });

    organizationRepository.Save();
}

static void GetEmployeeById(IRepository<Employee> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    foreach (var item in repository.GetAll())
    {
        Console.WriteLine(item);
    }
}


static void AddManagers(IWriteRepository<Manager> managerRepository)
{
    //employeeRepository.Add(new Employee());
    managerRepository.Add(new Manager { FirstName = "Sara" });
    managerRepository.Add(new Manager { FirstName = "Henry" });
    managerRepository.Save();
}