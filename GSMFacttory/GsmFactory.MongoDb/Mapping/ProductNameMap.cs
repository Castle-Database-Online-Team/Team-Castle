namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class ProductNameMap
    {       

        [BsonConstructor]
        public ProductNameMap(int productNameId, string productName)
        {
            this.ProductNameId = productNameId;
            this.ProductName = productName;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int ProductNameId { get;  set; }

        public string ProductName { get;  set; }
    }
}