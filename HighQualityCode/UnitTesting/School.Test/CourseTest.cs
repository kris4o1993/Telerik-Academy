namespace SchoolTask.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void Course_ConstructorNameTest()
        {
            string name = "CSharp";
            Course testCourse = new Course(name);
            Assert.AreEqual(name, testCourse.CourseName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_ConstructorShortNameTest()
        {
            string name = "CS";
            Course testCourse = new Course(name);
            Assert.AreEqual(name, testCourse.CourseName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_ConstructorLongNameTest()
        {
            string name = "SuperHyperMegaGigaLongCourseUselessTitanicNameAndSomeMoreRandomText";
            Course testCourse = new Course(name);
            Assert.AreEqual(name, testCourse.CourseName);
        }

        [TestMethod]
        public void Course_AddStudentTest()
        {
            Student testStudent = new Student("Pesho", 11111);
            Course testCourse = new Course("CSharp");
            testCourse.AddStudent(testStudent);
            Assert.AreEqual(1, testCourse.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_AddSExistingStudentExceptionTest()
        {
            Student testStudent = new Student("Pesho", 11111);
            Course testCourse = new Course("CSharp");
            testCourse.AddStudent(testStudent);
            testCourse.AddStudent(testStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_AddSStudentCourseFullExceptionTest()
        {
            Course testCourse = new Course("CSharp");
            for (int i = 0; i < 30; i++)
            {
                testCourse.AddStudent(new Student(string.Format("Student{0}", i), 10000 + i));
            }
        }

        [TestMethod]
        public void Course_RemoveStudentTest()
        {
            Student testStudent = new Student("Pesho", 11111);
            Course testCourse = new Course("CSharp");
            testCourse.AddStudent(testStudent);
            testCourse.RemoveStudent(testStudent);
            Assert.AreEqual(0, testCourse.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_RemoveStudentExceptionTest()
        {
            Student firstTestStudent = new Student("Pesho", 11111);
            Student secondTestStudent = new Student("Pesho", 12345);
            Course testCourse = new Course("CSharp");
            testCourse.AddStudent(firstTestStudent);
            testCourse.RemoveStudent(secondTestStudent);
        }
    }
}
