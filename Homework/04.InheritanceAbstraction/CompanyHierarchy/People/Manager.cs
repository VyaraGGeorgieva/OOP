namespace CompanyHierarchy.People
{
    using System.Collections.Generic;
    using Interfaces;
    using Utilities;

    class Manager:Employee, IManager
    {
        private List<Employee> employees; 

        public Manager(int id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees ) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        public override string ToString()
        {
            string result = string.Format("Manager: {0} {1}, ID: {2}, salary: {3}, department {4}, Employees: ", this.FirstName, this.LastName, this.Id, this.Salary, this.Department.ToString());
            foreach (var employee in this.Employees)
            {
                result += "First name: " + employee.FirstName + "\n" +
                          "Last name: " + employee.LastName + "\n" +
                          "Id: " + employee.Id + "\n" +
                          "Salary:" + employee.Salary + "\n";
            }
            result += "\n";
            return result;
        }
    }
}
