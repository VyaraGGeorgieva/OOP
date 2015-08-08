namespace HumanStudentWorker.People
{
    public abstract class Human
    {

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string  FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("My name is {0} {1} and I'm a {2}", this.FirstName, this.LastName, GetType().Name);
        }

       
    }
}
