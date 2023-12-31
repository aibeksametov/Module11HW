﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Vacancies
{
    Manager,
    Developer,
    Designer,
    Marketing
}
struct Employee
{
    public string Name;
    public Vacancies Vacancy;
    public int[] EDate; 
    public int Salary;
}

class Program
{
    static void Main()
    {
        Employee employee;
        employee.Name = "Aiba Samet";
        employee.Vacancy = Vacancies.Developer;
        employee.EDate = new int[] { 2018, 01, 05 }; 
        employee.Salary = 480000;

        Console.WriteLine($"Name: {employee.Name}");
        Console.WriteLine($"Vacancy: {employee.Vacancy}");
        Console.WriteLine($"Hire Date: {employee.EDate[0]}.{employee.EDate[1]}.{employee.EDate[2]}");
        Console.WriteLine($"Salary: {employee.Salary}");
    }
}
