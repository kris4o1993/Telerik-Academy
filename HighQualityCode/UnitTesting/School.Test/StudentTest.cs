namespace SchoolTask.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void Student_ConstructorNameTest()
        {
            string name = "Pesho";
            int id = 12345;
            Student testStudent = new Student(name, id);
            Assert.AreEqual(name, testStudent.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Student_ConstructorNameExceptionTest()
        {
            string name = "Pe";
            int id = 12345;
            Student testStudent = new Student(name, id);
        }

        [TestMethod]
        public void Student_ConstructorUniqueNumberTest()
        {
            string name = "Pesho";
            int id = 99999;
            Student testStudent = new Student(name, id);
            Assert.AreEqual(id, testStudent.UniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Student_ConstructorUniqueNumberExceptionLowerTest()
        {
            string name = "Pesho";
            int id = 9999;
            Student testStudent = new Student(name, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Student_ConstructorUniqueNumberExceptionUpperTest()
        {
            string name = "Pesho";
            int id = 100000;
            Student testStudent = new Student(name, id);
        }

        [TestMethod]
        public void Student_ToStringTest()
        {
            string name = "Pesho";
            int id = 12345;
            Student testStudent = new Student(name, id);
            Assert.AreEqual("Student Pesho, Unique number 12345;", testStudent.ToString());
        }
    }
}
