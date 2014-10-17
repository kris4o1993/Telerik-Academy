namespace SchoolTask.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTest
    {
        private static School testSchool = new School();
        private static Course testHtmlCourse = new Course("HTML");

        [TestMethod]
        public void School_ConstructorTest()
        {
            Assert.IsNotNull(testSchool);
        }

        [TestMethod]
        public void School_CoursesListTest()
        {
            Assert.IsNotNull(testSchool.Courses);
        }

        [TestMethod]
        public void School_RemoveCourseTest()
        {
            testSchool.AddCourse(testHtmlCourse);
            testSchool.RemoveCourse(testHtmlCourse);
            Assert.AreEqual(0, testSchool.Courses.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void School_RemoveCourseExceptionTest()
        {
            testSchool.RemoveCourse(testHtmlCourse);
        }

        [TestMethod]
        public void School_AddCourseTest()
        {
            testSchool.AddCourse(testHtmlCourse);
            Assert.AreEqual(testHtmlCourse.CourseName, testSchool.Courses[0].CourseName);
        }
    }
}
