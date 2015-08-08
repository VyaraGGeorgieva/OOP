using System;
using System.Collections.Generic;
using System.Linq;
namespace Animals.Animals.Cats
{
    public abstract class Cat : Animal
    {
        protected Cat(string name, double age, Gender gender) 
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "I say \"Miau!\"";
        }
    }
}
