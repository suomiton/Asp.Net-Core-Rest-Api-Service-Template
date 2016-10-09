using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using RestService.DAL.Models;

namespace RestService.DAL.Services
{
    public interface IDocumentService
    {
        Task<IList<Restaurant>> GetRestaurants();
        Task<Restaurant> GetRestaurant(string id);
        Task InsertRestaurant(Restaurant restaurant);
        Task<ReplaceOneResult> UpdateRestaurant(Restaurant updateObj, Restaurant restaurant);
        Task<DeleteResult> DeleteRestaurant(string id);
    }
}