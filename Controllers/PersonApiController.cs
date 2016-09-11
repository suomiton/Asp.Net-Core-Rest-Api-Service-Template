using System;
using Microsoft.AspNetCore.Mvc;

namespace RestService.Controllers
{
    [Route("api/person")]
    public sealed class PersonApiController : Controller
    {
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Entry
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Entry/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Entry/5
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}