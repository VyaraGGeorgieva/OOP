namespace CompanyHierarchy
{
    using System;
    using Utilities;
    using System.Collections.Generic;
    using People;
    class CompanyTester
    {
        static void Main()
        {
            var employees = new List<Person>()
            {
                new Manager(1, "Peter", "Marinov", 20000, Department.Production, 
                    new List<Employee>()
                    {
                        new Employee(12, "Mariya", "Marinova", 3000,Department.Production),
                        new Employee(13, "Vyara", "Georgieva", 4000, Department.Accounting),
                        new Employee(14, "Peter", "Petrov", 1400, Department.Sales)
                    }),
                new SalesEmployee(2, "Tom", "Tomov", 3000, Department.Marketing, new List<Sale>()
                {
                    new Sale("ChocoBar",DateTime.Now, 30),
                    new Sale("PhotoStripe",DateTime.Now, 400)
                }),

                new Developer(4, "Denis", "Buchel", 400000, Department.Marketing, new List<Project>()
                {
                    new Project("CSharpLab", DateTime.Now, "To be done", State.Open),
                    new Project("JaveDevMicro", DateTime.Now, "In process", State.Open)
                }),
                new Customer(2,"Tanya", "Buchel", 2000)
            };

            employees.ForEach(Console.WriteLine);
        }
    }
}
