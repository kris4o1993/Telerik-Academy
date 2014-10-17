namespace MusicStore.Services.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using MusicStore.Models;
    using MusicStore.Data;
    using MusicStore.Repositories;

    public class ArtistsController : ApiController
    {
        private readonly UnitOfWork uow;

        public ArtistsController()
        {
            this.uow = new UnitOfWork(new MusicStoreDbContext());
        }

        [HttpPost]
        public HttpResponseMessage Add(Artist artist)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            }

            this.uow.ArtistsRepository.Add(artist);
            this.uow.Commit();

            var response = this.Request.CreateResponse(HttpStatusCode.Created, new ArtistApi(artist));
            response.Headers.Location = new Uri(this.Url.Link("DefaultApi", new { id = artist.Id }));
            return response;
        }

        [HttpGet]
        public IEnumerable<ArtistFullApi> GetAll()
        {
            var artists = this.uow.ArtistsRepository.GetAll().ToList().Select(x => new ArtistFullApi(x));
            return artists;
        }

        [HttpGet]
        public ArtistApi GetById(int id)
        {
            Artist artist = this.uow.ArtistsRepository.GetById(id);
            if (artist == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return new ArtistApi(artist);
        }

        [HttpPut]
        public HttpResponseMessage Update(int id, Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != artist.Id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            this.uow.ArtistsRepository.Update(artist);

            try
            {
                this.uow.Commit();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, new ArtistApi(artist));
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            Artist artist = this.uow.ArtistsRepository.GetById(id);
            if (artist == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            this.uow.ArtistsRepository.Delete(id);

            try
            {
                this.uow.Commit();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, new ArtistApi(artist));
        }

        protected override void Dispose(bool disposing)
        {
            this.uow.Dispose();
            base.Dispose(disposing);
        }
    }
}