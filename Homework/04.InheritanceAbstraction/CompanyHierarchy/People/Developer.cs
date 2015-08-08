using System.Runtime.Remoting.Messaging;
using System.Xml;

namespace CompanyHierarchy.People
{
    using System.Collections.Generic;
    using Interfaces;
    using Utilities;

    class Developer :RegularEmployee, IDeveloper
    {
        private List<Project> projects; 
        public Developer(int id, string firstName, string lastName, decimal salary, Department department, List<Project> projects ) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }

        public override string ToString()
        {
            string result = string.Format("Developer: {0} {1}, ID: {2}, salary: {3}, department:  {4}\n, Projects: ",this.FirstName, this.LastName, this.Id, this.Salary, this.Department.ToString());
            foreach (var project in this.Projects)
            {
                result += "Project name: " + project.ProjectName + "\n"+
                          "Start date: " + project.StartDate + "\n" +
                          "Details: " + project.Details + "\n" +
                          "State: " + project.State +"\n";

            }
            result += "\n";
            return result;
        }
    }
}
