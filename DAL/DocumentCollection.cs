using MongoDB.Bson;
using MongoDB.Driver;
using RestService.Models;

namespace RestService.DAL
{
    public sealed class DocumentCollection : ContextBase, IDocumentCollection
    {        
        public IMongoCollection<Restaurant> Restaurants
        {
            get
            {
                return base._db.GetCollection<Restaurant>("restaurants");
            }
        }

        public DocumentCollection (IDocumentContext context) : base(context.Documents)
        {          
            ;
        }        
    }
}