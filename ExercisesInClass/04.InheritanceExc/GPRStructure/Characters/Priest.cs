using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPRStructure.Characters;
using GPRStructure.Interfaces;

namespace GPRStructure.Characters
{
    class Priest : Character, IHeal
    {
        private const int PriestMana = 200;
        private const int PriestHealth = 125;
        private const int PriestDamage = 100;
        public Priest() 
            : base(PriestMana, PriestHealth, PriestDamage)
        {
        }

        public override void Attack(Character target)
        {
            this.Mana = -100;
            target.Health -= PriestDamage;
            this.Health += PriestDamage/10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            this.Health += 150;
        }
    }
}
