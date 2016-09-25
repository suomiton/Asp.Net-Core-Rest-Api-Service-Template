using MongoDB.Driver;
using RestService.Models;

namespace RestService.DAL
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