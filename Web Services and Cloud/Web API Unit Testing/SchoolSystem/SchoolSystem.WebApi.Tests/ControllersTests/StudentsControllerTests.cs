namespace SchoolSystem.WebApi.Tests.ControllersTests
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Hosting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using SchoolSystem.Models;
    using SchoolSystem.Repositories;
    using SchoolSystem.WebApi.Controllers;

    [TestClass]
    public class StudentsControllerTests
    {
        [TestMethod]
        public void GetAllStudents_WhenASingleStudentInRepository_ShouldReturnSingleStudent()
        {
            // Arrange
            var repository = new FakeStudentsRepository();
            var student = new Student
            {
                FirstName = "Gosho"
            };
            repository.Students.Add(student);

            var controller = SetupController(repository, HttpMethod.Get);

            // Act
            var students = controller.GetAllStudents();

            // Assert
            Assert.IsNotNull(students);
            Assert.IsTrue(students.Count() == 1);
            Assert.AreEqual(student.FirstName, students.First().FirstName);
        }

        [TestMethod]
        public void GetAllStudents_WhenRepositoryIsEmpty_ShouldReturnEmptyCollection()
        {
            // Arrange
            var repository = new FakeStudentsRepository();
            var controller = SetupController(repository, HttpMethod.Get);

            // Act
            var students = controller.GetAllStudents();

            // Assert
            Assert.IsNotNull(students);
            Assert.IsFalse(students.Any());
        }

        [TestMethod]
        public void GetStudentById_WhenExistStudentWithThisId_ShouldReturnSingleStudentWithThisId()
        {
            // Arrange
            const int Id = 1;
            var repository = new FakeStudentsRepository();
            repository.Students.Add(new Student
            {
                Id = Id,
                FirstName = "Gosho"
            });

            var controller = SetupController(repository, HttpMethod.Get, 
                new KeyValuePair<string, object>("id", Id));

            // Act
            var student = controller.GetStudentById(Id);

            // Assert
            Assert.IsNotNull(student);
            Assert.AreEqual(Id, student.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpResponseException))]
        public void GetStudentById_WhenIsNotExistStudentWithThisId_ShouldThrowHttpResponseExceptionWithStatusBadRequest()
        {
            // Arrange
            const int Id = 1;
            var repository = new FakeStudentsRepository();
            var controller = SetupController(repository, HttpMethod.Get,
                new KeyValuePair<string, object>("id", Id));

            try
            {
                // Act
                var student = controller.GetStudentById(Id);
            }
            catch (HttpResponseException hre)
            {
                // Assert
                Assert.AreEqual(HttpStatusCode.BadRequest, hre.Response.StatusCode);
                throw;
            }
        }

        [TestMethod]
        public void GetAllStudentsBySubjectAndValue_WhenMatchOneStudentFromThree_ShouldReturnSingleStudent()
        {
            // Arrange
            var repository = new FakeStudentsRepository();
            repository.Students.Add(new Student
            {
                Marks = new Collection<Mark>
                {
                    new Mark {Subject = "Math", Value = 5.5m }
                }
            });
            repository.Students.Add(new Student
            {
                Marks = new Collection<Mark>
                {
                    new Mark {Subject = "Biology", Value = 4.0m }
                }
            });
            repository.Students.Add(new Student
            {
                Marks = new Collection<Mark>
                {
                    new Mark {Subject = "Math", Value = 3.0m }
                }
            });

            const string Subject = "Math";
            const decimal Value = 5.00m;
            var controller = SetupController(repository, HttpMethod.Get,
                new KeyValuePair<string, object>("subject", Subject), new KeyValuePair<string, object>("value", Value));

            // Act
            var students = controller.GetAllStudentsBySubjectAndValue(Subject, Value);

            // Assert
            Assert.IsNotNull(students);
            Assert.IsTrue(students.Count() == 1);
            Assert.IsTrue(students.First().Marks.Any(m => m.Subject == Subject && m.Value >= Value));
        }

        [TestMethod]
        public void GetAllStudentsBySubjectAndValue_WhenNotMatchAnyStudent_ShouldReturnEmptyCollection()
        {
            // Arrange
            var repository = new FakeStudentsRepository();
            repository.Students.Add(new Student
            {
                Marks = new Collection<Mark>
                {
                    new Mark {Subject = "Math", Value = 5.5m }
                }
            });
            repository.Students.Add(new Student
            {
                Marks = new Collection<Mark>
                {
                    new Mark {Subject = "Biology", Value = 4.0m }
                }
            });
            repository.Students.Add(new Student
            {
                Marks = new Collection<Mark>
                {
                    new Mark {Subject = "Math", Value = 3.0m }
                }
            });

            const string Subject = "Math";
            const decimal Value = 6.00m;
            var controller = SetupController(repository, HttpMethod.Get, 
                new KeyValuePair<string, object>("subject", Subject), new KeyValuePair<string, object>("value", Value));

            // Act
            var students = controller.GetAllStudentsBySubjectAndValue(Subject, Value);

            // Assert
            Assert.IsNotNull(students);
            Assert.IsTrue(!students.Any());
        }

        [TestMethod]
        public void AddStudent_WhenAddOneValidStudent_ShouldReturAddedStudent()
        {
            // Arrange
            var repository = new FakeStudentsRepository();
            var controller = SetupController(repository, HttpMethod.Post);

            // Act
            var response = controller.AddStudent(new Student
            {
                Id = 6,
                FirstName = "Gosho",
                LastName = "Petkov",
                Age = 12,
                Grade = 6,
                School = new School { Name = "TelerikAcademy", Location = "Sofia" }
            });

            // Assert
            Assert.IsNotNull(response.Content);
            Assert.IsTrue(repository.Students.Count == 1);
            var student = JsonConvert.DeserializeObject<Student>(response.Content.ReadAsStringAsync().Result);
            Assert.AreEqual("Gosho", student.FirstName);
        }

        private static StudentsController SetupController(IRepository repository, HttpMethod method, params KeyValuePair<string, object>[] attributes)
        {
            var path = "http://localhost/api/students";

            if (attributes.Any(x => x.Key == "id"))
            {
                path += string.Format("/{0}", attributes.First(x => x.Key == "id").Value);
            }
            else if (attributes.Any(x => x.Key == "subject"))
            {
                path += string.Format("?subject={0}&value={1}", attributes.First(x => x.Key == "subject").Value, attributes.First(x => x.Key == "value").Value);
            }

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(method, path);
            config.Routes.MapHttpRoute("ApiName", "api/{controller}/{id}");
            var controller = new StudentsController(repository)
            {
                Request = request
            };

            controller.Request.Properties[HttpPropertyKeys.HttpConfigurationKey] = config;
            return controller;
        }
    }
}
