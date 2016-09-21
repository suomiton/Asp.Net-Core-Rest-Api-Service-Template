using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using RestService.Models;

namespace RestService.DAL
{
    public sealed class DocumentService : IDocumentService
    {
        private readonly IDocumentCollection _db;

        public DocumentService (IDocumentCollection db)
        {          
            this._db = db;
        }

        public async Task DeleteRestaurant(int id)
        {
            await this._db.Restaurants.DeleteOneAsync( o => o.Id == id);
        }

        public async Task<Restaurant> GetRestaurant(int id)
        {            
            return await this._db.Restaurants
                .Find(o => o.Id == id).SingleOrDefaultAsync();
        }

        public async Task<IList<Restaurant>> GetRestaurants()
        {
            return await this._db.Restaurants.AsQueryable().ToListAsync();
        }

        public async Task InsertRestaurant(Restaurant restaurant)
        {
            await this._db.Restaurants.InsertOneAsync(restaurant);
        }

        public async Task UpdateRestaurant(Restaurant restaurant)
        {
            var updateObj = await this.GetRestaurant(restaurant.Id);
            await this._db.Restaurants.UpdateOneAsync(updateObj.ToBsonDocument(), restaurant.ToBsonDocument());
        }
    }
}