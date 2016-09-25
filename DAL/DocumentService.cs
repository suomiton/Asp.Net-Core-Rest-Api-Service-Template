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
        private readonly IDocumentRepository _db;

        public DocumentService(IDocumentRepository db)
        {
            this._db = db;
        }

        public async Task<DeleteResult> DeleteRestaurant(string id)
        {
            return await this._db.Restaurants.DeleteOneAsync(o => o.RestaurantId == id);
        }

        public async Task<Restaurant> GetRestaurant(string id)
        {
            return await this._db.Restaurants
                .Find(o => o.RestaurantId == id).SingleOrDefaultAsync();
        }

        public async Task<IList<Restaurant>> GetRestaurants()
        {
            return await this._db.Restaurants.AsQueryable().ToListAsync();
        }

        public async Task InsertRestaurant(Restaurant restaurant)
        {
            await this._db.Restaurants.InsertOneAsync(restaurant);
        }

        public async Task<ReplaceOneResult> UpdateRestaurant(Restaurant updateObj, Restaurant restaurant)
        {
            restaurant.Id = updateObj.Id; // Ensure equality
            return await this._db.Restaurants.ReplaceOneAsync(updateObj.ToBsonDocument(), restaurant);
        }
    }
}