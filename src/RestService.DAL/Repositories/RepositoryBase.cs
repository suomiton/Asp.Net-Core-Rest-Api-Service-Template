using MongoDB.Driver;

namespace RestService.DAL.Repositories
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