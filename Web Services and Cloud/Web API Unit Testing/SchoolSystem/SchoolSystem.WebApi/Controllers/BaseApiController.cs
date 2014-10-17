namespace SchoolSystem.WebApi.Controllers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using SchoolSystem.Repositories;

    public class BaseApiController : ApiController
    {
        public IRepository DataStore { get; set; }

        public string[] Includes { get; set; }

        public BaseApiController()
        {
            //TODO: USE DEPENDENCY INJECTION FOR DECOUPLING
            this.DataStore = new DbRepository();
        }

        // Constructor for unit testing
        public BaseApiController(IRepository repository)
        {
            this.DataStore = repository;
        }

        protected T HandleExceptions<T>(Func<T> operation)
        {
            try
            {
                return operation();
            }
            catch (Exception ex)
            {
                var errResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                throw new HttpResponseException(errResponse);
            }
        }
    }
}