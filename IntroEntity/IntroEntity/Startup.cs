using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

                IEnumerable<Employee> employees = context.Employees;

                foreach (Employee employee in employees)
                {
                    content.AppendLine(
                        $"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary}");
                }

                File.WriteAllText("../../Output.txt", content.ToString());
            }
        }
    }
}
