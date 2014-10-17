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

    public class SongsController : ApiController
    {
        private readonly UnitOfWork uow;

        public SongsController()
        {
            this.uow = new UnitOfWork(new MusicStoreDbContext());
        }

        [HttpPost]
        public HttpResponseMessage Add(Song song)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            }

            this.uow.SongsRepository.Add(song);
            this.uow.Commit();

            var response = this.Request.CreateResponse(HttpStatusCode.Created, new SongApi(song));
            response.Headers.Location = new Uri(this.Url.Link("DefaultApi", new { id = song.Id }));
            return response;
        }

        [HttpGet]
        public IEnumerable<SongFullApi> GetAll()
        {
            var songs = this.uow.SongsRepository.GetAll().ToList().Select(x => new SongFullApi(x));
            return songs;
        }

        [HttpGet]
        public SongApi GetById(int id)
        {
            Song song = this.uow.SongsRepository.GetById(id);
            if (song == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return new SongApi(song);
        }

        [HttpPut]
        public HttpResponseMessage Update(int id, Song song)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != song.Id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            this.uow.SongsRepository.Update(song);

            try
            {
                this.uow.Commit();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, new SongApi(song));
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            Song song = this.uow.SongsRepository.GetById(id);
            if (song == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            this.uow.SongsRepository.Delete(id);

            try
            {
                this.uow.Commit();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, new SongApi(song));
        }

        protected override void Dispose(bool disposing)
        {
            this.uow.Dispose();
            base.Dispose(disposing);
        }
    }
}