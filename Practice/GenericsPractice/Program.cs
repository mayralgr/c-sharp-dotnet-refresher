﻿// See https://aka.ms/new-console-template for more information
using GenericsPractice.Entities;
using GenericsPractice.Repositories;
using System;

Console.WriteLine("Hello, World!");

var employeeRepository = new GenericRepository<Employee>();

AddEmployees(employeeRepository);
GetEmployeeById(employeeRepository);


var organizationRepository = new GenericRepository<Organization>();

AddOrganizations(organizationRepository);

Console.ReadLine();

static void AddEmployees(GenericRepository<Employee> employeeRepository)
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

static void AddOrganizations(GenericRepository<Organization> organizationRepository)
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

static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
}