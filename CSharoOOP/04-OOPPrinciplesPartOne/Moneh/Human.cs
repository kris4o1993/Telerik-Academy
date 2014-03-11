namespace Moneh
{
    using System;

    public abstract class Human
    {
        /// <summary>
        /// Fields
        /// </summary>
        private string firstName;
        private string lastName;

        /// <summary>
        /// Properties
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += (string.Format("FIRST NAME: {0}", this.FirstName));
            result += (string.Format("\nLAST NAME: {0}", this.LastName));
            result += "\n----------------------------\n";
            return result;
        }

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}