using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Wikipi.Domain.Repository.Interfaces;

namespace Wikipi.Domain.Repository.MongoDb
{
    public class DbFactory : IDbFactory
    {
        private readonly IMongoDatabase database;
        public DbFactory(IOptions<RepositorySettings> repoSettings)
        {
            try
            {
                var connectionString = repoSettings.Value.ConnectionString;
                var mongoClient = new MongoClient(connectionString);
                database = mongoClient.GetDatabase(repoSettings.Value.DatabaseName);
            }
            catch (Exception ex)
            {

            }
        }
        public IMongoDatabase GetDb()
        {
            return database;
        }
    }
}
