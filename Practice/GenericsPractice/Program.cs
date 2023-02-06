// See https://aka.ms/new-console-template for more information
using GenericsPractice.Entities;
using GenericsPractice.Repositories;
using System;

Console.WriteLine("Hello, World!");

var employeeRepository = new GenericRepository<Employee>();

employeeRepository.Add(new Employee
{
    Id = 1,
    FirstName = "Some name",
});


employeeRepository.Add(new Employee
{
    Id = 3,
    FirstName = "Some OTHER",
});


employeeRepository.Add(new Employee
{
    Id = 3,
    FirstName = "NAME",
});

var organizationRepository = new GenericRepository<Organization>();

organizationRepository.Add(new Organization
{
    Id = 1,
    FirstName = "Org 1",
});


organizationRepository.Add(new Organization
{
    Id = 3,
    FirstName = "Org 3",
});


organizationRepository.Add(new Organization
{
    Id = 3,
    FirstName = "Org 33",
});



employeeRepository.Save();
organizationRepository.Save();

Console.ReadLine();
