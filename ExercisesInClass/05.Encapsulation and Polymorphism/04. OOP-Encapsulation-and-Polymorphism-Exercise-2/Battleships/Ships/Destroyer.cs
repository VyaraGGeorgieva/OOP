namespace Battleships.Ships
{
    using System;

    public class Destroyer : BattleShip
    {

        private int numberOfAmmunition;

        public Destroyer(string name, double lengthInMetres, double volume, int numberOfAmmunation) 
            : base(name, lengthInMetres, volume)
        {
            this.NumberofAmmunation = numberOfAmmunition;
        }

        public int NumberofAmmunation { get; set; }

        public override string Attack(Ship target)
        {
            this.DestroyTarget(target);
            return "They didn't see us coming!";
        }
    }
}


