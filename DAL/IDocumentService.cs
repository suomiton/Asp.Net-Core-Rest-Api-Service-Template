using System.Collections.Generic;
using System.Threading.Tasks;
using RestService.Models;

namespace RestService.DAL
{
    public interface IDocumentService
    {
        Task<IList<Restaurant>> GetRestaurants();
        Task<Restaurant> GetRestaurant(string id);
        Task InsertRestaurant(Restaurant person);
        Task UpdateRestaurant(Restaurant person);
        Task DeleteRestaurant(int id);
    }
}