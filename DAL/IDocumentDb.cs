using MongoDB.Driver;
using RestService.Models;

namespace RestService.DAL
{
    public interface IDocumentDb
    {
        IMongoCollection<Person> Persons { get; }
    }
}