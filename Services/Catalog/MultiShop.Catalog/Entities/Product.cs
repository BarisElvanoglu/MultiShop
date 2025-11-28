using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{

    /// <summary>
    /// product entity
    /// </summary> 
    public class Product 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int ProductImageUrl { get; set; }
        public string ProductDescriptipn { get; set; }
        public string CategoryId { get; set; }

        [BsonIgnore]
        public Category Category{ get; set; }
    }
}
