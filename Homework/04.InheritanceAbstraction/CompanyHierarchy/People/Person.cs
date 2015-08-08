

namespace CompanyHierarchy.People
{
    using System;
    using System.Text.RegularExpressions;
    using Interfaces;

    abstract class Person : IPerson
    {
        private int id;
        public string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value>0)
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value","The field must be a positive number!");
                }
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (IsValidName(value))
                {
                    this.firstName = value;
                }
                
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set {
                if (IsValidName(value))
                {
                    this.lastName = value;
                }
            }
        }

        public static bool IsValidName(string name)
        {
            if (Regex.IsMatch(name,"[a-zA-Z]{2,100}"))
            {
                return true;
            }
            throw new ArgumentException("Invalid name!");
        }

        public override string ToString()
        {
            string name = this.firstName +" "+ this.lastName;
            return string.Format("My name is {0} and I am a {1}", name, GetType().Name);
        }
    } 
}
