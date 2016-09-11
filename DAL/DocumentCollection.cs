using MongoDB.Driver;
using RestService.Models;

namespace RestService.DAL
{
    public sealed class DocumentCollection : ContextBase, IDocumentCollection
    {        
        public IMongoCollection<Person> Persons
        {
            get
            {
                return base._db.GetCollection<Person>("Person");
            }
        }

        public DocumentCollection (IDocumentContext context) : base(context.Documents)
        {          
            ;
        }        
    }
}