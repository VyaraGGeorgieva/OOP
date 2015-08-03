using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPRStructure.Characters;

namespace GPRStructure.Characters
{
    class Warrior : Character
    {
        private const int WarriorMana = 0;
        private const int WarriorHealth = 300;
        private const int WarriorDamage = 120;

        public Warrior() 
            : base(WarriorMana, WarriorHealth, WarriorDamage)
        {
        }
        
        public override void Attack(Character target)
        {
            this.Health -= this.Damage;
        }
    }
}
