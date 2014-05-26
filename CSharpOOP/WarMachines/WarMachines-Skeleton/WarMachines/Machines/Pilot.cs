using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;
        public Pilot(string name)
        {
            this.Name = name;
            this.Machines = new List<IMachine>();
        }

        public IList<IMachine> Machines
        {
            get
            {
                return this.machines;
            }
            set
            {
                this.machines = value;
            }
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.Machines.Add(machine);
        }

        public string Report()
        {
            var output = new StringBuilder();
            string numberOfMachines;
            string formatString;

            if (this.Machines.Count > 0)
            {
                numberOfMachines = this.Machines.Count.ToString();

                if (this.Machines.Count == 1)
                {
                    formatString = "machine";
                }

                else
                {
                    formatString = "machines";
                }
            }

            else
            {
                numberOfMachines = "no";
                formatString = "machines";
            }

            
            string basicInfo = String.Format("{0} - {1} {2}", this.Name, numberOfMachines, formatString);
            output.AppendLine(basicInfo);

            foreach (var machine in this.Machines)
            {
                output.AppendLine(machine.ToString());
            }

            return output.ToString().Trim();
        }
    }
}
