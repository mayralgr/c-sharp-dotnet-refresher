// See https://aka.ms/new-console-template for more information
using GenericsPractice.Entities;
using GenericsPractice.Repositories;
using System;

Console.WriteLine("Hello, World!");

var employeeRepository = new EmployeeRepository();

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


employeeRepository.Save();

Console.ReadLine();
