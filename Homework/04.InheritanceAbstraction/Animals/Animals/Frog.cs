using System;
using System.Collections.Generic;
using System.Linq;
namespace Animals.Animals
{
   public class Frog : Animal
    {
        public Frog(string name, double age, Gender gender) 
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "I say \"Qwak-Qwak!\"";
        }
    }
}
