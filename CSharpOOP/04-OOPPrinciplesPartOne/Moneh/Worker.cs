namespace Moneh
{
    class Worker : Human
    {
        /// <summary>
        /// Fields
        /// </summary>
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }


        public double MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += (string.Format("FIRST NAME: {0}", this.FirstName));
            result += (string.Format("\nLAST NAME: {0}", this.LastName));
            result += (string.Format("\nMONEY PER HOUR: {0:F2}", MoneyPerHour()));
            result += "\n----------------------------\n";
            return result;
        }
    }
}