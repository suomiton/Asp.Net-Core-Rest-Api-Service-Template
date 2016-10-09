using MongoDB.Driver;

namespace RestService.DAL.Context
{
    public interface IMongoContext
    {
        IMongoDatabase Documents { get; }        
    }
}