using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using RestService.DAL.Services;
using RestService.DAL.Models;

namespace RestService.Controllers
{
    [Route("api/restaurant")]
    public sealed class RestaurantApiController : Controller
    {
        public readonly IDocumentService _documentService;

        public RestaurantApiController(IDocumentService documentService)
        {
            this._documentService = documentService;
        }

        [HttpGet()]
        public async Task<IList<Restaurant>> Get()
        {
            IList<Restaurant> results = await this._documentService.GetRestaurants();
            return results;
        }

        [HttpGet("{id}")]
        public async Task<Restaurant> Get(string id)
        {
            return await this._documentService.GetRestaurant(id);
        }

        // POST: api/Entry
        [HttpPost]
        public async Task Post(Restaurant value)
        {
            await this._documentService.InsertRestaurant(value);
        }

        // PUT: api/Entry/5
        [HttpPut("{id}")]
        public async Task<ReplaceOneResult> Put(string id, Restaurant value)
        {
            Restaurant updateObj = await this._documentService.GetRestaurant(id);
            if(updateObj == null) {                
                await this._documentService.InsertRestaurant(value);
                return null;                
            } else {                
                return await this._documentService.UpdateRestaurant(updateObj, value);
            }                        
        }

        // DELETE: api/Entry/5
        [HttpDelete("{id}")]
        public async Task<DeleteResult> Delete(string id)
        {
            return await this._documentService.DeleteRestaurant(id);
        }
    }
}