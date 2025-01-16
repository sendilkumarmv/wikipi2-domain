using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Wikipi.Domain.Repository.Attributes;
using Wikipi.Domain.Repository.Interfaces;

namespace Wikipi.Domain.Repository.Models
{
    [CollectionName("products")]
    public class Product : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get ; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
