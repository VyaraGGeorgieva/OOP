using System;
using GPRStructure.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRStructure.Characters
{
   public abstract class Character : IAttack
   {
       private int mana;
       private int health;
       private int damage;

       public int Mana { get; set; }
       public int Health { get; set; }
       public int Damage { get; set; }

       protected Character(int mana, int health, int damage)
       {
           this.Mana = mana;
           this.Health = health;
           this.Damage = damage;
       }

       public abstract void Attack(Character target);
   }
}
