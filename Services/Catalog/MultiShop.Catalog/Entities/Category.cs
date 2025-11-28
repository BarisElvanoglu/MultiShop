using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    /// <summary>
    /// Category entity 
    /// </summary> 
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}
