using MongoDB.Driver;
using RestService.Models;

namespace RestService.DAL
{
    public interface IDocumentCollection
    {
        IMongoCollection<Restaurant> Restaurants { get; }
    }
}