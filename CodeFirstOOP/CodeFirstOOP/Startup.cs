namespace CodeFirstOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Startup
    {
        static void Main()
        {
            //// 1.	Define a class Person
            //Person pesho = new Person() { Name = "Pesho", Age = 20 };
            //Person gosho = new Person();
            //gosho.Name = "Gosho";
            //gosho.Age = 18;

            //Person stamat = new Person();
            //stamat.Name = "Stamat";
            //stamat.Age = 43;

            //Console.WriteLine($"{pesho.Name} {pesho.Age}");
            //Console.WriteLine($"{gosho.Name} {gosho.Age}");
            //Console.WriteLine($"{stamat.Name} {stamat.Age}");

            //// 2.	Create Person Constructors
            //string[] inputArgs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            //if (inputArgs.Length == 0)
            //{
            //    Person p = new Person();
            //    Console.WriteLine($"{p.Name} {p.Age}");
            //}
            //else if (inputArgs.Length == 1)
            //{
            //    string argument = inputArgs[0];
            //    int age = -1;

            //    if (int.TryParse(argument, out age))
            //    {
            //        Person p = new Person(age);
            //        Console.WriteLine($"{p.Name} {p.Age}");
            //    }
            //    else
            //    {
            //        Person p = new Person(argument);
            //        Console.WriteLine($"{p.Name} {p.Age}");
            //    }
            //}
            //else if (inputArgs.Length == 2)
            //{
            //    string name = inputArgs[0];
            //    int age = int.Parse(inputArgs[1]);
            //    Person p = new Person(name, age);
            //    Console.WriteLine($"{p.Name} {p.Age}");
            //}

            //// 3.	Oldest Family Member
            //int numberOfMembers = int.Parse(Console.ReadLine());
            //Family inputFamily = new Family();
            //for (int i = 0; i < numberOfMembers; i++)
            //{
            //    string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //    Person member = new Person() {Name = input[0], Age = int.Parse(input[1]) };
            //    inputFamily.AddMember(member);
            //}

            //Person oldestOne = inputFamily.GetOldestPerson();
            //Console.WriteLine($"{oldestOne.Name} {oldestOne.Age}");

            //// 4.	Students
            //string inputStudent = Console.ReadLine();

            //while (inputStudent != "End")
            //{
            //    Student st = new Student(inputStudent);
            //    inputStudent = Console.ReadLine();
            //}

            //Console.WriteLine(Student.count);

            //// 5.	Planck Constant
            //Calculation.ReducedPlanck();

            // 6.	Math Utilities
            var input = Console.ReadLine();

            while (input != "End")
            {
                var command = input.Split(' ');
                var method = command[0];
                var a = double.Parse(command[1]);
                var b = double.Parse(command[2]);

                switch (method)
                {
                    case "Sum":
                        Console.WriteLine($"{MathUtil.Sum(a, b):F2}");
                        break;
                    case "Subtract":
                        Console.WriteLine($"{MathUtil.Subtract(a, b):F2}");
                        break;
                    case "Multiply":
                        Console.WriteLine($"{MathUtil.Multiply(a, b):F2}");
                        break;
                    case "Divide":
                        Console.WriteLine($"{MathUtil.Divide(a, b):F2}");
                        break;
                    case "Percentage":
                        Console.WriteLine($"{MathUtil.Percentage(a, b):F2}");
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
