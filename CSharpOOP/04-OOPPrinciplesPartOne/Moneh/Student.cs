namespace Moneh
{
    public class Student : Human
    {
        /// <summary>
        /// Fields
        /// </summary>
        private byte grade;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="grade"></param>
        public Student(string firstName, string lastName, byte grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public byte Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += (string.Format("FIRST NAME: {0}", this.FirstName));
            result += (string.Format("\nLAST NAME: {0}", this.LastName));
            result += (string.Format("\nGRADE: {0}", this.Grade));
            result += "\n----------------------------\n";
            return result;
        }
    }
}
