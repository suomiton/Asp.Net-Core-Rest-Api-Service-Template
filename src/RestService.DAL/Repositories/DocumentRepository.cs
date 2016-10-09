using MongoDB.Driver;
using RestService.DAL.Context;
using RestService.DAL.Models;

namespace RestService.DAL.Repositories
{
    public sealed class DocumentRepository : RepositoryBase, IDocumentRepository
    {        
        public IMongoCollection<Restaurant> Restaurants
        {
            get
            {
                return base._db.GetCollection<Restaurant>("restaurants");
            }
        }

        public DocumentRepository (IMongoContext context) : base(context.Documents)
        {          
            ;
        }        
    }
}