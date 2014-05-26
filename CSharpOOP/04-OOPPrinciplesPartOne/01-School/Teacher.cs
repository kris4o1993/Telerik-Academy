namespace School
{
    using System;
    using System.Collections.Generic;
    class Teacher : Person
    {
        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        private List<Discipline> disciplines;

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("TEACHER NAME: {0}", this.Name);
            result += "\nDISCIPLINES:\n";

            foreach (Discipline disc in this.Disciplines)
            {
                result += disc;
            }
            result += "-------------------------------------";
            return result;
        }

    }
}
