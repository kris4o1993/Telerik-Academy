namespace SchoolTask
{
    using System;

    public class Student
    {
        private string name;

        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            private set 
            {
                if (value.Length < 3 || value.Length > 50)
                {
                    throw new ArgumentException("Name must be between 3 and 50 characters long");
                }

                this.name = value; 
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            private set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("Unique number must be between 10000 and 99999(including) characters long");
                }

                this.uniqueNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student {0}, Unique number {1};", this.Name, this.UniqueNumber);
        }
    }
}
