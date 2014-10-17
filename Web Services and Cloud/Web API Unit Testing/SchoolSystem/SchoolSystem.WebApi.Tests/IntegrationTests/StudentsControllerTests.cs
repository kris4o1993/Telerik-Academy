namespace SchoolSystem.WebApi.Tests.IntegrationTests
{
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Transactions;
    using System.Collections.Generic;
    using System.Web.Http;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using SchoolSystem.Models;
    using SchoolSystem.WebApi.Controllers;

    [TestClass]
    public class StudentsControllerTests
    {
        private static TransactionScope transactionScope;
        private InMemoryHttpServer httpServer;

        [TestInitialize]
        public void TestInitialize()
        {

            var type = typeof(StudentsController);
            transactionScope = new TransactionScope(TransactionScopeOption.Required,
                new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted });

            var routes = new List<Route>
            {
                new Route(
                    "DefaultApi",
                    "api/{controller}/{id}",
                    new { id = RouteParameter.Optional }),
            };

            this.httpServer = new InMemoryHttpServer("http://localhost/", routes);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            transactionScope.Dispose();
        }

        [TestMethod]
        public void GetAllStudents_WhenASingleStudentInRepository_ShouldReturnSingleStudent()
        {
            // Arrange
            var student = new Student
            {
                FirstName = "Gosho",
                LastName = "Petkov",
                Age = 15,
                Grade = 9
            };

            AddStudent(this.httpServer, student);

            // Act
            var response = this.httpServer.Get("api/students");

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response.Content);
            var responseStudents = GetStudentCollection(response.Content).ToList();
            Assert.AreEqual(1, responseStudents.Count());
            Assert.AreEqual(student.FirstName, responseStudents.First().FirstName);
        }

        [TestMethod]
        public void GetAllStudents_WhenRepositoryIsEmpty_ShouldReturnEmptyCollection()
        {
            // Arrange

            // Act
            var response = this.httpServer.Get("api/students");

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response.Content);
            var responseStudents = GetStudentCollection(response.Content);
            Assert.AreEqual(0, responseStudents.Count());
        }

        [TestMethod]
        public void GetStudentById_WhenExistStudentWithThisId_ShouldReturnSingleStudentWithThisId()
        {
            // Arrange
            var student = new Student
            {
                FirstName = "Gosho",
                LastName = "Petkov",
                Age = 15,
                Grade = 9
            };

            var addedStudent = AddStudent(this.httpServer, student);

            // Act
            var response = this.httpServer.Get("api/students/" + addedStudent.Id);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response.Content);
            var responseStudent = GetStudent(response.Content);
            Assert.AreEqual(addedStudent.Id, responseStudent.Id);
        }

        [TestMethod]
        public void GetStudentById_WhenIsNotExistStudentWithThisId_ShouldReturnBadRequestStatusCode()
        {
            // Arrange

            // Act
            var response = this.httpServer.Get("api/students/" + 1);

            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [TestMethod]
        public void GetAllStudentsBySubjectAndValue_WhenMatchOneStudentFromThree_ShouldReturnSingleStudent()
        {
            // Arrange
            string subject = "Math";
            decimal value = 5.00m;

            var student1 = new Student
            {
                FirstName = "Gosho", LastName = "Petkov", Age = 14, Grade = 8,
                Marks = new HashSet<Mark> { new Mark {Subject = "Math", Value = 5.5m } }
            };

            var student2 = new Student
            {
                FirstName = "Pesho", LastName = "Georgiev", Age = 15, Grade = 9,
                Marks = new HashSet<Mark> { new Mark { Subject = "Math", Value = 5.0m } }
            };

            var student3 = new Student
            {
                FirstName = "Ivan", LastName = "Ivanov", Age = 16, Grade = 10,
                Marks = new HashSet<Mark> { new Mark { Subject = "Math", Value = 4.5m } }
            };

            student1 = AddStudent(this.httpServer, student1);
            student2 = AddStudent(this.httpServer, student2);
            student3 = AddStudent(this.httpServer, student3);

            // Act
            var response = this.httpServer.Get(string.Format("api/students?subject={0}&value={1}", subject, value));

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response.Content);
            var responseStudents = GetStudentCollection(response.Content).ToList();
            Assert.AreEqual(2, responseStudents.Count());
            Assert.IsFalse(responseStudents.Any(s => s.Marks.Any(m => m.Subject != subject && m.Value < value)));
            Assert.IsTrue(responseStudents.Any(s => s.FirstName == student1.FirstName));
            Assert.IsTrue(responseStudents.Any(s => s.FirstName == student2.FirstName));
            Assert.IsFalse(responseStudents.Any(s => s.FirstName == student3.FirstName));
        }

        [TestMethod]
        public void GetAllStudentsBySubjectAndValue_WhenNotMatchAnyStudent_ShouldReturnEmptyCollection()
        {
            // Arrange
            string subject = "Math";
            decimal value = 6.00m;

            var student1 = new Student
            {
                FirstName = "Gosho",
                LastName = "Petkov",
                Age = 14,
                Grade = 8,
                Marks = new HashSet<Mark> { new Mark { Subject = "Math", Value = 5.5m } }
            };

            var student2 = new Student
            {
                FirstName = "Pesho",
                LastName = "Georgiev",
                Age = 15,
                Grade = 9,
                Marks = new HashSet<Mark> { new Mark { Subject = "Math", Value = 5.0m } }
            };

            var student3 = new Student
            {
                FirstName = "Ivan",
                LastName = "Ivanov",
                Age = 16,
                Grade = 10,
                Marks = new HashSet<Mark> { new Mark { Subject = "Math", Value = 4.5m } }
            };

            student1 = AddStudent(this.httpServer, student1);
            student2 = AddStudent(this.httpServer, student2);
            student3 = AddStudent(this.httpServer, student3);

            // Act
            var response = this.httpServer.Get(string.Format("api/students?subject={0}&value={1}", subject, value));

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response.Content);
            var responseStudents = GetStudentCollection(response.Content).ToList();
            Assert.AreEqual(0, responseStudents.Count());
            Assert.IsFalse(responseStudents.Any(s => s.Marks.Any(m => m.Subject != subject && m.Value < value)));
            Assert.IsFalse(responseStudents.Any(s => s.FirstName == student1.FirstName));
            Assert.IsFalse(responseStudents.Any(s => s.FirstName == student2.FirstName));
            Assert.IsFalse(responseStudents.Any(s => s.FirstName == student3.FirstName));
        }

        [TestMethod]
        public void AddStudent_WhenAddOneValidStudent_ShouldReturAddedStudent()
        {
            // Arrange
            var student = new Student
            {
                FirstName = "Gosho",
                LastName = "Petkov",
                Age = 15,
                Grade = 9
            };

            // Act
            var response = this.httpServer.Post("api/students", student);

            // Assert
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            Assert.IsNotNull(response.Content);
            var responseStudent = GetStudent(response.Content);
            Assert.AreEqual(student.FirstName, responseStudent.FirstName);
        }

        [TestMethod]
        public void AddStudent_WhenAddOneNotValidStudent_ShouldReturBadRequestStatusCode()
        {
            // Arrange
            var student = new Student
            {
                FirstName = "Gosho",
            };

            // Act
            var response = this.httpServer.Post("api/students", student);

            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        private static Student AddStudent(InMemoryHttpServer httpServer, Student student)
        {
            var response = httpServer.Post("api/students", student);
            return GetStudent(response.Content);
        }

        private static Student GetStudent(HttpContent content)
        {
            var contentString = content.ReadAsStringAsync().Result;
            var studentModel = JsonConvert.DeserializeObject<Student>(contentString);
            return studentModel;
        }

        private static IEnumerable<Student> GetStudentCollection(HttpContent content)
        {
            var contentString = content.ReadAsStringAsync().Result;
            var studentsModels = JsonConvert.DeserializeObject<IEnumerable<Student>>(contentString);
            return studentsModels;
        }
    }
}
