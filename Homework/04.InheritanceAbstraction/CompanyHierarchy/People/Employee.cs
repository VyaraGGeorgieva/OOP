

using System;
using CompanyHierarchy.Utilities;

namespace CompanyHierarchy.People
{
    using CompanyHierarchy.Interfaces;

    class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Department = department;
            this.Salary = salary;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value > 0)
                {
                    this.salary = value;
                }
                else
                {
                     throw new ArgumentException("The field must be a positive number");
                }
            }
        }

        public Department Department { 
            get { return this.department; }
            set { this.department = value; } 
        }

        
    }
}
