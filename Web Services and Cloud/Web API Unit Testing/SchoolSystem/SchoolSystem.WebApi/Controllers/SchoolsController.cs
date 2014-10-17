namespace SchoolSystem.WebApi.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using SchoolSystem.Models;

    public class SchoolsController : BaseApiController
    {
        public SchoolsController()
        {
            this.Includes = new[] { "Students" };
        }

        [HttpGet]
        public IQueryable<School> GetAllSchools()
        {
            var response = this.HandleExceptions(() =>
            {
                var allSchools = this.DataStore.All<School>(this.Includes).AsQueryable();
                return allSchools;
            });

            return response;
        }

        [HttpGet]
        public School GetSchooldById(int id)
        {
            var response = this.HandleExceptions(() =>
            {
                var school = this.DataStore.Get<School>(s => s.Id == id, this.Includes);

                if (school == null)
                {
                    throw new ArgumentNullException(
                        "school", string.Format("School with id = {0} doesn't exist in the database!", id));
                }

                return school;
            });

            return response;
        }

        [HttpPost]
        public HttpResponseMessage AddSchool([FromBody] School school)
        {
            var response = this.HandleExceptions(() =>
            {
                if (!this.ModelState.IsValid)
                {
                    throw new ArgumentNullException(
                        "school", string.Format("The school model is not valid. {0}", this.ModelState));
                }

                school = this.DataStore.Create(school);
                return school;
            });

            return this.Request.CreateResponse(HttpStatusCode.Created, response);
        }
    }
}
