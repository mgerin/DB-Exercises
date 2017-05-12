using System;
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
                // var addresses = context.Addresses.OrderByDescending(a => a.Employees.Count).ThenBy(a => a.Town.Name)
                //     .Take(10);
                // 
                // foreach (Address address in addresses)
                // {
                //     content.AppendLine(
                //         $"{address.AddressText}, {address.Town.Name} - {address.Employees.Count} employees");
                // }

                // 9.	Employee with id 147
                // var employee = context.Employees.Find(147);
                // var projects = employee.Projects.OrderBy(p => p.Name);
                // 
                // content.AppendLine($"{employee.FirstName} {employee.LastName} {employee.JobTitle}");
                // foreach (Project project in projects)
                // {
                //     content.AppendLine(project.Name);
                // }

                // 10.	Departments with more than 5 employees
                // var departments = context.Departments.Where(d => d.Employees.Count > 5).OrderBy(d => d.Employees.Count);
                // 
                // foreach (Department department in departments)
                // {
                //     content.AppendLine($"{department.Name} {department.Employee.FirstName}");
                //     foreach (Employee departmentEmployee in department.Employees)
                //     {
                //         content.AppendLine(
                //             $"{departmentEmployee.FirstName} {departmentEmployee.LastName} {departmentEmployee.JobTitle}");
                //     }
                // }

                // 11.	Find Latest 10 Projects
                // Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                // var latestProjects = context.Projects.OrderByDescending(p => p.StartDate).Take(10).OrderBy(p => p.Name);
                // 
                // foreach (Project latestProject in latestProjects)
                // {
                //     content.AppendLine(
                //         $"{latestProject.Name} {latestProject.Description} {latestProject.StartDate} {latestProject.EndDate}");
                // }

                // 12.	Increase Salaries
                // 
                // var employees =
                //     context.Employees.Where(e => e.Department.Name == "Engineering" ||
                //                                  e.Department.Name == "Tool Design" ||
                //                                  e.Department.Name == "Marketing" ||
                //                                  e.Department.Name == "Information Services");
                // foreach (Employee employee in employees)
                // {
                //     employee.Salary *= 1.12m;
                //     content.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary})");
                // }
                //
                // context.SaveChanges();

                // 13.	Find Employees by First Name Starting with ‘SA’

                string pattern = "SA";
                var employees = context.Employees.Where(e => e.FirstName.StartsWith(pattern));
                foreach (Employee employee in employees)
                {
                    content.AppendLine($"{employee.FirstName} {employee.LastName} " +
                                       $"- {employee.JobTitle} - (${employee.Salary})");
                }

                File.WriteAllText("../../Output.txt", content.ToString());
            }
        }
    }
}
