using MongoDB.Bson;
using MongoDB.Driver;
using RestService.DAL.Models;

namespace RestService.DAL.Repositories
{
    public interface IDocumentRepository
    {
        IMongoCollection<Restaurant> Restaurants { get; }
    }
}