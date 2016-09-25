using System;
using MongoDB.Driver;

namespace RestService.DAL
{
    public class MongoContext : IMongoContext, IDisposable
    {
        private readonly AppSettings _appSettings;
        private readonly MongoClient _client;
        private IMongoDatabase _documents;

        public IMongoDatabase Documents
        {
            get
            {
                if(null == this._documents) this._documents = this._client.GetDatabase(this._appSettings.DbName);
                return this._documents;
            }
        }

        public MongoContext(AppSettings settings)
        {
            this._appSettings = settings;            
            this._client = new MongoDB.Driver.MongoClient(settings.ConnectionString);            
        }

        public void Dispose()
        {
            this._client.Cluster.Dispose();
        }
    }
}