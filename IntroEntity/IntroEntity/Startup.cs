﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IntroEntity.Models;

namespace IntroEntity
{
    class Startup
    {
        static void Main()
        {
            var context = new SoftuniContext();
            StringBuilder content = new StringBuilder();

            using (context)
            {
                // 3.	Employees Full Information

                // IEnumerable<Employee> employees = context.Employees;
                // 
                // foreach (Employee employee in employees)
                // {
                //     content.AppendLine(
                //         $"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary}");
                // }

                // 4.	Employees with Salary Over 50 000
                // var employees = context.Employees.Where(e => e.Salary > 50000)
                //     .Select(e => e.FirstName);
                // foreach (var employee in employees)
                // {
                //     content.AppendLine($"{employee}");
                // }

                // 5.	Employees from Research and Development
                // var employees = context.Employees.Where(e => e.Department.Name == "Research and Development")
                //     .OrderBy(e => e.Salary).ThenByDescending(e => e.FirstName);
                // foreach (var employee in employees)
                // {
                //     content.AppendLine($"{employee.FirstName} {employee.LastName} " +
                //                        $"from {employee.Department.Name} - ${employee.Salary:F2}");
                // }

                // 6.	Adding a New Address and Updating Employee
                // var address = new Address()
                // {
                //     AddressText = "Vitoshka 15",
                //     TownID = 4
                // };
                // var employee = context.Employees.First(e => e.LastName == "Nakov");
                // employee.Address = address;
                // context.SaveChanges();
                // 
                // var employeeAddresses = context.Employees.OrderByDescending(e => e.Address.AddressID).Take(10)
                //     .Select(e => e.Address.AddressText);
                // foreach (var employeeAddress in employeeAddresses)
                // {
                //     content.AppendLine($"{employeeAddress}");
                // }

                // 7.	Find Employees in Period
                // Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                // var employees = context.Employees
                //     .Where(e => e.Projects.Count(
                //                     project => project.StartDate.Year >= 2001 && project.StartDate.Year <= 2003) > 0)
                //     .Take(30);
                // foreach (var employee in employees)
                // {
                //     content.AppendLine($"{employee.FirstName} {employee.LastName} {employee.Manager.FirstName}");
                //     foreach (Project employeeProject in employee.Projects)
                //     {
                //         content.AppendLine(
                //             $"--{employeeProject.Name} {employeeProject.StartDate:M/d/yyyy hh:mm:ss tt} {employeeProject.EndDate:M/d/yyyy hh:mm:ss tt}");
                //     }
                // }

                // 8.	Addresses by Town Name 
                var addresses = context.Addresses.OrderByDescending(a => a.Employees.Count).ThenBy(a => a.Town.Name)
                    .Take(10);

                File.WriteAllText("../../Output.txt", content.ToString());
            }
        }
    }
}
