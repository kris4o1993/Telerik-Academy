using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter
    {
        private const double InitialFighterHealth = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode) 
            : base(name, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
            this.HealthPoints = InitialFighterHealth;
        }

        public bool StealthMode { get; set; }
        

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            if (this.StealthMode == true)
            {
                return base.ToString() + " *Stealth: ON";
            }
            
            else
            {
                return base.ToString() + " *Stealth: OFF";
            }
        }
    }
}
