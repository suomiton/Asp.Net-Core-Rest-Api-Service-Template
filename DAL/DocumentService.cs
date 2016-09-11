using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
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

        public async Task DeletePerson(int id)
        {
            await this._db.Persons.DeleteOneAsync( o => o.Id == id);
        }

        public async Task<Person> GetPerson(int id)
        {            
            return await this._db.Persons
                .Find(o => o.Id == id).SingleOrDefaultAsync();
        }

        public async Task<IList<Person>> GetPersons()
        {
            return await this._db.Persons.AsQueryable().ToListAsync();
        }

        public async Task InsertPerson(Person person)
        {
            await this._db.Persons.InsertOneAsync(person);
        }

        public async Task UpdatePerson(Person person)
        {
            var updateObj = await this.GetPerson(person.Id);
            await this._db.Persons.UpdateOneAsync(updateObj.ToBsonDocument(), person.ToBsonDocument());
        }
    }
}