namespace School
{
    using System;
    using System.Collections.Generic;
    class Class
    {
        public Class(string name, List<Teacher> teachers, List<Student> students)
        {
            this.Name = name;
            this.Teachers = teachers;
            this.Students = students;
        }

        private List<Student> students;
        private List<Teacher> teachers;
        private string name;

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        public List<Student> Students
        {
            get { return this.students; }
            protected set { this.students = value; }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            protected set { this.teachers = value; }
        }
    }
}
