using MongoDB.Driver;

namespace RestService.DAL
{
    public interface IMongoContext
    {
        IMongoDatabase Documents { get; }        
    }
}