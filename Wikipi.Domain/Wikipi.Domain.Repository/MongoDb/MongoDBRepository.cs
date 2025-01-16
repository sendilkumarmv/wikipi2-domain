using MongoDB.Driver;
using Wikipi.Domain.Repository.Attributes;
using Wikipi.Domain.Repository.Interfaces;

namespace Wikipi.Domain.Repository.MongoDb
{
    public class MongoDBRepository : IBaseRepository
    {
        private readonly IMongoDatabase _database;
        public MongoDBRepository(IDbFactory dbFactory)
        {
            _database = dbFactory.GetDb();
        }
        public async Task<TEntity> Create<TEntity>(TEntity obj)
        {
            var dbCollection = _database.GetCollection<TEntity>(typeof(TEntity).GetCollectionName());
            await dbCollection.InsertOneAsync(obj);
            return obj;
        }

        public Task<TEntity> Delete<TEntity>(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> Get<TEntity>(string id) where TEntity : IEntity
        {
            var dbCollection = _database.GetCollection<TEntity>(typeof(TEntity).GetCollectionName());
            var asyncCursor = await dbCollection.FindAsync(x => x.Id == id);
            return await asyncCursor.FirstOrDefaultAsync();
        }

        public Task<IEnumerable<TEntity>> GetAll<TEntity>()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Update<TEntity>(TEntity obj)
        {
throw new NotImplementedException();
        }
    }
}
