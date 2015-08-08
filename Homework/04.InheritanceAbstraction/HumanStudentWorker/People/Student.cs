using System;

namespace HumanStudentWorker.People
{
    public class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length<5 || value.Length>10)
                {
                    throw new ArgumentOutOfRangeException("value","The faculty number should be not shorter that 5 chars and not longer than 10!");
                }
                else
                {
                     this.facultyNumber = value;
                }
                
            }
        }
    }
}
