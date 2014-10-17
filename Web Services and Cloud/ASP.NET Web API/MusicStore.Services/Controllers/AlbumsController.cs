namespace MusicStore.Services.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using MusicStore.Models;
    using MusicStore.Data;
    using MusicStore.Repositories;

    public class AlbumsController : ApiController
    {
        private readonly UnitOfWork uow;

        public AlbumsController()
        {
            this.uow = new UnitOfWork(new MusicStoreDbContext());
        }

        [HttpPost]
        public HttpResponseMessage Add(Album album)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            }

            this.uow.AlbumsRepository.Add(album);
            this.uow.Commit();

            var response = this.Request.CreateResponse(HttpStatusCode.Created, new AlbumApi(album));
            response.Headers.Location = new Uri(this.Url.Link("DefaultApi", new { id = album.Id }));
            return response;
        }

        [HttpGet]
        public IEnumerable<AlbumFullApi> GetAll()
        {
            var albums = this.uow.AlbumsRepository.GetAll().ToList().Select(x => new AlbumFullApi(x));
            return albums;
        }

        [HttpGet]
        public AlbumApi GetById(int id)
        {
            Album album = this.uow.AlbumsRepository.GetById(id);
            if (album == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return new AlbumApi(album);
        }

        [HttpPut]
        public HttpResponseMessage Update(int id, Album album)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != album.Id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            this.uow.AlbumsRepository.Update(album);

            try
            {
                this.uow.Commit();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, new AlbumApi(album));
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            Album album = this.uow.AlbumsRepository.GetById(id);
            if (album == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            this.uow.AlbumsRepository.Delete(id);

            try
            {
                this.uow.Commit();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, new AlbumApi(album));
        }

        protected override void Dispose(bool disposing)
        {
            this.uow.Dispose();
            base.Dispose(disposing);
        }
    }
}