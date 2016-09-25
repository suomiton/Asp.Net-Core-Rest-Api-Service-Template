using MongoDB.Bson;
using MongoDB.Driver;
using RestService.Models;

namespace RestService.DAL
{
    public interface IDocumentRepository
    {
        IMongoCollection<Restaurant> Restaurants { get; }
    }
}