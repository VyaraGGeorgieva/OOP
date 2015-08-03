using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleships.Contracts;

namespace Battleships.Ships
{
    public abstract class BattleShip:Ship, IAttack
    {
        protected BattleShip(string name, double lengthInMetres, double volume) 
            : base(name, lengthInMetres, volume)
        {
        }

        public abstract string Attack(Ship target);


        protected void DestroyTarget(Ship target)
        {
            target.IsDestroyed = true;
        }
    }
}
