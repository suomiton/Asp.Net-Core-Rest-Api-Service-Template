using MongoDB.Driver;

namespace RestService.DAL
{
    public abstract class RepositoryBase
    {
        protected readonly IMongoDatabase _db;

        public RepositoryBase (IMongoDatabase db)
        {          
            this._db = db;
        }
    }
}