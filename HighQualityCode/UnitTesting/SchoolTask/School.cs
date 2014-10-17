namespace SchoolTask
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private IList<Course> courses;

        public School()
        {
            this.courses = new List<Course>();
        }

        public IList<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public void AddCourse(Course courseToAdd)
        {
            this.courses.Add(courseToAdd);
        }

        public void RemoveCourse(Course courseToRemove)
        {
            bool courseIsFound = this.CourseExists(courseToRemove);

            if (!courseIsFound)
            {
                throw new ArgumentException("No such course found");
            }

            this.courses.Remove(courseToRemove);
        }

        private bool CourseExists(Course courseToCheck)
        {
            bool isFound = false;

            foreach (var course in this.courses)
            {
                if (courseToCheck.CourseName == course.CourseName)
                {
                    isFound = true;
                }
            }

            return isFound;
        }
    }
}
