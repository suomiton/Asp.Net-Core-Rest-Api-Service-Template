using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace RestService.DAL
{
    public class ContextBase
    {
        protected readonly IMongoDatabase _db;

        public ContextBase (IMongoDatabase db)
        {          
            this._db = db;
        }
    }
}