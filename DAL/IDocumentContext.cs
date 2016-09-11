using MongoDB.Driver;

namespace RestService.DAL
{
    public interface IDocumentContext
    {
        IMongoDatabase Documents { get; }        
    }
}