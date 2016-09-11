using System;
using MongoDB.Driver;
using RestService.Models;

namespace RestService.DAL
{
    public sealed class DocumentDb : ContextBase, IDocumentDb
    {        
        public IMongoCollection<Person> Persons
        {
            get
            {
                return base._db.GetCollection<Person>("Person");
            }
        }

        public DocumentDb (IDocumentContext context) : base(context.Documents)
        {          
            ;
        }        
    }
}