namespace SchoolSystem.WebApi.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using SchoolSystem.Models;
    using SchoolSystem.Repositories;

    public class StudentsController : BaseApiController
    {
        public StudentsController()
        {
            this.Includes = new[] { "School", "Marks" };
        }

        // Constructor for unit testing
        public StudentsController(IRepository repository)
            : base(repository) 
        {
            this.Includes = new[] { "School", "Marks" };
        }

        [HttpGet]
        public IQueryable<Student> GetAllStudents()
        {
            var response = this.HandleExceptions(() =>
            {
                var allStudents = this.DataStore.All<Student>(this.Includes).AsQueryable();
                return allStudents;
            });

            return response;
        }

        [HttpGet]
        public Student GetStudentById(int id)
        {
            var response = this.HandleExceptions(() =>
            {
                var student = this.DataStore.Get<Student>(s => s.Id == id, this.Includes);

                if (student == null)
                {
                    throw new ArgumentNullException(
                        "student", string.Format("Student with id = {0} doesn't exist in the database!", id));
                }

                return student;
            });

            return response;
        }

        [HttpGet]
        public IQueryable<Student> GetAllStudentsBySubjectAndValue(string subject, decimal value)
        {
            var response = this.HandleExceptions(() =>
            {
                var allStudents = this.DataStore.Filter<Student>(s => s.Marks.Any(m => m.Subject == subject && m.Value >= value), this.Includes);
                return allStudents;
            });

            return response;
        }

        [HttpPost]
        public HttpResponseMessage AddStudent(Student student)
        {
            var response = this.HandleExceptions(() =>
            {
                if (!this.ModelState.IsValid)
                {
                    throw new ArgumentNullException(
                        "student", string.Format("The student model is not valid. {0}", this.ModelState));
                }

                student = this.DataStore.Create(student);
                return this.Request.CreateResponse(HttpStatusCode.Created, student);
            });

            return response;
        }
    }
}
