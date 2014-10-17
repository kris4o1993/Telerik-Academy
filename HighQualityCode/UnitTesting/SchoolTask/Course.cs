namespace SchoolTask
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxNumberOfStudentPerCourse = 29;

        private string courseName;

        private IList<Student> students;

        public Course(string name)
        {
            this.CourseName = name;
            this.students = new List<Student>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            private set
            {
                if (value.Length < 3 || value.Length > 50)
                {
                    throw new ArgumentException("Name must be between 3 and 50 characters long");
                }

                this.courseName = value;
            }
        }

        public IList<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student studentToAdd)
        {
            if (this.StudentExists(studentToAdd))
            {
                throw new ArgumentException("Student {0} is already taking this course", studentToAdd.Name);
            }
            else if (this.students.Count >= MaxNumberOfStudentPerCourse)
            {
                throw new ArgumentException("The {0} course is full. No more students can sing for this course", this.CourseName);
            }
            else
            {
                this.students.Add(studentToAdd);
            }
        }

        public void RemoveStudent(Student studentToRemove)
        {
            if (!this.StudentExists(studentToRemove))
            {
                throw new ArgumentException("No such student exists in this course");
            }

            this.students.Remove(studentToRemove);
        }

        private bool StudentExists(Student studentToCheck)
        {
            bool isFound = false;

            foreach (var stu in this.students)
            {
                if (studentToCheck.UniqueNumber == stu.UniqueNumber)
                {
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }
    }
}
