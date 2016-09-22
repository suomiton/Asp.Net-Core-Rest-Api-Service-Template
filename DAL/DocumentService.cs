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

        public DocumentService(IDocumentCollection db)
        {
            this._db = db;
        }

        public async Task DeleteRestaurant(int id)
        {
            throw new NotImplementedException();
            //await this._db.Restaurants.DeleteOneAsync(o => o.restaurant_id == id);
        }

        public async Task<Restaurant> GetRestaurant(int id)
        {
            throw new NotImplementedException();
            //return await this._db.Restaurants
            //    .Find(o => o.restaurant_id == id).SingleOrDefaultAsync();
        }

        public async Task<IList<Restaurant>> GetRestaurants()
        {            
            return await this._db.Restaurants.AsQueryable().ToListAsync();
        }

        public async Task InsertRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
            //await this._db.Restaurants.InsertOneAsync(restaurant);
        }

        public async Task UpdateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
            //var updateObj = await this.GetRestaurant(restaurant.restaurant_id);
            //await this._db.Restaurants.UpdateOneAsync(updateObj.ToBsonDocument(), restaurant.ToBsonDocument());
        }
    }
}