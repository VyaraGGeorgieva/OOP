namespace Battleships.Ships
{
    using System;

    public class Warship : BattleShip
    {
        public Warship(string name, double lengthInMetres, double volume) 
            : base(name, lengthInMetres, volume)
        {
            
        }

        public override string Attack(Ship target)
        {
            this.DestroyTarget(target);

            return "Victory is ours!";
        }
    }
}
