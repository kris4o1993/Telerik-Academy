using System;
using System.Linq;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank
    {
        private const double InitialTankHealth = 100;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = InitialTankHealth;
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; set; }

        public void ToggleDefenseMode()
        {
            if (!this.DefenseMode)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }

            else
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }

            this.DefenseMode = !this.DefenseMode;

        }

        public override string ToString()
        {
            if (this.DefenseMode == true)
            {
                return base.ToString() + " *Defense: ON";
            }

            else
            {
                return base.ToString() + " *Defense: OFF";
            }
        }
    }
}