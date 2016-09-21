using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestService.DAL;
using RestService.Models;

namespace RestService.Controllers
{
    [Route("api/restaurant")]
    public sealed class PersonApiController : Controller
    {
        public readonly IDocumentService _documentService;

        public PersonApiController(IDocumentService documentService)
        {
            this._documentService = documentService;
        }

        [HttpGet()]
        public async Task<IList<Restaurant>> Get()
        {
            return await this._documentService.GetRestaurants();
        }

        [HttpGet("{id}")]
        public async Task<Restaurant> Get(int id)
        {
            return await this._documentService.GetRestaurant(id);
        }

        // POST: api/Entry
        public async Task Post([FromBody]Restaurant value)
        {
            await this._documentService.InsertRestaurant(value);
        }

        // PUT: api/Entry/5
        public async Task Put(int id, [FromBody]Restaurant value)
        {
            await this._documentService.UpdateRestaurant(value);
        }

        // DELETE: api/Entry/5
        public async Task Delete(int id)
        {
            await this._documentService.DeleteRestaurant(id);
        }
    }
}