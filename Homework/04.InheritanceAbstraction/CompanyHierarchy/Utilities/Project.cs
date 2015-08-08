using System;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Utilities
{
    class Project :IProject
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private State state;

        public Project(string projectName, DateTime startDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (Regex.IsMatch(value, "[a-zA-Z]{2,100}"))
                {
                    this.projectName = value;
                }
                else
                {
                    throw new ArgumentException("The Project's name should consist of not less than 2 and not more than 20 symbols");
                }
                
                
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }
        public State State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void CloseProject()
        {
            this.State= State.Close;
        }
    }
}
