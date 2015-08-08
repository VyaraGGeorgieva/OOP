using System;
using Animals.Functions;

namespace Animals.Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string _name;
        private double _age;
        

        protected Animal(string name, double age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value","The name must consist of at least two symbols!");
                }
                this._name = value;
            }
        }

        public double Age
        {
            get { return this._age; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("value","The age cannot be a negative number!");
                }
                this._age = value;
            }
        }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return string.Format("My name is {0}, I am {1} years old and I am a {2}", this.Name, this.Age, this.GetType().Name);
        }

        public abstract string ProduceSound();
        
    }
}
