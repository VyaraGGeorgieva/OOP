using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRStructure.Characters
{
    class Mage : Character
    {
        private const int MageHealth = 100;
        private const int MageMana = 300;
        private const int MageDamage = 75;

        public Mage() 
            : base(MageMana, MageHealth, MageDamage)
        {
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            this.Health -= 2 * this.Damage;
        }
    }
}
