namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string name)
            : base(name, null, null)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName, null)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            if (this.Town != null)
            {
                return string.Format("{0}{1}{2}{3}", base.ToString(), "; Town = ", this.Town, "}");
            }
            else
            {
                return string.Format("{0}{1}", base.ToString(), "}");
            }
        }
    }
}
