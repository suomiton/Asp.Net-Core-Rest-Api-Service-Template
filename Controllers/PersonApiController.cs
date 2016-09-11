using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestService.DAL;
using RestService.Models;

namespace RestService.Controllers
{
    [Route("api/person")]
    public sealed class PersonApiController : Controller
    {
        public readonly IDocumentService _documentService;

        public PersonApiController(IDocumentService documentService)
        {
            this._documentService = documentService;
        }

        [HttpGet()]
        public async Task<IList<Person>> Get()
        {
            return await this._documentService.GetPersons();
        }

        [HttpGet("{id}")]
        public async Task<Person> Get(int id)
        {
            return await this._documentService.GetPerson(id);
        }

        // POST: api/Entry
        public async Task Post([FromBody]Person value)
        {
            await this._documentService.InsertPerson(value);
        }

        // PUT: api/Entry/5
        public async Task Put(int id, [FromBody]Person value)
        {
            await this._documentService.UpdatePerson(value);
        }

        // DELETE: api/Entry/5
        public async Task Delete(int id)
        {
            await this._documentService.DeletePerson(id);
        }
    }
}