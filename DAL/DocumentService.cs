using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using RestService.Models;

namespace RestService.DAL
{
    public sealed class DocumentService : IDocumentService
    {
        private readonly IDocumentCollection _db;

        public DocumentService (IDocumentCollection db)
        {          
            this._db = db;
        }

        public async Task<IList<Person>> getDocuments() {
            return await this._db.Persons.FindSync(null).ToListAsync();
        }
    }
}