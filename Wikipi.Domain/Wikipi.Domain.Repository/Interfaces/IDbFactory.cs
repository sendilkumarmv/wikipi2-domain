using MongoDB.Driver;

namespace Wikipi.Domain.Repository.Interfaces
{
    public interface IDbFactory
    {
        IMongoDatabase GetDb();
    }
}
