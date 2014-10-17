namespace WarMachines.Machines
{
    using System;
    using WarMachines.Interfaces;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    public abstract class Machine : IMachine
    {

        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;


        public Machine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get 
            {
                return this.attackPoints;
            }

            protected set
            {
                this.attackPoints = value;
            }

        }

        public double DefensePoints
        {
            get 
            {
                return this.defensePoints; 
            }

            protected set
            {
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get 
            {
                return this.targets;
            }

            set
            {
                this.targets = value;
            }
        }

        public void Attack(string target)
        {
            this.Targets.Add(target);
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            string machineName = string.Format("- {0}", this.Name);
            output.AppendLine(machineName);
            output.AppendLine(" *Type: " + this.GetType().Name);
            output.AppendLine(" *Health: " + this.HealthPoints);
            output.AppendLine(" *Attack: " + this.AttackPoints);
            output.AppendLine(" *Defense: " + this.DefensePoints);

            string machineTargets;

            if (this.Targets.Count == 0)
            {
                machineTargets = "None";
            }
            else
            {
                machineTargets = String.Join(", ", this.Targets.Select(x => x.ToString()));
            }

            output.AppendLine(" *Targets: " + machineTargets);

            return output.ToString();
        }

    }
}
