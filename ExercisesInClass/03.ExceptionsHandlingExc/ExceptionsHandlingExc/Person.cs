using System;


namespace ExceptionsHandlingExc
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string  FirstName 
        { 
            get 
            {
                return this.firstName;
            } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The first name can't be skipped!");
                }
                    this.firstName = value;
            }  
        }

        public string  LastName 
        { 
            get 
            {
                return this.lastName;
            } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The last name cannot be skipped!");
                }
                this.lastName = value;
            }  
        }

        public int  Age 
        { 
            get 
            {
                return this.age;
            } 
            set 
            {
                if (value<0 || value >120)
                {
                    throw new ArgumentOutOfRangeException("value", "The age must be between 1 and 120!");
                }
                this.age = value;
            }  
        }
    }
}
